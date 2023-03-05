using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.Sql;
using Microsoft.Data.SqlClient;

namespace PracticeIgora
{
    class Database
    {
        SqlConnection connection = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=igora;Integrated Security=True");

        public void openConnection()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();
                Console.WriteLine("Connection open!");
            }
            
        }

        public void closeConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
            {

                connection.Close();
                Console.WriteLine("Connection close!");
            }
        }

        public SqlConnection getConnection()
        {
            return connection;
        } 

    }

}
