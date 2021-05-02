using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.Common;
using MySql.Data.MySqlClient;
using System.Text.RegularExpressions;

namespace Sprint3
{
    public partial class ResetPasswordForm : Form
    {
        public ResetPasswordForm()
        {
            InitializeComponent();
        }

        protected bool ConnectDB(string username, string email, string card)
        {
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
            builder.Server = "209.106.201.103";
            builder.UserID = "dbstudent18";
            builder.Password = "longwhale63";
            builder.Database = "group4";
            MySqlConnection connection = new MySqlConnection(builder.ToString());
            MySqlCommand command = new MySqlCommand();
            connection.Open();
            command.Connection = connection;
            command.CommandText = $"SELECT Password FROM Customers WHERE username = \"{username}\" AND email = \"{email}\" AND cardNum = \"{card}\"";
            MySqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                MessageBox.Show($"Your password is {reader["Password"]}");
                return true;
            }
            else
            {
                MessageBox.Show("No account found with that username, email, and card number combination. Please check your inputs and try again.");
                cardTextBox.Clear();
                emailTextBox.Clear();
                usernameTextBox.Clear();
                usernameTextBox.Focus();
                return false;
            }
        }

        private void ResetPasswordForm_Load(object sender, EventArgs e)
        {
            MessageBox.Show("In order to retrieve your password, you must enter the account's username, email address, and the card number associated with the account.", "Instructions");
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
            LogInForm logInForm = new LogInForm();
            logInForm.Show();
        }

        private void getPasswordButton_Click(object sender, EventArgs e)
        {
            string username = usernameTextBox.Text;
            string email = emailTextBox.Text;
            string card = cardTextBox.Text;
            if (username == "" || username == " ")
            {
                MessageBox.Show("Username is not valid or is blank. Please check your input and try again.");
                usernameTextBox.Focus();
            }
            else
            {
                bool isCard = Regex.IsMatch(card, @"[0-9]{4}[-][0-9]{4}[-][0-9]{4}[-][0-9]{4}");
                bool isEmail = Regex.IsMatch(email, @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z", RegexOptions.IgnoreCase);
                if (isEmail)
                {
                    if (isCard)
                    {
                        if (ConnectDB(username, email, card))
                        {
                            backButton_Click(sender, e);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Not a valid card number. Please enter it in the XXXX-XXXX-XXXX-XXXX format.");
                        cardTextBox.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Not a valid email. Please check your input and try again.");
                    emailTextBox.Focus();
                }
            }
        }
    }
}
