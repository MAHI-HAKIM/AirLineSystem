using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AirLineSystem
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void manageButtons(Button current)
        {
            //SidePanel.Height = current.Height;
            //SidePanel.Top = current.Top;
            //current.BackColor = Color.FromArgb(78, 86, 105);
            //foreach (Control c in guna2CustomGradientPanel1.Controls.OfType<Button>().ToList())
            {
                //if (c != current)
                //    c.BackColor = Color.FromArgb(56, 62, 76);
            }
        }
        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2GradientButton3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            Login lg = new Login();
            lg.Show();
            this.Hide();
        }

        private void homeButton_Click_1(object sender, EventArgs e)
        {
            manageButtons(homeButton);
        }

        private void tripsButton_Click_1(object sender, EventArgs e)
        {
            TripPannel tr = new TripPannel();
            tr.Show();
            this.Hide();
        }

        private void routesButton_Click_1(object sender, EventArgs e)
        {
            manageButtons(routesButton);
        }

        private void busButton_Click_1(object sender, EventArgs e)
        {
            manageButtons(busButton);
        }

        private void driversButton_Click_1(object sender, EventArgs e)
        {
            manageButtons(driversButton);
        }

        private void discountsButton_Click_1(object sender, EventArgs e)
        {

            manageButtons(discountsButton);
        }
    }
}
