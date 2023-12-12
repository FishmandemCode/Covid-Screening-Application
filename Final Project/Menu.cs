using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Project
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Users users = new Users();
            users.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            screen_form scr = new screen_form();
            scr.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Report rpt = new Report();
            rpt.ShowDialog();
        }
    }
}
