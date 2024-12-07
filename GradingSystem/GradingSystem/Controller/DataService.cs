using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace GradingSystem.Services
{
    internal class DataService
    {
        private List<Teacher> teachers = new List<Teacher>();
        private List<Student> students = new List<Student>();
        private List<Course> coursess = new List<Course>();
        private static int nextTeacherId = 1;
        private static int nextStudentId = 1;
        private static int nextCourseId = 1;

        public  List<Teacher> Teachers
        {
            get
            {
                return teachers;
            }
            set
            {
                teachers = value;
            }
        }
        public  List<Student> Students
        {
            get
            {
                return students;
            }
            set
            {
                students = value;
            }
        }
        public  List<Course> Courses
        {
            get
            {
                return coursess;
            }
            set
            {
                coursess = value;
            }
        }

        public static Teacher Teacher { get; set; }
        public static Student Student { get; set; }
        public static Course Course { get; set; }

        // Add Teacher
        public Teacher AddTeacher(string name, string email, string password)
        {
            if (teachers.Any(t => t.Email == email)) throw new Exception("Teacher email already exists.");
            var teacher = new Teacher
            {
                Id = nextTeacherId++,
                Name = name,
                Email = email,
                Password = password
            };
            teachers.Add(teacher);
            Console.WriteLine($"Teacher '{name}' was added with ID {teacher.Id} {password}");
            return teacher;
        }

        // Add Student
        public Student AddStudent(string name, string email, string password)
        {
            if (students.Any(s => s.Email == email)) throw new Exception("Student email already exists.");
            var student = new Student
            {
                Id = nextStudentId++,
                Name = name,
                Email = email,
                Password = password
            };
            students.Add(student);
            foreach(Course course in Courses)
            {
                course.Students = new List<Student>();
                DataService.Course = course;
                DataService.Course.Assignments = new List<Assignment>();
            }
            Console.WriteLine($"Student '{name}' was added with ID {student.Id}" );
            return student;
        }

        // Add Course
        public Course AddCourse(string courseName, int teacherId)
        {
            var teacher = teachers.FirstOrDefault(t => t.Id == teacherId);
            if (teacher == null) throw new Exception("Teacher not found.");
            var course = new Course
            {
                CourseId = nextCourseId++,
                CourseName = courseName,
                TeacherId = teacherId
            };
            Courses.Add(course);
            teacher.Courses.Add(course);
            coursess.Add(course);
            return course;
        }

        public  void EnrollStudentInCourse(int courseId,int studentId)
        {
            var course = coursess.FirstOrDefault(s => s.CourseId == courseId);
            if (course == null) throw new Exception("Course not found.");

            var student = students.FirstOrDefault(s => s.Id == studentId);

            if (student == null) throw new Exception("Student not found.");
            if (student.EnrolledCourses.Contains(course))
            {
                Console.WriteLine($"Already enrolled in course {courseId}.");
                return;
            }

            student.EnrolledCourses.Add(course);
            course.addStudent(student);


            Console.WriteLine($"Successfully enrolled in course {courseId}.");
        }

        // Assign Grade
        public static void AssignGrade(int studentId, int courseId, string assignmentName, double grade)
        {
            List<Student> students = DataBackupService.RestoreStudentData();
            List<Course> courses = DataBackupService.RestoreCourseData();
            List<Assignment> assignments = DataBackupService.RestoreAssignmentsData();

            var student = students.FirstOrDefault(s => s.Id == studentId);
            var course = courses.FirstOrDefault(c => c.CourseId == courseId);

            if (student == null || course == null ||courses.FirstOrDefault(c => c.CourseId == courseId).Assignments.FirstOrDefault(a => a.Name == assignmentName) == null)
            {
                throw new Exception("Invalid data provided.");
            }

            for(int i = 0; i < course.Assignments.Count; i++)
            {
                if(course.Assignments[i] == course.Assignments.FirstOrDefault(a => a.Name == assignmentName))
                {
                    
                    
                    course.Assignments[i].StudentGrades[studentId] = grade;
                    assignments.FirstOrDefault(a => a.Name == assignmentName).StudentGrades[studentId] = grade;
                }
            }
            DataBackupService.BackupCoursesData(courses);
            DataBackupService.BackupAssignmentData(assignments);


            // Recalculate student's average for the course
            RecalculateStudentAverage(studentId, courseId);
        }

        // Create Assignment
        public static Assignment CreateAssignment(int courseId, string name, double weight)
        {
            List<Assignment> assignments = DataBackupService.RestoreAssignmentsData();
            List<Course> courses = DataBackupService.RestoreCourseData();
            for(int i =0; i < courses.Count; i++)
            {
                if(courses[i].CourseId == courseId)
                {
                    if (courses[i] == null) throw new Exception("Course not found.");
                    var assignment = new Assignment(name, weight);
                    assignments.Add(assignment);
                    courses[i].Assignments.Add(assignment);
                    DataBackupService.BackupCoursesData(courses);
                    DataBackupService.BackupAssignmentData(assignments);
                    Console.WriteLine($"Assignment '{name}' added to course '{courses[i].CourseName}'.");
                    return assignment;
                }
            }
            return null;
        }

        // Modify Assignment Weight
        public static void ModifyAssignmentWeight(int courseId, string assignmentName, double newWeight)
        {
            List<Assignment> assignments = DataBackupService.RestoreAssignmentsData();
            List<Course> courses = DataBackupService.RestoreCourseData();

            var course = DataBackupService.RestoreCourseData().FirstOrDefault(c => c.CourseId == courseId);
            var assignment = course.Assignments.FirstOrDefault(a => a.Name == assignmentName);

            if (assignment == null) throw new Exception("Assignment not found.");

            Console.WriteLine($"Assignment '{assignmentName}' weight updated to {newWeight}%.");

            for (int i = 0; i < courses.Count; i++)
            {
                if (courses[i] == course)
                {
                    courses[i].Assignments.FirstOrDefault(a => a.Name == assignmentName).Weight = newWeight;
                    assignments.FirstOrDefault(a => a.Name == assignmentName).Weight = newWeight;
                }
            }
            Console.WriteLine($"Assignment '{assignmentName}' weight updated to {newWeight}%.");
            DataBackupService.BackupCoursesData(courses);
            DataBackupService.BackupAssignmentData(assignments);


        }

        // Drop Student From Course
        public static void DropStudentFromCourse(int studentId, int courseId)
        {
            List<Course> courses = DataBackupService.RestoreCourseData();
            List<Student> students = DataBackupService.RestoreStudentData();
            List<Assignment> assignments = DataBackupService.RestoreAssignmentsData();


            var student = DataBackupService.RestoreStudentData().FirstOrDefault(s => s.Id == studentId);
            var course = DataBackupService.RestoreCourseData().FirstOrDefault(c => c.CourseId == courseId);

            if (student == null || course == null) throw new Exception("Invalid data provided.");

            students.FirstOrDefault(s => s.Id == studentId).EnrolledCourses.Remove(course);
            courses.FirstOrDefault(c => c.CourseId == courseId).StudentAverages.Remove(studentId);

            

            for (int i = 0; i < assignments.Count; i++)
            {
                assignments[i].StudentGrades.Remove(studentId);
            }
            DataBackupService.BackupCoursesData(courses);
            DataBackupService.BackupAssignmentData(assignments);
            DataBackupService.BackupStudentData(students);
        }

        // Recalculate Student Average
        private static void RecalculateStudentAverage(int studentId, int courseId)
        {
            List<Course> courses = DataBackupService.RestoreCourseData();
            List<Student> students = DataBackupService.RestoreStudentData();
            List<Assignment> assignments = DataBackupService.RestoreAssignmentsData();

            var course = courses.FirstOrDefault(c => c.CourseId == courseId);
            if (course == null) return;

            var totalWeight = 0.0;
            var weightedSum = 0.0;

            foreach (var assignment in assignments)
            {
                if (assignment.StudentGrades.TryGetValue(studentId, out double grade))
                {
                    weightedSum += grade * assignment.Weight / 100;
                    totalWeight += assignment.Weight;
                }
            }

            if (Math.Abs(totalWeight - 100) > 0.01)
                throw new Exception("Course weighting does not sum to 100%.");

            for(int i = 0; i < courses.Count;i++) 
            {
                if (courses[i] == course)
                {
                    courses[i].StudentAverages[studentId] = weightedSum;
                }
            }
            DataBackupService.BackupCoursesData(courses);
            DataBackupService.BackupAssignmentData(assignments);
            DataBackupService.BackupStudentData(students);

        }

        // Get Courses for a Teacher
        public static List<Course> GetCoursesForTeacher(int teacherId)
        {
            return DataBackupService.RestoreCourseData().Where(c => c.TeacherId == teacherId).ToList();
        }

        // Get Student Status
        public string GetStudentStatus(int studentId, int courseId)
        {
            List<Course> courses = DataBackupService.RestoreCourseData();

            var course = courses.FirstOrDefault(c => c.CourseId == courseId);
            if (course == null) return "Course not found.";

            if (!course.StudentAverages.TryGetValue(studentId, out double average))
                return "No grades available.";

            return average >= 60 ? "Passing" : "Failing";
        }
    }
}

