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
    public partial class Membership : Form
    {
        public Membership()
        {
            InitializeComponent();
        }
        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void guna2GradientButton3_Click(object sender, EventArgs e)
        {
            Login lg = new Login();
            lg.Show();
            this.Hide();
        }
    }
}
