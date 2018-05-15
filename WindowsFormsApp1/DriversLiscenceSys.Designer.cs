namespace WindowsFormsApp2
{
    partial class DriversLiscenceSys
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DriversLiscenceSys));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listOfDriversLiscenceProcessedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userAccessDetailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.disableUsersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adminToolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchByDateAddedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.reportToolStripMenuItem,
            this.adminToolsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(596, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            this.fileToolStripMenuItem.Click += new System.EventHandler(this.fileToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // reportToolStripMenuItem
            // 
            this.reportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listOfDriversLiscenceProcessedToolStripMenuItem,
            this.userAccessDetailToolStripMenuItem,
            this.disableUsersToolStripMenuItem});
            this.reportToolStripMenuItem.Name = "reportToolStripMenuItem";
            this.reportToolStripMenuItem.Size = new System.Drawing.Size(108, 20);
            this.reportToolStripMenuItem.Text = "Admin Privilages";
            this.reportToolStripMenuItem.Click += new System.EventHandler(this.reportToolStripMenuItem_Click);
            // 
            // listOfDriversLiscenceProcessedToolStripMenuItem
            // 
            this.listOfDriversLiscenceProcessedToolStripMenuItem.Name = "listOfDriversLiscenceProcessedToolStripMenuItem";
            this.listOfDriversLiscenceProcessedToolStripMenuItem.Size = new System.Drawing.Size(304, 22);
            this.listOfDriversLiscenceProcessedToolStripMenuItem.Text = "List of Drivers Liscence Processed by User(s)";
            // 
            // userAccessDetailToolStripMenuItem
            // 
            this.userAccessDetailToolStripMenuItem.Name = "userAccessDetailToolStripMenuItem";
            this.userAccessDetailToolStripMenuItem.Size = new System.Drawing.Size(304, 22);
            this.userAccessDetailToolStripMenuItem.Text = "User Access Detail";
            // 
            // disableUsersToolStripMenuItem
            // 
            this.disableUsersToolStripMenuItem.Name = "disableUsersToolStripMenuItem";
            this.disableUsersToolStripMenuItem.Size = new System.Drawing.Size(304, 22);
            this.disableUsersToolStripMenuItem.Text = "Disable User(s)";
            // 
            // adminToolsToolStripMenuItem
            // 
            this.adminToolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.searchByDateAddedToolStripMenuItem});
            this.adminToolsToolStripMenuItem.Name = "adminToolsToolStripMenuItem";
            this.adminToolsToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.adminToolsToolStripMenuItem.Text = "Search";
            this.adminToolsToolStripMenuItem.Click += new System.EventHandler(this.adminToolsToolStripMenuItem_Click);
            // 
            // searchByDateAddedToolStripMenuItem
            // 
            this.searchByDateAddedToolStripMenuItem.Name = "searchByDateAddedToolStripMenuItem";
            this.searchByDateAddedToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.searchByDateAddedToolStripMenuItem.Text = "Search By Date Added";
            // 
            // DriversLiscenceSys
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(596, 357);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "DriversLiscenceSys";
            this.Text = "DriversLiscenceSys";
            this.Load += new System.EventHandler(this.DriversLiscenceSys_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listOfDriversLiscenceProcessedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userAccessDetailToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem disableUsersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adminToolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchByDateAddedToolStripMenuItem;
    }
}