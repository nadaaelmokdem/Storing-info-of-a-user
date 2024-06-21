using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp7
{
    public partial class Frms_photo2 : Form
    {
        public Frms_photo2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources._2815428;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //pictureBox2.Image = Image.FromFile("spotify.png");
            //لو عايوين نمسح الصوره و البرنامج مفتوح
            try
            {
                FileStream fs = File.Open("spotify.png", FileMode.Open);
                Bitmap bitmap = new Bitmap(fs);
                pictureBox2.Image = bitmap;
                fs.Close();
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            };
        }
    }
}
