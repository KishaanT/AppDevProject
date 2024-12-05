using System;
using System.Collections.Generic;
using System.Linq;

namespace GradingSystem.Services
{
    internal class GraphDataService
    {
        // Get grade trends for a student across enrolled courses
        public Dictionary<string, double> GetGradeTrendsForStudent(Student student, List<Course> courses)
        {
            var gradeTrends = new Dictionary<string, double>();

            foreach (var courseId in student.EnrolledCourses)
            {
                var course = courses.FirstOrDefault(c => c.CourseId == courseId);
                if (course == null)
                {
                    Console.WriteLine($"Warning: Course ID {courseId} not found.");
                    continue;
                }

                double totalGrades = 0;
                int count = 0;

                foreach (var assignment in course.Assignments)
                {
                    if (assignment.StudentGrades.TryGetValue(student.Id, out double grade))
                    {
                        totalGrades += grade;
                        count++;
                    }
                }

                gradeTrends[course.CourseName] = count > 0 ? totalGrades / count : 0;
            }

            return gradeTrends;
        }

        // Get performance details for each assignment in a course
        public Dictionary<string, double> GetAssignmentPerformance(Course course)
        {
            return course.Assignments.ToDictionary(a => a.Name, a =>
            {
                if (a.StudentGrades.Count == 0) return 0;

                var average = a.StudentGrades.Values.Average();
                return average;
            });
        }

        // Enhanced: Get detailed performance statistics for assignments
        public Dictionary<string, (double Average, double Min, double Max)> GetDetailedAssignmentPerformance(Course course)
        {
            return course.Assignments.ToDictionary(a => a.Name, a =>
            {
                if (a.StudentGrades.Count == 0) return (0, 0, 0);

                var grades = a.StudentGrades.Values.ToList();
                return (grades.Average(), grades.Min(), grades.Max());
            });
        }

        // Enhanced: Get overall statistics for a course
        public (double Average, double Min, double Max) GetOverallCourseStatistics(Course course)
        {
            var allGrades = course.Assignments
                                  .SelectMany(a => a.StudentGrades.Values)
                                  .ToList();

            if (allGrades.Count == 0) return (0, 0, 0);

            return (allGrades.Average(), allGrades.Min(), allGrades.Max());
        }
    }
}