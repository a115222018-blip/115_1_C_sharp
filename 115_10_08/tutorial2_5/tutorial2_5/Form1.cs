namespace tutorial2_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void showface_Click(object sender, EventArgs e)
        {
            face.Visible = true;

            back.Visible = false;
        }

        private void showback_Click(object sender, EventArgs e)
        {
            face.Visible = false;

            back.Visible = true;
               
        }

        private void face_Click(object sender, EventArgs e)
        {

        }
    }
}
