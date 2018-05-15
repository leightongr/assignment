using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using license.model;

namespace license.winform
{
    public partial class loginScreen : Form
    {
        public loginScreen()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void loginScreen_Load(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Password_Click(object sender, EventArgs e)
        {

        }

        private void OK_Click(object sender, EventArgs e)
        {

            LicenseConnection connection = new LicenseConnection();
            var userName = this.txtUserName.Text;
            var password = this.txtPassword.Text;
            var existingUser = connection.Users.
                FirstOrDefault(x => x.UserName == userName &&
                                   x.Password == password);
            if(existingUser == null)
            {
                MessageBox.Show("Invalid username and password! please try again.");
            }
            else
            {
                var mainForm = new Main();
                mainForm.Show();
                this.Hide();

            }


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
