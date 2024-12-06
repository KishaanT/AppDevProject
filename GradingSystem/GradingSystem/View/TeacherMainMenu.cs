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
            Hide();
            var form = new TeacherOperation();
            form.Closed += (s, args) => Close();
            form.Show();
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
