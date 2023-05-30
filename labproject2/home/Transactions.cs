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
    public partial class Transactions : Form
    {
        string str = @"Data Source=DESKTOP-LRD7VGB; Initial Catalog=project; Integrated Security=True;";
        public Transactions()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void SelectbankCMB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Transactions_Load(object sender, EventArgs e)
        {
            SelectbankCMB.Items.Add("Askri Bank");
            SelectbankCMB.Items.Add("HBL Bank");
            SelectbankCMB.Items.Add("UBL Bank");
            SelectbankCMB.Items.Add("BOP Bank");

            SelectPurposeOfPaymentCMB.Items.Add("Loan");
            SelectPurposeOfPaymentCMB.Items.Add("Self");
            SelectPurposeOfPaymentCMB.Items.Add("Subscription");
            SelectPurposeOfPaymentCMB.Items.Add("Family Support");
        }

        private void ProceedBTN_Click(object sender, EventArgs e)
        {
            string bank = SelectbankCMB.SelectedItem.ToString();
            int acc = Convert.ToInt32(amountTextBox.Text);
            string purpose = SelectPurposeOfPaymentCMB.SelectedItem.ToString();
            int amount = Convert.ToInt32(amountTextBox.Text);
            string query = "INSERT INTO bankTrasnferTable (purpose, amount, acc,bank) " +
               "VALUES (@purpose, @amount,  @acc, @bank)";

            using (SqlConnection connection = new SqlConnection(str))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Set up the parameters
                    command.Parameters.AddWithValue("@purpose", purpose);
                    command.Parameters.AddWithValue("@amount", amount);
                    command.Parameters.AddWithValue("@acc", acc);
                    command.Parameters.AddWithValue("@bank", bank);

                    // Open the connection
                    connection.Open();

                    // Execute the query
                    command.ExecuteNonQuery();

                    // Close the connection
                    connection.Close();

                    // Show a success message or perform any other actions
                    MessageBox.Show("Transaction successful!", "Insert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
