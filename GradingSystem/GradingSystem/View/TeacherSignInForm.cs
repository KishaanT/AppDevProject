using Globalization;
using GradingSystem.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GradingSystem
{
    public partial class TeacherSignInForm : Form
    {
        ChangeLanguage changeLanguage = new ChangeLanguage();
        private List<Teacher> teachers = new List<Teacher>();

        public TeacherSignInForm()
        {
            InitializeComponent();
            changeLanguage.UpdateConfig(ApplicationLanguage.Instance.Key, ApplicationLanguage.Instance.Value);
            loadDataFromFile();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Hide();
            var identify = new IdentifyForm();
            identify.Closed += (s, args) => Close();
            identify.Show();
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Go to the Teacher GUI
                foreach (Teacher t in teachers)
                {

                    if (t.Id == Int32.Parse(IDtextBox.Text) && t.Password == passwordTextBox.Text)
                    {
                        DataService.Teacher = t;
                        Hide();
                        var form = new teacherMainMenu();
                        form.Closed += (s, args) => Close();
                        form.Show();
                        break;
                    }
                    else
                    {
                        // do nothing
                    }
                }
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Your ID must be composed only of numbers", "ID must be numbers", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void loadDataFromFile()
        {
            // retrieves and loads data from file. For now, we will manually create the data
            List<Assignment> assignments = new List<Assignment>();
            Teacher teacher1 = new Teacher(1, "Name1", "Email1", "12345");
            Teacher teacher2 = new Teacher(2, "Name2", "Email2", "12345");
            Teacher teacher3 = new Teacher(3, "Name3", "Email3", "12345");
            Course course1 = new Course(1, "Course 1", teacher1.Id, assignments);
            Course course2 = new Course(2, "Course 2", teacher1.Id, assignments);
            Course course3 = new Course(3, "Course 3", teacher1.Id, assignments);
            Course course4 = new Course(4, "Course 4", teacher2.Id, assignments);
            List<Course> courseList = new List<Course>();
            courseList.Add(course1);
            courseList.Add(course2);
            courseList.Add(course3);
            courseList.Add(course4);
            teacher1.Courses = courseList;
            teacher2.Courses = courseList;
            teacher3.Courses = courseList;
            teachers.Add(teacher1);
            teachers.Add(teacher2);
            teachers.Add(teacher3);
            DataService.Courses = courseList;
            DataService.Teachers = teachers;
            
        }

    }
}
