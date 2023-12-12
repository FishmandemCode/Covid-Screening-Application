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
    public partial class Users : Form
    {
        string connectionstring = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
        
        public Users()
        {
            InitializeComponent();
        }


        private void Users_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseDataSet.Users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.databaseDataSet.Users);
            usertypeComboBox.Items.Insert(0, "Employee");
            usertypeComboBox.Items.Insert(1, "Student");
            studentIDTextBox.Text = ""; usernameTextBox.Text = ""; usertypeComboBox.Text = "";
        }

        private void update_btn(object sender, EventArgs e)
        {
            try
            {
                if (studentIDTextBox.Text == "" || usernameTextBox.Text == "" || usertypeComboBox.Text == "") MessageBox.Show("Input Data");
                else
                {
                    int count = usersDataGridView.RowCount;

                    SqlConnection sqlcon = new SqlConnection(connectionstring);

                    string cmd_update = "INSERT INTO Users (StudentID,Username,Usertype) VALUES ('" + studentIDTextBox.Text + "','" + usernameTextBox.Text + "','" + usertypeComboBox.Text + "')";
                    string cmd_update2 = "INSERT INTO Screening (StudentID) VALUES ('" + studentIDTextBox.Text + "')";

                    SqlCommand cmd = new SqlCommand(cmd_update, sqlcon);
                    SqlCommand cmd2 = new SqlCommand(cmd_update2, sqlcon);

                    sqlcon.Open(); cmd.ExecuteNonQuery(); cmd2.ExecuteNonQuery(); sqlcon.Close();

                    string cmd_data = "SELECT * FROM Users";

                    SqlCommand cmd3 = new SqlCommand(cmd_data, sqlcon);

                    sqlcon.Open(); SqlDataAdapter sdr = new SqlDataAdapter(cmd3); DataTable dt = new DataTable(); sdr.Fill(dt); usersDataGridView.DataSource = dt; sqlcon.Close();
                    studentIDTextBox.Text = ""; usernameTextBox.Text = ""; usertypeComboBox.Text = "";
                }
            }
            catch
            {
                MessageBox.Show("User ID Taken");
                studentIDTextBox.Text = ""; usernameTextBox.Text = ""; usertypeComboBox.Text = "";
            }
            
        }

        private void btn_click(object sender, EventArgs e)
        {
            if (studentIDTextBox.Text == "" || usernameTextBox.Text == "" || usertypeComboBox.Text == "") MessageBox.Show("Input Data");
            else
            {
                SqlConnection sqlcon = new SqlConnection(connectionstring);
                string cmd_edit = "UPDATE Users SET Username = '" + usernameTextBox.Text + "', Usertype = '" + usertypeComboBox.Text + "' WHERE StudentID = '" + studentIDTextBox.Text + "'";
                SqlCommand cmd = new SqlCommand(cmd_edit, sqlcon);
                sqlcon.Open(); cmd.ExecuteNonQuery(); sqlcon.Close();
                string cmd_data = "SELECT * FROM Users";

                SqlCommand cmd2 = new SqlCommand(cmd_data, sqlcon);

                sqlcon.Open(); SqlDataAdapter sdr = new SqlDataAdapter(cmd2); DataTable dt = new DataTable(); sdr.Fill(dt); usersDataGridView.DataSource = dt; sqlcon.Close();
                studentIDTextBox.Text = ""; usernameTextBox.Text = ""; usertypeComboBox.Text = "";
            }
        }
        private void delete_btn(object sender, EventArgs e)
        {
            if (studentIDTextBox.Text == "") MessageBox.Show("Input ID");
            else
            {
                SqlConnection sqlcon = new SqlConnection(connectionstring);
                string cmd_delete = "DELETE FROM Users WHERE StudentID = '" + studentIDTextBox.Text + "'";
                string cmd_delete2 = "DELETE FROM Screening WHERE StudentID = '" + studentIDTextBox.Text + "'";
                SqlCommand cmd = new SqlCommand(cmd_delete, sqlcon);
                SqlCommand cmd2 = new SqlCommand(cmd_delete2, sqlcon);
                sqlcon.Open(); cmd.ExecuteNonQuery(); cmd2.ExecuteNonQuery(); sqlcon.Close();
                string cmd_data = "SELECT * FROM Users";

                SqlCommand cmd3 = new SqlCommand(cmd_data, sqlcon);

                sqlcon.Open(); SqlDataAdapter sdr = new SqlDataAdapter(cmd3); DataTable dt = new DataTable(); sdr.Fill(dt); usersDataGridView.DataSource = dt; sqlcon.Close();
                studentIDTextBox.Text = ""; usernameTextBox.Text = ""; usertypeComboBox.Text = "";
            }
            
        }
        private void reset_btn(object sender, EventArgs e)
        {
            if (studentIDTextBox.Text == "") MessageBox.Show("Input ID");
            else
            {
                SqlConnection sqlcon = new SqlConnection(connectionstring);
                string cmd_reset = "UPDATE Users SET UserFlagged = ' ' WHERE StudentID = '" + studentIDTextBox.Text + "'";
                SqlCommand cmd = new SqlCommand(cmd_reset, sqlcon);
                sqlcon.Open(); cmd.ExecuteNonQuery(); sqlcon.Close();

                string cmd_data = "SELECT * FROM Users";

                SqlCommand cmd2 = new SqlCommand(cmd_data, sqlcon);

                sqlcon.Open(); SqlDataAdapter sdr = new SqlDataAdapter(cmd2); DataTable dt = new DataTable(); sdr.Fill(dt); usersDataGridView.DataSource = dt; sqlcon.Close();
                studentIDTextBox.Text = ""; usernameTextBox.Text = ""; usertypeComboBox.Text = "";
            }
                
        }


        private void scr_display(object sender, EventArgs e)
        {
            this.Hide();
            screen_form scr = new screen_form();
            scr.ShowDialog();
        }

        private void usr_btn(object sender, EventArgs e)
        {
            this.Hide();
            Menu frm = new Menu();
            frm.ShowDialog();
        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
