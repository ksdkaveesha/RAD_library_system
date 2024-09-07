using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    public partial class dashboard : Form
    {
        public dashboard()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Logout()
        {
            // Close the current dashboard form
            this.Close();

            // Show the login form again
            Form1 loginForm = new Form1();
            loginForm.Show();


        }

        private void btnlogout_Click(object sender, EventArgs e)
        {
            Logout();
        }

        private string loggedInUsername;
        public dashboard(string username)
        {
            InitializeComponent();
            loggedInUsername = username;
            ShowUsername();  // Call a method to display the username
        }

        private void ShowUsername()
        {
            // Assuming you have a Label named lblUsername on the dashboard form
            welcomelbl.Text = "Welcome, " + loggedInUsername + "!";
        }

        private void welcomelbl_Click(object sender, EventArgs e)
        {

        }

        private void dashboard_Load(object sender, EventArgs e)
        {

        }

        private void btnaddbook_Click(object sender, EventArgs e)
        {
            this.Close();
            add_book add = new add_book(loggedInUsername);
            add.Show();
        }
    }
}
