﻿using MySql.Data.MySqlClient;
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

            purcgrid.Columns.Add(" provId", "№");
            purcgrid.Columns.Add("provName", "Поставщик");
            purcgrid.Columns.Add("bookId", "№ Книги");
            purcgrid.Columns.Add("cost", "Цена");
            purcgrid.Columns.Add("datePurchase", "Дата закупки");
            purcgrid.Columns.Add("IsNew", string.Empty);
        }
        private void ReadSingleRow(DataGridView dgw, IDataRecord record)
        {
            dgw.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetString(2), record.GetInt32(3), record.GetData(4), RowState.ModifiedNew);
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
    }
}
