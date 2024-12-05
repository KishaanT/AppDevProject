using System;
using System.Collections.Generic;
using System.Linq;

namespace GradingSystem
{
    internal class Course
    {
        public int CourseId { get; set; }
        public string CourseName { get; set; }
        public int TeacherId { get; set; }
        public List<Assignment> Assignments { get; set; } = new List<Assignment>();
        public Dictionary<int, double> StudentAverages { get; set; } = new Dictionary<int, double>();

        // Enroll a student in the course
        public void EnrollStudent(int studentId)
        {
            if (StudentAverages.ContainsKey(studentId))
            {
                Console.WriteLine($"Student {studentId} is already enrolled in the course.");
                return;
            }

            StudentAverages[studentId] = 0; // Initialize average as 0
            Console.WriteLine($"Student {studentId} enrolled in course {CourseName}.");
        }

        // Remove a student from the course
        public void RemoveStudent(int studentId)
        {
            if (StudentAverages.Remove(studentId))
            {
                foreach (var assignment in Assignments)
                {
                    assignment.StudentGrades.Remove(studentId);
                }
                Console.WriteLine($"Student {studentId} removed from course {CourseName}.");
            }
            else
            {
                Console.WriteLine($"Student {studentId} is not enrolled in the course.");
            }
        }

        // Add a new assignment to the course
        public void AddAssignment(string name, double weight)
        {
            if (Assignments.Any(a => a.Name.Equals(name, StringComparison.OrdinalIgnoreCase)))
            {
                Console.WriteLine($"Assignment '{name}' already exists in the course.");
                return;
            }

            var assignment = new Assignment(name, weight, 0);
            Assignments.Add(assignment);
            Console.WriteLine($"Assignment '{name}' added to course {CourseName}.");
        }

        // Remove an assignment from the course
        public void RemoveAssignment(string name)
        {
            var assignment = Assignments.FirstOrDefault(a => a.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
            if (assignment == null)
            {
                Console.WriteLine($"Assignment '{name}' not found in the course.");
                return;
            }

            Assignments.Remove(assignment);
            Console.WriteLine($"Assignment '{name}' removed from course {CourseName}.");
        }

        // Calculate student averages based on assignments
        public void CalculateStudentAverages()
        {
            if (Assignments == null || Assignments.Count == 0)
            {
                Console.WriteLine("No assignments in the course to calculate averages.");
                return;
            }

            foreach (var studentId in StudentAverages.Keys.ToList())
            {
                double total = 0;
                double totalWeight = 0;

                foreach (var assignment in Assignments)
                {
                    if (assignment.StudentGrades.TryGetValue(studentId, out double grade))
                    {
                        total += grade * assignment.Weight / 100;
                        totalWeight += assignment.Weight;
                    }
                }

                StudentAverages[studentId] = totalWeight > 0 ? total : 0;
            }
            Console.WriteLine("Student averages recalculated.");
        }

        // Get overall course statistics (average, min, max grades)
        public (double Average, double Min, double Max) GetCourseStatistics()
        {
            var allGrades = Assignments
                            .SelectMany(a => a.StudentGrades.Values)
                            .ToList();

            if (allGrades.Count == 0) return (0, 0, 0);

            return (allGrades.Average(), allGrades.Min(), allGrades.Max());
        }
    }
}
