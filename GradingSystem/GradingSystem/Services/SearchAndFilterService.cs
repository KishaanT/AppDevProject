using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradingSystem.Services
{
    internal class SearchAndFilterService
    {
        public List<Student> SearchStudentsByName(List<Student> students, string name)
        {
            return students.Where(s =>
                    !string.IsNullOrEmpty(s.Name) &&
                    s.Name.IndexOf(name, StringComparison.OrdinalIgnoreCase) >= 0).ToList();
        }

        public List<Student> FilterStudentsByAverage(List<Student> students, Dictionary<int, double> averages, double threshold, bool above)
        {
            return students.Where(s =>
            {
                if (averages.TryGetValue(s.Id, out double average))
                {
                    return above ? average >= threshold : average < threshold;
                }
                return false;
            }).ToList();
        }

        public List<Assignment> FilterAssignmentsByGrade(List<Assignment> assignments, double threshold, bool above)
        {
            return assignments.Where(a =>
                a.StudentGrades.Values.Any(g => above ? g >= threshold : g < threshold)).ToList();
        }

        public List<Course> FilterCoursesByName(List<Course> courses, string name)
        {
            return courses.Where(c =>
                !string.IsNullOrEmpty(c.CourseName) &&
                c.CourseName.IndexOf(name, StringComparison.OrdinalIgnoreCase) >= 0).ToList();
        }
    }
}
