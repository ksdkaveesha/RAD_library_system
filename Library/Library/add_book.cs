using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Library
{
    public partial class add_book : Form
    {
        private void add_book_Load(object sender, EventArgs e)
        {
        }

        private dashboard dasboard;
        public add_book(string username, dashboard das)
        {
            InitializeComponent();
            this.dasboard = das;
        }

        private void label5_Click(object sender, EventArgs e)
        {
            // Close the current dashboard form
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void reset_Click(object sender, EventArgs e)
        {
            txtbookid.Text = "";
            txttitle.Text = "";
            txtauthor.Text = "";
            txtavailablecopies.Text = "";
        }

        private void addbook_Click(object sender, EventArgs e)
        {
            // Get values from input fields
            string bookid = txtbookid.Text;
            string title = txttitle.Text;
            string author = txtauthor.Text;
            string availablecopies = txtavailablecopies.Text;

            // Connection string to your database
            SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=F:\\github\\RAD_library_system\\Library\\Library\\library.mdf;Integrated Security=True");

            try
            {
                // Open the connection
                con.Open();

                // Check if the book already exists in the 'Books' table
                SqlCommand checkbook = new SqlCommand("SELECT * FROM Books WHERE bookid = '"+bookid+"'", con);

                SqlDataAdapter userdata = new SqlDataAdapter(checkbook);
                DataSet ds = new DataSet();
                userdata.Fill(ds);

                // If book exists, show a message
                if (ds.Tables[0].Rows.Count > 0)
                {
                    MessageBox.Show("The Book already exists");
                }
                else
                {
                    // Add a new book using SQL parameters (safe from SQL injection)
                    SqlCommand addbook = new SqlCommand("INSERT INTO Books (bookid, title, author, availablecopies) VALUES ('"+bookid+"', '"+title+"', '"+author+"', '"+availablecopies+"')", con);

                    // Execute the insert query
                    addbook.ExecuteNonQuery();

                    MessageBox.Show("Book added successfully!");

                    txtbookid.Text = "";
                    txttitle.Text = "";
                    txtauthor.Text = "";
                    txtavailablecopies.Text = "";
                }
            }
            catch (Exception ex)
            {
                // Handle any errors that might occur
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                // Close the connection
                con.Close();
            }
        }

        private void label5_Click_1(object sender, EventArgs e)
        {
            dasboard.panel2.BackColor = Color.LightSalmon;
            Close();  // Close the current form
        }
    }
}
