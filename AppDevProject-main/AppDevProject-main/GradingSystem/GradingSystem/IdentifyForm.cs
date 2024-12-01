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
    public partial class IdentifyForm : Form
    {
        ApplicationLanguage language = ApplicationLanguage.Instance;
        ChangeLanguage changeLanguage = new ChangeLanguage();

        public IdentifyForm()
        {
            InitializeComponent();
        }

        private void studentButton_Click(object sender, EventArgs e)
        {
            Hide();
            var studentSignInForm = new StudentSignInForm();
            studentSignInForm.Closed += (s, args) => this.Close();
            studentSignInForm.Show();
        }

        private void teacherButton_Click(object sender, EventArgs e)
        {
            Hide();
            var teacherSignInForm = new TeacherSignInForm();
            teacherSignInForm.Closed += (s, args) => this.Close();
            teacherSignInForm.Show();
        }

        private void languageComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (languageComboBox.SelectedIndex)
            {
                case 0:
                    changeLanguage.UpdateConfig("language", "en");
                    language.Key = "language";
                    language.Value = "en";
                    Application.Restart();
                    break;
                case 1:
                    changeLanguage.UpdateConfig("language", "fr-CA");
                    language.Key = "language";
                    language.Value = "fr-CA";
                    Application.Restart();
                    break;
                case 2:
                    changeLanguage.UpdateConfig("language", "es");
                    language.Key = "language";
                    language.Value = "es";
                    Application.Restart();
                    break;
            }
        }
    }
}
