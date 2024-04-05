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
    public partial class Place : Form
    {
        DB DB = new DB();
        int selectedRow;
        public Place()
        {
            InitializeComponent();
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Close();
            Library back = new Library();
            back.Show();
        }

        private void Place_Load(object sender, EventArgs e)
        {
            CreateColumns();
            RefreshDataGrid(placesgrid);
        }

        private void CreateColumns()
        {
            placesgrid.Columns.Add("bookId", "№");
            placesgrid.Columns.Add("name", "Название");
            placesgrid.Columns.Add("code", "Код книги");
            placesgrid.Columns.Add("number", "Номер книги");
            placesgrid.Columns.Add("IsNew", string.Empty);


        }
        private void ReadSingleRow(DataGridView dgw, IDataRecord record)
        {
            //dgw.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetInt32(2), record.GetInt32(3), RowState.ModifiedNew);
        }

        private void RefreshDataGrid(DataGridView dgw)
        {
            dgw.Rows.Clear();
            string queryString = $"select*from place";
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
