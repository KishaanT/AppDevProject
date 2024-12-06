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
            foreach (Course course in DataService.Teacher.Courses)
            {
                comboBoxClasses.Items.Add(course.CourseName);
            }
            
        }

        private void gotoclassButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < DataService.Teacher.Courses.Count; i++)
            {
                if (comboBoxClasses.SelectedItem == null)
                {
                    MessageBox.Show("You must select a class before proceding", "Select Class", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    break;
                }
                else
                {
                        DataService.Course = DataService.Teacher.Courses[i];
                        Hide();
                        var form = new TeacherOperation();
                        form.Closed += (s, args) => Close();
                        form.Show();
                        break;
                }
            }
        }

        private void signOutButton_Click(object sender, EventArgs e)
        {
            Hide();
            var identify = new IdentifyForm();
            identify.Closed += (s, args) => Close();
            identify.Show();
        }
    }
}
