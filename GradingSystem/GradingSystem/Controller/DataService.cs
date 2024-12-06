using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace GradingSystem.Services
{
    internal class DataService
    {
        private static List<Teacher> teachers = new List<Teacher>();
        private static List<Student> students = new List<Student>();
        private static List<Course> courses = new List<Course>();
        private static int nextTeacherId = 1;
        private static int nextStudentId = 1;
        private static int nextCourseId = 1;

        public static List<Teacher> Teachers
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
        public static List<Student> Students
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
        public static List<Course> Courses
        {
            get
            {
                return courses;
            }
            set
            {
                courses = value;
            }
        }

        public static Teacher Teacher { get; set; }
        public static Student Student { get; set; }

        // Add Teacher
        public static Teacher AddTeacher(string name, string email, string password)
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
        public static Student AddStudent(string name, string email, string password)
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
            Console.WriteLine($"Student '{name}' was added with ID {student.Id}" );
            return student;
        }

        // Add Course
        public static Course AddCourse(string courseName, int teacherId)
        {
            var teacher = teachers.FirstOrDefault(t => t.Id == teacherId);
            if (teacher == null) throw new Exception("Teacher not found.");
            var course = new Course
            {
                CourseId = nextCourseId++,
                CourseName = courseName,
                TeacherId = teacherId
            };
            teacher.Courses.Add(course);
            courses.Add(course);
            return course;
        }

        public static void EnrollStudentInCourse(int courseId,int studentId)
        {
            var course = courses.FirstOrDefault(s => s.CourseId == courseId);
            if (course == null) throw new Exception("Course not found.");

            var student = students.FirstOrDefault(s => s.Id == studentId);

            if (student == null) throw new Exception("Student not found.");
            if (student.EnrolledCourses.Contains(courseId))
            {
                Console.WriteLine($"Already enrolled in course {courseId}.");
                return;
            }
            student.EnrolledCourses.Add(courseId);
            Console.WriteLine($"Successfully enrolled in course {courseId}.");
        }

        // Assign Grade
        public static void AssignGrade(int studentId, int courseId, string assignmentName, double grade)
        {
            var student = students.FirstOrDefault(s => s.Id == studentId);
            var course = courses.FirstOrDefault(c => c.CourseId == courseId);
            var assignment = course?.Assignments.FirstOrDefault(a => a.Name == assignmentName);

            if (student == null || course == null || assignment == null)
                throw new Exception("Invalid data provided.");

            assignment.StudentGrades[studentId] = grade;

            // Recalculate student's average for the course
            RecalculateStudentAverage(studentId, courseId);
        }

        // Create Assignment
        public static Assignment CreateAssignment(int courseId, string name, double weight)
        {
            var course = courses.FirstOrDefault(c => c.CourseId == courseId);
            if (course == null) throw new Exception("Course not found.");

            var assignment = new Assignment(name, weight, 0);
            course.Assignments.Add(assignment);

            Console.WriteLine($"Assignment '{name}' added to course '{course.CourseName}'.");
            return assignment;
        }

        // Modify Assignment Weight
        public static void ModifyAssignmentWeight(int courseId, string assignmentName, double newWeight)
        {
            var course = courses.FirstOrDefault(c => c.CourseId == courseId);
            var assignment = course?.Assignments.FirstOrDefault(a => a.Name == assignmentName);

            if (assignment == null) throw new Exception("Assignment not found.");

            assignment.Weight = newWeight;
            Console.WriteLine($"Assignment '{assignmentName}' weight updated to {newWeight}%.");
        }

        // Drop Student From Course
        public static void DropStudentFromCourse(int studentId, int courseId)
        {
            var student = students.FirstOrDefault(s => s.Id == studentId);
            var course = courses.FirstOrDefault(c => c.CourseId == courseId);

            if (student == null || course == null) throw new Exception("Invalid data provided.");

            student.EnrolledCourses.Remove(courseId);
            course.StudentAverages.Remove(studentId);

            foreach (var assignment in course.Assignments)
            {
                assignment.StudentGrades.Remove(studentId);
            }
        }

        // Recalculate Student Average
        private static void RecalculateStudentAverage(int studentId, int courseId)
        {
            var course = courses.FirstOrDefault(c => c.CourseId == courseId);
            if (course == null) return;

            var totalWeight = 0.0;
            var weightedSum = 0.0;

            foreach (var assignment in course.Assignments)
            {
                if (assignment.StudentGrades.TryGetValue(studentId, out double grade))
                {
                    weightedSum += grade * assignment.Weight / 100;
                    totalWeight += assignment.Weight;
                }
            }

            if (Math.Abs(totalWeight - 100) > 0.01)
                throw new Exception("Course weighting does not sum to 100%.");

            course.StudentAverages[studentId] = weightedSum;
        }

        // Get Courses for a Teacher
        public static List<Course> GetCoursesForTeacher(int teacherId)
        {
            return courses.Where(c => c.TeacherId == teacherId).ToList();
        }

        // Get Student Status
        public static string GetStudentStatus(int studentId, int courseId)
        {
            var course = courses.FirstOrDefault(c => c.CourseId == courseId);
            if (course == null) return "Course not found.";

            if (!course.StudentAverages.TryGetValue(studentId, out double average))
                return "No grades available.";

            return average >= 50 ? "Passing" : "Failing";
        }

        // Backup Data (Save to File)
        public static void SaveData(string filePath)
        {
            // Save data to CSV (implement CSV writer logic here)
            Console.WriteLine("Data saved successfully.");
        }

        // Load Data (From File)
        public static void LoadData(string filePath)
        {
            // Load data from CSV (implement CSV reader logic here)
            Console.WriteLine("Data loaded successfully.");
        }
    }
}

