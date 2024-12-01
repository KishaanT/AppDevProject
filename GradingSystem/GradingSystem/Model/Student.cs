using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradingSystem
{
    internal class Student : User
    {
        public Dictionary<int, double> Grades { get; set; } = new Dictionary<int, double>();
        public List<int> EnrolledCourses { get; set; } = new List<int>();

        public Student(int id, string name, string email, string password, List<int> enrolledCourses,Dictionary<int,double> grades) : base(id, name, email, password)
        {
            this.Grades = grades;
            this.EnrolledCourses = enrolledCourses;
        }
    }

}
