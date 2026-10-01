using System.Security.Cryptography;

namespace tutorial2_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        private void german_Click(object sender, EventArgs e)
        {
            translateLabel.Text = "Guten Morgen";
        }

        private void spainish_Click(object sender, EventArgs e)
        {
            translateLabel.Text = "Buen día";
        }

        private void italion_Click(object sender, EventArgs e)
        {
            translateLabel.Text = "Buongiorno";
        }
    }
}
