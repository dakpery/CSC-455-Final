using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatabaseProject
{
    public partial class UserWallet : Form
    {

        public string user_id;
        public string ConnectionStr = "server=localhost; uid=root; pwd=Deepw00d; database=crypto";


        public UserWallet()
        {
            InitializeComponent();
        }

        public void setUserID(string userID)
        {
            this.user_id = userID;
            userLabel.Text = "Logged in as: " + user_id;

        }

        private void walletInfoBtn_Click(object sender, EventArgs e)
        {
            userGrid.Rows.Clear();
            userGrid.Columns.Clear();
            string query = "select * from user_wallet where user_id=@Username;";
            string userName = user_id;
            DataTable dt = new DataTable();
            //var height = 0;
            userGrid.AllowUserToAddRows = false;
            userGrid.AutoGenerateColumns = false;

            using (MySqlConnection connection = new MySqlConnection(ConnectionStr))
            {
                MySqlCommand selectCommand = new MySqlCommand(query, connection);
                connection.Open();

                selectCommand.Parameters.AddWithValue("@Username", userName);

                dt.Load(selectCommand.ExecuteReader());



                if (dt.Rows.Count == 0)
                {
                    errorLabel.Text = "The username and password do not exist in our system, please try again.";
                }
                else
                {
                    foreach (DataColumn dc in dt.Columns)
                    {
                        userGrid.Columns.Add(new DataGridViewTextBoxColumn());
                    }

                    userGrid.Columns[0].HeaderText = "User";
                    userGrid.Columns[1].HeaderText = "Crypto";
                    userGrid.Columns[2].HeaderText = "Balance";
                    userGrid.Columns[3].HeaderText = "date bought";
                    userGrid.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    userGrid.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    userGrid.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    userGrid.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;


                    foreach (DataRow row in dt.Rows)
                    {
                        userGrid.Rows.Add(row.ItemArray);
                        //height += 1; 
                    }
                    //userGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
                    userGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;


                    //userGrid.Height = height;
                }
                connection.Close();
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string query = "select * from (select user_id,user_wallet.crypto_name,balance,current_USD,current_USD*balance as usersUSD,current_BTC_Rate*balance as usersBTC from user_wallet join prices_aftertrigger on user_wallet.crypto_name=prices_aftertrigger.crypto_name) as tTable where user_id=@userName;";
            string userName = this.user_id;
            DataTable dt = new DataTable();
            userGrid.Rows.Clear();
            userGrid.Columns.Clear();
            using (MySqlConnection connection = new MySqlConnection(ConnectionStr))
            {
                MySqlCommand selectCommand = new MySqlCommand(query, connection);
                connection.Open();

                selectCommand.Parameters.AddWithValue("@Username", userName);

                dt.Load(selectCommand.ExecuteReader());



                if (dt.Rows.Count == 0)
                {
                    errorLabel.Text = "Something went wrong.";
                }
                else
                {
                    foreach (DataColumn dc in dt.Columns)
                    {
                        userGrid.Columns.Add(new DataGridViewTextBoxColumn());
                    }

                    userGrid.Columns[0].HeaderText = "User";
                    userGrid.Columns[1].HeaderText = "Crypto";
                    userGrid.Columns[2].HeaderText = "Balance";
                    userGrid.Columns[3].HeaderText = "Current Price of Crypto";
                    userGrid.Columns[4].HeaderText = "Users USD total";
                    userGrid.Columns[5].HeaderText = "Users BTC total";
                    userGrid.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    userGrid.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    userGrid.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    userGrid.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    userGrid.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    userGrid.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;



                    foreach (DataRow row in dt.Rows)
                    {
                        userGrid.Rows.Add(row.ItemArray);
                        //height += 1; 
                    }
                    //userGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
                    userGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;


                    //userGrid.Height = height;
                }
                connection.Close();
            }
        }

        private void addCryptoBtn_Click(object sender, EventArgs e)
        {
            AddCrypto ac = new AddCrypto();
            ac.setUserName(this.user_id);
            ac.Show();
        }
    }
}
