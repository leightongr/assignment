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
    public partial class DliscDatabase : Form
    {
        public DliscDatabase()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void DliscDatabase_Load(object sender, EventArgs e)
        {

        }

        private void AddRecord_Click(object sender, EventArgs e)
        {
            DLlogin AddRecord = new DLlogin();
            //login.MdiParent = this;
            AddRecord.Show();
        }

        private void Clear_Click(object sender, EventArgs e)
        {
     
            //var username1 = "admin";
            //var password1 = "admin";

            //if (username1 == textBox1.Text && password1 == textBox2.Text)
            //{
            //    Clear.Visible = true;
            //}
            //else
            //{
            //    Clear.Visible = false;
            //}
        }

        private void DliscDatabase_KeyDown(object sender, KeyEventArgs e)
        {
            if (/*e.Control &&*/ e.KeyCode.ToString() == "F2") 
            MessageBox.Show("Test");
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            panel1.BackColor = Color.FromArgb(69,Color.Gray);
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
          
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            panel2.BackColor = Color.FromArgb(0, Color.Gray);
            panel2.Visible = false;
     
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            panel3.BackColor = Color.FromArgb(0, Color.Gray);
            //panel3.Enabled = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox17_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
