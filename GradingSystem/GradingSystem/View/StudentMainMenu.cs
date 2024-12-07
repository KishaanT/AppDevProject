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
    public partial class StudentMainMenu : Form
    {
        ChangeLanguage changeLanguage = new ChangeLanguage();
        public StudentMainMenu()
        {
            changeLanguage.UpdateConfig(ApplicationLanguage.Instance.Key, ApplicationLanguage.Instance.Value);
            InitializeComponent();
            foreach(Course course in DataService.Student.EnrolledCourses)
            {
                //var courseName = DataService.Courses.FirstOrDefault(s => s.CourseId == course.CourseId);
                //comboBoxClasses.Items.Add(courseName.CourseName);
            }
        }

        private void signOutButton_Click(object sender, EventArgs e)
        {
            Hide();
            var form = new IdentifyForm();
            form.Closed += (s, args) => this.Close();
            form.Show();
        }

        private void gotoclassButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < DataService.Student.EnrolledCourses.Count; i++)
            {
                if (comboBoxClasses.SelectedItem == null)
                {
                    MessageBox.Show("You must select a class before proceding", "Select Class", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    break;
                }
                else
                {
                    Hide();
                    var form = new StudentGrades();
                    form.Closed += (s, args) => Close();
                    form.Show();
                    break;
                }
            }
        }

       
    }
}
