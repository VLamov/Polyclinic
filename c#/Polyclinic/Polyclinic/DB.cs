using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace Polyclinic
{
    class DB
    {
        NpgsqlConnection connection = new NpgsqlConnection(@"Server = localhost; Port = 5432; User ID = postgres; Password = postgres; Database = Polyclinic; Persist Security Info = True");
        public void openConnection()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
                connection.Open();
        }

        public void closeConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
                connection.Close();
        }
        public NpgsqlConnection getConnection()
        {
            return connection;
        }
    }
}
