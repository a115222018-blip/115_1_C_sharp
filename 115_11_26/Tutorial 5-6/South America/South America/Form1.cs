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

namespace South_America
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void getCountriesButton_Click(object sender, EventArgs e)
        {
            // 這裡是取得國家按鈕的點擊事件處理程式。
            try
            {
                StreamReader inputFile;

                inputFile= File.OpenText(@"C:\Users\m303\Desktop\115_1_C_sharp\115_11_26\Tutorial 5-6\South America\South America\bin\Debug\countries.txt");

                while (!inputFile.EndOfStream)
                {
                    // 讀取每一行，並將其加入到國家清單中。
                    string country = inputFile.ReadLine();
                    countriesListBox.Items.Add(country);
                }
            }
            catch (Exception ex)
            {
                // 如果發生錯誤，顯示錯誤訊息。
                MessageBox.Show("無法讀取國家檔案: " + ex.Message);
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉表單。
            this.Close();
        }
    }
}
