using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace AirLineSystem
{
    class DbConnection
    {
        private NpgsqlConnection connection = new NpgsqlConnection("server=localhost; port = 5432; DataBase = AirLineDBSystem; user Id = postgres ; password = Mahi.2003");
        public NpgsqlConnection GetCon()
        {
            return connection;
        }
        public void OpenCon()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
            {

                connection.Open();
            }
        }
        public void CloseCon()
        {
            if (connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
        }
    }
}
