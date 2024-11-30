using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradingSystem
{
    internal class Assignment
    {
        public string Name { get; set; }
        public double Weight { get; set; }
        public Dictionary<int, double> StudentGrades { get; set; } = new Dictionary<int, double>();

        public Assignment(string name,double Weight, Dictionary<int, double> studentGrades) 
        {
            this.Name = name;
            this.Weight = Weight;
            this.StudentGrades = studentGrades;

        }

    }
}
