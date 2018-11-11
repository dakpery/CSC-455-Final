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
    public partial class AddCrypto : Form
    {
        string user_id;
        public string ConnectionStr = "server=localhost; uid=root; pwd=Deepw00d; database=crypto";


        public AddCrypto()
        {
            InitializeComponent();
            loadCombo();
            
        }

        private void loadCombo()
        {
            string query = "select crypto_name from cryptos;";
            DataTable dt = new DataTable();


            using (MySqlConnection connection = new MySqlConnection(ConnectionStr))
            {
                MySqlCommand selectCommand = new MySqlCommand(query, connection);
                connection.Open();


                dt.Load(selectCommand.ExecuteReader());



                if (dt.Rows.Count == 0)
                {
                    errorLabel.Text = "Something went wrong.";
                }
                else
                {
                    foreach (DataRow row in dt.Rows)
                    {
                        cryptoCombo.Items.Add(row.ItemArray[0]);
                        
                    }

                }
                connection.Close();
            }


        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            int myInt = Convert.ToInt32(numBox.Value);
            if (myInt < 0)
            {
                MessageBox.Show("Warning, your number must be 0 or greater");
                return;
            }

            // get ddl value 

            string query = $"update user_wallet set balance = balance + {numBox.Value} where crypto_name = @CryptoName and user_id = @Username";


            DataTable dt = new DataTable();


            string selected = cryptoCombo.GetItemText(cryptoCombo.SelectedItem);
            if(selected == "")
            {
                return;
            }



            using (MySqlConnection connection = new MySqlConnection(ConnectionStr))
            {
                MySqlCommand updateCommand = new MySqlCommand(query, connection);
                connection.Open();

                updateCommand.Parameters.AddWithValue("@Username", this.user_id);
                updateCommand.Parameters.AddWithValue("@CryptoName", selected);

                int count = Convert.ToInt32(updateCommand.ExecuteNonQuery());



                if (count == 0)
                {
                    errorLabel.Text = "Something went wrong.";
                }
                else
                {
                    errorLabel.Text = "Success";

                }
                connection.Close();
            }






        }

        public void setUserName(string userName)
        {
            this.user_id = userName;
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
