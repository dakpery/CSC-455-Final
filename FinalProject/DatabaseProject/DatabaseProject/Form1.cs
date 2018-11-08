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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void readDatabase()
        {
            string queryStr = "Select * FROM course_table;";


            string ConnectionStr = "server=localhost; uid=root; pwd=Deepw00d; database=Courses";
            using (MySqlConnection connection = new MySqlConnection(ConnectionStr))
            {
                MySqlCommand command = new MySqlCommand(queryStr, connection);
                connection.Open();
                try
                {
                    MySqlDataReader reader = command.ExecuteReader();




                } finally
                {
                    connection.Close();
                }
            }





        }

        private void createUserBtn_Click(object sender, EventArgs e)
        {
            CreateUser newUser = new CreateUser();
            newUser.Show();
        }

        private void signInBtn_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
        }
    }
}
