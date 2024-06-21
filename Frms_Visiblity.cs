namespace WinFormsApp7
{
    public partial class Frms_Visiblity : Form
    {
        public Frms_Visiblity()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello " + textBox1.Text);
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            textBox1.Visible = true;
            textBox1.Focus();
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            textBox1.Visible = false;
        }
    }
}