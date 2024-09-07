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
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=F:\\github\\RAD_library_system\\Library\\Library\\library.mdf;Integrated Security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            con.Open(); //open connection

            cmd.CommandText = "select * from [User] where username='"+username.Text+"' and password='"+password.Text+"'";
            SqlDataAdapter logincmd = new SqlDataAdapter(cmd);
            DataSet logindataset = new DataSet();
            logincmd.Fill(logindataset);


            if (logindataset.Tables[0].Rows.Count > 0)
            {
                string role = logindataset.Tables[0].Rows[0]["role"].ToString();

                // Check if the role is 'admin'
                if (role == "admin")
                {
                    MessageBox.Show("Login Successful as Admin");

                    // Redirect to the dashboard form
                    dashboard dashboardForm = new dashboard();
                    dashboardForm.Show();   // Show the dashboard form
                    this.Hide();  // Hide the login form
                }
                else
                {
                    MessageBox.Show("Login Successful as User");
                    MessageBox.Show("User Section Comming Soon");

                    Form1 form1 = new Form1();
                    form1.Show(); // Hide the login form
                }
            }
            else
            {
                MessageBox.Show("Invalid Username or Password");
            }

            con.Close(); //close connection
        }
    }
}
