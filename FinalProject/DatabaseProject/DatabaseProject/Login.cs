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
    public partial class Login : Form
    {
        public string ConnectionStr = "server=localhost; uid=root; pwd=Deepw00d; database=crypto";


        public Login()
        {

            InitializeComponent();
        }

        private void signInBtn_Click(object sender, EventArgs e)
        {
            string query = "select count(*) from users where user_id=@Username and password=@Password;";
            string userName = userTxt.Text;
            string password = passwordTxt.Text;


            Boolean regex = checkRegex(userName, password);

            if (regex)
            {
                using (MySqlConnection connection = new MySqlConnection(ConnectionStr))
                {
                    MySqlCommand selectCommand = new MySqlCommand(query, connection);

                    connection.Open();

                    selectCommand.Parameters.AddWithValue("@Username", userName);
                    selectCommand.Parameters.AddWithValue("@Password", password);

                    int count = Convert.ToInt32(selectCommand.ExecuteScalar());

                    if (count == 0)
                    {
                        errorLabel.Text = "The username and password do not exist in our system, please try again."; 
                    }
                    else
                    {
                        errorLabel.Text = "Success";
                        UserWallet uw = new UserWallet();
                        uw.setUserID(userName);
                        this.Hide();
                        uw.Show();

                        // go to login stuff
                    }
                    connection.Close();
                }
            }



        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            this.Hide();
            f1.Show();
        }


        private Boolean checkRegex(string userName, string password)
        {
            string userPattern = @"^[a-zA-Z][a-zA-Z0-9]{4,16}$";

            Match m = Regex.Match(userTxt.Text, userPattern);
            if (!m.Success)
            {
                errorLabel.Text = "Username does not meet requirements";
                return false;
            }

            m = Regex.Match(passwordTxt.Text, userPattern);
            if (!m.Success)
            {
                errorLabel.Text = "Password does not neet requirements";
                return false;
            }

            return true;
        }

        private void password_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar==(char)13)
            {
                signInBtn.PerformClick();
            }
        }
    }
}
