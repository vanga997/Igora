﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PracticeIgora
{
    public partial class Service : Form
    {
        string Login = Auth.login1.ToString();
        string password = Auth.password1.ToString();
        public Service()
        {
            InitializeComponent();
        }

        private void serviceBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.serviceBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.igoraDataSet);

        }

        private void Service_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "igoraDataSet.service". При необходимости она может быть перемещена или удалена.
            this.serviceTableAdapter.Fill(this.igoraDataSet.service);

        }

        private void btn_menu_Click(object sender, EventArgs e)
        {
            string user_type;

            using (SqlConnection conn = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=igora;Integrated Security=True"))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand($"SELECT Post FROM employee WHERE login='{Login}' AND password='{password}'", conn);
                user_type = (string)cmd.ExecuteScalar();

                if (user_type == "Администратор")
                {
                    this.Close();
                    Menu newMenu = new Menu();
                    newMenu.Show();
                }
                else if (user_type == "Старший смены")
                {
                    this.Close();
                    MenuUser newMenu = new MenuUser();
                    newMenu.Show();
                }
                else
                {
                    this.Close();
                    MenuUser newMenu = new MenuUser();
                    newMenu.Show();
                }
                conn.Close();
            }
        }
    }
}
