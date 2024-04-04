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
    public partial class Guide : Form
    {
        public Guide()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Guide_Load(object sender, EventArgs e)
        {

        }

        private void back_Click(object sender, EventArgs e)
        {

                this.Close();
                Library back = new Library();
                back.Show();
          
        }
    }
}
