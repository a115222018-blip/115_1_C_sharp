using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Total_Sales
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            // 計算按鈕點擊事件處理
            try
            {
                StreamReader inputFile; 

                inputFile = File.OpenText("Sales.txt"); 

                decimal total = 0m; // 儲存總銷售額
                decimal sales; 

                while (!inputFile.EndOfStream) 
                {
                    if (decimal.TryParse(inputFile.ReadLine(), out sales)) 
                    {
                        total += sales; 
                    }
                    else
                    {
                        MessageBox.Show("檔案中包含無效的銷售額數據。");
                        inputFile.Close(); 
                        return; 
                    }
                }
                inputFile.Close(); 
                totalLabel.Text = total.ToString("C"); // 顯示總銷售額，格式化為貨幣
            }

            catch(Exception ex)
            {
                MessageBox.Show("發生錯誤:" + ex.Message);
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉表單
            this.Close();
        }
    }
}
