using Globalization;
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
        public TeacherSignInForm()
        {
            InitializeComponent();
            changeLanguage.UpdateConfig(ApplicationLanguage.Instance.Key, ApplicationLanguage.Instance.Value);
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
