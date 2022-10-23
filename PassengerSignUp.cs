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

namespace Transport_System
{

    // ======================================================
    public partial class PassengerSignUp : Form
    {
        public PassengerSignUp()
        {
            InitializeComponent();
        }




        // ************************************************************************************************************
        

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
                MessageBox.Show("Database Connected");

            }
            catch (MySqlException ex)
            {
                MessageBox.Show("MySQL Connection! \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return connection;
        }
        // ============================================================ INSERT INTO ================================================
        private void button1_Click(object sender, EventArgs e)
        {

            string sql = "INSERT INTO passengersignup (Name,PEmail, Pword, CPword) VALUES ('" + this.Name.Text +  "','" + this.PEmail.Text + "','" + 
                this.Pword.Text + "','" + this.CPword.Text + "');";
            // Create a connection object
            MySqlConnection con = GetSqlConnection();

            // Create a command object
            MySqlCommand cmd = new MySqlCommand(sql, con);

            object ID = null;
            // Add the values to the placeholders. The values that will assigned will replace the placeholders
            cmd.Parameters.Add("@Name", MySqlDbType.VarChar).Value = Name;
            cmd.Parameters.Add("@PEmail", MySqlDbType.VarChar).Value =PEmail;
            cmd.Parameters.Add("@Pword", MySqlDbType.VarChar).Value = Pword;
            cmd.Parameters.Add("@CPword", MySqlDbType.VarChar).Value = CPword;
             

            try
            {
                // Execute the command
                // The ExecuteNonQuery method is used to execute a SQL statement that does not return any data
                cmd.ExecuteNonQuery();
                // Show a message box that the contact was added successfully
                MessageBox.Show(" Sign Up Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                // If there was an error whiles  connecting to the database
                // We will show a message box that has the error message
                MessageBox.Show("MySQL Connection! \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Close the connection
                con.Close();
            }   


        // ***********************************************************************************************************

       



            String name = Name.Text;
            String email = PEmail.Text;
            String password = Pword.Text;
            Pword.PasswordChar = '*';
            String cpassword = CPword.Text;
            CPword.PasswordChar = '*';

            try
            {
                if (name == "" | email == "" | password == "" | cpassword == "")
                {
                    MessageBox.Show("All Fields Are Required!");
                }
                else if (cpassword != password)
                {
                    MessageBox.Show("Password did not match!!!");
                }
                else
                {
                    Ticket
                    ticket = new Ticket();
                    ticket.Show();
                    this.Hide();

                }
            }
            catch
            {
                MessageBox.Show("OOPs Invalid Input!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PassengerLogin
            PassengerLogin_login = new PassengerLogin();
            PassengerLogin_login.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Home
            Form1 = new Home();
            Form1.Show();
            this.Hide();
            MessageBox.Show("Log Out Successfully");
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Home
            Form1 = new Home();
            Form1.Show();
            this.Hide();
            MessageBox.Show("Log Out Successfully");
        }

        private void PassengerSignUp_Load(object sender, EventArgs e)
        {

        }
    }
}
