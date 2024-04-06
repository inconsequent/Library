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
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Library
{
    public partial class Cards : Form
    {
        DB DB = new DB();
        int selectedRow;
        public Cards()
        {
            InitializeComponent();
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Close();
            Library back = new Library();
            back.Show();
        }

        private void Cards_Load(object sender, EventArgs e)
        {
            CreateColumns();
            RefreshDataGrid(cardsgrid);
        }
        private void CreateColumns()
        {
            cardsgrid.Columns.Add("readerId", "№");
            cardsgrid.Columns.Add("readersName", "Ф.И.О.");
            cardsgrid.Columns.Add("Name", "Название");
            cardsgrid.Columns.Add("bookId", "№ Книги"); 
            cardsgrid.Columns.Add("data", "Дата выдачи");
            cardsgrid.Columns.Add("IsNew", string.Empty);

        }
        private void ReadSingleRow(DataGridView dgw, IDataRecord record)
        {
            dgw.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetString(2), record.GetData(3), RowState.ModifiedNew);
        }

        private void RefreshDataGrid(DataGridView dgw)
        {
            dgw.Rows.Clear();
           дописать запрос вывода таблиц из бд.
 string queryString = $"select ";
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
