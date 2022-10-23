using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Transport_System
{
    public partial class Ticket : Form
    {
        public Ticket()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Home
            Form1 = new Home();
            Form1.Show();
            this.Hide();
            MessageBox.Show("Log Out Successfully");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*comboBox1.Items.Add("ACCRA");
            comboBox1.Items.Add("KUMASI");
            comboBox1.Items.Add("TECHIMAN");
            comboBox1.Items.Add("SUNYANI");
            comboBox1.Text = "Select Station";*/
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
        

            /* SaveFileDialog savefile = new SaveFileDialog();
             savefile.RestoreDirectory = true;
             savefile.Title = "Save Ticket";
             savefile.InitialDirectory = "D:\\C# Projects";
             savefile.FileName = String.Format("{0}.txt", txtidstruk.Text);
             savefile.DefaultExt = "*.txt";
             savefile.Filter = "TEXT Files|*.txt";

             if (savefile.ShowDialog() == DialogResult.OK)
             {
                 using (System.IO.StreamWriter sw = new System.IO.StreamWriter(savefile.FileName)) sw.WriteLine(rtfReceipt.Text);
             }  */
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void namelbl_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            String Destination = To.Text;
            String Date = date1.Text;
            String No_Seat = seat.Text;
            String Contact = contact.Text;

            try
            {
                if (male.Checked == true & mtn.Checked== true)
                {

                 display.Text= ("                              TICKET DETAILS\n=========================================== \n\n" +
                   "From:  SOFOLINE BUS STATION \n***********************************************************\n\n" + 
                    "To :" + Destination + "\n***********************************************************\n\n" + 
                    "Date: " + Date + "\n***********************************************************\n\n" +
                    "Gender : Male" + "\n***********************************************************\n\n" + 
                    "No of Seats: " + No_Seat + "\n***********************************************************\n\n" + 
                    "Contact : " + Contact + "\n***********************************************************\n\n" + 
                    "Mode of Payment : MTN");

                }
                else if (female.Checked == true & mtn.Checked == true)
                    {
                    display.Text = ("                           TICKET DETAILS\n=========================================== \n\n" +
                   "From:  SOFOLINE BUS STATION \n***********************************************************\n\n" +
                    "To :" + Destination + "\n***********************************************************\n\n" +
                    "Date: " + Date + "\n***********************************************************\n\n" +
                    "Gender : Female" + "\n***********************************************************\n\n" +
                    "No of Seats: " + No_Seat + "\n***********************************************************\n\n" +
                    "Contact : " + Contact + "\n***********************************************************\n\n" +
                    "Mode of Payment : MTN");
                }
                else if (female.Checked == true & vcash.Checked == true)
                {
                    display.Text = ("                            TICKET DETAILS\n=========================================== \n\n" +
                   "From:  SOFOLINE BUS STATION \n***********************************************************\n\n" +
                    "To :" + Destination + "\n***********************************************************\n\n" +
                    "Date: " + Date + "\n***********************************************************\n\n" +
                    "Gender : Female" + "\n***********************************************************\n\n" +
                    "No of Seats: " + No_Seat + "\n***********************************************************\n\n" +
                    "Contact : " + Contact + "\n***********************************************************\n\n" +
                    "Mode of Payment : Vodafone Cash");
                }

                else if (male.Checked == true & vcash.Checked == true)
                {

                    display.Text = ("                            TICKET DETAILS\n=========================================== \n\n" +
                      "From:  SOFOLINE BUS STATION \n***********************************************************\n\n" +
                       "To :" + Destination + "\n***********************************************************\n\n" +
                       "Date: " + Date + "\n***********************************************************\n\n" +
                       "Gender : Male" + "\n***********************************************************\n\n" +
                       "No of Seats: " + No_Seat + "\n***********************************************************\n\n" +
                       "Contact : " + Contact + "\n***********************************************************\n\n" +
                       "Mode of Payment : Vodafone Cash");

                }

                else if (male.Checked == true & tigo.Checked == true)
                {

                    display.Text = ("                                 TICKET DETAILS\n=========================================== \n\n" +
                      "From:  SOFOLINE BUS STATION \n***********************************************************\n\n" +
                       "To :" + Destination + "\n***********************************************************\n\n" +
                       "Date: " + Date + "\n***********************************************************\n\n" +
                       "Gender : Male" + "\n***********************************************************\n\n" +
                       "No of Seats: " + No_Seat + "\n***********************************************************\n\n" +
                       "Contact : " + Contact + "\n***********************************************************\n\n" +
                       "Mode of Payment : AirtelTigo");

                }
                else if (female.Checked == true & tigo.Checked == true)
                {
                    display.Text = ("                                TICKET DETAILS\n=========================================== \n\n" +
                   "From:  SOFOLINE BUS STATION \n***********************************************************\n\n" +
                    "To :" + Destination + "\n***********************************************************\n\n" +
                    "Date: " + Date + "\n***********************************************************\n\n" +
                    "Gender : Female" + "\n***********************************************************\n\n" +
                    "No of Seats: " + No_Seat + "\n***********************************************************\n\n" +
                    "Contact : " + Contact + "\n***********************************************************\n\n" +
                    "Mode of Payment : AirtelTigo");
                }

                else if (Name=="" | Destination=="" | Contact == "")
                {
                    MessageBox.Show("All Fields Required !!!");
                }
                else
                {
                    MessageBox.Show("ERROR!");
                } 
            }
            catch
            {
                MessageBox.Show("Inalid Input");
            }
        }

        private void Ticket_Load(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
