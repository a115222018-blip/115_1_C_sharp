using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Loan_Qualifier
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkButton_Click(object sender, EventArgs e)
        {
            const decimal MIN_SALARY = 40000m; // 最低年收入
            const int MIN_YEARS = 2; // 最低工作年資

            decimal salary; // 年收入
            int years; // 工作年資

            try
            {
                salary = decimal.Parse(salaryTextBox.Text);
                years = int.Parse(yearsTextBox.Text);

                if (salary >= MIN_SALARY )
                {
                  
                    if (years >= MIN_YEARS)
                    {
                        decisionLabel.Text = "符合貸款資格";
                    }
                    else
                    {
                        decisionLabel.Text = "薪資符合但是年資不符合貸款資格";
                    }
                }
                else
                {
                    decisionLabel.Text = "薪資不符合貸款資格";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ex.Message");
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            // 清除文字方塊與審核結果。
            salaryTextBox.Text = "";
            yearsTextBox.Text = "";
            decisionLabel.Text = "";

            // 將輸入焦點放回年收入文字方塊。
            salaryTextBox.Focus();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉視窗。
            this.Close();
        }
    }
}
