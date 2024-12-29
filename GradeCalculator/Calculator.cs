using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GradeCalculator
{
    internal class Calculator
    {
        static double grades = 0;

        public static double GetGrade(TextBox[] textbox, Label grade, Label convertedGrade)
        {
            double total20Percent = 0;
            double total40Percent = 0;

            if (textbox[3].Text != "")
            {
                for (int i = 0; i < 3; i++)
                {
                    total20Percent = total20Percent + double.Parse(textbox[i].Text);
                }
                total40Percent = double.Parse(textbox[3].Text);
                
                grades = (total20Percent * 0.20) + (total40Percent * 0.40);
            }
            else if (textbox[3].Text == "")
            {
                for (int i = 0; i < 3; i++)
                {
                    total20Percent = total20Percent + double.Parse(textbox[i].Text);
                }
                grades = total20Percent * 0.20;
            }
            else if(textbox[2].Text == "")
            {
                for (int i = 0; i < 2; i++)
                {
                    total20Percent = total20Percent + double.Parse(textbox[i].Text);
                }

                grades = total20Percent * 0.20;
            }
            else if(textbox[1].Text == "")
            {
                for (int i = 0; i < 1; i++)
                {
                    total20Percent = total20Percent + double.Parse(textbox[i].Text);
                }

                grades = total20Percent * 0.20;
            }
            else if (textbox[0].Text == "")
            {
                MessageBox.Show("Please enter a grade");
            }

            grade.Text = grades.ToString();

            CalculateGradePoint(grades, convertedGrade);

            return grades;
        }

        //CALCULATION FROM STACKOVERFLOW (this is beyond my knowledge, and i dont care about this college grade convertion shit)
        static double CalculateGradePoint(double percentage, Label label)
        {
            double[] percentages = { 97.5, 94.5, 91.5, 88.5, 85.5, 81.5, 77.5, 73.5, 69.5 };
            double[] gradePoints = { 1.00, 1.25, 1.50, 1.75, 2.00, 2.25, 2.50, 2.75, 3.00 };

            if (percentage < percentages[percentages.Length - 1])
            {
                label.Text = "5.00";
                return 5.00;
            }

            for (int i = 0; i < percentages.Length - 1; i++)
            {
                if (percentage >= percentages[i + 1] && percentage <= percentages[i])
                {
                    double P_low = percentages[i + 1];
                    double P_high = percentages[i];
                    double G_low = gradePoints[i + 1];
                    double G_high = gradePoints[i];

                    label.Text = (G_low + ((percentage - P_low) / (P_high - P_low)) * (G_high - G_low)).ToString("F2");
                    return G_low + ((percentage - P_low) / (P_high - P_low)) * (G_high - G_low);
                }
            }

            label.Text = "3.00";
            return 3.00;
        }
    }
}
