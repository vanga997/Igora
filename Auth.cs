using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.Sql;
using Microsoft.Data.SqlClient;
using Microsoft.Identity.Client;

namespace PracticeIgora
{
    public partial class Auth : Form
    {
        //Database database = new Database();
        static public string login1;
        static public string password1;

        public Auth()
        {
            InitializeComponent();            
            /*string login = log.Text;
            string password = pas.Text;*/
        }

        private void Auth_Load(object sender, EventArgs e)
        {
            pas.PasswordChar = '*';
        }

        private void btn_enter_Click(object sender, EventArgs e)
        {
            string user_type;
            object id_employee;

            //database.openConnection();
            using (SqlConnection conn = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=igora;Integrated Security=True"))
            {
                DateTime entry = DateTime.Now;
                entry.ToString();

                login1 = log.Text;
                password1 = pas.Text;
                //string login1 = log.Text;
                //string password1 = pas.Text;
                conn.Open();

                SqlCommand cmd2 = new SqlCommand($"SELECT ID_Employee FROM Employee WHERE login='{login1}' AND password='{password1}'", conn);
                id_employee = (int)cmd2.ExecuteScalar();

                SqlCommand cmd = new SqlCommand($"SELECT Post FROM employee WHERE login='{login1}' AND password='{password1}'", conn);
                user_type = (string)cmd.ExecuteScalar();

                if (user_type == "Администратор")
                {
                    this.Hide();
                    Menu menu = new Menu();
                    SqlCommand cmd1 = new SqlCommand($"INSERT INTO history(DateOfEnter, DateOfExit, Block, Employee) VALUES ('{entry}', '?', '?', '{id_employee}')", conn);
                    cmd1.ExecuteScalar();

                    menu.Show();
                    //conn.Close();
                }
                else if (user_type == "Старший смены")
                {
                    this.Hide();
                    MenuUser menuUser = new MenuUser();
                    //this.Close();
                    
                    SqlCommand cmd1 = new SqlCommand($"INSERT INTO history(DateOfEnter, DateOfExit, Block, Employee) VALUES ('{entry}', '?', '?', '{id_employee}')", conn);
                    cmd1.ExecuteScalar();
                    menuUser.Show();
                    MessageBox.Show("Вы вошли как старший смены", "Message", MessageBoxButtons.OK);
                    //conn.Close();
                }
                else if (user_type == "Продавец")
                {
                    this.Hide();
                    MenuUser menuUser1 = new MenuUser();
                    //this.Close();
                    SqlCommand cmd1 = new SqlCommand($"INSERT INTO history(DateOfEnter, DateOfExit, Block, Employee) VALUES ('{entry}', '?', '?', '{id_employee}')", conn);
                    cmd1.ExecuteScalar();
                    menuUser1.Show();
                    MessageBox.Show("Вы вошли как продавец", "Message", MessageBoxButtons.OK);
                    //conn.Close();
                }
                else
                {
                    MessageBox.Show("Error");
                }
                conn.Close();
            }

          

            string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=igora;Integrated Security=True";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                Console.WriteLine("Подключение открыто");
                
                conn.Close();
            }
           
        }

        private void btn_off_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void log_TextChanged(object sender, EventArgs e)
        {
             
        }

        private void pas_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
