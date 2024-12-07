using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Globalization;
using GradingSystem.Services;

namespace GradingSystem
{
    public partial class SeeClassStatus : Form
    {
        ChangeLanguage changeLanguage = new ChangeLanguage();
        public SeeClassStatus()
        {
            InitializeComponent();
            changeLanguage.UpdateConfig(ApplicationLanguage.Instance.Key, ApplicationLanguage.Instance.Value);
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void determineStanding()
        {
            // Get the student's status (Passing or Failing) using the GetStatus method
            string status = DataService.Student.GetStatus();

            // Update the label text and color based on the status
            if (status == "Passing")
            {
                passingLabel.Text = "Passing";
                passingLabel.ForeColor = Color.SpringGreen;
            }
            else
            {
                passingLabel.Text = "Failing";
                passingLabel.ForeColor = Color.IndianRed;
            }
        }

        private void displayAverage()
        {
            string averageToDisplay = DataService.Student.Average.ToString();
            averageToDisplay += "%";
            gradeLabel.Text = averageToDisplay;
        }
    }
}
