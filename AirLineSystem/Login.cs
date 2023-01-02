using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using Npgsql;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AirLineSystem
{
    public partial class Login : Form
    {
        NpgsqlConnection connection = new NpgsqlConnection("server = localhost ; port = 5432 ; Database = AirLineDBSystem ; user Id = postgres ; password = Mahi.2003");

        public Login()
        {
            InitializeComponent();
        }
        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {
            Membership m = new Membership();
            m.Show();
            this.Hide();
        }
        private void guna2GradientButton3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            //Checks if the textbox is Empty or not
            if (usernametxt.Text == "" || passwordtxt.Text == "")
            {
                MessageBox.Show("Please enter username and password", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                if (guna2ComboBox1.SelectedIndex > -1)
                {
                    if (guna2ComboBox1.SelectedItem.ToString() == "Admin")
                    {
                        if (usernametxt.Text == "Admin" && passwordtxt.Text == "admin")
                        {

                            Admin ad = new Admin();
                            ad.Show();
                            this.Hide();                          //
                        }
                        else
                        {
                            MessageBox.Show("USER NAME= Admin  ||  PASSWORD : admin", "Miss Id", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        string query = "SELECT * FROM \"users\" WHERE \"username\" = '" + usernametxt.Text + "' and \"password\"= '" + passwordtxt.Text + "'";
                        NpgsqlCommand command = new NpgsqlCommand(query, connection);
                        connection.Open();
                        //NpgsqlDataReader reader = command.ExecuteReader();
                        NpgsqlDataAdapter adapt = new NpgsqlDataAdapter(query, connection);
                        DataTable table = new DataTable();
                        adapt.Fill(table);

                        if (table.Rows.Count > 0)
                        {
                            Form1 fr = new Form1();
                            fr.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Wrong Username or Password", "Wrong Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            connection.Close();


                        }
                    }
                }
                else //IF the user has not choose a role it will show error MessageBox
                {
                    MessageBox.Show("Please Select Role", "Wrong Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }catch(Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }
    }
}
