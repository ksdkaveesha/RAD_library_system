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
    public partial class view_book : Form
    {
        private dashboard dashboard;
        public view_book(dashboard das)
        {
            InitializeComponent();
            this.dashboard = das;
        }

        private void label5_Click(object sender, EventArgs e)
        {
            dashboard.panel5.BackColor = Color.LightSalmon;
            this.Close();
        }

        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=F:\\github\\RAD_library_system\\Library\\Library\\library.mdf;Integrated Security=True");

        private void view_book_Load(object sender, EventArgs e)
        {
            try
            {
                con.Open();

                // Query to select all books
                string query = "SELECT BookId, Title, Author, AvailableCopies FROM Books";
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);

                // Bind the data to the DataGridView
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
            dataGridView1.Columns[0].HeaderText = "Book ID";
            dataGridView1.Columns[1].HeaderText = "Title";
            dataGridView1.Columns[2].HeaderText = "Author";
            dataGridView1.Columns[3].HeaderText = "Available Copies";
        }

        private void button5_Click(object sender, EventArgs e)
        { //search
            if (string.IsNullOrEmpty(txtsearch.Text))
            {
                MessageBox.Show("Please enter a book title to search.");
                view_book_Load(sender, e);
                return;
            }

            try
            {
                con.Open();

                // SQL query to select books with titles containing the search text
                string query = "SELECT BookId, Title, Author, AvailableCopies FROM Books WHERE LOWER(Title) LIKE '%' + LOWER('" + txtsearch.Text + "') + '%'";
                SqlCommand cmd = new SqlCommand(query, con);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    dataGridView1.DataSource = dt;
                    dataGridView1.Columns[0].HeaderText = "Book ID";
                    dataGridView1.Columns[1].HeaderText = "Title";
                    dataGridView1.Columns[2].HeaderText = "Author";
                    dataGridView1.Columns[3].HeaderText = "Available Copies";
                }
                else
                {
                    MessageBox.Show("No books found with that title.");
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                txtbookid.Text = row.Cells["BookId"].Value.ToString();
                txttitle.Text = row.Cells["Title"].Value.ToString();
                txtauthor.Text = row.Cells["Author"].Value.ToString();
                txtavailablecopies.Text = row.Cells["AvailableCopies"].Value.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        { //update section
            try
            {
                con.Open();

                string query = "UPDATE Books SET Title = '" + txttitle.Text + "', Author = '" + txtauthor.Text + "', AvailableCopies = '" + txtavailablecopies.Text + "' WHERE BookId = '" + txtbookid.Text + "'";
                SqlCommand cmd = new SqlCommand(query, con);

                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Book updated successfully!");
                }
                else
                {
                    MessageBox.Show("Update failed!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                con.Close();
                view_book_Load(sender, e);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        { //delete section
            try
            {
                con.Open();

                string query = "DELETE FROM Books WHERE BookId = '"+txtbookid.Text+"'";
                SqlCommand cmd = new SqlCommand(query, con);

                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Book deleted successfully!");
                    txtbookid.Clear();
                    txttitle.Clear();
                    txtauthor.Clear();
                    txtavailablecopies.Clear();
                }
                else
                {
                    MessageBox.Show("Delete failed!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                con.Close();
                view_book_Load(sender, e);
            }
        }
    }
}
