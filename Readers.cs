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
    public partial class Readers : Form
    {
        DB DB = new DB();
        int selectedRow;
        public Readers()
        {
            InitializeComponent();
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Close();
            Library back = new Library();
            back.Show();
        }

        private void Readers_Load(object sender, EventArgs e)
        {
            CreateColumns();
            RefreshDataGrid(readersgrid);
        }
        private void CreateColumns()
        {
            readersgrid.Columns.Add("readerId", "№");
            readersgrid.Columns.Add("readersName", "Имя");
            readersgrid.Columns.Add("age", "Возраст");
            readersgrid.Columns.Add("number", "Номер карточки");
           
        }
        private void ReadSingleRow(DataGridView dgw, IDataRecord record)
        {
            dgw.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetInt32(2), record.GetInt32(3));
        }

        private void RefreshDataGrid(DataGridView dgw)
        {
            dgw.Rows.Clear();
            string queryString = $"select*from readers";
            MySqlCommand command = new MySqlCommand(queryString, DB.getConnection());

            DB.openConnection();
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                ReadSingleRow(dgw, reader);
            }
            reader.Close();
        }

        private void readersgrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = readersgrid.Rows[selectedRow];
                textBox1.Text = row.Cells[1].Value.ToString();
                textBox3.Text = row.Cells[2].Value.ToString();
                textBox2.Text = row.Cells[3].Value.ToString();
            }
        }

        // сохранение данных(добавление)
        private void save_Click(object sender, EventArgs e)
        {
            DB.openConnection();

            var readersName = textBox1.Text;
            var age = textBox3.Text;
            var number = textBox2.Text;
            //int price; if(int.TryParce(местоположение, out название переменной))
            var addQuery = $"insert into readers(readersName,age,number) values('{readersName}','{age}','{number}')";
            var command = new MySqlCommand(addQuery, DB.getConnection());
            command.ExecuteNonQuery();

            DB.closeConnection();
        }

        //Обновление данных

        private void update_Click(object sender, EventArgs e)
        {
            RefreshDataGrid(readersgrid);
        }

        // Изменение данных
        private void change_Click(object sender, EventArgs e)
        {

            DB.openConnection();
            var index = readersgrid.CurrentCell.RowIndex;
            var id = Convert.ToInt32(readersgrid.Rows[index].Cells[0].Value);
            var deleteQuery = $" UPDATE `readers` SET `readersName` = '{textBox1.Text}', `age` = '{textBox3.Text}', `number` = '{textBox2.Text}' WHERE `readers`.`readerId` = {id};";
            var command = new MySqlCommand(deleteQuery, DB.getConnection());
            command.ExecuteNonQuery();

            DB.closeConnection();
        }




        //удаление данных

        private void delete_Click(object sender, EventArgs e)
        {
            var index = readersgrid.CurrentCell.RowIndex;
            var id = Convert.ToInt32(readersgrid.Rows[index].Cells[0].Value);
            var deleteQuery = $"delete from readers where readerId = {id}";
            var command = new MySqlCommand(deleteQuery, DB.getConnection());
            command.ExecuteNonQuery();
            DB.closeConnection();


        }

    }
}
