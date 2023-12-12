using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using System.IO;


namespace Final_Project
{
    public partial class Report : Form
    {
        string connectionstring = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
        DataTable dt = new DataTable();
        public Report()
        {
            InitializeComponent();
        }

        private void Report_Load(object sender, EventArgs e)
        {
            report_table.DataSource = filler();
        }
        private DataTable filler()
        {
            SqlConnection sqlcon = new SqlConnection(connectionstring);
            string sqltable = "SELECT Users.StudentID,Users.Username,Screening.CloseContact,Screening.Travelled,Screening.Symtoms,Users.UserFlagged FROM [dbo].[Screening] INNER JOIN [dbo].[Users] ON Screening.StudentID = Users.StudentID";
            SqlCommand cmd = new SqlCommand(sqltable, sqlcon);
            sqlcon.Open();
            SqlDataAdapter sdr = new SqlDataAdapter(cmd);
            sdr.Fill(dt); sqlcon.Close(); return dt;
        }
        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {

            TextWriter txt = new StreamWriter("D:\\School Work\\Season 4\\PRG\\Final Project\\Report.txt");
            for (int i = 0; i < report_table.Rows.Count - 1; i++)
            {
                for (int j = 0; j < report_table.Columns.Count; j++)
                {
                    txt.Write("|" + "\t " + report_table.Rows[i].Cells[j].Value.ToString() + "  \t" + "|");
                }
                txt.WriteLine("");
                txt.WriteLine("______________________________________________________________________________________________________________________");
            }
            txt.Close();
            MessageBox.Show("Report.Txt created");

        }

        private void search_text(object sender, EventArgs e)
        {
            DataView dv = dt.DefaultView;
            dv.RowFilter = "Username LIKE '%" + textBox1.Text + "%'";
        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu mn = new Menu();
            mn.ShowDialog();
        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Users usr = new Users();
            usr.ShowDialog();
        }

        private void screeningToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            screen_form scr = new screen_form();
            scr.ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
