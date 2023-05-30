using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using VP_Project.auth;
using VP_Project.home;

namespace VP_Project.menu
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Home_Load_1(object sender, EventArgs e)
        {
            //SqlConnection sqlConnection = new SqlConnection(@"Data Source=DESKTOP-LRD7VGB; Initial Catalog=Products; Integrated Security=True;");
        }

        private void CreatenewAccountBTN_Click(object sender, EventArgs e)
        {
            CreateNewAccount createNew = new CreateNewAccount();
            this.Hide();
            createNew.Show();
        }

        private void LoanBTN_Click(object sender, EventArgs e)
        {
            Loan loan = new Loan();
            this.Hide();    
            loan.Show();
        }

        private void TransactionBTN_Click(object sender, EventArgs e)
        {
            Transactions transactions = new Transactions();
            this.Hide();
            transactions.Show();

        }

        private void CheckBoolBTN_Click(object sender, EventArgs e)
        {
            ApplyForCheckBook book = new ApplyForCheckBook();
            this.Hide();
            book.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            CustomersDetails details = new CustomersDetails();
            this.Hide();
            details.Show();
        }

        private void LoanDetailsBTN_Click(object sender, EventArgs e)
        {
            LoansDetails loans = new LoansDetails();
            this.Hide();
            loans.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
