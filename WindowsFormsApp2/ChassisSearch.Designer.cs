namespace WindowsFormsApp2
{
    partial class ChassisSearch
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChassisSearch));
            this.label1 = new System.Windows.Forms.Label();
            this.ChassisTextBox = new System.Windows.Forms.TextBox();
            this.OK = new System.Windows.Forms.Button();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.Cancel = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(84, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Please Enter Motor Vehicle Chassis Number:";
            // 
            // ChassisTextBox
            // 
            this.ChassisTextBox.Location = new System.Drawing.Point(104, 94);
            this.ChassisTextBox.Name = "ChassisTextBox";
            this.ChassisTextBox.Size = new System.Drawing.Size(178, 20);
            this.ChassisTextBox.TabIndex = 2;
            this.ChassisTextBox.TextChanged += new System.EventHandler(this.ChassisTextBox_TextChanged);
            // 
            // OK
            // 
            this.OK.Location = new System.Drawing.Point(48, 120);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(75, 23);
            this.OK.TabIndex = 3;
            this.OK.Text = "OK";
            this.OK.UseVisualStyleBackColor = true;
            this.OK.Click += new System.EventHandler(this.OK_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(263, 120);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(75, 23);
            this.Cancel.TabIndex = 4;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(166, 43);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(42, 32);
            this.button1.TabIndex = 5;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // ChassisSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(370, 204);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.OK);
            this.Controls.Add(this.ChassisTextBox);
            this.Controls.Add(this.label1);
            this.Name = "ChassisSearch";
            this.Text = "ChassisSearch";
            this.Load += new System.EventHandler(this.ChassisSearch_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ChassisTextBox;
        private System.Windows.Forms.Button OK;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Button button1;
    }
}