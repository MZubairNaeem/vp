using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;

namespace VP_Project.auth
{
    public partial class Register : Form
    {
        string str = @"Data Source=DESKTOP-LRD7VGB; Initial Catalog=project; Integrated Security=True;";
        public Register()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Register_Load(object sender, EventArgs e)
        {

        }
        public bool regexPatterns(String email, String password)
        {
            //regex patterns
            string passwordPattern, emailPattern;
            emailPattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,4}$";
            passwordPattern = @"^.{6,}$";

            bool validEmail, validPassword;
            validEmail = Regex.IsMatch(email, emailPattern);
            validPassword = Regex.IsMatch(password, passwordPattern);

            if (validEmail && validPassword)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        private void RegisterBTN_Click(object sender, EventArgs e)
        {
            String email = EmailTextbox.Text;
            String pass = PasswordtextBox.Text;
            bool regex = regexPatterns(email, pass);
            if (NameTextbox.Text.Length == 0)
            {
                namelbl.Text = "Enter your name...";
                emaillbl.Text = "*";
                passlbl.Text = "*";
            }
            else if (EmailTextbox.Text.Length == 0)
            {
                emaillbl.Text = "Enter your email...";
                namelbl.Text = "*";
                passlbl.Text = "*";
            }
            else if (PasswordtextBox.Text.Length == 0)
            {
                passlbl.Text = "Enter your passowrd...";
                emaillbl.Text = "*";
                namelbl.Text = "*";
            }
            else
            {
                if (regex)
                {
                    SqlConnection sqlConn = new SqlConnection(str);
                    sqlConn.Open();
                    SqlCommand sqlCmd = new SqlCommand("UserAdd", sqlConn);
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    sqlCmd.Parameters.AddWithValue("@username", NameTextbox.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@email", email);
                    sqlCmd.Parameters.AddWithValue("@password", pass);
                    int res = sqlCmd.ExecuteNonQuery();
                    EmailTextbox.Text = "";
                    NameTextbox.Text = "";
                    PasswordtextBox.Text = "";
                    if (res > 0)
                    {
                        MessageBox.Show("Signedup Successfully");
                        Login login = new Login();
                        this.Hide();
                        login.Show();
                    }
                    else
                    {
                        MessageBox.Show("Some Error Occurs! Please try again.");
                    }
                }
                else
                {
                    passlbl.Text = "must be greater than 6";
                    emaillbl.Text = "must in coorect format";
                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
