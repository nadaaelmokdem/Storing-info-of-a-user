namespace WinFormsApp7
{
    partial class Frms_Example1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.id1 = new System.Windows.Forms.Label();
            this.id2 = new System.Windows.Forms.TextBox();
            this.name2 = new System.Windows.Forms.TextBox();
            this.name1 = new System.Windows.Forms.Label();
            this.address2 = new System.Windows.Forms.TextBox();
            this.address1 = new System.Windows.Forms.Label();
            this.new1 = new System.Windows.Forms.Button();
            this.find1 = new System.Windows.Forms.Button();
            this.show1 = new System.Windows.Forms.Button();
            this.exit1 = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnperson = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe Fluent Icons", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Location = new System.Drawing.Point(351, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(681, 128);
            this.label1.TabIndex = 0;
            this.label1.Text = "Person Data ";
            // 
            // id1
            // 
            this.id1.AutoSize = true;
            this.id1.BackColor = System.Drawing.Color.Teal;
            this.id1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.id1.ForeColor = System.Drawing.Color.White;
            this.id1.Location = new System.Drawing.Point(101, 145);
            this.id1.Name = "id1";
            this.id1.Size = new System.Drawing.Size(54, 41);
            this.id1.TabIndex = 1;
            this.id1.Text = "ID:";
            // 
            // id2
            // 
            this.id2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.id2.Location = new System.Drawing.Point(253, 159);
            this.id2.Multiline = true;
            this.id2.Name = "id2";
            this.id2.Size = new System.Drawing.Size(465, 27);
            this.id2.TabIndex = 2;
            this.toolTip1.SetToolTip(this.id2, "Enter Your ID");
            this.id2.TextChanged += new System.EventHandler(this.id2_TextChanged);
            // 
            // name2
            // 
            this.name2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.name2.Location = new System.Drawing.Point(253, 218);
            this.name2.Multiline = true;
            this.name2.Name = "name2";
            this.name2.Size = new System.Drawing.Size(465, 27);
            this.name2.TabIndex = 4;
            this.toolTip1.SetToolTip(this.name2, "Enter Your Name");
            // 
            // name1
            // 
            this.name1.AutoSize = true;
            this.name1.BackColor = System.Drawing.Color.Teal;
            this.name1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.name1.ForeColor = System.Drawing.Color.White;
            this.name1.Location = new System.Drawing.Point(101, 204);
            this.name1.Name = "name1";
            this.name1.Size = new System.Drawing.Size(104, 41);
            this.name1.TabIndex = 3;
            this.name1.Text = "Name:";
            // 
            // address2
            // 
            this.address2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.address2.Location = new System.Drawing.Point(253, 276);
            this.address2.Multiline = true;
            this.address2.Name = "address2";
            this.address2.Size = new System.Drawing.Size(465, 27);
            this.address2.TabIndex = 6;
            this.toolTip1.SetToolTip(this.address2, "Enter Your Address");
            // 
            // address1
            // 
            this.address1.AutoSize = true;
            this.address1.BackColor = System.Drawing.Color.Teal;
            this.address1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.address1.ForeColor = System.Drawing.Color.White;
            this.address1.Location = new System.Drawing.Point(101, 262);
            this.address1.Name = "address1";
            this.address1.Size = new System.Drawing.Size(140, 41);
            this.address1.TabIndex = 5;
            this.address1.Text = "Address :";
            // 
            // new1
            // 
            this.new1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.new1.AutoEllipsis = true;
            this.new1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.new1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.new1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.new1.Font = new System.Drawing.Font("Simple Bold Jut Out", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.new1.ForeColor = System.Drawing.Color.White;
            this.new1.Location = new System.Drawing.Point(75, 344);
            this.new1.Name = "new1";
            this.new1.Size = new System.Drawing.Size(172, 64);
            this.new1.TabIndex = 7;
            this.new1.Text = "Add New ";
            this.toolTip1.SetToolTip(this.new1, "To Add New Person");
            this.new1.UseVisualStyleBackColor = false;
            this.new1.Click += new System.EventHandler(this.button1_Click);
            // 
            // find1
            // 
            this.find1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.find1.AutoEllipsis = true;
            this.find1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.find1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.find1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.find1.Font = new System.Drawing.Font("Simple Bold Jut Out", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.find1.ForeColor = System.Drawing.Color.White;
            this.find1.Location = new System.Drawing.Point(253, 344);
            this.find1.Name = "find1";
            this.find1.Size = new System.Drawing.Size(172, 64);
            this.find1.TabIndex = 8;
            this.find1.Text = "Find";
            this.toolTip1.SetToolTip(this.find1, "To Find Someone");
            this.find1.UseVisualStyleBackColor = false;
            this.find1.Click += new System.EventHandler(this.find1_Click);
            // 
            // show1
            // 
            this.show1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.show1.AutoEllipsis = true;
            this.show1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.show1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.show1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.show1.Font = new System.Drawing.Font("Simple Bold Jut Out", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.show1.ForeColor = System.Drawing.Color.White;
            this.show1.Location = new System.Drawing.Point(431, 344);
            this.show1.Name = "show1";
            this.show1.Size = new System.Drawing.Size(172, 64);
            this.show1.TabIndex = 9;
            this.show1.Text = "Show All";
            this.toolTip1.SetToolTip(this.show1, "Showing All The Info");
            this.show1.UseVisualStyleBackColor = false;
            this.show1.Click += new System.EventHandler(this.show1_Click);
            // 
            // exit1
            // 
            this.exit1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.exit1.AutoEllipsis = true;
            this.exit1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.exit1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.exit1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.exit1.Font = new System.Drawing.Font("Simple Bold Jut Out", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.exit1.ForeColor = System.Drawing.Color.White;
            this.exit1.Location = new System.Drawing.Point(609, 344);
            this.exit1.Name = "exit1";
            this.exit1.Size = new System.Drawing.Size(172, 64);
            this.exit1.TabIndex = 10;
            this.exit1.Text = "Exit";
            this.toolTip1.SetToolTip(this.exit1, "Exit The Application");
            this.exit1.UseVisualStyleBackColor = false;
            this.exit1.Click += new System.EventHandler(this.button4_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip1.ToolTipTitle = "Note";
            // 
            // btnperson
            // 
            this.btnperson.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnperson.AutoEllipsis = true;
            this.btnperson.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnperson.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnperson.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnperson.Font = new System.Drawing.Font("Simple Bold Jut Out", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnperson.ForeColor = System.Drawing.Color.White;
            this.btnperson.Location = new System.Drawing.Point(860, 344);
            this.btnperson.Name = "btnperson";
            this.btnperson.Size = new System.Drawing.Size(172, 64);
            this.btnperson.TabIndex = 11;
            this.btnperson.Text = "Choose a pic";
            this.toolTip1.SetToolTip(this.btnperson, "Exit The Application");
            this.btnperson.UseVisualStyleBackColor = false;
            this.btnperson.Click += new System.EventHandler(this.btnperson_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(843, 100);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(221, 225);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // Frms_Example1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1130, 452);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnperson);
            this.Controls.Add(this.exit1);
            this.Controls.Add(this.show1);
            this.Controls.Add(this.find1);
            this.Controls.Add(this.new1);
            this.Controls.Add(this.address2);
            this.Controls.Add(this.address1);
            this.Controls.Add(this.name2);
            this.Controls.Add(this.name1);
            this.Controls.Add(this.id2);
            this.Controls.Add(this.id1);
            this.Controls.Add(this.label1);
            this.Name = "Frms_Example1";
            this.Text = "Frms_Example1";
            this.Load += new System.EventHandler(this.Frms_Example1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label id1;
        private TextBox id2;
        private TextBox name2;
        private Label name1;
        private TextBox address2;
        private Label address1;
        private Button new1;
        private Button find1;
        private Button show1;
        private Button exit1;
        private ToolTip toolTip1;
        private Button btnperson;
        private PictureBox pictureBox1;
    }
}