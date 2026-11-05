namespace StringCompare
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCompare_Click(object sender, EventArgs e)
        {
            string string1, string2;
            string1 = txtString1.Text;
            string2 = txtString2.Text;

            if (String.Compare(string1,string2)==0)
            {
                MessageBox.Show("兩個字串相同");
            }
            else if (String.Compare(string1, string2) < 0)
            {
                MessageBox.Show($"{string1} 小於 {string2}");
            }
            
            else
            {
                MessageBox.Show($"{string1} 大於 {string2}");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
