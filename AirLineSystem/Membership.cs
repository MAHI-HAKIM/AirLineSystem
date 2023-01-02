using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using Npgsql;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AirLineSystem
{
    public partial class Membership : Form
    {
        NpgsqlConnection connection = new NpgsqlConnection("server = localhost ; port = 5432 ; Database = AirLineDBSystem ; user Id = postgres ; password = Mahi.2003");
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

        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {
            try
            {
            if (userNAMEtxt.Text == "" || emailtxt.Text == "" || passWORDtxt.Text == "")
                {
                    MessageBox.Show("Missing Information", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                string query = "INSERT INTO \"users\" ( \"username\", \"password\", \"email\") " +
               "VALUES('" + userNAMEtxt.Text + "', '" + passWORDtxt.Text + "', '" + emailtxt.Text + "')";
                connection.Open();
                NpgsqlCommand command = new NpgsqlCommand(query, connection);
                command.ExecuteNonQuery();
                userNAMEtxt.Text = passWORDtxt.Text = emailtxt.Text = "";
                 MessageBox.Show("Your Account has been Successfully Created!", "Registration Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch  // Catchs error if the user miss information or if the user unput invalid information
            {
                MessageBox.Show("Seems like there is a missing information or wrong input", "Unable to add", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                connection.Close();
            }
        }
    
    }
}
