using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Time_Zone
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            string city = "";

            if (cityListBox.SelectedIndex != -1)
            {
                city = cityListBox.SelectedItem.ToString();
            }

            switch (city)
            {
                case "紐約":
                    MessageBox.Show("東部時間");
                    break;
                case "舊金山":
                    MessageBox.Show("太平洋時間");
                    break;
                case "明尼阿波利斯":
                    MessageBox.Show("中部時間");
                    break;
                case "檀香山":
                    MessageBox.Show("夏威夷時間");
                    break;
                case "丹佛":
                    MessageBox.Show("山區時間");
                    break;
                default:
                    MessageBox.Show("請選擇一個城市。");
                    break;
            }
        }
        
           

        

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }

        private void cityListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void addbutton_Click(object sender, EventArgs e)
        {
            cityListBox.Items.Add("水牛城");
        }

        private void clearbutton_Click(object sender, EventArgs e)
        {
            cityListBox.Items.Clear();
        }
    }
}
