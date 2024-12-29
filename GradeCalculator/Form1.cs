using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GradeCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate1_Click(object sender, EventArgs e)
        {
            TextBox[] subject1 = { prelim1, midterm1, prefinals1, finals1 };

            Calculator.GetGrade(subject1, lblGrade1, lblConvertedGrade1);
        }

        private void btnCalculate2_Click(object sender, EventArgs e)
        {
            TextBox[] subject2 = { prelim2, midterm2, prefinals2, finals2 };

            Calculator.GetGrade(subject2, lblGrade2, lblConvertedGrade2);
        }

        private void btnCalculate3_Click(object sender, EventArgs e)
        {
            TextBox[] subject3 = { prelim3, midterm3, prefinals3, finals3 };

            Calculator.GetGrade(subject3, lblGrade3, lblConvertedGrade3);
        }

        private void btnCalculate4_Click(object sender, EventArgs e)
        {
            TextBox[] subject4 = { prelim4, midterm4, prefinals4, finals4 };

            Calculator.GetGrade(subject4, lblGrade4, lblConvertedGrade4);
        }

        private void btnCalculate5_Click(object sender, EventArgs e)
        {
            TextBox[] subject5 = { prelim5, midterm5, prefinals5, finals5 };

            Calculator.GetGrade(subject5, lblGrade5, lblConvertedGrade5);
        }

        private void btnCalculate6_Click(object sender, EventArgs e)
        {
            TextBox[] subject6 = { prelim6, midterm6, prefinals6, finals6 };

            Calculator.GetGrade(subject6, lblGrade6, lblConvertedGrade6);
        }

        private void btnCalculate7_Click(object sender, EventArgs e)
        { 
            TextBox[] subject7 = { prelim7, midterm7, prefinals7, finals7 };

            Calculator.GetGrade(subject7, lblGrade7, lblConvertedGrade7);
        }
    }
}
