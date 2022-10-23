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
    public partial class DRIVER : Form
    {
        public DRIVER()
        {
            InitializeComponent();
        }

        // =========================================================DATABASE CONNECTION===========================================================================
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
                // If there was an error whiles  connecting to the database
                // We will show a message box that has the error message
                MessageBox.Show("MySQL Connection! \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return connection;
        }


        // =========================================================START INSERT INTO===========================================================================

       
        

        private void ADD_BTN_Click(object sender, EventArgs e)
        {


            

            string sql = "INSERT INTO drivertb (Id,Fname,Lname,contact,Dob) VALUES ('" + this.Id.Text + "','" + this.Fname.Text + "','" + 
                this.Lname.Text + "','" + this.contact.Text + "','" + this.Dob.Text + "');";
            // Create a connection object
            MySqlConnection con = GetSqlConnection();

            // Create a command object
            MySqlCommand cmd = new MySqlCommand(sql, con);

            object ID = null;
            // Add the values to the placeholders. The values that will assigned will replace the placeholders
            cmd.Parameters.Add("@Id", MySqlDbType.Int16).Value = Id;
            cmd.Parameters.Add("@Fname", MySqlDbType.VarChar).Value = Fname;
            cmd.Parameters.Add("@Lname", MySqlDbType.VarChar).Value = Lname;
            cmd.Parameters.Add("@contact", MySqlDbType.Int16).Value = contact;
            cmd.Parameters.Add("@Dob", MySqlDbType.Date).Value = Dob;

            try
            {
                // Execute the command
                // The ExecuteNonQuery method is used to execute a SQL statement that does not return any data
                cmd.ExecuteNonQuery();
                // Show a message box that the contact was added successfully
                MessageBox.Show(" Data is saved successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        }



        // =========================================================END  INSERT INTO===========================================================================






        // =========================================================START UPDATE===========================================================================

       
private void Up_btn_Click(object sender, EventArgs e)
        {


            string connectionString = "datasource=localhost;port=3306;username=root;password=Rock1844;database=transport";

            // Create an instance of MySqlConnection. Pass the connection string as an arguement to contructor of the MySqlConnection class
            MySqlConnection connection = new MySqlConnection(connectionString);
            

            string sql = "UPDATE drivertb SET Id ='" + this.Id.Text + "',Fname='" + this.Fname.Text + "',Lname='" + this.Lname.Text + "',contact='" + this.contact.Text + "',Dob='" + this.Dob.Text + "' WHERE Id=  @Id ";
            // Create a connection object
           MySqlConnection con = GetSqlConnection();

            MySqlCommand cmd = new MySqlCommand(sql, con);
            // Create a command object

            cmd.Parameters.AddWithValue("@Id", Id.Text);
            cmd.Parameters.AddWithValue("@First name", Fname.Text);
            cmd.Parameters.AddWithValue("@Last name", Lname.Text);
            cmd.Parameters.AddWithValue("@contact", contact.Text);
            cmd.Parameters.AddWithValue("@Date of Birth", Dob.MaxDate);



            try
            {
                cmd.ExecuteNonQuery();

                // Show a message box that the contact was added successfully
                MessageBox.Show(" Data Updated Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        }
    

        // =========================================================UPDATE End===========================================================================



        // =========================================================START  DELETE===========================================================================


        private void Delete_btn_Click(object sender, EventArgs e)
        {

          //string sql = "DELETE FROM drivertb  WHERE Id= '" + this.Id.Text + "','" +this.Fname.Text + "','" + this.Lname.Text + "','" + this.contact.Text + "','" + this.Dob.Text + "';";
           string sql = "DELETE FROM drivertb  WHERE Id = @Id";
            // Create a connection object
            MySqlConnection con = GetSqlConnection();

            // Create a command object
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@Id",Id.Text);

           

            try
            {
                // Execute the command
                // The ExecuteNonQuery method is used to execute a SQL statement that does not return any data
                cmd.ExecuteNonQuery();
                // Show a message box that the contact was added successfully
                MessageBox.Show(" Data is Deleted Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        }
    

        // =========================================================END  DELETE===========================================================================

        
        // =============================================================Display  gridView=======================================================================
        public void QueeryData(DataGridView gridView)
        {
            // SQL statement to query all the data from the contacts table
            string query = "SELECT * FROM drivertb";

            // Create a connection object
            MySqlConnection con = GetSqlConnection();

            // Create a command object
            MySqlCommand cmd = new MySqlCommand(query, con);

            try
            {
                
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);

                // Create a data table object
                DataTable table = new DataTable();

                
                adapter.Fill(table);

                // Set the data source of the DataGridView to the data table
                gridView.DataSource = table;
            }
            catch (MySqlException ex)
            {
                // If there was an error whiles  connecting to the database
                MessageBox.Show("MySQL Connection! \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Close the connection
                con.Close();
            }
        }

        // =========================================================END ===========================================================================


        private void Form1_Shown(object sender, EventArgs e)
        {
            // Call the QueryData method to populate the DataGridView with the data from the database
            this.QueeryData(this.dataGridView1);
        }

     
        // ------------------------------------------------------END --------------------------------------------------


        // ------------------------------------------------------Buttons --------------------------------------------------
        private void refresh_btn_Click(object sender, EventArgs e)
        {
            // Call the QueryData method to populate the DataGridView with the data from the database
            this.QueeryData(this.dataGridView1);
        }

        

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Admin
            admin = new Admin();
            admin.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            BUS
            bus = new BUS();
            bus.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            DISTINATION
            destination = new DISTINATION();
            destination.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            TICKET2
           ticket2 = new TICKET2();
            ticket2.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PASSENGER
            passenger = new PASSENGER();
            passenger.Show();
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button_CLEAR_Click(object sender, EventArgs e)
        {
          
        }

        private void CLEAR_BTN_Click(object sender, EventArgs e)
        {
            Id.Text = "";
            Fname.Text = "";
            Lname.Text = "";
            contact.Text = "";
        }

        private void DRIVER_Load(object sender, EventArgs e)
        {

        }
    }

}   

