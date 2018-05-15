namespace WindowsFormsApp2
{
    partial class FirstBody1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FirstBody1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.systemsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.motorVechSystemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lostRegristrationFitnessToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.motorVehicleDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.drivesLiscSystemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.motorVechTitleSystemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.motorVehicleDatabaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitlogoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.systemsToolStripMenuItem,
            this.ExitlogoutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(917, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // systemsToolStripMenuItem
            // 
            this.systemsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.motorVechSystemToolStripMenuItem,
            this.drivesLiscSystemToolStripMenuItem,
            this.motorVechTitleSystemToolStripMenuItem});
            this.systemsToolStripMenuItem.Name = "systemsToolStripMenuItem";
            this.systemsToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.systemsToolStripMenuItem.Text = "Systems";
            this.systemsToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // motorVechSystemToolStripMenuItem
            // 
            this.motorVechSystemToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lostRegristrationFitnessToolStripMenuItem,
            this.motorVehicleDetailsToolStripMenuItem});
            this.motorVechSystemToolStripMenuItem.Name = "motorVechSystemToolStripMenuItem";
            this.motorVechSystemToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.motorVechSystemToolStripMenuItem.Text = "Motor Vehicle System";
            this.motorVechSystemToolStripMenuItem.Click += new System.EventHandler(this.motorVechSystemToolStripMenuItem_Click);
            // 
            // lostRegristrationFitnessToolStripMenuItem
            // 
            this.lostRegristrationFitnessToolStripMenuItem.Name = "lostRegristrationFitnessToolStripMenuItem";
            this.lostRegristrationFitnessToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.lostRegristrationFitnessToolStripMenuItem.Text = "Lost Regristration/Fitness";
            // 
            // motorVehicleDetailsToolStripMenuItem
            // 
            this.motorVehicleDetailsToolStripMenuItem.Name = "motorVehicleDetailsToolStripMenuItem";
            this.motorVehicleDetailsToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.motorVehicleDetailsToolStripMenuItem.Text = "Motor Vehicle Details";
            // 
            // drivesLiscSystemToolStripMenuItem
            // 
            this.drivesLiscSystemToolStripMenuItem.Name = "drivesLiscSystemToolStripMenuItem";
            this.drivesLiscSystemToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.drivesLiscSystemToolStripMenuItem.Text = "Drives Lisc System";
            // 
            // motorVechTitleSystemToolStripMenuItem
            // 
            this.motorVechTitleSystemToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.searchToolStripMenuItem,
            this.motorVehicleDatabaseToolStripMenuItem});
            this.motorVechTitleSystemToolStripMenuItem.Name = "motorVechTitleSystemToolStripMenuItem";
            this.motorVechTitleSystemToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.motorVechTitleSystemToolStripMenuItem.Text = "Motor Vehicle Title System";
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.searchToolStripMenuItem.Text = "Search...";
            // 
            // motorVehicleDatabaseToolStripMenuItem
            // 
            this.motorVehicleDatabaseToolStripMenuItem.Name = "motorVehicleDatabaseToolStripMenuItem";
            this.motorVehicleDatabaseToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.motorVehicleDatabaseToolStripMenuItem.Text = "Motor Vehicle Database";
            // 
            // ExitlogoutToolStripMenuItem
            // 
            this.ExitlogoutToolStripMenuItem.Name = "ExitlogoutToolStripMenuItem";
            this.ExitlogoutToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.ExitlogoutToolStripMenuItem.Text = "Exit";
            this.ExitlogoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel3});
            this.statusStrip1.Location = new System.Drawing.Point(0, 412);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(917, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            this.statusStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.statusStrip1_ItemClicked);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripStatusLabel1.Image")));
            this.toolStripStatusLabel1.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(84, 17);
            this.toolStripStatusLabel1.Text = "Title Search";
            this.toolStripStatusLabel1.Click += new System.EventHandler(this.toolStripStatusLabel1_Click);
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel2.Text = "toolStripStatusLabel2";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel3.Text = "toolStripStatusLabel3";
            // 
            // timer1
            // 
            this.timer1.Interval = 3000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FirstBody1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(917, 434);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FirstBody1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FirstBody1";
            this.Load += new System.EventHandler(this.FirstBody1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
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
    }
}