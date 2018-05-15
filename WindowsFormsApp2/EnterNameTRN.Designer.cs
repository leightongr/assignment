namespace WindowsFormsApp2
{
    partial class EnterNameTRN
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EnterNameTRN));
            this.NameTRN = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.FirstName = new System.Windows.Forms.Label();
            this.TRN = new System.Windows.Forms.Label();
            this.LastName = new System.Windows.Forms.Label();
            this.Gobutton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.helpinfo = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // NameTRN
            // 
            this.NameTRN.AutoSize = true;
            this.NameTRN.Location = new System.Drawing.Point(107, 25);
            this.NameTRN.Name = "NameTRN";
            this.NameTRN.Size = new System.Drawing.Size(133, 13);
            this.NameTRN.TabIndex = 1;
            this.NameTRN.Text = "Search by Name and TRN";
            this.NameTRN.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(96, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Please Enter the Following Fields";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // FirstName
            // 
            this.FirstName.AutoSize = true;
            this.FirstName.Location = new System.Drawing.Point(65, 93);
            this.FirstName.Name = "FirstName";
            this.FirstName.Size = new System.Drawing.Size(57, 13);
            this.FirstName.TabIndex = 3;
            this.FirstName.Text = "FirstName:";
            // 
            // TRN
            // 
            this.TRN.AutoSize = true;
            this.TRN.Location = new System.Drawing.Point(65, 150);
            this.TRN.Name = "TRN";
            this.TRN.Size = new System.Drawing.Size(33, 13);
            this.TRN.TabIndex = 4;
            this.TRN.Text = "TRN:";
            // 
            // LastName
            // 
            this.LastName.AutoSize = true;
            this.LastName.Location = new System.Drawing.Point(65, 121);
            this.LastName.Name = "LastName";
            this.LastName.Size = new System.Drawing.Size(58, 13);
            this.LastName.TabIndex = 5;
            this.LastName.Text = "LastName:";
            // 
            // Gobutton
            // 
            this.Gobutton.Image = ((System.Drawing.Image)(resources.GetObject("Gobutton.Image")));
            this.Gobutton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Gobutton.Location = new System.Drawing.Point(164, 192);
            this.Gobutton.Name = "Gobutton";
            this.Gobutton.Size = new System.Drawing.Size(49, 38);
            this.Gobutton.TabIndex = 7;
            this.Gobutton.UseVisualStyleBackColor = true;
            this.Gobutton.Click += new System.EventHandler(this.Gobutton_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(140, 93);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 8;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(140, 119);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 9;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(140, 147);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 10;
            // 
            // helpinfo
            // 
            this.helpinfo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("helpinfo.BackgroundImage")));
            this.helpinfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.helpinfo.Location = new System.Drawing.Point(246, 145);
            this.helpinfo.Name = "helpinfo";
            this.helpinfo.Size = new System.Drawing.Size(29, 22);
            this.helpinfo.TabIndex = 11;
            this.helpinfo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.helpinfo.UseVisualStyleBackColor = true;
            this.helpinfo.Click += new System.EventHandler(this.helpinfo_Click);
            // 
            // EnterNameTRN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(349, 303);
            this.Controls.Add(this.helpinfo);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Gobutton);
            this.Controls.Add(this.LastName);
            this.Controls.Add(this.TRN);
            this.Controls.Add(this.FirstName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NameTRN);
            this.Name = "EnterNameTRN";
            this.Text = "EnterNameTRN";
            this.Load += new System.EventHandler(this.EnterNameTRN_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NameTRN;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label FirstName;
        private System.Windows.Forms.Label TRN;
        private System.Windows.Forms.Label LastName;
        private System.Windows.Forms.Button Gobutton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button helpinfo;
        private System.Windows.Forms.Timer timer1;
    }
}