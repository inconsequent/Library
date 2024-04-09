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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Library
{

    public partial class Cancellation : Form
    {
        DB DB = new DB();
        int selectedRow;
        public Cancellation()
        {
            InitializeComponent();

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
            RefreshDataGrid(cancelegrid);
        }

        private void cancelegrid_Click(object sender, EventArgs e)
        {

        }
        private void CreateColumns()
        {
            cancelegrid.Columns.Add("cancId", "№");
            cancelegrid.Columns.Add("name", "Название");
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

        //автозаполнение полей ввода при наведение на данные в таблице.
        private void cancelegrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = cancelegrid.Rows[selectedRow];
                textBox1.Text = row.Cells[1].Value.ToString();
                textBox2.Text = row.Cells[2].Value.ToString();

            }
        }

        // сохранение данных(добавление)
        private void save_Click(object sender, EventArgs e)
        {
            DB.openConnection();

            var name = textBox1.Text;
            var reason = textBox2.Text;

            //int price; if(int.TryParce(местоположение, out название переменной))
            var addQuery = $"insert into cancellation(name,reason) values('{name}','{reason}')";
            var command = new MySqlCommand(addQuery, DB.getConnection());
            command.ExecuteNonQuery();

            DB.closeConnection();
            //проблема с числом в id при добавлении оно не сбрасывается при удалении,решить

        }

        private void update_Click(object sender, EventArgs e)
        {
            RefreshDataGrid(cancelegrid);
        }
    }
}
