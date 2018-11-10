using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatabaseProject
{
    public partial class CreateUser : Form
    {
        public string ConnectionStr = "server=localhost; uid=root; pwd=Deepw00d; database=crypto";

        public CreateUser()
        {
            InitializeComponent();

            ToolTip userTP = new ToolTip();
            userTP.ShowAlways = true;
            userTP.SetToolTip(UserTxt, "Usernames must be letters, numbers, and 4-16 characters");
            userTP.SetToolTip(PasswordTxt, "Password must be letters,numbers, and 4-16 characters");
        }

        private void CreateUserBtn_Click(object sender, EventArgs e)
        {
            string username = UserTxt.Text;
            string password = PasswordTxt.Text;
            string userPattern = @"^[a-zA-Z][a-zA-Z0-9]{4,16}$";
            string queryStr = "Insert into users values (@Username,@Password);";
            string selectQry = "Select count(*) from users where user_id = @Username;";

            Match m = Regex.Match(UserTxt.Text, userPattern);
            if(!m.Success)
            {
                ErrorLabel.Text = "Username does not meet requirements";
                return;
            }

            m = Regex.Match(password, userPattern);
            if (!m.Success)
            {
                ErrorLabel.Text = "Password does not neet requirements";
                return;
            }

            ErrorLabel.Text = "";

            using (MySqlConnection connection = new MySqlConnection(ConnectionStr))
            {
                MySqlCommand selectCommand = new MySqlCommand(selectQry, connection);

                MySqlCommand insertCommand = new MySqlCommand(queryStr, connection);

                connection.Open();

                selectCommand.Parameters.AddWithValue("@Username", username);
                insertCommand.Parameters.AddWithValue("@Username", username);
                insertCommand.Parameters.AddWithValue("@Password", password);

                int count = Convert.ToInt32(selectCommand.ExecuteScalar());

                if (count == 0)
                {
                    int inserted = insertCommand.ExecuteNonQuery();
                    if (inserted == 0)
                    {
                        ErrorLabel.Text = "We could not process your request";
                    }
                    else
                    {
                        ErrorLabel.Text = "We have created a user account for you. Please go back and log in";
                    }
                }
                else
                {
                    ErrorLabel.Text = "The username you are attempting to insert is already in use. Please select see users to see usernames";
                }
                connection.Close();
            }
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            this.Hide();
            f1.Show();            
        }

        private void UserViewBtn_Click(object sender, EventArgs e)
        {
            userGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            userGrid.AutoGenerateColumns = false;

            string selectViewQuery = "select * from user_view; ";
            DataTable dt = new DataTable();

            using (MySqlConnection connection = new MySqlConnection(ConnectionStr))
            {
                MySqlCommand selectCommand = new MySqlCommand(selectViewQuery, connection);
                MySqlCommand insertCommand = new MySqlCommand(selectViewQuery, connection);
                connection.Open();
                dt.Load(selectCommand.ExecuteReader());

                foreach (DataColumn dc in dt.Columns)
                {
                    userGrid.Columns.Add(new DataGridViewTextBoxColumn());
                    userGrid.Columns[0].HeaderText = "Users";
                }

                foreach (DataRow row in dt.Rows)
                {
                    userGrid.Rows.Add(row.ItemArray);
                }
                connection.Close();
            }
        }
    }
}
