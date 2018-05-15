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

namespace WindowsFormsApp2
{
    public partial class FirstBody1 : Form
    {
        //loginScreen login = new loginScreen();

        public FirstBody1()

        {
            InitializeComponent();
        }
        
        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //loginScreen Login = new loginScreen();
            // login.MdiParent = this;
            //login.Show();

        }
        //loginScreen login;
        private void FirstBody1_Load(object sender, EventArgs e)
        {
            timer1.Start();


        }

        private void motorVechSystemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var carinfo = new Motorcarinfo();
            carinfo.MdiParent = this;
            carinfo.Show();
        }

        private void loginToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {
            var carinfo = new Motorcarinfo();
            carinfo.MdiParent = this;
            carinfo.Show();
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripProgressBar1_Click(object sender, EventArgs e)
        {

           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            loginScreen loginscreenauto = new loginScreen();
            loginscreenauto.MdiParent = this;
            loginscreenauto.Show();

            timer1.Start();

            timer1.Stop();
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripStatusLabel3_Click(object sender, EventArgs e)
        {

        }

        private void lostRegristrationFitnessToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void motorVehicleDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void motorVehicleDatabaseToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
