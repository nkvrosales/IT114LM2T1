using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Module1Exercise1
{
    public partial class Exercise3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // TODO 3.3 Set the text value of the finalGrade label to "Submit your grade percentage to see your final grade!". Watch out for post backs
            finalGrade.Text = "Submit your grade percentage to see your final grade!";
        }

        protected void DisplayGrade(object sender, EventArgs e)
        {
            // Get the percentage grade entered by the user
            string percentageText = percentageGrade.Text;

            if (!string.IsNullOrEmpty(percentageText))
            {
                if (double.TryParse(percentageText, out double percentage))
                {
                    if (percentage > 96.00)
                    {
                        finalGrade.Text = "1.00";
                        Response.Write($"<script>alert('Congratulations! You got an uno.')</script>");
                    }
                    else if (percentage <= 96.00 && percentage >= 91.51)
                    {
                        finalGrade.Text = "1.25";
                    }
                    else if (percentage < 91.51 && percentage >= 87.01)
                    {
                        finalGrade.Text = "1.50";
                    }
                    else if (percentage < 87.01 && percentage >= 82.51)
                    {
                        finalGrade.Text = "1.75";
                    }
                    else if (percentage < 82.51 && percentage >= 78.01)
                    {
                        finalGrade.Text = "2.00";
                    }
                    else if (percentage < 78.01 && percentage >= 73.51)
                    {
                        finalGrade.Text = "2.25";
                    }
                    else if (percentage < 73.51 && percentage >= 69.01)
                    {
                        finalGrade.Text = "2.50";
                    }
                    else if (percentage < 69.01 && percentage >= 64.51)
                    {
                        finalGrade.Text = "2.75";
                    }
                    else if (percentage < 64.51 && percentage >= 60.00)
                    {
                        finalGrade.Text = "3.00";
                    }
                    else if (percentage < 60.00)
                    {
                        finalGrade.Text = "5.00";
                    }
                }
                else
                {
                    finalGrade.Text = "Invalid input";
                }
            }
        }
    }
}