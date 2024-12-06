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
            //Hide();
            //var form = new StudentMainMenu();
            //form.Closed += (s, args) => Close();
            //form.Show();
          
            try
            {
                List<Student> students = DataService.Students;
                foreach (Student s in students)
                {
                    
                    if (s.Id == int.Parse(IDtextBox.Text) && s.Password == passwordTextBox.Text)
                    {
                        DataService.Student = s;

                        Hide();
                        var form = new StudentMainMenu();
                        form.Closed += (c, args) => Close();
                        form.Show();
                        break;
                    }
                    else
                    {
                        //MessageBox.Show("Student Id or Password", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                MessageBox.Show("Student Id or Password", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Your ID must be composed only of numbers", "ID must be numbers", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (NullReferenceException ex) 
            {
                MessageBox.Show("School is empty", "NO STUDENTS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }
}
