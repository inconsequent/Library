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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Text;
using static System.Net.Mime.MediaTypeNames;

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
            cardsgrid.Columns.Add("name", "Название");
            cardsgrid.Columns.Add("code", "Код Книги");
            cardsgrid.Columns.Add("data", "Дата выдачи");

            cardsgrid.Columns.Add("IsNew", string.Empty);

        }
        private void ReadSingleRow(DataGridView dgw, IDataRecord record)
        {
            dgw.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetString(2), record.GetInt32(3), record.GetString(4), RowState.ModifiedNew);
        }

        private void RefreshDataGrid(DataGridView dgw)
        {
            dgw.Rows.Clear();
            //дописать запрос вывода таблиц из бд.

            string queryString = $"select*from cards";
            MySqlCommand command = new MySqlCommand(queryString, DB.getConnection());

            DB.openConnection();
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                ReadSingleRow(dgw, reader);
            }
            reader.Close();

        }

        private void cardsgrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = cardsgrid.Rows[selectedRow];
                textBox4.Text = row.Cells[1].Value.ToString();
                textBox1.Text = row.Cells[2].Value.ToString();
                textBox2.Text = row.Cells[3].Value.ToString();
                textBox3.Text = row.Cells[4].Value.ToString();
            }
        }
        
        private void save_Click(object sender, EventArgs e)
        {
            DB.openConnection();
            var readersName = textBox4.Text;
            var name = textBox1.Text;
            var code = textBox2.Text;
            var data = textBox3.Text;
            //int price; if(int.TryParce(местоположение, out название переменной))
            var addQuery = $"insert into cards(readersName,name,code,data) values('{readersName}','{name}','{code}','{data}')";
            var command = new MySqlCommand(addQuery, DB.getConnection());
            command.ExecuteNonQuery();

            DB.closeConnection();
            // id прибавляется некорректно.
        }
        // Обновление данных
        private void update_Click(object sender, EventArgs e)
        {
            RefreshDataGrid(cardsgrid);
        }

        // Изменение данных
        private void change_Click(object sender, EventArgs e)
        {

            DB.openConnection();
            var index = cardsgrid.CurrentCell.RowIndex;
            var id = Convert.ToInt32(cardsgrid.Rows[index].Cells[0].Value);
            var deleteQuery = $" UPDATE `cards` SET `readersName` = '{textBox4.Text}', `name` = '{textBox1.Text}', `code` = '{textBox2.Text}', `data` = '{textBox3.Text}' WHERE `cards`.`readerId` = {id};";
            var command = new MySqlCommand(deleteQuery, DB.getConnection());
            command.ExecuteNonQuery();

            DB.closeConnection();
        }
                                       
                                         
                                         
        //удаление данных                

        private void delete_Click(object sender, EventArgs e)
        {
            var index = cardsgrid.CurrentCell.RowIndex;
            var id = Convert.ToInt32(cardsgrid.Rows[index].Cells[0].Value);
            var deleteQuery = $"delete from cards where readerId = {id}";
            var command = new MySqlCommand(deleteQuery, DB.getConnection());
            command.ExecuteNonQuery();
            DB.closeConnection();


        }
    }
}
