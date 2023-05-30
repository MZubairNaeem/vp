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

namespace VP_Project.home
{
    public partial class Loan : Form
    {
        string str = @"Data Source=DESKTOP-LRD7VGB; Initial Catalog=project; Integrated Security=True;";
        public Loan()
        {
            InitializeComponent();
        }

        private void Loan_Load(object sender, EventArgs e)
        {

        }

        private void ApplyLoanBTN_Click(object sender, EventArgs e)
        {
            string name = NametextBox.Text;
            int cnic = Convert.ToInt32(CNICtextBox.Text);
            int phoneNo = Convert.ToInt32(PhoneNotextBox.Text);
            int amount = Convert.ToInt32(amounttextBox.Text);
            string query = "INSERT INTO loadTable (name, cnic, amount,phoneno) " +
               "VALUES (@name, @cnic,  @amount, @phoneno)";

            using (SqlConnection connection = new SqlConnection(str))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Set up the parameters
                    command.Parameters.AddWithValue("@name", name);
                    command.Parameters.AddWithValue("@cnic", cnic);
                    command.Parameters.AddWithValue("@phoneno", phoneNo);
                    command.Parameters.AddWithValue("@amount", amount);

                    // Open the connection
                    connection.Open();

                    // Execute the query
                    command.ExecuteNonQuery();

                    // Close the connection
                    connection.Close();

                    // Show a success message or perform any other actions
                    MessageBox.Show("Load applied successfully!", "Insert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
