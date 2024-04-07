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

    public partial class Cancellation : Form
    {
        DB DB = new DB();
        int selectedRow;
        public Cancellation()
        {
            InitializeComponent();
            RefreshDataGrid(cancelegrid);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // прописать сохранение ввода форм
            this.Close();
            Library back = new Library();
            back.Show();
        }

        private void Cancellation_Load(object sender, EventArgs e)
        {
            CreateColumns();

        }

        private void cancelegrid_Click(object sender, EventArgs e)
        {

        }
        private void CreateColumns()
        {
           cancelegrid.Columns.Add("bookId", "№");
           cancelegrid.Columns.Add("name","Название" );
           cancelegrid.Columns.Add("reason", "Причина");
           cancelegrid.Columns.Add("IsNew", string.Empty);

        }
        private void ReadSingleRow(DataGridView dgw, IDataRecord record)
        {
            dgw.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetString(2), RowState.ModifiedNew);
        }

        private void RefreshDataGrid(DataGridView dgw)
        {
            dgw.Rows.Clear();
            string queryString = $"select*from cancellation";
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
