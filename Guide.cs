using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Net;

namespace Library
{
    public partial class Guide : Form
    {
        DB DB = new DB();
        int selectedRow;

        public Guide()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Guide_Load(object sender, EventArgs e)
        {
            CreateColumns();
            RefreshDataGrid(guidegrid);
        }

        private void back_Click(object sender, EventArgs e)
        {

            this.Close();
            Library back = new Library();
            back.Show();

        }

        private void guidegrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        // подклюсение и вывод бд
        private void CreateColumns()
        {
            guidegrid.Columns.Add("bookId", "№");
            guidegrid.Columns.Add("genre", "Жанр");
            guidegrid.Columns.Add("author", "Автор");
            guidegrid.Columns.Add("name", "Название");
            guidegrid.Columns.Add("IsNew", string.Empty);
        }
        private void ReadSingleRow(DataGridView dgw, IDataRecord record)
        {
            dgw.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetString(2), record.GetString(3), RowState.ModifiedNew);
        }

        private void RefreshDataGrid(DataGridView dgw)
        {
            dgw.Rows.Clear();
            string queryString = $"SELECT*from guide;";
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
        private void guidegrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = guidegrid.Rows[selectedRow];
                textBox6.Text = row.Cells[1].Value.ToString();
                textBox5.Text = row.Cells[2].Value.ToString();
                textBox4.Text = row.Cells[3].Value.ToString();
            }
        }
        // сохранение данных(добавление)
        private void save_Click(object sender, EventArgs e)
        {
            DB.openConnection();

            var name = textBox6.Text;
            var author = textBox5.Text;
            var genre = textBox4.Text;
            //int price; if(int.TryParce(местоположение, out название переменной))
            var addQuery = $"insert into guide(genre,author,name) values('{genre}','{author}','{name}')";
            var command = new MySqlCommand(addQuery, DB.getConnection());
            command.ExecuteNonQuery();

            DB.closeConnection();
        }

        private void change_Click(object sender, EventArgs e)
        {

            DB.openConnection();

            var name = textBox6.Text;
            var author = textBox5.Text;
            var genre = textBox4.Text;
            //int price; if(int.TryParce(местоположение, out название переменной))
            var addQuery = $"insert into guide(genre,author,name) values('{genre}','{author}','{name}')";
            var command = new MySqlCommand(addQuery, DB.getConnection());
            command.ExecuteNonQuery();

            DB.closeConnection();
        }
    }

}           

