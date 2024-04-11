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
            placesgrid.Columns.Add("placeId", "№");
            placesgrid.Columns.Add("name", "Название");
            placesgrid.Columns.Add("code", "Код книги");
            placesgrid.Columns.Add("number", "Номер книги");
         

        }
        private void ReadSingleRow(DataGridView dgw, IDataRecord record)
        {
            dgw.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetString(2), record.GetInt32(3), RowState.ModifiedNew);
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

        private void placesgrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = placesgrid.Rows[selectedRow];
                textBox1.Text = row.Cells[1].Value.ToString();
                textBox2.Text = row.Cells[2].Value.ToString();
                textBox3.Text = row.Cells[3].Value.ToString();


            }
        }

        // сохранение данных(добавление)
        private void save_Click(object sender, EventArgs e)
        {
            DB.openConnection();

            var name = textBox1.Text;
            var code = textBox2.Text;
            var number = textBox3.Text;
            //int price; if(int.TryParce(местоположение, out название переменной))
            var addQuery = $"insert into place(name,code,number) values('{name}','{code}','{number}')";
            var command = new MySqlCommand(addQuery, DB.getConnection());
            command.ExecuteNonQuery();

            DB.closeConnection();
        }
        private void update_Click(object sender, EventArgs e)
        {
            RefreshDataGrid(placesgrid);
        }

        // Изменение данных
        private void change_Click(object sender, EventArgs e)
        {

            DB.openConnection();
            var index = placesgrid.CurrentCell.RowIndex;
            var id = Convert.ToInt32(placesgrid.Rows[index].Cells[0].Value);
            var deleteQuery = $" UPDATE `place` SET `name` = '{textBox1.Text}', `code` = '{textBox2.Text}', `number` = '{textBox3.Text}' WHERE `place`.`placeId` = {id};";
            var command = new MySqlCommand(deleteQuery, DB.getConnection());
            command.ExecuteNonQuery();

            DB.closeConnection();
        }
     


        //удаление данных                

        private void delete_Click(object sender, EventArgs e)
        {
            var index = placesgrid.CurrentCell.RowIndex;
            var id = Convert.ToInt32(placesgrid.Rows[index].Cells[0].Value);
            var deleteQuery = $"delete from place where placeId = {id}";
            var command = new MySqlCommand(deleteQuery, DB.getConnection());
            command.ExecuteNonQuery();
            DB.closeConnection();


        }
    }
}
