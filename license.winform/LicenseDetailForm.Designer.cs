namespace license.winform
{
    partial class LicenseDetailForm
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
            this.lblTrn = new System.Windows.Forms.Label();
            this.txtTrn = new System.Windows.Forms.TextBox();
            this.bindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblFirstName = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chkPPV = new System.Windows.Forms.CheckBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblType = new System.Windows.Forms.Label();
            this.lblPPV = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtLaden = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtUnLaden = new System.Windows.Forms.TextBox();
            this.txtCCRatings = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dtExpireDate = new System.Windows.Forms.DateTimePicker();
            this.dtDateReceived = new System.Windows.Forms.DateTimePicker();
            this.dtDateCollected = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.lblDateCollected = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtDepot = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbSave = new System.Windows.Forms.ToolStripButton();
            this.tsbCancel = new System.Windows.Forms.ToolStripButton();
            this.tsbDelete = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tslCurrentRecordId = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTrn
            // 
            this.lblTrn.AutoSize = true;
            this.lblTrn.Location = new System.Drawing.Point(7, 41);
            this.lblTrn.Name = "lblTrn";
            this.lblTrn.Size = new System.Drawing.Size(45, 17);
            this.lblTrn.TabIndex = 0;
            this.lblTrn.Text = "TRN :";
            // 
            // txtTrn
            // 
            this.txtTrn.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource, "Trn", true));
            this.txtTrn.Location = new System.Drawing.Point(126, 41);
            this.txtTrn.Name = "txtTrn";
            this.txtTrn.Size = new System.Drawing.Size(219, 22);
            this.txtTrn.TabIndex = 1;
            // 
            // bindingSource
            // 
            this.bindingSource.DataSource = typeof(license.model.License);
            this.bindingSource.CurrentChanged += new System.EventHandler(this.bindingSource_CurrentChanged);
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(7, 69);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(84, 17);
            this.lblFirstName.TabIndex = 0;
            this.lblFirstName.Text = "First Name: ";
            // 
            // txtFirstName
            // 
            this.txtFirstName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource, "FirstName", true));
            this.txtFirstName.Location = new System.Drawing.Point(126, 69);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(219, 22);
            this.txtFirstName.TabIndex = 1;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(7, 97);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(80, 17);
            this.lblLastName.TabIndex = 0;
            this.lblLastName.Text = "Last Name:";
            // 
            // textBox2
            // 
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource, "LastName", true));
            this.textBox2.Location = new System.Drawing.Point(126, 97);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(219, 22);
            this.textBox2.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Phone Number: ";
            // 
            // textBox5
            // 
            this.textBox5.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource, "PhoneNumber", true));
            this.textBox5.Location = new System.Drawing.Point(126, 125);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(219, 22);
            this.textBox5.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.txtTrn);
            this.groupBox1.Controls.Add(this.lblTrn);
            this.groupBox1.Controls.Add(this.lblFirstName);
            this.groupBox1.Controls.Add(this.txtFirstName);
            this.groupBox1.Controls.Add(this.lblLastName);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textBox5);
            this.groupBox1.Location = new System.Drawing.Point(12, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(351, 172);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Driver Information";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.chkPPV);
            this.groupBox2.Controls.Add(this.comboBox1);
            this.groupBox2.Controls.Add(this.lblType);
            this.groupBox2.Controls.Add(this.lblPPV);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtLaden);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtUnLaden);
            this.groupBox2.Controls.Add(this.txtCCRatings);
            this.groupBox2.Location = new System.Drawing.Point(369, 40);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(345, 186);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Car Information";
            // 
            // chkPPV
            // 
            this.chkPPV.AutoSize = true;
            this.chkPPV.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.bindingSource, "PPV", true));
            this.chkPPV.Location = new System.Drawing.Point(95, 73);
            this.chkPPV.Name = "chkPPV";
            this.chkPPV.Size = new System.Drawing.Size(18, 17);
            this.chkPPV.TabIndex = 3;
            this.chkPPV.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.bindingSource, "Type", true));
            this.comboBox1.DisplayMember = "Type";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Private",
            "General"});
            this.comboBox1.Location = new System.Drawing.Point(95, 41);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(156, 24);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.ValueMember = "Type";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(7, 41);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(48, 17);
            this.lblType.TabIndex = 0;
            this.lblType.Text = "Type: ";
            // 
            // lblPPV
            // 
            this.lblPPV.AutoSize = true;
            this.lblPPV.Location = new System.Drawing.Point(7, 72);
            this.lblPPV.Name = "lblPPV";
            this.lblPPV.Size = new System.Drawing.Size(39, 17);
            this.lblPPV.TabIndex = 0;
            this.lblPPV.Text = "PPV:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 97);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Laden:";
            // 
            // txtLaden
            // 
            this.txtLaden.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource, "Laden", true));
            this.txtLaden.Location = new System.Drawing.Point(95, 97);
            this.txtLaden.Name = "txtLaden";
            this.txtLaden.Size = new System.Drawing.Size(156, 22);
            this.txtLaden.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "UnLaden:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 153);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 17);
            this.label7.TabIndex = 0;
            this.label7.Text = "CC Ratings:";
            // 
            // txtUnLaden
            // 
            this.txtUnLaden.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource, "Unladen", true));
            this.txtUnLaden.Location = new System.Drawing.Point(95, 122);
            this.txtUnLaden.Name = "txtUnLaden";
            this.txtUnLaden.Size = new System.Drawing.Size(156, 22);
            this.txtUnLaden.TabIndex = 1;
            // 
            // txtCCRatings
            // 
            this.txtCCRatings.Location = new System.Drawing.Point(95, 153);
            this.txtCCRatings.Name = "txtCCRatings";
            this.txtCCRatings.Size = new System.Drawing.Size(156, 22);
            this.txtCCRatings.TabIndex = 1;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.dtExpireDate);
            this.groupBox3.Controls.Add(this.dtDateReceived);
            this.groupBox3.Controls.Add(this.dtDateCollected);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.lblDateCollected);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.txtDepot);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox3.Location = new System.Drawing.Point(13, 216);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(475, 182);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "License Information";
            // 
            // dtExpireDate
            // 
            this.dtExpireDate.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bindingSource, "ExpireDate", true));
            this.dtExpireDate.Location = new System.Drawing.Point(123, 114);
            this.dtExpireDate.Name = "dtExpireDate";
            this.dtExpireDate.Size = new System.Drawing.Size(287, 22);
            this.dtExpireDate.TabIndex = 8;
            // 
            // dtDateReceived
            // 
            this.dtDateReceived.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bindingSource, "DateReceived", true));
            this.dtDateReceived.Location = new System.Drawing.Point(123, 86);
            this.dtDateReceived.Name = "dtDateReceived";
            this.dtDateReceived.Size = new System.Drawing.Size(287, 22);
            this.dtDateReceived.TabIndex = 9;
            // 
            // dtDateCollected
            // 
            this.dtDateCollected.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bindingSource, "DateCollected", true));
            this.dtDateCollected.Location = new System.Drawing.Point(124, 58);
            this.dtDateCollected.Name = "dtDateCollected";
            this.dtDateCollected.Size = new System.Drawing.Size(287, 22);
            this.dtDateCollected.TabIndex = 10;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 113);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(85, 17);
            this.label11.TabIndex = 3;
            this.label11.Text = "Expire Date:";
            // 
            // lblDateCollected
            // 
            this.lblDateCollected.AutoSize = true;
            this.lblDateCollected.Location = new System.Drawing.Point(6, 57);
            this.lblDateCollected.Name = "lblDateCollected";
            this.lblDateCollected.Size = new System.Drawing.Size(104, 17);
            this.lblDateCollected.TabIndex = 4;
            this.lblDateCollected.Text = "Date Collected:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 85);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(105, 17);
            this.label9.TabIndex = 5;
            this.label9.Text = "Date Received:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtDepot
            // 
            this.txtDepot.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource, "Depot", true));
            this.txtDepot.Location = new System.Drawing.Point(125, 29);
            this.txtDepot.Name = "txtDepot";
            this.txtDepot.Size = new System.Drawing.Size(285, 22);
            this.txtDepot.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 29);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 17);
            this.label8.TabIndex = 6;
            this.label8.Text = "Depot: ";
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbSave,
            this.tsbCancel,
            this.tsbDelete});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(738, 27);
            this.toolStrip1.TabIndex = 5;
            this.toolStrip1.Text = "tsAddNew";
            // 
            // tsbSave
            // 
            this.tsbSave.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsbSave.Image = global::license.winform.Properties.Resources._2123959___add_app_essential_ui;
            this.tsbSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSave.Name = "tsbSave";
            this.tsbSave.Size = new System.Drawing.Size(68, 24);
            this.tsbSave.Text = " &Save";
            this.tsbSave.Click += new System.EventHandler(this.tsbSave_Click);
            // 
            // tsbCancel
            // 
            this.tsbCancel.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsbCancel.Image = global::license.winform.Properties.Resources._2123910___app_essential_power_ui;
            this.tsbCancel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCancel.Name = "tsbCancel";
            this.tsbCancel.Size = new System.Drawing.Size(77, 24);
            this.tsbCancel.Text = "&Cancel";
            this.tsbCancel.Click += new System.EventHandler(this.tsbCancel_Click);
            // 
            // tsbDelete
            // 
            this.tsbDelete.Image = global::license.winform.Properties.Resources._2123880___app_cancel_essential_ui;
            this.tsbDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDelete.Name = "tsbDelete";
            this.tsbDelete.Size = new System.Drawing.Size(86, 24);
            this.tsbDelete.Text = "Delete...";
            this.tsbDelete.Click += new System.EventHandler(this.tsbDelete_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslCurrentRecordId});
            this.statusStrip1.Location = new System.Drawing.Point(0, 569);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(738, 25);
            this.statusStrip1.TabIndex = 6;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tslCurrentRecordId
            // 
            this.tslCurrentRecordId.Name = "tslCurrentRecordId";
            this.tslCurrentRecordId.Size = new System.Drawing.Size(119, 20);
            this.tslCurrentRecordId.Text = "Current Record : ";
            // 
            // LicenseDetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::license.winform.Properties.Resources.Background;
            this.ClientSize = new System.Drawing.Size(738, 594);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "LicenseDetailForm";
            this.Text = "License Detail Form";
            this.Load += new System.EventHandler(this.LicenseDetailForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTrn;
        private System.Windows.Forms.TextBox txtTrn;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblPPV;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtLaden;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCCRatings;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DateTimePicker dtExpireDate;
        private System.Windows.Forms.DateTimePicker dtDateReceived;
        private System.Windows.Forms.DateTimePicker dtDateCollected;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblDateCollected;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtDepot;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.BindingSource bindingSource;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.CheckBox chkPPV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUnLaden;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbSave;
        private System.Windows.Forms.ToolStripButton tsbCancel;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tslCurrentRecordId;
        private System.Windows.Forms.ToolStripButton tsbDelete;
    }
}