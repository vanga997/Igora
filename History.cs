using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticeIgora
{
    public partial class History : Form
    {
        public History()
        {
            InitializeComponent();
        }

        private void historyBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.historyBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.igoraDataSet);

        }

        private void History_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "igoraDataSet.history". При необходимости она может быть перемещена или удалена.
            this.historyTableAdapter.Fill(this.igoraDataSet.history);

        }

        private void btn_menu_Click(object sender, EventArgs e)
        {
            this.Close();
            Menu newMenu = new Menu();
            newMenu.Show();
        }
    }
}
