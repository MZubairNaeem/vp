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

namespace VP_Project.home
{
    public partial class ApplyForCheckBook : Form
    {
        string str = @"Data Source=DESKTOP-LRD7VGB; Initial Catalog=project; Integrated Security=True;";
        public ApplyForCheckBook()
        {
            InitializeComponent();
        }

        private void ApplyBTN_Click(object sender, EventArgs e)
        {

            string name = NametextBox.Text;
            int cnic = Convert.ToInt32(CNICtextBox.Text);
            int acc = Convert.ToInt32(acctextBox.Text);
            string query = "INSERT INTO checkbookTable (name, cnic, accno) " +
               "VALUES (@name, @cnic,  @accno)";

            using (SqlConnection connection = new SqlConnection(str))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Set up the parameters
                    command.Parameters.AddWithValue("@name", name);
                    command.Parameters.AddWithValue("@cnic", cnic);
                    command.Parameters.AddWithValue("@accno", acc);

                    // Open the connection
                    connection.Open();

                    // Execute the query
                    command.ExecuteNonQuery();

                    // Close the connection
                    connection.Close();

                    // Show a success message or perform any other actions
                    MessageBox.Show("CheckBook applied successfully!", "Insert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            this.Hide();
            home.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
