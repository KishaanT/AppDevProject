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
        public List<Course> Courses { get; set; } = new List<Course>();

        //public Teacher(int id, string name, string email, string password,List<Course> courses) :base(id,name,email,password) 
        //{
        //    this.Courses = courses;   
        //}
    }

}
