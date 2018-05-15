namespace license.winform
{
    partial class LicenseListForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.licenseDataGridView = new System.Windows.Forms.DataGridView();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.licenseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colTrn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPPV = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.licenseDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.licenseBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // licenseDataGridView
            // 
            this.licenseDataGridView.AllowUserToDeleteRows = false;
            this.licenseDataGridView.AllowUserToOrderColumns = true;
            this.licenseDataGridView.AutoGenerateColumns = false;
            this.licenseDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.licenseDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colTrn,
            this.colFullName,
            this.colFirstName,
            this.colLastName,
            this.colType,
            this.colPPV,
            this.colDelete});
            this.licenseDataGridView.DataSource = this.licenseBindingSource;
            this.licenseDataGridView.Location = new System.Drawing.Point(12, 157);
            this.licenseDataGridView.MultiSelect = false;
            this.licenseDataGridView.Name = "licenseDataGridView";
            this.licenseDataGridView.ReadOnly = true;
            this.licenseDataGridView.RowTemplate.Height = 24;
            this.licenseDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.licenseDataGridView.Size = new System.Drawing.Size(1134, 431);
            this.licenseDataGridView.TabIndex = 1;
            this.licenseDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.licenseDataGridView_CellDoubleClick);
            // 
            // btnAddNew
            // 
            this.btnAddNew.Location = new System.Drawing.Point(12, 55);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(194, 45);
            this.btnAddNew.TabIndex = 2;
            this.btnAddNew.Text = "Add &New...";
            this.btnAddNew.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnAddNew.UseVisualStyleBackColor = true;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // licenseBindingSource
            // 
            this.licenseBindingSource.DataSource = typeof(license.model.License);
            // 
            // colTrn
            // 
            this.colTrn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colTrn.DataPropertyName = "Trn";
            this.colTrn.HeaderText = "Trn";
            this.colTrn.Name = "colTrn";
            this.colTrn.ReadOnly = true;
            // 
            // colFullName
            // 
            this.colFullName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colFullName.DataPropertyName = "FullName";
            this.colFullName.HeaderText = "FullName";
            this.colFullName.Name = "colFullName";
            this.colFullName.ReadOnly = true;
            // 
            // colFirstName
            // 
            this.colFirstName.DataPropertyName = "FirstName";
            this.colFirstName.HeaderText = "FirstName";
            this.colFirstName.Name = "colFirstName";
            this.colFirstName.ReadOnly = true;
            // 
            // colLastName
            // 
            this.colLastName.DataPropertyName = "LastName";
            this.colLastName.HeaderText = "LastName";
            this.colLastName.Name = "colLastName";
            this.colLastName.ReadOnly = true;
            // 
            // colType
            // 
            this.colType.DataPropertyName = "Type";
            this.colType.HeaderText = "Type";
            this.colType.Name = "colType";
            this.colType.ReadOnly = true;
            // 
            // colPPV
            // 
            this.colPPV.DataPropertyName = "PPV";
            this.colPPV.HeaderText = "PPV";
            this.colPPV.Name = "colPPV";
            this.colPPV.ReadOnly = true;
            // 
            // colDelete
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.colDelete.DefaultCellStyle = dataGridViewCellStyle1;
            this.colDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.colDelete.HeaderText = "Delete";
            this.colDelete.Name = "colDelete";
            this.colDelete.ReadOnly = true;
            this.colDelete.Text = "Delete";
            this.colDelete.UseColumnTextForButtonValue = true;

            // 
            // LicenseListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::license.winform.Properties.Resources.Background;
            this.ClientSize = new System.Drawing.Size(1146, 593);
            this.Controls.Add(this.btnAddNew);
            this.Controls.Add(this.licenseDataGridView);
            this.Name = "LicenseListForm";
            this.Text = "License List Form";
            this.Load += new System.EventHandler(this.LicenseListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.licenseDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.licenseBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource licenseBindingSource;
        private System.Windows.Forms.DataGridView licenseDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTrn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colType;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colPPV;
        private System.Windows.Forms.DataGridViewButtonColumn colDelete;
    }
}