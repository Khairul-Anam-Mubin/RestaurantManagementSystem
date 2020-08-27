using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace RestaurantManagement
{
    
    class DB
    {
        // Setting up database connection......
        MySqlConnection connection = new MySqlConnection("server=localhost;port=3306;username=root;password=;database=restaurant");

        // opening a connection..
        public void openConnection()
        {
            if(connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }

        }
        // closing connection...
        public void closeConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
        }
        // To returning a function..
        public MySqlConnection getConnection()
        {
            return connection;
        }
    }
}
