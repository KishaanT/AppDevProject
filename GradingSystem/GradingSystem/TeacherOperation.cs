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
    public partial class TeacherOperation : Form
    {
        public TeacherOperation()
        {
            InitializeComponent();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Hide();
            var form = new teacherMainMenu();
            form.Closed += (s, args) => Close();
            form.Show();
        }

        private void gradesButton_Click(object sender, EventArgs e)
        {
            Hide();
            var form = new TeacherGUI();
            form.Closed += (s, args) => Close();
            form.Show();
        }

        private void assignmentsButton_Click(object sender, EventArgs e)
        {
            // change this
            Hide();
            var form = new AssignmentGUI();
            form.Closed += (s, args) => Close();
            form.Show();
        }
    }
}
