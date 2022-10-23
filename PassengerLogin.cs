using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;

namespace Transport_System
{
    public partial class PassengerLogin : Form
    {
        public PassengerLogin()
        {
            InitializeComponent();
        }


        public MySqlConnection GetSqlConnection()
        {
            // Create a connection string that contains the basic information needed to connect to the database
            // THe string segmented into five section. The semi-colon separate the sections 
            string connectionString = "datasource=localhost;port=3306;username=root;password=Rock1844;database=transport";

            // Create an instance of MySqlConnection. Pass the connection string as an arguement to contructor of the MySqlConnection class
            MySqlConnection connection = new MySqlConnection(connectionString);

            // You can open the connection to test if the connection was successful or not
            try
            {
                // The Open method is invoked into connection object
                connection.Open();
                MessageBox.Show("Success!");

            }
            catch (MySqlException ex)
            {
                MessageBox.Show("MySQL Connection! \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return connection;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            PassengerSignUp
            PassengerSignUP = new PassengerSignUp();
            PassengerSignUP.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            String Email = EmailBox.Text;
            Email = Email.ToString();
            
            String Password = PwordBox.Text;
            string PEmail = "";
            string Pword = "";
            //string sql = @"Select PEmail, Pword from passengersignup where PEmail = PEmail";
            string sql = @"Select PEmail, Pword from passengersignup where PEmail= PEmail";
            MySqlConnection con = GetSqlConnection();
            

            
            try
            {

                MySqlCommand cmd = new MySqlCommand(sql, con);

                

                MySqlDataReader dataReader = cmd.ExecuteReader();

                
                while (dataReader.Read())
                {
                    PEmail = dataReader[0].ToString();
                    Pword = dataReader[1].ToString();
                }

                dataReader.Close();
                con.Close();

               
               

                if (Email == "" || Password == "")
                {
                    MessageBox.Show("All Fields Required!");
                }

                else
                {
                    if (Email == PEmail && Password == Pword)
                    {
                        Ticket
                        ticket = new Ticket();
                        ticket.Show();
                        this.Hide();
                    }

                    else
                    {
                        MessageBox.Show("OOPs Incorrect Data!!!");
                    }
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show( ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
