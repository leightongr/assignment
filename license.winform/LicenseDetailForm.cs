using license.model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace license.winform
{
    public partial class LicenseDetailForm : Form
    {
        LicenseConnection connection;
        Guid? id;
        public LicenseDetailForm(LicenseConnection connection, Guid? id = null)
        {
            this.connection = connection;
            this.id = id;
            InitializeComponent();
        }

        private void LicenseDetailForm_Load(object sender, EventArgs e)
        {
            License data = null;
            if(id == null)
            {
                data = new License();
            }
            else
            {
                data = connection.Licenses.FirstOrDefault(x => x.Id == this.id);
            }

            this.bindingSource.DataSource = data;


            this.tslCurrentRecordId.Text += id.ToString();
        }

        private void tsbSave_Click(object sender, EventArgs e)
        {
            this.bindingSource.EndEdit();
            var data = this.bindingSource.Current as License;
            if (data.Id == null || data.Id == Guid.Empty)
            {
                data.Id = Guid.NewGuid();
                this.connection.Licenses.Add(this.bindingSource.Current as License); 
            }
            
            this.connection.SaveChanges();
            this.Close();
        }

        private void tsbCancel_Click(object sender, EventArgs e)
        {
            this.bindingSource.CancelEdit();
            this.Close();
        }

        private void bindingSource_CurrentChanged(object sender, EventArgs e)
        {
            var t = DateTime.Now;
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void tsbDelete_Click(object sender, EventArgs e)
        {

           var result = MessageBox.Show("Are you sure you want to delete?", "Deleting", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);

            if(result == DialogResult.Yes)
            {
                var data = this.bindingSource.Current as License;

                this.connection.Licenses.Remove(data);
                this.connection.SaveChanges();
                this.Close();
            }
        }
    }
}
