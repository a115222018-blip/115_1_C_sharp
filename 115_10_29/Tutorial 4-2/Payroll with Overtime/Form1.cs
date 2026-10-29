using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Payroll_with_Overtime
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            const int BASE_HOURS = 40; // Regular hours per week
            const decimal OVERTIME_RATE = 1.5m; // Overtime pay rate
           
            double hoursWorked;
            decimal hourlyPayRate;
            decimal grossPay;

            try
            {   // Get the hours worked and hourly pay rate from the TextBoxes.
                hoursWorked = double.Parse(hoursWorkedTextBox.Text);
                hourlyPayRate = decimal.Parse(hourlyPayRateTextBox.Text);
                // Calculate gross pay with overtime consideration.
                if (hoursWorked <= BASE_HOURS)
                {
                    grossPay = (decimal)hoursWorked * hourlyPayRate;
                }
                else
                {
                   decimal overtimeHours = (decimal)hoursWorked - BASE_HOURS;
                    grossPay = (BASE_HOURS * hourlyPayRate) +(overtimeHours * hourlyPayRate * OVERTIME_RATE);
                }
                // Display the gross pay in the label.
                grossPayLabel.Text = grossPay.ToString("C");
            }
            catch (FormatException)
            {
                MessageBox.Show("請輸入有效的數字。");
            }

        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            // Clear the TextBoxes and gross pay label.
            hoursWorkedTextBox.Text = "";
            hourlyPayRateTextBox.Text = "";
            grossPayLabel.Text = "";

            // Reset the focus.
            hoursWorkedTextBox.Focus();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }
    }
}
