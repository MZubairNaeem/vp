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

    public partial class CustomersDetails : Form
    {
        string str = @"Data Source=DESKTOP-LRD7VGB; Initial Catalog=project; Integrated Security=True;";
        public CustomersDetails()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void deleteBTN_Click(object sender, EventArgs e)
        {
            DataTable customerTable = new DataTable();
            customerTable.Columns.Add("Name", typeof(string));
            customerTable.Columns.Add("CNIC", typeof(string));
            customerTable.Columns.Add("PhoneNo", typeof(string));
            customerTable.Columns.Add("Email", typeof(string));
            customerTable.Columns.Add("Address", typeof(string));
            customerTable.Columns.Add("DOB", typeof(DateTime));
            using (SqlConnection connection = new SqlConnection(str))
            {
                string query = "SELECT * FROM custTable";  // Replace with your actual table name

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();

                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        string name = reader["name"].ToString();
                        string cnic = reader["cnic"].ToString();
                        string phoneNo = reader["phoneno"].ToString();
                        string email = reader["email"].ToString();
                        string address = reader["address"].ToString();
                        DateTime dob = Convert.ToDateTime(reader["dob"]);

                        customerTable.Rows.Add(name, cnic, phoneNo, email, address, dob);
                    }

                    reader.Close();
                    connection.Close();
                }
            }
            CustomersDataGridView.DataSource = customerTable;  // Replace dataGridView1 with your actual DataGridView control name


        }
    }
}
