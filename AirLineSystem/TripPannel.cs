using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

using Npgsql;

namespace AirLineSystem
{
    public partial class TripPannel : Form
    {
        NpgsqlConnection connection = new NpgsqlConnection("server = localhost ; port = 5432 ; Database = AirLineDBSystem ; user Id = postgres ; password = Mahi.2003");

        public TripPannel()
        {
            InitializeComponent();
        }

        private void guna2GradientButton3_Click(object sender, EventArgs e)
        {
            Application.Exit()
;        }

        private void AddTripBtn_Click(object sender, EventArgs e)
        {
            if (fromComboBox.SelectedIndex == -1 || toComboBox.SelectedIndex == -1 || assignComboBox.SelectedIndex == -1 || priceBox.Text == "")
            {
                MessageBox.Show("Please fill in all boxes", "Adding Trip Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                string query;
                string departureTime = dateTimePicker1.Value.ToString("hh:mm", CultureInfo.InvariantCulture);
                string arrivalTime = dateTimePicker2.Value.ToString("hh:mm", CultureInfo.InvariantCulture);

                TimeSpan span = TimeSpan.Parse(arrivalTime) - TimeSpan.Parse(departureTime);

                string duration = span.ToString();

                int pilotID = Convert.ToInt32(assignComboBox.GetItemText(assignComboBox.SelectedItem));

                int routeID = GetID("SELECT \"routeID\" FROM \"route\" WHERE \"departure\" = '"
                    + fromComboBox.GetItemText(fromComboBox.SelectedItem)
                    + "' AND \"destination\" = '" + toComboBox.GetItemText(toComboBox.SelectedItem) + "';");
                if (routeID == 0)
                {
                    MessageBox.Show("No such route was found. Please add the route first", "Adding Trip Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                int aircraftID = GetID("SELECT \"aircraft\".\"aircraftID\" FROM \"aircraft\" " +
                    "INNER JOIN \"pilot\" ON \"aircraft\".\"aircraftID\" = \"pilot\".\"aircraftID\"" +
                    " WHERE \"pilot\".\"pilotrID\" = '" + assignComboBox.GetItemText(assignComboBox.SelectedItem) + "';");

                query = "INSERT INTO \"flight\" ( \"departureTime\", \"arrivalTime\", \"travelDuration\", \"aircraftID\", \"pilotID\", \"routeID\") " +
                    "VALUES('" + departureTime + "', '" + arrivalTime + "', '" + duration
                    + "', " + aircraftID + ", " + pilotID + ", " + routeID + ")";

                connection.Open();
                NpgsqlCommand command = new NpgsqlCommand(query, connection);
                command.ExecuteNonQuery();
                connection.Close();

                int flightID = GetID("SELECT \"flightID\" FROM \"flight\" WHERE \"pilotID\" = " + pilotID + ";");

                query = "INSERT INTO \"ticket\" (\"price\", \"flightID\")" +
                    "VALUES(" + Convert.ToInt32(priceBox.Text) + ", " + flightID + "); ";

                connection.Open();
                command = new NpgsqlCommand(query, connection);
                command.ExecuteNonQuery();

                MessageBox.Show("Flight has been added!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                query = "SELECT \"flightID\",\"departure\", \"destination\", \"travelDuration\",\"pilotID\", \"aircrafID\", \"price\" FROM \"flight\"" +
                            "INNER JOIN \"ticket\" ON \"ticket\".\"flightID\" = \"flight\".\"flightID\"" +
                            "INNER JOIN \"route\" ON \"route\".\"routeID\" = \"flight\".\"routeID\";";

                FillTable(query, dgvTrip);
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
            finally { connection.Close(); }

        }
        private void FillTable(string query, DataGridView dv)
        {
            try
            {
                NpgsqlDataAdapter dadapter = new NpgsqlDataAdapter();
                dadapter.SelectCommand = new NpgsqlCommand(query, connection);
                DataTable table = new DataTable();
                dadapter.Fill(table);
                dv.DataSource = table;
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message);
            }
        }
        private void FillComboBox(string query, ComboBox combo)
        {
            try
            {
                connection.Open();
                NpgsqlCommand command = new NpgsqlCommand(query, connection);
                NpgsqlDataReader reader = command.ExecuteReader();

                combo.Items.Clear();
                while (reader.Read())
                {
                    combo.Items.Add(reader[0].ToString());
                }
                reader.Close();
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message);
            }
            finally { connection.Close(); }
        }

        int GetID(string query)
        {
            int id = 0;
            try
            {
                connection.Open();
                NpgsqlCommand command = new NpgsqlCommand(query, connection);
                NpgsqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    id = Convert.ToInt32(reader[0].ToString());
                }
                reader.Close();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
            finally { connection.Close(); }
            return id;
        }

        private void fromComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(connection.State == System.Data.ConnectionState.Open)
            {
                MessageBox.Show("YEah");
            }
            FillComboBox("SELECT DISTINCT \"name\" FROM \"country\" " +
            "WHERE \"name\" != '" + fromComboBox.GetItemText(fromComboBox.SelectedItem) + "'ORDER BY \"name\" ASC", toComboBox);
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            Admin ad = new Admin();
            ad.Show();
            this.Hide();
        }
    }
}
