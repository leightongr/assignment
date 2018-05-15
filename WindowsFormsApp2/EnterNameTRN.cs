using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class EnterNameTRN : Form
    {
        public EnterNameTRN()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void helpinfo_Click(object sender, EventArgs e)
        {

        }

        private void EnterNameTRN_Load(object sender, EventArgs e)
        {
      
        }

        private void Gobutton_Click(object sender, EventArgs e)
        {
            var firstname1 = "leighton";
            var lastname1 = "grant";
            var trn1 = "123456789";


            if (firstname1 == textBox1.Text && lastname1 == textBox2.Text && trn1 == textBox3.Text)
            {
                DliscDatabase OK = new DliscDatabase();
                //login.MdiParent = this;
                OK.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Field Empty or User Info Invalid");
            }
        }
    }
}
