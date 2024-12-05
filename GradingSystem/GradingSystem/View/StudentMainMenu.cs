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
        public StudentMainMenu()
        {
            InitializeComponent();
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
            Hide();
            var form = new StudentGrades();
            form.Closed += (s, args) => Close();
            form.Show();
        }
    }
}
