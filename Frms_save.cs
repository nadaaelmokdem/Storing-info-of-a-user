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
    public partial class Frms_save : Form
    {
        public Frms_save()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.FileName = "قم ياختيار الملف";
            sfd.InitialDirectory = Environment.GetFolderPath (Environment.SpecialFolder.ApplicationData);
            sfd.FileName = textBox2.Text + "txt";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                string strpath = sfd.FileName;
                if (Path.GetExtension(sfd.FileName ).ToLower () != ".txt")
                {

                }
            }

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
