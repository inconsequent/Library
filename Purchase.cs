using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    public partial class Purchase : Form
    {
        DB DB = new DB();
        int selectedRow;
        public Purchase()
        {
            InitializeComponent();
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Close();
            Library back = new Library();
            back.Show();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Purchase_Load(object sender, EventArgs e)
        {
            CreateColumns();
            RefreshDataGrid(purcgrid);
        }

        private void CreateColumns()
        {

            purcgrid.Columns.Add("purcId", "№");
            purcgrid.Columns.Add("name", "Название");
            purcgrid.Columns.Add("author", "Автор");
            purcgrid.Columns.Add("genre", "Жанр");
            purcgrid.Columns.Add("provName", "Поставщик");
            purcgrid.Columns.Add("cost", "Цена");
            purcgrid.Columns.Add("datePurchase", "Дата закупки");

        }
        private void ReadSingleRow(DataGridView dgw, IDataRecord record)
        {
            dgw.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetString(2), record.GetString(3), record.GetString(4), record.GetDecimal(5), record.GetString(6), RowState.ModifiedNew);
        }

        private void RefreshDataGrid(DataGridView dgw)
        {
            dgw.Rows.Clear();
            string queryString = $"select*from purchase";
            MySqlCommand command = new MySqlCommand(queryString, DB.getConnection());

            DB.openConnection();
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                ReadSingleRow(dgw, reader);
            }
            reader.Close();

        }


        private void purcgrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = purcgrid.Rows[selectedRow];
                textBox6.Text = row.Cells[1].Value.ToString();
                textBox5.Text = row.Cells[2].Value.ToString();
                textBox4.Text = row.Cells[3].Value.ToString();
                textBox1.Text = row.Cells[4].Value.ToString();
                textBox2.Text = row.Cells[5].Value.ToString();
                textBox3.Text = row.Cells[6].Value.ToString();
            }
        }

        // сохранение данных(добавление)
        private void save_Click(object sender, EventArgs e)
        {
            DB.openConnection();

            var name = textBox6.Text;
            var author = textBox5.Text;
            var genre = textBox4.Text;
            var provName = textBox1.Text;
            var cost = textBox2.Text;
            var datePurchase = textBox3.Text;
            //int price; if(int.TryParce(местоположение, out название переменной))
            var addQuery = $"insert into purchase(name,author,genre,provName,cost,datePurchase) values('{name}','{author}','{genre}','{provName}','{cost}','{datePurchase}')";
            var command = new MySqlCommand(addQuery, DB.getConnection());
            command.ExecuteNonQuery();

            DB.closeConnection();
        }

        //Обновление данных

        private void update_Click(object sender, EventArgs e)
        {
            RefreshDataGrid(purcgrid);
        }

        // Изменение данных                                                           
        private void change_Click(object sender, EventArgs e)
        {

            DB.openConnection();
            var index = purcgrid.CurrentCell.RowIndex;
            var id = Convert.ToInt32(purcgrid.Rows[index].Cells[0].Value);
            var deleteQuery = $" UPDATE `purchase` SET `name` = '{textBox6.Text}', `author` = '{textBox5.Text}', `genre` = '{textBox4.Text}', `provName` = '{textBox1.Text}', `cost` = '{textBox2.Text}', `datePurchase` = '{textBox3.Text}' WHERE `purchase`.`purcId` = {id};";
            var command = new MySqlCommand(deleteQuery, DB.getConnection());
            command.ExecuteNonQuery();

            DB.closeConnection();
        }




        //удаление данных

        private void delete_Click(object sender, EventArgs e)
        {
            var index = purcgrid.CurrentCell.RowIndex;
            var id = Convert.ToInt32(purcgrid.Rows[index].Cells[0].Value);
            var deleteQuery = $"delete from purchase where purcId = {id}";
            var command = new MySqlCommand(deleteQuery, DB.getConnection());
            command.ExecuteNonQuery();
            DB.closeConnection();


        }
    }
}
