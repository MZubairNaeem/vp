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
using VP_Project.menu;

namespace VP_Project.auth
{
    public partial class Login : Form
    {
        string str = @"Data Source=DESKTOP-LRD7VGB; Initial Catalog=project; Integrated Security=True;";

        public Login()
        {
            InitializeComponent();
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {
            emailtextBox.Text = "Enter your email";
            passtextBox.Text = "Enter your password";
            emailtextBox.ForeColor = Color.Gray;
            passtextBox.ForeColor = Color.Gray;
        }

        private void emailtextBox_Enter(object sender, EventArgs e)
        {
            if (emailtextBox.Text == "Enter your email")
            {
                emailtextBox.Text = "";
                emailtextBox.ForeColor = Color.Black;
            }
        }

        private void passtextBox_Enter(object sender, EventArgs e)
        {
            if (passtextBox.Text == "Enter your password")
            {
                passtextBox.Text = "";
                passtextBox.ForeColor = Color.Black;
            }
        }

        private void Login_Enter(object sender, EventArgs e)
        {

        }

        private void Login_Leave(object sender, EventArgs e)
        {

        }

        private void emailtextBox_Leave(object sender, EventArgs e)
        {
            if (emailtextBox.Text == "")
            {
                emailtextBox.Text = "Enter your email";
                emailtextBox.ForeColor = Color.Gray;
            }
        }

        private void passtextBox_Leave(object sender, EventArgs e)
        {
            if (passtextBox.Text == "")
            {
                passtextBox.Text = "Enter your password";
                passtextBox.ForeColor = Color.Gray;
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            this.Hide();
            register.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void emailtextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Login_Load_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*SqlConnection sqlConn = new SqlConnection(str);
            string query = "select * from tblUser email = '" + emailtextBox.Text.Trim() + "' and password = '" + passtextBox.Text.Trim() + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, sqlConn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if(dt.Rows.Count == 1 ) 
            {
                Home home = new Home();
                this.Hide();
                home.Show();
            }
            else
            {
                emailtextBox.Text = "";
                passtextBox.Text = "";
                MessageBox.Show("Incorrect Credentials or User Does'nt Exist");
            }*/

            string email = emailtextBox.Text;
            string password = passtextBox.Text;

            using (SqlConnection connection = new SqlConnection(str))
            {
                string query = "SELECT COUNT(*) FROM tblUser WHERE email = @email AND password = @password";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Set up the parameters
                    command.Parameters.AddWithValue("@email", email);
                    command.Parameters.AddWithValue("@password", password);

                    // Open the connection
                    connection.Open();

                    // Execute the query and get the result
                    int count = (int)command.ExecuteScalar();

                    // Close the connection
                    connection.Close();

                    // Check the validity of the credentials
                    if (count > 0)
                    {
                        // Successful login
                        Home home = new Home();
                        this.Hide();
                        home.Show();
                        // Navigate to the main application form or perform any other actions
                    }
                    else
                    {
                        // Invalid login
                        MessageBox.Show("Invalid email or password.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void label6_Click_1(object sender, EventArgs e)
        {
            Register register = new Register();
            this.Hide();
            register.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
