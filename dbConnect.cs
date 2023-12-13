using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental
{
    class dbConnect
    {
        private SqlConnection connection = new SqlConnection(@"Data Source = X280\SQLEXPRESS; Initial Catalog = CarRentalCW; Integrated Security = True");

        public SqlConnection connect()
        {
            return connection;
        }

        public void open()
        {
            if(connection.State == System.Data.ConnectionState.Closed)
                connection.Open();
        }

        public void close()
        {
            if(connection.State == System.Data.ConnectionState.Open)
                connection.Close();
        }
    }
}
