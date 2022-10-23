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
    public partial class Admin : Form
    {
        public Admin()
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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Home
            Form1 = new Home();
            Form1.Show();
            this.Hide();
            MessageBox.Show("Log Out Successfully");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Home
            Form1 = new Home();
            Form1.Show();
            this.Hide();
            MessageBox.Show("Log Out Successfully");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            PASSENGER
            passenger = new PASSENGER();
            passenger.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            BUS
            Bus = new BUS();
            Bus.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            DRIVER
            Driver = new DRIVER();
            Driver.Show();
            this.Hide();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            TICKET2
            ticket2 = new TICKET2();
            ticket2.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            DISTINATION
            destination = new DISTINATION();
            destination.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
        // ========================================================================== passenger ==================================================================


        public void QueeryData(DataGridView gridView)
        {


            // SQL statement to query all the data from the bus table
            string query = "SELECT * FROM passenger";

            // Create a connection object
            MySqlConnection con = GetSqlConnection();
           
            MySqlCommand cmd = new MySqlCommand(query, con);
            // ==================================================

            try
            {

                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);

                DataTable table = new DataTable();
                adapter.Fill(table);
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
        private void passView_btn_Click(object sender, EventArgs e)
        {
            this.QueeryData(this.adminGrid);
        }


        // ========================================================================== driver ==================================================================


        public void QueeryDatadb(DataGridView gridView)
        {


            // SQL statement to query all the data from the  table
            string querydb = "SELECT * FROM drivertb";

            // Create a connection object
            MySqlConnection con = GetSqlConnection();

            MySqlCommand cmd = new MySqlCommand(querydb, con);
            // ==================================================

            try
            {

                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);

                DataTable table = new DataTable();
                adapter.Fill(table);
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
        private void driverView_btn_Click(object sender, EventArgs e)
        {

            
            this.QueeryDatadb(this.adminGrid);
        }


        // ================================================================ bus ============================================================================


        public void QueeryDataBus(DataGridView gridView)
        {


            // SQL statement to query all the data from the bus table
            string querybus = "SELECT * FROM bus";

            // Create a connection object
            MySqlConnection con = GetSqlConnection();

            MySqlCommand cmd = new MySqlCommand(querybus, con);
            // ==================================================

            try
            {

                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);

                DataTable table = new DataTable();
                adapter.Fill(table);
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

        private void busView_btn_Click(object sender, EventArgs e)
        {

            
            this.QueeryDataBus(this.adminGrid);

        }


        // =========================================================== ticket=================================================================================


        public void QueeryDatatk(DataGridView gridView)
        {


            // SQL statement to query all the data from the bus table
            string query = "SELECT * FROM ticket";

            // Create a connection object
            MySqlConnection con = GetSqlConnection();

            MySqlCommand cmd = new MySqlCommand(query, con);
            // ==================================================

            try
            {

                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);

                DataTable table = new DataTable();
                adapter.Fill(table);
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

        private void ticketView_btn_Click(object sender, EventArgs e)
        {
            this.QueeryDatatk(this.adminGrid);
        }


        // =========================================================== destination =================================================================================


        public void QueeryDatadest(DataGridView gridView)
        {


            // SQL statement to query all the data from the bus table
            string query = "SELECT * FROM destination";

            // Create a connection object
            MySqlConnection con = GetSqlConnection();

            MySqlCommand cmd = new MySqlCommand(query, con);
            // ==================================================

            try
            {

                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);

                DataTable table = new DataTable();
                adapter.Fill(table);
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

        private void dsetView_btn_Click(object sender, EventArgs e)
        {
            this.QueeryDatadest(this.adminGrid);
        }

        private void search_btn_Click(object sender, EventArgs e)
        {
            
        }

        private void seachBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void adminGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Admin_Load(object sender, EventArgs e)
        {

        }
    }
    }

    