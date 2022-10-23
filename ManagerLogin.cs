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
    public partial class ManagerLogin : Form
    {
        public ManagerLogin()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            String Username = "Admin";
            String Passwrd = "boss";
            // ================================================== Try statement ========================
            try
            {

                String username = textBox5.Text;
                String Password = textBox6.Text;
                textBox6.PasswordChar = '*';

                

                if (username == "" | Password == "")
                {
                    MessageBox.Show("All Fields are Required !!!");
                }

                else if (username != Username | Passwrd != Password)
                {
                    MessageBox.Show("Incorrect Password or Username !!!");
                }
                
                else
                {
                    Admin
                    AdminLogin = new Admin();
                    AdminLogin.Show();
                    this.Hide();
                }
            }
            
            // ================================================== Catch statement ========================
            catch
            {
                MessageBox.Show("Invalid Inputs!");
            }
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            Home
            Form1 = new Home();
            Form1.Show();
            this.Hide();
            MessageBox.Show("Log Out Successfully");

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Home
            Form1 = new Home();
            Form1.Show();
            this.Hide();
            MessageBox.Show("Log Out Successfully");
        }
    }
}
