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

namespace Library
{
    public partial class return_book : Form
    {
        private dashboard dashboard;
        public return_book(dashboard das)
        {
            InitializeComponent();
            this.dashboard = das;
        }

        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=F:\\github\\RAD_library_system\\Library\\Library\\library.mdf;Integrated Security=True");


        private void return_book_Load(object sender, EventArgs e)
        {
            txtbookid.Hide();
            lblbookid.Hide();
            lbllatefee.Hide();
            lblreturndate.Hide();
            txtreturndate.Hide();
            txtlatefee.Hide();
            btnrefresh.Hide();
            btnreturn.Hide();
            btncalculate.Hide();
            dataGridView1.Hide();
        }

        private void close_Click(object sender, EventArgs e)
        {
            dashboard.panel4.BackColor = Color.LightSalmon;
            this.Close();
        }

        private void btnrefresh_Click(object sender, EventArgs e)
        {
            return_book_Load(sender, e);
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtmemberid.Text))
            {
                MessageBox.Show("Enter Valid Member Id");
                return;
            }

            try
            {
                con.Open();

                string query = "SELECT BorrowId, BookId, IssueDate, ReturnDate, DueDate, LateFee, MemberId, MemberPhone, MemberName, MemberAddress FROM BorrowedBooks WHERE MemberId = '" + txtmemberid.Text + "'";
                SqlCommand cmd = new SqlCommand(query, con);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    dataGridView1.DataSource = dt;
                    dataGridView1.Columns[0].HeaderText = "BorrowID";
                    dataGridView1.Columns[1].HeaderText = "Book Id";
                    dataGridView1.Columns[2].HeaderText = "Issue Date";
                    dataGridView1.Columns[3].HeaderText = "Return Date";
                    dataGridView1.Columns[4].HeaderText = "Due Date";
                    dataGridView1.Columns[5].HeaderText = "Late Fee";
                    dataGridView1.Columns[6].HeaderText = "MemberId";
                    dataGridView1.Columns[7].HeaderText = "Mobile No.";
                    dataGridView1.Columns[8].HeaderText = "Name";
                    dataGridView1.Columns[9].HeaderText = "Address";

                    txtbookid.Show();
                    txtreturndate.Show();
                    txtlatefee.Show();
                    btnrefresh.Show();
                    btnreturn.Show();
                    btncalculate.Show();
                    dataGridView1.Show();
                    lblbookid.Show();
                    lbllatefee.Show();
                    lblreturndate.Show();

                    txtreturndate.Text = Convert.ToString(DateTime.Now.ToString("MM/dd/yyyy"));
                }
                else
                {
                    MessageBox.Show("No books found with that ID.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                con.Close();
            }

        }

        private void btncalculate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtbookid.Text) || string.IsNullOrEmpty(txtmemberid.Text))
            {
                MessageBox.Show("Enter Valid Book Id and Member Id");
                return;
            }
            else
            {
                try
                {
                    DateTime returnDate = Convert.ToDateTime(txtreturndate.Text);

                    // Query to get IssueDate for the specific member and book
                    string latefeequery = "SELECT IssueDate FROM BorrowedBooks WHERE MemberId = @MemberId AND BookId = @BookId";
                    SqlCommand latefeecmd = new SqlCommand(latefeequery, con);

                    // Using parameters for safer queries to prevent SQL injection
                    latefeecmd.Parameters.AddWithValue("@MemberId", txtmemberid.Text);
                    latefeecmd.Parameters.AddWithValue("@BookId", txtbookid.Text);

                    SqlDataAdapter latefeeda = new SqlDataAdapter(latefeecmd);
                    DataSet latefeeds = new DataSet();
                    latefeeda.Fill(latefeeds);

                    if (latefeeds.Tables[0].Rows.Count > 0)
                    {
                        DateTime issueDate = Convert.ToDateTime(latefeeds.Tables[0].Rows[0]["IssueDate"]);

                        // Calculate the difference in days between the return date and issue date
                        TimeSpan latedays = returnDate - issueDate;
                        int daysDifference = latedays.Days;

                        // Late fee logic (charge Rs. 2 for each day late)
                        string lateFee = "0";
                        if (daysDifference > 14)  // Assuming the due date is 14 days after issue date
                        {
                            int overdueDays = daysDifference - 14;  // Days beyond the 14-day loan period
                            lateFee = (overdueDays * 2).ToString();  // Rs. 2 per overdue day
                        }

                        txtlatefee.Text = lateFee;
                    }
                    else
                    {
                        MessageBox.Show("No record found for the given Book ID and Member ID");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
    }
}
