
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class IntroScreenCustomer1 : Form
    {
        public IntroScreenCustomer1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void optionAlostMvech_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (MessageBox.Show("Please Note an original and valid Identification(Valid Drivers Liscence, Voters ID or Passport) is needed to collect documents.If collecting on behalf of someone else a letter should be provided giving permission as well as a copy of the owners ID as well as the ORIGINAL ID of the person collecting.", "DISCLAMER!", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.OK)
            {
                Process.Start("cmd");
            }
        }

        private void IntroScreenCustomer1_Load(object sender, EventArgs e)
        {

        }

        private void optionBCollectionofDriversLisc_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}

