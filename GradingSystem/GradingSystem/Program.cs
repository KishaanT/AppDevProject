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
            var language = ConfigurationManager.AppSettings["language"];

            Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo(language);
            Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo(language);

            DataService.AddStudent("Kishaan","kishaan@gmail.com","1234");
            DataService.AddStudent("Thao", "thao@gmail.com", "1234");
            DataService.AddStudent("Brian", "brian@gmail.com", "1234");

            DataService.AddTeacher("Kishaan", "kishaan@gmail.com","1234");
            DataService.AddTeacher("Thao", "thao@gmail.com","1234");
            DataService.AddTeacher("Brian", "brian@gmail.com","1234");

            DataService.AddCourse("Calculus 1",1);
            DataService.AddCourse("History", 3);
            DataService.AddCourse("Chemsitry", 2);


            DataService.AddCourse("Calculus 2", 3);
            DataService.AddCourse("English", 1);
            DataService.AddCourse("Humanities", 2);


            DataService.AddCourse("Linear Algebra", 2);
            DataService.AddCourse("Physical Education", 3);
            DataService.AddCourse("Introduction to Programming", 1);

            foreach(Course course in DataService.Courses)
            {
                foreach (var student in DataService.Students)
                {
                    DataService.EnrollStudentInCourse(course.CourseId,student.Id);
                }
            }
            

            if (DataService.Students.Count == 0)
            {
                Console.WriteLine("Empty");
            }

            Application.Run(new IdentifyForm());

        }
}
}
