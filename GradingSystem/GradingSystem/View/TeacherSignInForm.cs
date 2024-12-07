using Globalization;
using GradingSystem.Services;
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
        //private List<Teacher> teachers = new List<Teacher>();

        public TeacherSignInForm()
        {
            InitializeComponent();
            changeLanguage.UpdateConfig(ApplicationLanguage.Instance.Key, ApplicationLanguage.Instance.Value);
            //loadDataFromFile();
            ApplyTheme();
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
            //    try
            //    {
            //        // Go to the Teacher GUI
            //        List<Teacher> teachers = DataService.Teachers;
            //        bool valid = false;
            //        foreach (Teacher t in teachers)
            //        {

            //            if (t.Id == int.Parse(IDtextBox.Text) && t.Password == passwordTextBox.Text)
            //            {
            //                DataService.Teacher = t;
            //                valid = true;

            Hide();
            var form = new teacherMainMenu();
            form.Closed += (s, args) => Close();
            form.Show();
            //                break;
            //            }
            //            else
            //            {
            //                // Do nothing
            //            }
            //        }
            //        if (!valid)
            //        {
            //            MessageBox.Show("Teacher ID or Password is incorrect", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //        }
            //    }
            //    catch (FormatException ex)
            //    {
            //        MessageBox.Show("Your ID must be composed only of numbers", "ID must be numbers", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    }
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

                // TextBoxes
                IDtextBox.BackColor = Color.FromArgb(30, 30, 30);
                IDtextBox.ForeColor = Color.White;

                passwordTextBox.BackColor = Color.FromArgb(30, 30, 30);
                passwordTextBox.ForeColor = Color.White;

                // Buttons
                backButton.BackColor = Color.DarkRed;
                backButton.ForeColor = Color.White;

                nextButton.BackColor = Color.Teal;
                nextButton.ForeColor = Color.White;
            }
            else
            {
                // General form background and text color
                this.BackColor = Color.White;
                this.ForeColor = Color.Black;

                // TextBoxes
                IDtextBox.BackColor = Color.White;
                IDtextBox.ForeColor = Color.Black;

                passwordTextBox.BackColor = Color.White;
                passwordTextBox.ForeColor = Color.Black;

                // Buttons
                backButton.BackColor = Color.LightCoral;
                backButton.ForeColor = Color.Black;

                nextButton.BackColor = Color.LightSeaGreen;
                nextButton.ForeColor = Color.Black;
            }
        }
    }
}