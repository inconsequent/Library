﻿using MySql.Data.MySqlClient;
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

        private void providersgrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = providersgrid.Rows[selectedRow];
                textBox1.Text = row.Cells[1].Value.ToString();
                textBox2.Text = row.Cells[2].Value.ToString();

            }
        }

        // сохранение данных(добавление)
        private void save_Click(object sender, EventArgs e)
        {
            DB.openConnection();

            var provName = textBox1.Text;
            var address = textBox2.Text;
            //int price; if(int.TryParce(местоположение, out название переменной))
            var addQuery = $"insert into providers(provName,address) values('{provName}','{address}')";
            var command = new MySqlCommand(addQuery, DB.getConnection());
            command.ExecuteNonQuery();

            DB.closeConnection();
        }

        //Обновление данных

        private void update_Click(object sender, EventArgs e)
        {
            RefreshDataGrid(providersgrid);
        }

        // Изменение данных
        private void change_Click(object sender, EventArgs e)
        {

            DB.openConnection();
            var index = providersgrid.CurrentCell.RowIndex;
            var id = Convert.ToInt32(providersgrid.Rows[index].Cells[0].Value);
            var deleteQuery = $" UPDATE `providers` SET `provName` = '{textBox1.Text}', `address` = '{textBox2.Text}' WHERE `providers`.`provId` = {id};";
            var command = new MySqlCommand(deleteQuery, DB.getConnection());
            command.ExecuteNonQuery();

            DB.closeConnection();
        }




        //удаление данных

        private void delete_Click(object sender, EventArgs e)
        {
            var index = providersgrid.CurrentCell.RowIndex;
            var id = Convert.ToInt32(providersgrid.Rows[index].Cells[0].Value);
            var deleteQuery = $"delete from providers where provId = {id}";
            var command = new MySqlCommand(deleteQuery, DB.getConnection());
            command.ExecuteNonQuery();
            DB.closeConnection();


        }




    }
}
