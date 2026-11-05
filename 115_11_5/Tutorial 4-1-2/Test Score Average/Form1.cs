using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_Score_Average
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            // 初始化表單上的所有控制項。
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
           
        {
            // 設定及格分數門檻。
            
            double test1, test2, test3, average;
            string grade;

            try
            {
                // 讀取三次測驗分數，並將輸入內容轉換為數值。
                test1 = double.Parse(test1TextBox.Text);
                test2 = double.Parse(test2TextBox.Text);
                test3 = double.Parse(test3TextBox.Text);

                // 計算三次測驗分數的平均值。
                average = (test1 + test2 + test3) / 3.0;

                // 將平均分數格式化為小數點後一位並顯示。
                averageLabel.Text = average.ToString("F1");

                if (average >= 90)
                {
                    grade = "A";
                }
                else if (average >= 80 && average < 90)
                {
                    grade = "B";
                }
                else if (average >= 70 && average < 80)
                {
                    grade = "C";
                }
                else if (average >= 60 && average < 70)
                { 
                    grade = "D";
                }
                else
                { 
                    grade = "F"; 
                }

                   MessageBox.Show("成績等級:" + grade);
            }
            catch (Exception ex)
            {
                // 當輸入內容不是有效數值時，顯示錯誤訊息。
                MessageBox.Show(ex.Message);
            }
        }



        private void clearButton_Click(object sender, EventArgs e)
        {
            // 清除三個輸入框與平均分數顯示欄位的內容。
            test1TextBox.Text = "";
            test2TextBox.Text = "";
            test3TextBox.Text = "";
            averageLabel.Text = "";

            // 將輸入焦點移回第一個測驗分數輸入框。
            test1TextBox.Focus();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉目前的表單。
            this.Close();
        }
    }
}
