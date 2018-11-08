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

            string ConnectionStr = "server=localhost; uid=root; pwd=whatever your password is ; database=crypto";
            using (MySqlConnection connection = new MySqlConnection(ConnectionStr))
            {
                MySqlCommand command = new MySqlCommand(queryStr, connection);

                connection.Open();

                command.Parameters.AddWithValue("@Username", username);
                command.Parameters.AddWithValue("@Password", password);
                try
                {
                    int inserted = command.ExecuteNonQuery();
                    if (inserted == 0)
                    {
                        ErrorLabel.Text = "We could not process your request";
                    } else
                    {
                        ErrorLabel.Text = "We have created a user account for you. Please go back and log in";
                    }
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
