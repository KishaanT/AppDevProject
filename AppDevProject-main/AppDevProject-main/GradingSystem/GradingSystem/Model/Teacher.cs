using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradingSystem
{
    internal class Teacher : User
    {
        public List<Course> Courses { get; set; } = new List<Course>();
    }

}
