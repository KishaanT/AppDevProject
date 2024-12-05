using System;
using System.Collections.Generic;
using System.Linq;

namespace GradingSystem
{
    [Serializable]
    internal class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public double Average { get; private set; }
        public List<int> EnrolledCourses { get; set; } = new List<int>();
        public Dictionary<int, double> Grades { get; set; } = new Dictionary<int, double>();

        // Enroll in a course
        public void EnrollInCourse(int courseId)
        {
            if (EnrolledCourses.Contains(courseId))
            {
                Console.WriteLine($"Already enrolled in course {courseId}.");
                return;
            }

            EnrolledCourses.Add(courseId);
            Console.WriteLine($"Successfully enrolled in course {courseId}.");
        }

        // Drop a course
        public void DropCourse(int courseId)
        {
            if (EnrolledCourses.Remove(courseId))
            {
                Grades.Remove(courseId);
                Console.WriteLine($"Successfully dropped course {courseId}.");
            }
            else
            {
                Console.WriteLine($"Course {courseId} not found in enrolled list.");
            }
        }

        // Calculate average from assignment grades
        public void CalculateAverage(Dictionary<int, double> assignments)
        {
            if (assignments == null || assignments.Count == 0)
            {
                Average = 0;
                Console.WriteLine("No assignments available to calculate average.");
                return;
            }

            double total = assignments.Sum(a => a.Value * (a.Key / 100.0));
            double totalWeight = assignments.Sum(a => a.Key);

            if (Math.Abs(totalWeight - 100) > 0.01)
            {
                Console.WriteLine("Warning: Total assignment weights do not sum to 100%. Adjust calculations accordingly.");
            }

            Average = totalWeight > 0 ? total : 0;
            Console.WriteLine($"New average calculated: {Average:F2}");
        }

        // Get pass/fail status
        public string GetStatus()
        {
            return Average >= 60 ? "Passing" : "Failing";
        }

        // Fetch detailed performance per course
        public void DisplayPerformance()
        {
            if (Grades.Count == 0)
            {
                Console.WriteLine("No grades available to display performance.");
                return;
            }

            Console.WriteLine($"Performance for Student {Name} (ID: {Id}):");
            foreach (var grade in Grades)
            {
                Console.WriteLine($"- Course {grade.Key}: {grade.Value:F2}%");
            }
            Console.WriteLine($"Overall Average: {Average:F2}% ({GetStatus()})");
        }
    }
}
