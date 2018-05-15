namespace WindowsFormsApp2
{
    partial class IntroScreenCustomer1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IntroScreenCustomer1));
            this.label1 = new System.Windows.Forms.Label();
            this.optionAlostMvech = new System.Windows.Forms.LinkLabel();
            this.optionBCollectionofDriversLisc = new System.Windows.Forms.LinkLabel();
            this.linkLabel3 = new System.Windows.Forms.LinkLabel();
            this.linkLabel4 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 20F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(178, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(623, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Good Day.What Transaction Would you like to Do Today?";
            // 
            // optionAlostMvech
            // 
            this.optionAlostMvech.AutoSize = true;
            this.optionAlostMvech.Location = new System.Drawing.Point(381, 121);
            this.optionAlostMvech.Name = "optionAlostMvech";
            this.optionAlostMvech.Size = new System.Drawing.Size(390, 13);
            this.optionAlostMvech.TabIndex = 1;
            this.optionAlostMvech.TabStop = true;
            this.optionAlostMvech.Text = "A. Lost Motor Vechile Documentation (Drivers Liscence Fitness and Regristration)";
            this.optionAlostMvech.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.optionAlostMvech_LinkClicked);
            // 
            // optionBCollectionofDriversLisc
            // 
            this.optionBCollectionofDriversLisc.AutoSize = true;
            this.optionBCollectionofDriversLisc.Location = new System.Drawing.Point(381, 148);
            this.optionBCollectionofDriversLisc.Name = "optionBCollectionofDriversLisc";
            this.optionBCollectionofDriversLisc.Size = new System.Drawing.Size(162, 13);
            this.optionBCollectionofDriversLisc.TabIndex = 2;
            this.optionBCollectionofDriversLisc.TabStop = true;
            this.optionBCollectionofDriversLisc.Text = "B. Collection Of Drivers Liscence";
            this.optionBCollectionofDriversLisc.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.optionBCollectionofDriversLisc_LinkClicked);
            // 
            // linkLabel3
            // 
            this.linkLabel3.AutoSize = true;
            this.linkLabel3.Location = new System.Drawing.Point(381, 175);
            this.linkLabel3.Name = "linkLabel3";
            this.linkLabel3.Size = new System.Drawing.Size(140, 13);
            this.linkLabel3.TabIndex = 3;
            this.linkLabel3.TabStop = true;
            this.linkLabel3.Text = "C. Motor Vehicle Information";
            // 
            // linkLabel4
            // 
            this.linkLabel4.AutoSize = true;
            this.linkLabel4.Location = new System.Drawing.Point(381, 199);
            this.linkLabel4.Name = "linkLabel4";
            this.linkLabel4.Size = new System.Drawing.Size(223, 13);
            this.linkLabel4.TabIndex = 4;
            this.linkLabel4.TabStop = true;
            this.linkLabel4.Text = "D. Checking on/Collecting Motor Vehicle Title";
            // 
            // IntroScreenCustomer1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(896, 484);
            this.Controls.Add(this.linkLabel4);
            this.Controls.Add(this.linkLabel3);
            this.Controls.Add(this.optionBCollectionofDriversLisc);
            this.Controls.Add(this.optionAlostMvech);
            this.Controls.Add(this.label1);
            this.Name = "IntroScreenCustomer1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.IntroScreenCustomer1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel optionAlostMvech;
        private System.Windows.Forms.LinkLabel optionBCollectionofDriversLisc;
        private System.Windows.Forms.LinkLabel linkLabel3;
        private System.Windows.Forms.LinkLabel linkLabel4;
    }
}