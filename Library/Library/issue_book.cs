using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    public partial class issue_book : Form
    {
        private dashboard dashboard;
        public issue_book(string username, dashboard das)
        {
            InitializeComponent();
            this.dashboard = das;
        }

        private void issue_book_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=F:\\github\\RAD_library_system\\Library\\Library\\library.mdf;Integrated Security=True");

            // Open the connection
            con.Open();

            // Check if the book already exists in the 'Books' table
            SqlCommand checkbook = new SqlCommand("SELECT * FROM Books", con);

            SqlDataAdapter userdata = new SqlDataAdapter(checkbook);
            DataSet ds = new DataSet();
            userdata.Fill(ds);

            if (ds.Tables[0].Rows.Count == 0)
            {
                MessageBox.Show("No Books Available for Issue");
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Close();
            dashboard.panel3.BackColor = Color.LightSalmon;
        }

        private string GenerateBorrowBookID()
        {
            // Random number generator
            Random random = new Random();

            // Generate 5 random digits
            string numbers = random.Next(10000, 99999).ToString(); // 5 digits

            string letters = "BH";            

            // Combine numbers and letters
            string borrowBookID = letters + numbers;

            return borrowBookID;
        }

        private void issuebook_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=F:\\github\\RAD_library_system\\Library\\Library\\library.mdf;Integrated Security=True");

            try
            {
                // Open the connection
                con.Open();

                // Check if the book exists and retrieve its details
                SqlCommand checkbook = new SqlCommand("SELECT * FROM Books WHERE BookId = '"+ txtbookid.Text + "'", con);

                SqlDataAdapter userdata = new SqlDataAdapter(checkbook);
                DataSet ds = new DataSet();
                userdata.Fill(ds);

                // Check if the dataset has any rows (i.e., if the book exists)
                if (ds.Tables[0].Rows.Count == 0)
                {
                    MessageBox.Show("Book not found!");
                    return;
                }

                // Get available copies
                int availableCopies = Convert.ToInt32(ds.Tables[0].Rows[0]["AvailableCopies"]);

                // Check if there are no available copies
                if (availableCopies == 0)
                {
                    MessageBox.Show("No Books Available for Issue");
                }
                else
                {
                    // Generate the borrow ID and other details
                    string borrowid = GenerateBorrowBookID();
                    DateTime issueDate = DateTime.Now;  // Issue date is today
                    DateTime returnDate = issueDate.AddDays(14);  // Return date is 14 days after issue date

                    TimeSpan remainingDays = returnDate - DateTime.Now;
                    int dueDays = remainingDays.Days;

                    // Late fee logic (charge Rs. 2 for each day late)
                    string lateFee = "0";
                    if (dueDays < 0)
                    {
                        lateFee = (Math.Abs(dueDays) * 2).ToString();  // Rs. 2 per day late
                    }

                    // Format the dates to MM/DD/YYYY format
                    string issueDateString = issueDate.ToString("MM/dd/yyyy");
                    string returnDateString = "Ongoing";

                    string dueDateString = returnDateString;  // Due date is same as return date for now

                    // Insert a record into the BorrowedBooks table
                    SqlCommand addbook = new SqlCommand("INSERT INTO BorrowedBooks (BorrowId, BookId, IssueDate, ReturnDate, DueDate, LateFee, MemberId, MemberPhone, MemberName, MemberAddress) VALUES (@borrowid, @bookid, @issuedate, @returndate, @duedate, @latefee, @memberid, @memberphone, @membername, @memberaddress)", con);

                    // Add parameters
                    addbook.Parameters.AddWithValue("@borrowid", borrowid);
                    addbook.Parameters.AddWithValue("@bookid", txtbookid.Text);
                    addbook.Parameters.AddWithValue("@issuedate", issueDateString);
                    addbook.Parameters.AddWithValue("@returndate", returnDateString);
                    addbook.Parameters.AddWithValue("@duedate", dueDateString);
                    addbook.Parameters.AddWithValue("@latefee", lateFee);
                    addbook.Parameters.AddWithValue("@memberid", txtmemberid.Text);
                    addbook.Parameters.AddWithValue("@memberphone", txtmemberphone.Text);
                    addbook.Parameters.AddWithValue("@membername", txtmembername.Text);
                    addbook.Parameters.AddWithValue("@memberaddress", txtmemberaddress.Text);

                    // Execute the insert query
                    addbook.ExecuteNonQuery();

                    int updatedbooks = availableCopies - 1;
                    // Update available copies in the Books table
                    SqlCommand updateBookCopies = new SqlCommand("UPDATE Books SET AvailableCopies = '" + updatedbooks + "' WHERE BookId = '"+ txtbookid.Text + "'", con);

                    // Execute the update query
                    updateBookCopies.ExecuteNonQuery();

                    MessageBox.Show("Book issued successfully!");
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


    }
}
