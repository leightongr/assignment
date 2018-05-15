namespace license.winform
{
    partial class Main
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
            this.msMain = new System.Windows.Forms.MenuStrip();
            this.ltsmiFile = new System.Windows.Forms.ToolStripMenuItem();
            this.ltsmiLogout = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ltsmiExit = new System.Windows.Forms.ToolStripMenuItem();
            this.ltsmiLicense = new System.Windows.Forms.ToolStripMenuItem();
            this.ltsmiLicenseList = new System.Windows.Forms.ToolStripMenuItem();
            this.ltsmiLicenseAddNew = new System.Windows.Forms.ToolStripMenuItem();
            this.motorVehicleSystemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.motorVehicleTitleSystemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lostToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.titleDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.msMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // msMain
            // 
            this.msMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.msMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ltsmiFile,
            this.ltsmiLicense,
            this.motorVehicleSystemToolStripMenuItem,
            this.motorVehicleTitleSystemToolStripMenuItem});
            this.msMain.Location = new System.Drawing.Point(0, 0);
            this.msMain.Name = "msMain";
            this.msMain.Size = new System.Drawing.Size(1159, 24);
            this.msMain.TabIndex = 1;
            this.msMain.Text = "Main Menu";
            // 
            // ltsmiFile
            // 
            this.ltsmiFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ltsmiLogout,
            this.toolStripSeparator1,
            this.ltsmiExit});
            this.ltsmiFile.Name = "ltsmiFile";
            this.ltsmiFile.Size = new System.Drawing.Size(37, 20);
            this.ltsmiFile.Text = "File";
            // 
            // ltsmiLogout
            // 
            this.ltsmiLogout.Name = "ltsmiLogout";
            this.ltsmiLogout.Size = new System.Drawing.Size(112, 22);
            this.ltsmiLogout.Text = "Logout";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(109, 6);
            // 
            // ltsmiExit
            // 
            this.ltsmiExit.Name = "ltsmiExit";
            this.ltsmiExit.Size = new System.Drawing.Size(112, 22);
            this.ltsmiExit.Text = "Exit";
            // 
            // ltsmiLicense
            // 
            this.ltsmiLicense.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ltsmiLicenseList,
            this.ltsmiLicenseAddNew});
            this.ltsmiLicense.Name = "ltsmiLicense";
            this.ltsmiLicense.Size = new System.Drawing.Size(58, 20);
            this.ltsmiLicense.Text = "License";
            // 
            // ltsmiLicenseList
            // 
            this.ltsmiLicenseList.Name = "ltsmiLicenseList";
            this.ltsmiLicenseList.Size = new System.Drawing.Size(123, 22);
            this.ltsmiLicenseList.Text = "List";
            this.ltsmiLicenseList.Click += new System.EventHandler(this.ltsmiLicenseList_Click);
            // 
            // ltsmiLicenseAddNew
            // 
            this.ltsmiLicenseAddNew.Name = "ltsmiLicenseAddNew";
            this.ltsmiLicenseAddNew.Size = new System.Drawing.Size(123, 22);
            this.ltsmiLicenseAddNew.Text = "Add New";
            // 
            // motorVehicleSystemToolStripMenuItem
            // 
            this.motorVehicleSystemToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lostToolStripMenuItem,
            this.toolStripMenuItem2});
            this.motorVehicleSystemToolStripMenuItem.Name = "motorVehicleSystemToolStripMenuItem";
            this.motorVehicleSystemToolStripMenuItem.Size = new System.Drawing.Size(133, 20);
            this.motorVehicleSystemToolStripMenuItem.Text = "Motor Vehicle System";
            // 
            // motorVehicleTitleSystemToolStripMenuItem
            // 
            this.motorVehicleTitleSystemToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem3,
            this.titleDetailsToolStripMenuItem});
            this.motorVehicleTitleSystemToolStripMenuItem.Name = "motorVehicleTitleSystemToolStripMenuItem";
            this.motorVehicleTitleSystemToolStripMenuItem.Size = new System.Drawing.Size(159, 20);
            this.motorVehicleTitleSystemToolStripMenuItem.Text = "Motor vehicle Title System";
            // 
            // lostToolStripMenuItem
            // 
            this.lostToolStripMenuItem.Name = "lostToolStripMenuItem";
            this.lostToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.lostToolStripMenuItem.Text = "Lost Regrestration/Fitness";
            this.lostToolStripMenuItem.Click += new System.EventHandler(this.lostToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(210, 22);
            this.toolStripMenuItem2.Text = "Motor Vehicle Details";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(152, 22);
            this.toolStripMenuItem3.Text = "Search...";
            // 
            // titleDetailsToolStripMenuItem
            // 
            this.titleDetailsToolStripMenuItem.Name = "titleDetailsToolStripMenuItem";
            this.titleDetailsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.titleDetailsToolStripMenuItem.Text = "Title Details";
            // 
            // Main
            // 
            this.BackgroundImage = global::license.winform.Properties.Resources.Background;
            this.ClientSize = new System.Drawing.Size(1159, 702);
            this.Controls.Add(this.msMain);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.msMain;
            this.Name = "Main";
            this.Text = "License Managment System";
            this.msMain.ResumeLayout(false);
            this.msMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem systemsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExitlogoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem motorVechSystemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem drivesLiscSystemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem motorVechTitleSystemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lostRegristrationFitnessToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem motorVehicleDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem motorVehicleDatabaseToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.MenuStrip msMain;
        private System.Windows.Forms.ToolStripMenuItem ltsmiFile;
        private System.Windows.Forms.ToolStripMenuItem ltsmiLogout;
        private System.Windows.Forms.ToolStripMenuItem ltsmiExit;
        private System.Windows.Forms.ToolStripMenuItem ltsmiLicense;
        private System.Windows.Forms.ToolStripMenuItem ltsmiLicenseList;
        private System.Windows.Forms.ToolStripMenuItem ltsmiLicenseAddNew;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem motorVehicleSystemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lostToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem motorVehicleTitleSystemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem titleDetailsToolStripMenuItem;
    }
}