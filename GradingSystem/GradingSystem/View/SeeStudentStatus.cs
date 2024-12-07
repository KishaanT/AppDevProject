using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GradingSystem.Services;

namespace GradingSystem
{
    public partial class SeeStudentStatus : Form
    {

        public SeeStudentStatus()
        {
            InitializeComponent();
            determineStanding();
            displayAverage();
            ApplyTheme();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void determineStanding()
        {
            //// Get the student's status (Passing or Failing) using the GetStatus method
            //string status = DataService.Student.GetStatus();

            //// Update the label text and color based on the status
            //if (status == "Passing")
            //{
            //    passingLabel.Text = "Passing";
            //    passingLabel.ForeColor = Color.SpringGreen;
            //}
            //else
            //{
            //    passingLabel.Text = "Failing";
            //    passingLabel.ForeColor = Color.IndianRed;
            //}
        }

        private void displayAverage()
        {
            //string averageToDisplay = DataService.Student.Average.ToString();
            //averageToDisplay += "%";
            //gradeLabel.Text = averageToDisplay;
        }

        private void ApplyTheme()
        {
            ThemeManager.ApplyTheme(this);

            if (ThemeManager.IsDarkMode)
            {
                this.BackColor = Color.FromArgb(18, 18, 18);
                this.ForeColor = Color.White;

                closeButton.BackColor = Color.DarkRed;
                closeButton.ForeColor = Color.White;

                if (passingLabel.Text == "Passing")
                {
                    passingLabel.ForeColor = Color.SpringGreen;
                }
                else
                {
                    passingLabel.ForeColor = Color.IndianRed;
                }
            }
            else
            {
                this.BackColor = Color.White;
                this.ForeColor = Color.Black;

                closeButton.BackColor = Color.LightCoral;
                closeButton.ForeColor = Color.Black;

                if (passingLabel.Text == "Passing")
                {
                    passingLabel.ForeColor = Color.SpringGreen;
                }
                else
                {
                    passingLabel.ForeColor = Color.IndianRed;
                }
            }
        }

    }
}
