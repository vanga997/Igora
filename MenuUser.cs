using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticeIgora
{
    public partial class MenuUser : Form
    {
        string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=igora;Integrated Security=True";
        string Login = Auth.login1.ToString();
        string password = Auth.password1.ToString();
        string user_type;
        public MenuUser()
        {
            InitializeComponent();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand($"SELECT Post FROM employee WHERE login='{Login}' AND password='{password}'", conn);
                user_type = (string)cmd.ExecuteScalar();

                if (user_type == "Старший смены")
                {
                    Console.WriteLine(user_type);
                }
                else
                {
                    Console.WriteLine(user_type);
                    all_clients.Hide();
                    //new_client.Hide();
                }

            }
            //string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=igora;Integrated Security=True";
            var get = new Auth();
            /*string Login = Auth.login1.ToString();
            string password = Auth.password1.ToString();*/

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand($"SELECT Name, Surname, LastName FROM Employee WHERE Login='{Login}' AND Password='{password}'", conn))
                {
                    using (var rd = cmd.ExecuteReader())
                    {
                        if (rd.Read())
                        {
                            fio.Text = ($"{rd.GetValue(1).ToString()}" + ' ' + $"{rd.GetValue(0).ToString()}" + ' ' + $"{rd.GetValue(2).ToString()}");
                        }
                    }
                }
                conn.Close();
            }
            /*using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string user_photo;
                using (SqlCommand cmd = new SqlCommand($"SELECT Photo FROM Employee WHERE Login='{Login}' AND Password='{password}'", conn))
                {
                    cmd.ExecuteScalar();
                    user_photo = (string)cmd.ExecuteScalar();

                    Console.WriteLine(user_photo);
                    //pictureBox1.Image = 
                    //user_photo
                    pictureBox1.Image = Image.FromFile(Properties.Resources.logo);
                }

                conn.Close();
            }*/


        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Hide();
            Auth newAuth = new Auth();
            newAuth.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void MenuUser_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "igoraDataSet.employee". При необходимости она может быть перемещена или удалена.
            
            
        }

        private void all_clients_Click(object sender, EventArgs e)
        {
            this.Close();
            Client client = new Client();
            client.Show();
        }

        private void all_requests_Click(object sender, EventArgs e)
        {
            this.Close();
            Request request = new Request();
            request.Show();
        }

        private void new_client_Click(object sender, EventArgs e)
        {

        }
    }
}
