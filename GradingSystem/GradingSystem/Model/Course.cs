using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradingSystem
{
    internal class Course
    {
        private int courseID;
        private Teacher teacher; // every course is assigned a teacher
        public int CourseId { get; set; }

        public string CourseName { get; set; }
        public List<Assignment> Assignments { get; set; } = new List<Assignment>();

        public List<Student> Students { get; set; } = new List<Student>(); // added a student list because it's important

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
