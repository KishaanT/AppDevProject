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
        private bool isDarkMode = false;

        public IdentifyForm()
        {
            InitializeComponent();
            ApplyTheme();
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

        private void darkModeButton_Click(object sender, EventArgs e)
        {
            // Toggle dark mode
            ThemeManager.IsDarkMode = !ThemeManager.IsDarkMode;

            // Apply theme to all forms
            foreach (Form form in Application.OpenForms)
            {
                if (form is IdentifyForm mainForm)
                {
                    mainForm.ApplyTheme(); // Apply local theme
                }
                else
                {
                    ThemeManager.ApplyTheme(form); // General theme application for other forms
                }
            }
        }

        private void ApplyTheme()
        {
            if (ThemeManager.IsDarkMode)
            {
                darkModeButton.Text = "Light Mode";
                this.BackColor = Color.FromArgb(18, 18, 18);
                this.ForeColor = Color.White;

                studentButton.BackColor = Color.DarkBlue;
                studentButton.ForeColor = Color.White;

                teacherButton.BackColor = Color.DarkMagenta;
                teacherButton.ForeColor = Color.White;
            }
            else
            {
                darkModeButton.Text = "Dark Mode";
                this.BackColor = Color.White;
                this.ForeColor = Color.Black;

                studentButton.BackColor = Color.LimeGreen;
                studentButton.ForeColor = Color.Black;

                teacherButton.BackColor = Color.Orange;
                teacherButton.ForeColor = Color.Black;
            }
        }
    }
}
