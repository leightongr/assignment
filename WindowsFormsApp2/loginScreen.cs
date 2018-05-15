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

namespace WindowsFormsApp2
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
            
           // SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-9PLDLI8\DESKTOP;Initial Catalog=login;Integrated Security=True");
           /* SqlDataAdapter sda = new SqlDataAdapter("Select count(*) from Table Where Username = '" + textBox1.Text + "' and Password = '" + textBox2.Text + "'",con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows [0] [0].ToString() == "1")
            {
                SqlDataAdapter sda1 = new SqlDataAdapter("Select Type from Table Where Username = '" + textBox1.Text + "' and Password = '" + textBox2.Text + "'", con);
                DataTable dt1 = new DataTable();
                sda.Fill(dt1);
                if (dt1.Rows[0][0].ToString() == "SERVER")
                {
                    this.Hide();
                    Server ss = new Server();
                    ss.Show();
                    
                }
                if (dt1.Rows[0][0].ToString() == "CLIENT")
                {
                    this.Hide();
                    Client ss = new Client();
                    ss.Show();
                }
            }*/

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
