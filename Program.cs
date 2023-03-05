using System;
using System.Collections.Generic;
using System.Data;
//using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace PracticeIgora
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static async Task Main(string[] args)
        {
            /*string conn = "Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog=igora; Integrated Security=True";
            //string conn = "Server=192.168.0.35;Initial Catalog=user16; user=user16; password=65644;Integrated Security=True";
            SqlConnection connection = new SqlConnection(conn); 
            try
                {
                    await connection.OpenAsync();
                }
            catch (SqlException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            finally
                {
                    if (connection.State == ConnectionState.Open)
                    {
                    Console.WriteLine("test");
                    }                        
                }
            
            Console.Read(); ;*/
   
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Auth());
        }
    }
}
