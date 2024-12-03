using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradingSystem
{
    internal class Course
    {
        public int CourseId { get; set; }
        public string CourseName { get; set; }
        public List<Assignment> Assignments { get; set; } = new List<Assignment>();
        public Dictionary<int, double> StudentAverages { get; set; } = new Dictionary<int, double>();

        //public Course(int courseId, string courseName, List<Assignment> assignments, Dictionary<int, double> studentAverages)
        //{
        //    CourseId = courseId;
        //    CourseName = courseName;
        //    Assignments = assignments;
        //    StudentAverages = studentAverages;
        //}
    }
}
