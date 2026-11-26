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

namespace Friend_File
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void writeNameButton_Click(object sender, EventArgs e)
        {
            try 
            {
                StreamWriter outputFile;

                //outputFile = File.CreateText("Friend.txt");

                outputFile = File.AppendText("Friend.txt");

                outputFile.WriteLine(nameTextBox.Text);

                outputFile.Close();

                MessageBox.Show("姓名已寫入 Friend.txt 檔案。");
            }
            catch (IOException ex)
            {
                MessageBox.Show("發生錯誤: " + ex.Message);
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉表單。
            this.Close();
        }
    }
}
