using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IdentityModel.Protocols.WSTrust;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticeIgora
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            //DateTime dt = new DateTime();
            
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "igoraDataSet.client". При необходимости она может быть перемещена или удалена.
            //this.clientTableAdapter.Fill(this.igoraDataSet.client);
            string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=igora;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (var cmd = new SqlCommand("SELECT Name, Surname, Lastname FROM employee WHERE Post='Администратор'", connection))
                {
                    using (var rd = cmd.ExecuteReader())
                    {
                        if (rd.Read())
                        {
                            adm_label.Text = ($"{rd.GetValue(1).ToString()}" + ' ' + $"{rd.GetValue(0).ToString()}" + ' ' + $"{rd.GetValue(2).ToString()}");
                        }
                    }
                }
                connection.Close();
            }


        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            DateTime exit = DateTime.Now;
            string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=igora;Integrated Security=True";
            exit.ToString();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand($"INSERT INTO history(DateOfEnter, DateOfExit, Block, Employee) VALUES ('?', '{exit}', '?', 103)", conn);
                cmd.ExecuteScalar();
                conn.Close();

                this.Hide();
                Auth newAuth = new Auth();
                newAuth.Show();
            } 
        }

        private void btn_client_Click(object sender, EventArgs e)
        {
            this.Hide();
            Client newClient = new Client();
            newClient.Show();
        }

        private void btn_employee_Click(object sender, EventArgs e)
        {
            this.Hide();
            Employee newEmployee = new Employee();
            newEmployee.Show();
        }

        private void btn_request_Click(object sender, EventArgs e)
        {
            this.Hide();
            Request newRequest = new Request();
            newRequest.Show();
        }

        private void btn_service_Click(object sender, EventArgs e)
        {
            this.Hide();
            Service newService = new Service();
            newService.Show();
        }

        private void btn_history_Click(object sender, EventArgs e)
        {
            this.Hide();
            History newHistory = new History();
            newHistory.Show();
        }

        private void adm_label_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
