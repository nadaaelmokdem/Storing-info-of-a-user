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
    public partial class Frms_Openfile : Form
    {
        public Frms_Openfile()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ofd.Title = "Choose A File :";
            //ofd.Multiselect= true;
            //ofd.InitialDirectory= Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);  
            ofd.ShowDialog();
            txtpath.Text = ofd.FileName;
            txtfilename.Text = Path.GetFileName(ofd.FileName);
            txtext.Text = Path.GetExtension (ofd.FileName);
        }
    }
}
