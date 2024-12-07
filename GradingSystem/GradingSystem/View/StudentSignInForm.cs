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
    public partial class StudentSignInForm : Form
    {
        ChangeLanguage changeLanguage = new ChangeLanguage();
        public StudentSignInForm()
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
         
            try
            {

                bool check = DataBackupService.CheckStudent(int.Parse(IDtextBox.Text), passwordTextBox.Text);
                if (check)
                {
                    int id = int.Parse(IDtextBox.Text);
                    DataService.Student = DataBackupService.RestoreStudentData().FirstOrDefault(t => t.Id == id);

                    Hide();
                    var form = new StudentMainMenu();
                    form.Closed += (c, args) => Close();
                    form.Show();
                    return;

                }
                else
                {
                    MessageBox.Show("Student ID or Password is incorrect", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Your ID must be composed only of numbers", "ID must be numbers", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }
}
