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
    public partial class StudentSignInForm : Form
    {
        public StudentSignInForm()
        {
            InitializeComponent();
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
            // Go to the Student GUI
        }
    }
}
