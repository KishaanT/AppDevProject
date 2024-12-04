using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradingSystem
{
    [Serializable]
    internal class Teacher : User
    {
        private string teacherID; // change field locations if necessary
        private string password;
        public List<Course> Courses { get; set; } = new List<Course>();
        public List<Assignment> assignments { get; set; } = new List<Assignment>();

    }

}
