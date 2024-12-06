using GradingSystem.Services;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GradingSystem
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            DataService dt = new DataService();
            var language = ConfigurationManager.AppSettings["language"];

            Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo(language);
            Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo(language);

            dt.AddTeacher("Kishaan", "kishaan@gmail.com", "1234");
            dt.AddTeacher("Thao", "thao@gmail.com", "1234");
            dt.AddTeacher("Brian", "brian@gmail.com", "1234");

            dt.AddCourse("Calculus 1", 1);
            dt.AddCourse("History", 3);
            dt.AddCourse("Chemsitry", 2);

            dt.AddCourse("Calculus 2", 3);
            dt.AddCourse("English", 1);
            dt.AddCourse("Humanities", 2);

            dt.AddCourse("Linear Algebra", 2);
            dt.AddCourse("Physical Education", 3);
            dt.AddCourse("Introduction to Programming", 1);

            dt.AddStudent("Kishaan","kishaan@gmail.com","1234");
            dt.AddStudent("Thao", "thao@gmail.com", "1234");
            dt.AddStudent("Brian", "brian@gmail.com", "1234");
            dt.AddStudent("Kyle", "thekyle@gmail.com", "1234");
            dt.AddStudent("Andrew", "theandrew@gmail.com", "1234");
            dt.AddStudent("Danat", "thedanat@gmail.com", "1234");
            dt.AddStudent("John Michael", "thejohnmichael@gmail.com", "1234");
            dt.AddStudent("Peenard", "thepeenard@gmail.com", "1234");
            dt.AddStudent("Mark", "themark@gmail.com", "1234");
            dt.AddStudent("Poopsie", "thepoopsie@gmail.com", "1234");




            foreach (Course course in dt.Courses)
            {
                foreach (var student in dt.Students)
                {
                    dt.EnrollStudentInCourse(course.CourseId,student.Id);
                    course.Students.Add(student);
                }
            }
            

            if (dt.Students.Count == 0)
            {
                Console.WriteLine("Empty");
            }

            Application.Run(new IdentifyForm());

        }
}
}
