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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;
using VP_Project.menu;

namespace VP_Project.home
{
    public partial class CreateNewAccount : Form
    {
        DateTime DOB;
        public CreateNewAccount()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void CustomerNameLBL_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void CreateNewAccount_Load(object sender, EventArgs e)
        {

        }

        private void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {
             DOB = dateTimePicker.Value;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string name = NametextBox.Text;
            int cnic = Convert.ToInt32(CNICtextBox.Text);
            int phoneNo = Convert.ToInt32(PhoneNotextBox.Text);
            string email = EmailtextBox.Text;
            string address = AddresstextBox.Text;
            string query = "INSERT INTO custTable (name, cnic, phoneNo, email, address, dob) " +
               "VALUES (@Name, @CNIC, @PhoneNo, @Email, @Address, @DOB)";
            string str = @"Data Source=DESKTOP-LRD7VGB; Initial Catalog=project; Integrated Security=True;";

            using (SqlConnection connection = new SqlConnection(str))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Set up the parameters
                    command.Parameters.AddWithValue("@name", name);
                    command.Parameters.AddWithValue("@cnic", cnic);
                    command.Parameters.AddWithValue("@phoneno", phoneNo);
                    command.Parameters.AddWithValue("@email", email);
                    command.Parameters.AddWithValue("@address", address);
                    command.Parameters.AddWithValue("@dob", DOB);

                    // Open the connection
                    connection.Open();

                    // Execute the query
                    command.ExecuteNonQuery();

                    // Close the connection
                    connection.Close();

                    // Show a success message or perform any other actions
                    MessageBox.Show("Data inserted successfully!", "Insert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            this.Hide();
            home.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
