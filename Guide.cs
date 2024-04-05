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

namespace Library
{

    enum RowState 
    {
    Existed,
    New,
    Modified,
    ModifiedNew,
    Deleted
    }
 


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

        private void LoadData()
        {
           
        }
        // подклюсение и вывод бд
        private void CreateColumns() 
        {
            guidegrid.Columns.Add("idBook", "№");
            guidegrid.Columns.Add("genre", "Жанр");
            guidegrid.Columns.Add("name", "Название");
            guidegrid.Columns.Add("IsNew", string.Empty);

        }
        private void ReadSingleRow( DataGridView dgw,IDataRecord record )
        {
            dgw.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetString(2),RowState.ModifiedNew);
        }

        private void RefreshDataGrid(DataGridView dgw)
        {
            dgw.Rows.Clear();
            string queryString = $"select*from guide";
            MySqlCommand command = new MySqlCommand(queryString,DB.getConnection());

            DB.openConnection();
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                ReadSingleRow(dgw,reader);
            }
            reader.Close();

        }
        

        }
   
    }

