using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Speed_Converter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void displayButton_Click(object sender, EventArgs e)
        {
            // 常數
            const int START_SPEED = 60;
            const int END_SPEED = 130;
            const int INTERVAL = 10;
            const double CONVERSION_FACTOR = 0.6214;

            int kmh; // 公里/小時
            double mph; // 英里/小時

            outputListBox.Items.Clear(); // 清空 ListBox


            for(kmh = START_SPEED; kmh <= END_SPEED; kmh += INTERVAL)
            {
                mph = kmh * CONVERSION_FACTOR; // 轉換為英里/小時
                outputListBox.Items.Add($"{kmh} 公里/小時 = {mph:F2} 英里/小時");
            }


        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉表單
            this.Close();
        }
    }
}