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
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void determineStanding() // it works, but the students must have assigned values first
        {
            if (DataService.Student.Average >= 60)
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
