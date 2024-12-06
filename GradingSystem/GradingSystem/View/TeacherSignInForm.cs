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
                // Go to the Teacher GUI
                List<Teacher> teachers = DataService.Teachers;
                bool valid = false;
                foreach (Teacher t in teachers)
                {

                    if (t.Id == int.Parse(IDtextBox.Text) && t.Password == passwordTextBox.Text)
                    {
                        DataService.Teacher = t;
                        valid = true;

                        Hide();
                        var form = new teacherMainMenu();
                        form.Closed += (s, args) => Close();
                        form.Show();
                        break;
                    }
                    else
                    {
                        // Do nothing
                    }
                }
                if (!valid)
                {
                    MessageBox.Show("Teacher ID or Password is incorrect", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Your ID must be composed only of numbers", "ID must be numbers", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
