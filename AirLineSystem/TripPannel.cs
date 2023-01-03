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

    }
}
