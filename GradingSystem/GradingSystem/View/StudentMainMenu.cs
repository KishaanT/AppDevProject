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
            //foreach(Course course in DataService.Student.EnrolledCourses)
            //{
            //    //var courseName = DataService.Courses.FirstOrDefault(s => s.CourseId == course.CourseId);
            //    //comboBoxClasses.Items.Add(courseName.CourseName);
            //}
            ApplyTheme();
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
            //for (int i = 0; i < DataService.Student.EnrolledCourses.Count; i++)
            //{
            //    if (comboBoxClasses.SelectedItem == null)
            //    {
            //        MessageBox.Show("You must select a class before proceding", "Select Class", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //        break;
            //    }
            //    else
            //    {
                    Hide();
                    var form = new StudentGrades();
                    form.Closed += (s, args) => Close();
                    form.Show();
                    //break;
                //}
            //}
        }
        private void ApplyTheme()
        {
            ThemeManager.ApplyTheme(this);

            if (ThemeManager.IsDarkMode)
            {
                this.BackColor = Color.FromArgb(18, 18, 18);
                this.ForeColor = Color.White;

                comboBoxClasses.BackColor = Color.Black;
                comboBoxClasses.ForeColor = Color.White;

                signOutButton.BackColor = Color.DarkRed;
                signOutButton.ForeColor = Color.White;

                gotoclassButton.BackColor = Color.Green;
                gotoclassButton.ForeColor = Color.White;
               
            }
            else
            {
                this.BackColor = Color.White;
                this.ForeColor = Color.Black;

                comboBoxClasses.BackColor = Color.White;
                comboBoxClasses.ForeColor = Color.Black;

                signOutButton.BackColor = Color.LightCoral;
                signOutButton.ForeColor = Color.Black;

                gotoclassButton.BackColor = Color.LightGreen;
                gotoclassButton.ForeColor = Color.Black;
            }
        }
    }
}
