using System;
using System.Collections.Generic;
using System.Linq;

namespace GradingSystem.Services
{
    internal class SearchAndFilterService
    {
        // Search students by name (case-insensitive)
        public List<Student> SearchStudentsByName(List<Student> students, string name)
        {
            if (students == null || string.IsNullOrWhiteSpace(name)) return new List<Student>();

            return students.Where(s =>
                    !string.IsNullOrEmpty(s.Name) &&
                    s.Name.IndexOf(name, StringComparison.OrdinalIgnoreCase) >= 0).ToList();
        }

        // Filter students by their average grades
        public List<Student> FilterStudentsByAverage(List<Student> students, Dictionary<int, double> averages, double threshold, bool above)
        {
            if (students == null || averages == null) return new List<Student>();

            return students.Where(s =>
            {
                if (averages.TryGetValue(s.Id, out double average))
                {
                    return above ? average >= threshold : average < threshold;
                }
                return false;
            }).ToList();
        }

        // Filter assignments by grade threshold
        public List<Assignment> FilterAssignmentsByGrade(List<Assignment> assignments, double threshold, bool above)
        {
            if (assignments == null) return new List<Assignment>();

            return assignments.Where(a =>
                a.StudentGrades.Values.Any(g => above ? g >= threshold : g < threshold)).ToList();
        }

        // Filter courses by name (case-insensitive)
        public List<Course> FilterCoursesByName(List<Course> courses, string name)
        {
            if (courses == null || string.IsNullOrWhiteSpace(name)) return new List<Course>();

            return courses.Where(c =>
                !string.IsNullOrEmpty(c.CourseName) &&
                c.CourseName.IndexOf(name, StringComparison.OrdinalIgnoreCase) >= 0).ToList();
        }

        // Enhanced: Get students with top N averages
        //public List<Student> GetTopStudentsByAverage(Dictionary<int, double> averages, int topN)
        //{
        //    if (averages == null || topN <= 0) return new List<Student>();

        //    return averages.OrderByDescending(pair => pair.Value)
        //                   .Take(topN)
        //                   .Select(pair => new Student { Id = pair.Key, Average = pair.Value }) // Assuming `Student` has an `Average` property
        //                   .ToList();
        //}

        // Enhanced: Get assignments with grades in a specific range
        public List<Assignment> FilterAssignmentsByGradeRange(List<Assignment> assignments, double minGrade, double maxGrade)
        {
            if (assignments == null) return new List<Assignment>();

            return assignments.Where(a =>
                a.StudentGrades.Values.Any(g => g >= minGrade && g <= maxGrade)).ToList();
        }

        // Enhanced: Filter students by name and average simultaneously
        public List<Student> FilterStudentsByNameAndAverage(List<Student> students, Dictionary<int, double> averages, string name, double threshold, bool above)
        {
            if (students == null || averages == null || string.IsNullOrWhiteSpace(name)) return new List<Student>();

            return students.Where(s =>
            {
                bool matchesName = !string.IsNullOrEmpty(s.Name) && s.Name.IndexOf(name, StringComparison.OrdinalIgnoreCase) >= 0;
                bool matchesAverage = averages.TryGetValue(s.Id, out double average) && (above ? average >= threshold : average < threshold);

                return matchesName && matchesAverage;
            }).ToList();
        }
    }
}
