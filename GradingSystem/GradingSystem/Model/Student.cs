using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradingSystem
{
    [Serializable]
    internal class Student : User
    {
        private string name;
        private int id;
        private double average;
        private string teacherID; // change field locations if necessary
        private string password;
        public double Average { get; set; }
        public Dictionary<Assignment, double> GradesForAssignments { get; set; } = new Dictionary<Assignment, double>();

        public Dictionary<int, double> Grades { get; set; } = new Dictionary<int, double>(); // we gotta link the grades with the assignments. This might be subject to deletion.
        
        public List<Assignment> Assignments { get; set; } = new List<Assignment>(); // when teacher creates a new assignment, the student will receive a new assignment in the assignment list.

        public List<int> EnrolledCourses { get; set; } = new List<int>(); // students are added enrolled to a course (Kishaan you gotta link this with the csv)

    }

}
