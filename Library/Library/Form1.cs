using System.Data;
using System.Data.SqlClient;

namespace Library
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=F:\\github\\RAD_library_system\\Library\\Library\\library.mdf;Integrated Security=True"))
            {
                SqlCommand cmd = new SqlCommand("SELECT role FROM [User] WHERE username = @username AND password = @password", con);

                // Use parameters to avoid SQL Injection
                cmd.Parameters.AddWithValue("@username", username.Text);
                cmd.Parameters.AddWithValue("@password", password.Text);

                con.Open();
                SqlDataAdapter logincmd = new SqlDataAdapter(cmd);
                DataSet logindataset = new DataSet();
                logincmd.Fill(logindataset);

                // Check if login is successful
                if (logindataset.Tables[0].Rows.Count > 0)
                {
                    // Retrieve the role of the user from the dataset
                    string role = logindataset.Tables[0].Rows[0]["role"].ToString();

                    if (role == "admin")
                    {
                        MessageBox.Show("Login Successful as Admin");

                        dashboard dashboardForm = new dashboard(username.Text);
                        dashboardForm.Show();
                        this.Hide();  // Hide the login form
                    }
                    else
                    {
                        MessageBox.Show("Login Successful as User");
                        this.Hide();
                    }
                }
                else
                {
                    MessageBox.Show("Invalid Username or Password");
                }

                con.Close();
            }
        }
    }
}
