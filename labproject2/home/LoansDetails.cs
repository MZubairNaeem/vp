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
    public partial class LoansDetails : Form
    {
        string str = @"Data Source=DESKTOP-LRD7VGB; Initial Catalog=project; Integrated Security=True;";
        public LoansDetails()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable customerTable = new DataTable();
            customerTable.Columns.Add("Name", typeof(string));
            customerTable.Columns.Add("CNIC", typeof(string));
            customerTable.Columns.Add("PhoneNo", typeof(string));
            customerTable.Columns.Add("Amount", typeof(string));
            using (SqlConnection connection = new SqlConnection(str))
            {
                string query = "SELECT * FROM loadTable";  // Replace with your actual table name

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();

                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        string name = reader["name"].ToString();
                        string cnic = reader["cnic"].ToString();
                        string amount = reader["amount"].ToString();
                        string phoneno = reader["phoneno"].ToString();

                        customerTable.Rows.Add(name, cnic, amount, phoneno);
                    }

                    reader.Close();
                    connection.Close();
                }
            }
            LoansDataGridView.DataSource = customerTable;  // Replace dataGridView1 with your actual DataGridView control name

        }
    }
}
