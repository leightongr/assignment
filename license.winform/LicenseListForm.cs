using license.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace license.winform
{
    public partial class LicenseListForm : Form
    {
        LicenseConnection connection;

        public LicenseListForm()
        {
            this.connection = new LicenseConnection();
            InitializeComponent();
        }

        private void LicenseListForm_Load(object sender, EventArgs e)
        {
            this.licenseBindingSource.DataSource = this.connection.Licenses.ToList();
        }

        private void licenseDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var id =  (this.licenseBindingSource.Current as model.License).Id;
            LicenseDetailForm licenseDetailForm = new LicenseDetailForm(this.connection,id);

            licenseDetailForm.MdiParent = this.MdiParent;
            licenseDetailForm.Show();
            licenseDetailForm.FormClosed += LicenseDetailForm_FormClosed;
        }

        private void LicenseDetailForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.licenseBindingSource.DataSource = this.connection.Licenses.ToList();
            this.licenseBindingSource.ResetBindings(false);
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            LicenseDetailForm licenseDetailForm = new LicenseDetailForm(this.connection);

            licenseDetailForm.MdiParent = this.MdiParent;
            licenseDetailForm.Show();
            licenseDetailForm.FormClosed += LicenseDetailForm_FormClosed;
        }
    }
}
