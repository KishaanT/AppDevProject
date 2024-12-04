using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradingSystem
{
    internal class Assignment
    {
        public string Name { get; set; } // the name given to the assignment
        public double Weight { get; set; } // the ponderation given to the assignment
        public double Grade { get; set; } // the grade given to the assignment (one grade per assignment)
        public Dictionary<int, double> StudentGrades { get; set; } = new Dictionary<int, double>();

        public Assignment(string name, double weight, double grade) 
        {
            Name = name;
            Weight = weight;
            Grade = grade;
        }

    }
}
