using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VP_Project.home
{
    public partial class Transactions : Form
    {
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
    }
}
