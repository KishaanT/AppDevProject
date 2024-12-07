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
            ApplyTheme();
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
            Hide();
            var form = new AssignmentGUI();
            form.Closed += (s, args) => Close();
            form.Show();
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

                // Buttons
                gradesButton.BackColor = Color.Orange;
                gradesButton.ForeColor = Color.White;

                assignmentsButton.BackColor = Color.Teal;
                assignmentsButton.ForeColor = Color.White;

                backButton.BackColor = Color.DarkRed;
                backButton.ForeColor = Color.White;
            }
            else
            {
                // General form background and text color
                this.BackColor = Color.White;
                this.ForeColor = Color.Black;

                // Buttons
                gradesButton.BackColor = Color.Orange;
                gradesButton.ForeColor = Color.Black;

                assignmentsButton.BackColor = Color.LightSeaGreen;
                assignmentsButton.ForeColor = Color.Black;

                backButton.BackColor = Color.LightCoral;
                backButton.ForeColor = Color.Black;
            }
        }
    }
}