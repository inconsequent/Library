using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    public partial class Providers : Form
    {

        DB DB = new DB();
        int selectedRow;
        public Providers()
        {
            InitializeComponent();
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Close();
            Library back = new Library();
            back.Show();
        }

        private void Providers_Load(object sender, EventArgs e)
        {
           CreateColumns(); 
           RefreshDataGrid(providersgrid);
        }

        private void CreateColumns()
        {
            providersgrid.Columns.Add("provId", "№");
            providersgrid.Columns.Add("provName", "Название");
            providersgrid.Columns.Add("address", "Адрес");
            providersgrid.Columns.Add("IsNew", string.Empty);

        }
        private void ReadSingleRow(DataGridView dgw, IDataRecord record)
        {
            dgw.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetString(2), RowState.ModifiedNew);
        }

        private void RefreshDataGrid(DataGridView dgw)
        {
            dgw.Rows.Clear();
            string queryString = $"select*from providers";
            MySqlCommand command = new MySqlCommand(queryString, DB.getConnection());

            DB.openConnection();
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                ReadSingleRow(dgw, reader);
            }
            reader.Close();

        }
    }
}
