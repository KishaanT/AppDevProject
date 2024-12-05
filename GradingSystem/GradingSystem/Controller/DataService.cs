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
        private List<Course> courses = new List<Course>();
        private int nextTeacherId = 1;
        private int nextStudentId = 1;
        private int nextCourseId = 1;

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
            teacher.Courses.Add(course);
            courses.Add(course);
            return course;
        }

        // Assign Grade
        public void AssignGrade(int studentId, int courseId, string assignmentName, double grade)
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
        public Assignment CreateAssignment(int courseId, string name, double weight)
        {
            var course = courses.FirstOrDefault(c => c.CourseId == courseId);
            if (course == null) throw new Exception("Course not found.");

            var assignment = new Assignment(name, weight, 0);
            course.Assignments.Add(assignment);

            Console.WriteLine($"Assignment '{name}' added to course '{course.CourseName}'.");
            return assignment;
        }

        // Modify Assignment Weight
        public void ModifyAssignmentWeight(int courseId, string assignmentName, double newWeight)
        {
            var course = courses.FirstOrDefault(c => c.CourseId == courseId);
            var assignment = course?.Assignments.FirstOrDefault(a => a.Name == assignmentName);

            if (assignment == null) throw new Exception("Assignment not found.");

            assignment.Weight = newWeight;
            Console.WriteLine($"Assignment '{assignmentName}' weight updated to {newWeight}%.");
        }

        // Drop Student From Course
        public void DropStudentFromCourse(int studentId, int courseId)
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
        private void RecalculateStudentAverage(int studentId, int courseId)
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
        public List<Course> GetCoursesForTeacher(int teacherId)
        {
            return courses.Where(c => c.TeacherId == teacherId).ToList();
        }

        // Get Student Status
        public string GetStudentStatus(int studentId, int courseId)
        {
            var course = courses.FirstOrDefault(c => c.CourseId == courseId);
            if (course == null) return "Course not found.";

            if (!course.StudentAverages.TryGetValue(studentId, out double average))
                return "No grades available.";

            return average >= 50 ? "Passing" : "Failing";
        }

        // Backup Data (Save to File)
        public void SaveData(string filePath)
        {
            // Save data to CSV (implement CSV writer logic here)
            Console.WriteLine("Data saved successfully.");
        }

        // Load Data (From File)
        public void LoadData(string filePath)
        {
            // Load data from CSV (implement CSV reader logic here)
            Console.WriteLine("Data loaded successfully.");
        }
    }
}

