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
    public partial class DisplayCrypto : Form
    {
        public string ConnectionStr = "server=localhost; uid=root; pwd=Deepw00d; database=crypto";

        public DisplayCrypto()
        {
            InitializeComponent();
        }

        private void cartesianBtn_Click(object sender, EventArgs e)
        {
            cryptoGrid.Rows.Clear();
            cryptoGrid.Columns.Clear();
            errorLabel.Text = "";

            string query = "select * from cryptos,platforms;";
            DataTable dt = new DataTable();

            using (MySqlConnection connection = new MySqlConnection(ConnectionStr))
            {
                MySqlCommand selectCommand = new MySqlCommand(query, connection);
                connection.Open();

                dt.Load(selectCommand.ExecuteReader());



                if (dt.Rows.Count == 0)
                {
                    errorLabel.Text = "something went wrong";
                }
                else
                {
                    errorLabel.Text = "This is just a cartesian product between the cryptos and platforms tables.";

                    foreach (DataColumn dc in dt.Columns)
                    {
                        cryptoGrid.Columns.Add(new DataGridViewTextBoxColumn());

                    }

                    cryptoGrid.Columns[0].HeaderText = "Crypto Name";
                    cryptoGrid.Columns[1].HeaderText = "Date Released";
                    cryptoGrid.Columns[2].HeaderText = "CryptoTable BlockChain Platform";
                    cryptoGrid.Columns[3].HeaderText = "Circulating Supply";
                    cryptoGrid.Columns[4].HeaderText = "Market Cap";
                    cryptoGrid.Columns[5].HeaderText = "Platforms BlockChain Platform";
                    cryptoGrid.Columns[6].HeaderText = "Number of Assets";

                    cryptoGrid.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    cryptoGrid.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    cryptoGrid.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    cryptoGrid.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    cryptoGrid.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    cryptoGrid.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    cryptoGrid.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    
                    foreach (DataRow row in dt.Rows)
                    {
                        cryptoGrid.Rows.Add(row.ItemArray);
                    }
                    cryptoGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
                }
                connection.Close();
            }


        }

        private void platMarketCapBtn_Click(object sender, EventArgs e)
        {
            cryptoGrid.Rows.Clear();
            cryptoGrid.Columns.Clear();
            errorLabel.Text = "";


            string query = "select blockchain_platform, sum(market_cap) as total_market_cap from cryptos group by blockchain_platform;";

            DataTable dt = new DataTable();

            using (MySqlConnection connection = new MySqlConnection(ConnectionStr))
            {
                MySqlCommand selectCommand = new MySqlCommand(query, connection);
                connection.Open();

                dt.Load(selectCommand.ExecuteReader());



                if (dt.Rows.Count == 0)
                {
                    errorLabel.Text = "something went wrong";
                }
                else
                {
                    errorLabel.Text = "This table is to show the total amount of market cap per blockchain platform.";

                    foreach (DataColumn dc in dt.Columns)
                    {
                        cryptoGrid.Columns.Add(new DataGridViewTextBoxColumn());

                    }

                    cryptoGrid.Columns[0].HeaderText = "Blockchain Platform";
                    cryptoGrid.Columns[1].HeaderText = "Total Market Cap of Blockchain Platform";


                    cryptoGrid.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    cryptoGrid.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;


                    foreach (DataRow row in dt.Rows)
                    {
                        cryptoGrid.Rows.Add(row.ItemArray);
                    }
                    cryptoGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
                }
                connection.Close();
            }

        }

        private void twoYearsBtn_Click(object sender, EventArgs e)
        {
            errorLabel.Text = "";
            cryptoGrid.Rows.Clear();
            cryptoGrid.Columns.Clear();

            string query = "select crypto_name,date_release from cryptos where datediff(now(),date_release) < (365*2);";

            DataTable dt = new DataTable();

            using (MySqlConnection connection = new MySqlConnection(ConnectionStr))
            {
                MySqlCommand selectCommand = new MySqlCommand(query, connection);
                connection.Open();

                dt.Load(selectCommand.ExecuteReader());



                if (dt.Rows.Count == 0)
                {
                    errorLabel.Text = "something went wrong";
                }
                else
                {
                    errorLabel.Text = "This table is to show cryptos that have been released in the past two years.";

                    foreach (DataColumn dc in dt.Columns)
                    {
                        cryptoGrid.Columns.Add(new DataGridViewTextBoxColumn());

                    }

                    cryptoGrid.Columns[0].HeaderText = "Crypto Name";
                    cryptoGrid.Columns[1].HeaderText = "Date Released";



                    cryptoGrid.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    cryptoGrid.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;


                    foreach (DataRow row in dt.Rows)
                    {
                        cryptoGrid.Rows.Add(row.ItemArray);
                    }
                    cryptoGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
                }
                connection.Close();
            }
        }

        private void avgSupplyBtn_Click(object sender, EventArgs e)
        {
            errorLabel.Text = "";
            cryptoGrid.Rows.Clear();
            cryptoGrid.Columns.Clear();

            string query = "select cryptos.crypto_name,circulating_supply,avg as avgergaeSupply from cryptos join (select crypto_name,avg(circulating_supply) as avg from cryptos) as t where cryptos.circulating_supply > t.avg;";

            DataTable dt = new DataTable();

            using (MySqlConnection connection = new MySqlConnection(ConnectionStr))
            {
                MySqlCommand selectCommand = new MySqlCommand(query, connection);
                connection.Open();

                dt.Load(selectCommand.ExecuteReader());



                if (dt.Rows.Count == 0)
                {
                    errorLabel.Text = "something went wrong";
                }
                else
                {
                    errorLabel.Text = "This table is to shows cryptos with a higher number of circulating supply than the average ciruclating supply";

                    foreach (DataColumn dc in dt.Columns)
                    {
                        cryptoGrid.Columns.Add(new DataGridViewTextBoxColumn());

                    }

                    cryptoGrid.Columns[0].HeaderText = "Crypto Name";
                    cryptoGrid.Columns[1].HeaderText = "Circulating Supply";
                    cryptoGrid.Columns[2].HeaderText = "Average Circulating Supply";


                    cryptoGrid.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    cryptoGrid.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    cryptoGrid.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;


                    foreach (DataRow row in dt.Rows)
                    {
                        cryptoGrid.Rows.Add(row.ItemArray);
                    }
                    cryptoGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
                }
                connection.Close();
            }
        }
    }
}
