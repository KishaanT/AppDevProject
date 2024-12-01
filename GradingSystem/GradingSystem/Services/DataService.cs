using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            return teacher;
        }

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
            return student;
        }

        public static Course AddCourse(string courseName, int teacherId)
        {
            var teacher = teachers.FirstOrDefault(t => t.Id == teacherId);
            if (teacher == null) throw new Exception("Teacher not found.");
            var course = new Course
            {
                CourseId = nextCourseId++,
                CourseName = courseName
            };
            teacher.Courses.Add(course);
            courses.Add(course);
            return course;
        }

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

        public static void BackupData(string filePath)
        {
            // Export all data to CSV format
            // Teachers, students, and courses
            System.IO.File.WriteAllText(filePath, "Backup Data\n");
        }
    }
}
