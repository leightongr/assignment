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
    public partial class DLlogin : Form
    {
        public DLlogin()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var dlusername1 = "admin";
            var dlpassword1 = "admin";

            if (dlusername1 == textBox1.Text && dlpassword1 == textBox2.Text)
            {

                DliscDatabase button1 = new DliscDatabase();
                //login.MdiParent = this;
                button1.Show();
                
                this.Hide();
                
                    

                

            }
            else
            {
                MessageBox.Show("User Name or Password is Invalid");
            }
        }

        private void DLlogin_Load(object sender, EventArgs e)
        {

        }
    }
}
