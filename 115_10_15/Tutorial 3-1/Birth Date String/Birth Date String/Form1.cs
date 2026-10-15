using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Birth_Date_String
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void showDateButton_Click(object sender, EventArgs e)
        {
            // 組合使用者輸入的日期字串並顯示在輸出標籤上
            // 範例輸出格式：星期一, 一月 1, 2000
            string output;

            // 從各輸入欄位取得文字，並用逗號與空白組合成完整的日期字串
            output = dayOfWeekTextBox.Text + ", " + monthTextBox.Text + " " + dayOfMonthTextBox.Text + ", " + yearTextBox.Text;

            // 將組合後的字串顯示在介面上的 label（dateOutputLabel）中
            dateOutputLabel.Text = output;
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            // 清空所有輸入欄位與輸出標籤的內容
            dayOfWeekTextBox.Text = "";   // 清除星期欄位
            monthTextBox.Text = "";      // 清除月份欄位
            dayOfMonthTextBox.Text = ""; // 清除日期欄位
            yearTextBox.Text = "";       // 清除年份欄位

            dateOutputLabel.Text = "";   // 清除顯示結果
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉目前表單，即結束程式視窗
            this.Close();
        }

        private void yearPromptLabel_Click(object sender, EventArgs e)
        {

            // 這是一個自動產生的事件處理器，目前未使用。
            // 如果不需要可以在設計工具中解除事件綁定以移除此方法。
        }
    }
}
