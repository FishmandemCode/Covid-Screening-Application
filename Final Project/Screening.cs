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

namespace Final_Project
{
    public partial class screen_form : Form
    {
        int val, val2, val3, flagged;
        string connectionstring = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
        List<string> choice = new List<string> { "Yes", "No" };
        public screen_form()
        {
            InitializeComponent();
            foreach(DataRow item in usersTableAdapter.GetData())
            {
                id_choice.Items.Add(item[0]);
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Users usr = new Users();
            usr.ShowDialog();
        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu frm = new Menu();
            frm.ShowDialog();
        }

        private void forceEditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            report.Clear(); report.Text = ("Force Edit in Progress"); Travel.Enabled = true; Close_Contact.Enabled = true; Symtoms.Enabled = true; date_pick.Enabled = true; richTextBox1.BackColor = Color.Yellow; button1.Enabled = true;
        }

        private void Screening_Load(object sender, EventArgs e)
        {
            this.usersTableAdapter.Fill(this.databaseDataSet.Users);
            this.screeningTableAdapter.Fill(this.databaseDataSet.Screening);
           
            foreach (string val in choice)
            {
                Travel.Items.Add(val);
                Close_Contact.Items.Add(val);
                Symtoms.Items.Add(val);
            }
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Travel.Text = ""; Close_Contact.Text = ""; Symtoms.Text = "";

            DataTable dt = screeningTableAdapter.GetData();
            DataTable dt2 = usersTableAdapter.GetData();
            ScreeningID.Text = dt.Rows[id_choice.SelectedIndex][0].ToString();
            Name_Txt.Text = dt2.Rows[id_choice.SelectedIndex][1].ToString();
            string flagger_mess = dt2.Rows[id_choice.SelectedIndex][3].ToString();
            date_pick.Text = dt.Rows[id_choice.SelectedIndex][5].ToString();

            if (flagger_mess == "1")
            {
                Travel.Enabled = false; Close_Contact.Enabled = false; Symtoms.Enabled = false; date_pick.Enabled = false; richTextBox1.BackColor = Color.Red; button1.Enabled = false;
                report.Text = ("User is Already Flagged: Positive \r\nPlease wait for 1 Week to Change");
            }
            else if (flagger_mess == "0")
            { report.Clear(); report.Text = ("User is not Flagged"); Travel.Enabled = true; Close_Contact.Enabled = true; Symtoms.Enabled = true; date_pick.Enabled = true; richTextBox1.BackColor = Color.Green; button1.Enabled = true; }
            else if(flagger_mess == "")
            { report.Text = ("No Infomration"); richTextBox1.BackColor = Color.Yellow; Travel.Enabled = true; Close_Contact.Enabled = true; Symtoms.Enabled = true; date_pick.Enabled = true; button1.Enabled = true; }
        }

        private void verify_btn(object sender, EventArgs e)
        {
            report.Clear();
            string date = date_pick.Text;
            SqlConnection sqlcon = new SqlConnection(connectionstring);

            if (Travel.Text == "Yes" || Close_Contact.Text == "Yes" || Symtoms.Text == "Yes")
            { richTextBox1.BackColor = Color.Red; report.Text = ("User is Flagged: Positive \r\nPlease wait for 1 Week to Change"); }
            else
            { richTextBox1.BackColor = Color.Green; report.Text = ("User is not Flagged"); }
        

            if (Travel.Text == "Yes") { val = 1; flagged = 1; } else val = 0;
            if (Close_Contact.Text == "Yes") { val2 = 1; flagged = 1; } else val2 = 0;
            if (Symtoms.Text == "Yes") { val3 = 1; flagged = 1; } else val3 = 0;

            string cmd_update = "UPDATE Screening SET CloseContact = '" + Convert.ToString(val) + "',Travelled = '" + Convert.ToString(val2) + "',Symtoms = '"+ Convert.ToString(val3) + "',Date = '"+ date + "' WHERE StudentID = '" + id_choice.Text + "' ";
            string cmd_update2 = "UPDATE Users SET UserFlagged = '" + Convert.ToString(flagged) + "' WHERE StudentID = '"+id_choice.Text+"' ";
            
            SqlCommand cmd = new SqlCommand(cmd_update, sqlcon);
            SqlCommand cmd2 = new SqlCommand(cmd_update2, sqlcon);
            
            sqlcon.Open();
            DataTable dt = screeningTableAdapter.GetData();
            cmd.ExecuteNonQuery(); cmd2.ExecuteNonQuery();
            sqlcon.Close();
            

        }
    }
}
