using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System;

namespace WinFormsApp7
{
    public partial class Frms_Example1 : Form
    {
        public Frms_Example1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                if (id2.Text.Trim() == "" || name2.Text.Trim() == "" || address2.Text.Trim() == "")
                {
                    MessageBox.Show("Please enter valid name");
                    return;
                }
                StreamReader sr2 = new StreamReader("Mydata.txt");
                string strname2 = sr2.ReadToEnd();
                sr2.Close();
                if (strname2.Contains(id2.Text + ":"))
                {
                    MessageBox.Show("This id already exists ,Please try another one");
                    id2.Focus();
                    id2.SelectAll();
                }
                else
                {
                    StreamWriter sr = new StreamWriter("Mydata.txt", true);
                    string strname = id2.Text + ":"
                                   + name2.Text + ":"
                                   + address2.Text;
                    sr.WriteLine(strname);
                    sr.Close();
                    if (!Directory.Exists("img"))
                        Directory.CreateDirectory("img");
                    pictureBox1.Image.Save("img/" + id2.Text + ".jpg");
                    MessageBox.Show("Person Is Added");
                    foreach (Control c in this.Controls)
                    {
                        if (c is TextBox)
                        {
                            c.Text = "";
                        }

                    }
                    pictureBox1.Image = new PictureBox().Image;
                    id2.Focus();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Frms_Example1_Load(object sender, EventArgs e)
        {
            Icon = Icon.ExtractAssociatedIcon("WinFormsApp7.exe");
        }

        private void find1_Click(object sender, EventArgs e)
        {
            try
            {
                if (id2.Text.Trim() != "")
                {
                    StreamReader stream = new StreamReader("Mydata.txt");
                    string stnamme = "";
                    bool found = false;
                    do
                    {
                        stnamme = stream.ReadLine();
                        if (stnamme != null)
                        {
                            string[] arrname = stnamme.Split(':');
                            if (arrname[0] == id2.Text)
                            {
                                id2.Text = arrname[0];
                                name2.Text = arrname[1];
                                address2.Text = arrname[2];
                                string mypath = "img/" + arrname[0] + ".jpg";
                                if (File.Exists(mypath))
                                    pictureBox1.Image = Image.FromFile(mypath);
                                found = true;
                                break;
                            }
                        }
                    } while (stnamme != null);
                    stream.Close();
                    if (!found)
                    {
                        MessageBox.Show("This Id is not avaliable , Please add or sreach with another one");
                        id2.Focus();
                        id2.SelectAll();
                    }


                }
                else
                {
                    MessageBox.Show("Error try again");
                    id2.Focus();
                    id2.SelectAll();
                }
            }
            catch (Exception ex)
            { 
                MessageBox.Show(ex.Message);    
            }
        }

        private void show1_Click(object sender, EventArgs e)
        {
            Form frmshow = new Form();  
            TextBox txtshow = new TextBox();
            frmshow.StartPosition = FormStartPosition.CenterScreen;
            frmshow.Font = this.Font;
            frmshow.Size = this.Size;
            frmshow.Icon = this.Icon;
            frmshow.Text = "All Data";
            txtshow.Multiline= true;
            txtshow.Dock= DockStyle.Fill;
            frmshow.Controls.Add(txtshow);
            try
            {
                StreamReader sr = new StreamReader("Mydata.txt");
                string strall = sr.ReadToEnd();
                sr.Close();
                txtshow.Text = strall;
             
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);    
            }
            frmshow.ShowDialog();


        }

        private void id2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnperson_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Images | *.jpg ; *.gif ; *.png";
            ofd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(ofd.FileName);
            }
        }
    }
}
