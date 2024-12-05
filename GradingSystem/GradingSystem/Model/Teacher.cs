using System;
using System.Collections.Generic;

namespace GradingSystem
{
    [Serializable]
    internal class Teacher
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public List<Course> Courses { get; set; } = new List<Course>();
        
        public Teacher()
        {

        }

        public Teacher(int ID, string name, string email, string password) {
            Id = ID;
            Name = name;
            Email = email;
            Password = password;
        }

        // Load courses assigned to the teacher
        public void LoadCourses(List<Course> allCourses)
        {
            if (allCourses == null)
            {
                Console.WriteLine("No courses available to load.");
                return;
            }

            Courses.Clear();
            foreach (var course in allCourses)
            {
                if (course.TeacherId == Id)
                {
                    Courses.Add(course);
                }
            }

            if (Courses.Count == 0)
            {
                Console.WriteLine($"No courses found for Teacher {Id}.");
            }
            else
            {
                Console.WriteLine($"Loaded {Courses.Count} courses for Teacher {Id}.");
            }
        }

        // Create a new course
        public void CreateCourse(string courseName, int courseId)
        {
            if (Courses.Exists(c => c.CourseId == courseId))
            {
                Console.WriteLine($"Course with ID {courseId} already exists.");
                return;
            }

            var newCourse = new Course
            {
                CourseId = courseId,
                CourseName = courseName,
                TeacherId = Id
            };

            Courses.Add(newCourse);
            Console.WriteLine($"Created course '{courseName}' with ID {courseId}.");
        }

        // Remove an existing course
        public void RemoveCourse(int courseId)
        {
            var course = Courses.Find(c => c.CourseId == courseId);
            if (course == null)
            {
                Console.WriteLine($"Course with ID {courseId} not found.");
                return;
            }

            Courses.Remove(course);
            Console.WriteLine($"Removed course '{course.CourseName}' with ID {courseId}.");
        }

        // Modify course details
        public void ModifyCourseName(int courseId, string newCourseName)
        {
            var course = Courses.Find(c => c.CourseId == courseId);
            if (course == null)
            {
                Console.WriteLine($"Course with ID {courseId} not found.");
                return;
            }

            course.CourseName = newCourseName;
            Console.WriteLine($"Updated course name to '{newCourseName}' for course ID {courseId}.");
        }

        // Generate a summary report of student performance in courses
        public void GeneratePerformanceReport()
        {
            Console.WriteLine($"Performance Report for Teacher {Name} (ID: {Id}):");
            if (Courses.Count == 0)
            {
                Console.WriteLine("No courses assigned.");
                return;
            }

            foreach (var course in Courses)
            {
                Console.WriteLine($"Course: {course.CourseName} (ID: {course.CourseId})");
                var stats = course.GetCourseStatistics();
                Console.WriteLine($"  - Average Grade: {stats.Average:F2}");
                Console.WriteLine($"  - Minimum Grade: {stats.Min:F2}");
                Console.WriteLine($"  - Maximum Grade: {stats.Max:F2}");
                Console.WriteLine();
            }
        }
    }
}
