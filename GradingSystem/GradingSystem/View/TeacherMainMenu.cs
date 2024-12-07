using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GradingSystem.Services;

namespace GradingSystem
{
    public partial class teacherMainMenu : Form
    {
        private Teacher teacher = DataService.Teacher;

        public teacherMainMenu()
        {
            InitializeComponent();
            //foreach (Course course in DataService.Teacher.Courses)
            //{
            //    comboBoxClasses.Items.Add(course.CourseName);
            //}
            ApplyTheme();
        }

        private void gotoclassButton_Click(object sender, EventArgs e)
        {
            //for (int i = 0; i < DataService.Teacher.Courses.Count; i++)
            //{
            //    if (comboBoxClasses.SelectedItem == null)
            //    {
            //        MessageBox.Show("You must select a class before proceding", "Select Class", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //        break;
            //    }
            //    else
            //    {
                        //DataService.Course = DataService.Teacher.Courses[i];
                        Hide();
                        var form = new TeacherOperation();
                        form.Closed += (s, args) => Close();
                        form.Show();
            //            break;
            //    }
            //}
        }

        private void signOutButton_Click(object sender, EventArgs e)
        {
            Hide();
            var identify = new IdentifyForm();
            identify.Closed += (s, args) => Close();
            identify.Show();
        }
        private void ApplyTheme()
        {
            // Apply the global theme
            ThemeManager.ApplyTheme(this);

            // Additional customizations based on the active theme
            if (ThemeManager.IsDarkMode)
            {
                // General form background and text color
                this.BackColor = Color.FromArgb(18, 18, 18);
                this.ForeColor = Color.White;

                // ComboBox
                comboBoxClasses.BackColor = Color.FromArgb(30, 30, 30);
                comboBoxClasses.ForeColor = Color.White;

                // Buttons
                signOutButton.BackColor = Color.DarkRed;
                signOutButton.ForeColor = Color.White;

                gotoclassButton.BackColor = Color.DarkGreen;
                gotoclassButton.ForeColor = Color.White;
            }
            else
            {
                // General form background and text color
                this.BackColor = Color.White;
                this.ForeColor = Color.Black;

                // ComboBox
                comboBoxClasses.BackColor = Color.White;
                comboBoxClasses.ForeColor = Color.Black;

                // Buttons
                signOutButton.BackColor = Color.LightCoral;
                signOutButton.ForeColor = Color.Black;

                gotoclassButton.BackColor = Color.LightGreen;
                gotoclassButton.ForeColor = Color.Black;
            }
        }
    }
}
