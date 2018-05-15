using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace license.winform
{
    public partial class Main : Form
    {
        loginScreen login = new loginScreen();

        public Main()

        {
            InitializeComponent();
        }
        
        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //loginScreen Login = new loginScreen();
            // login.MdiParent = this;
            //login.Show();

        }

        private void ltsmiLicenseList_Click(object sender, EventArgs e)
        {
            var listForm = new LicenseListForm();
            listForm.MdiParent = this;
            listForm.Show();
        }

        private void lostToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var lostFitnRegForm = new LostFitnessandReg();
            lostFitnRegForm.MdiParent = this;
            lostFitnRegForm.Show();
        }
    }
}
