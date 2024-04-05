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

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
