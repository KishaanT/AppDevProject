using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradingSystem.Services
{
    internal class GraphDataService
    {
        public Dictionary<string, double> GetGradeTrendsForStudent(Student student, List<Course> courses)
        {
            var gradeTrends = new Dictionary<string, double>();

            foreach (var courseId in student.EnrolledCourses)
            {
                var course = courses.FirstOrDefault(c => c.CourseId == courseId);
                if (course != null)
                {
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
            }

            return gradeTrends;
        }

        public Dictionary<string, double> GetAssignmentPerformance(Course course)
        {
            return course.Assignments.ToDictionary(a => a.Name, a =>
            {
                if (a.StudentGrades.Count == 0) return 0;
                return a.StudentGrades.Values.Average();
            });
        }
    }
}
