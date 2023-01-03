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
    public partial class splashscreen : Form
    {
        public splashscreen()
        {
            InitializeComponent();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if(guna2CircleProgressBar1.Value == 100)
            {
                timer1.Stop();
                LoginForm l = new LoginForm();
                l.Show();
                this.Hide();
            }
            else
            {
                guna2CircleProgressBar1.Value += 3;
                loadinglabel.Text = "Loading ...."+guna2CircleProgressBar1.Value.ToString() + "%";
            }
        }

    }
}
