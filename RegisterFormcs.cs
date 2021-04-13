using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Text.RegularExpressions;

namespace Sprint3
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void continueButton_Click(object sender, EventArgs e)
        {
            LogInForm logInForm = new LogInForm();
            string username = usernameTextBox.Text;
            string password = passwordTextBox.Text;
            string email = emailTextBox.Text;
            string phone = phoneTextBox.Text;
            string cardNum = cardNumTextBox.Text;
            string expiryDate = expiryDateTextBox.Text;
            string cvv = ccvTextBox.Text;
            string paymentType;
            char tierType;
            DateTime memExpiryDate = DateTime.Now;
            memExpiryDate = memExpiryDate.AddYears(1);
            string membershipExpiryDate = memExpiryDate.Date.ToString();
            bool isEmail = Regex.IsMatch(email, @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z", RegexOptions.IgnoreCase);
            bool isPhone = Regex.IsMatch(phone, @"^((\(\d{3}\) ?)|(\d{3}-))?\d{3}-\d{4}$");
            bool isCVV = Regex.IsMatch(cvv, @"^\d{3}$");
            bool isExpired = Regex.IsMatch(expiryDate, @"^(2[1-9])[/](0[1-9]|1[0-2])$");
            bool isCard = Regex.IsMatch(cardNum, @"[0-9]{4}[-][0-9]{4}[-][0-9]{4}[-][0-9]{4}");

            if (isEmail)
            {
                if (isPhone)
                {
                    if (isExpired)
                    {
                        if (isCard)
                        {
                            if (isCVV)
                            {
                                if (enterpriseRadioButton.Checked)
                                {
                                    tierType = 'E';
                                }
                                else if (unlimitedRadioButton.Checked)
                                {
                                    tierType = 'U';
                                }
                                else
                                {
                                    tierType = 'S';
                                }
                                if (creditRadioButton.Checked)
                                {
                                    paymentType = "CREDIT";
                                }
                                else
                                {
                                    paymentType = "DEBIT";
                                }
                                MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
                                builder.Server = "209.106.201.103";
                                builder.UserID = "dbstudent18";
                                builder.Password = "longwhale63";
                                builder.Database = "group4";
                                MySqlConnection connection = new MySqlConnection(builder.ToString());
                                MySqlCommand command = new MySqlCommand();
                                connection.Open();
                                command.Connection = connection;
                                command.CommandText = $"SELECT * FROM Customers WHERE username = '{username}'";
                                MySqlDataReader reader = command.ExecuteReader();
                                reader.Read();
                                if (reader.HasRows)
                                {
                                    MessageBox.Show("Username already exists.");
                                }
                                else if (usernameTextBox.Text == "" || passwordTextBox.Text == "" || usernameTextBox.Text.Contains(" ") || passwordTextBox.Text.Contains(" "))
                                {
                                    MessageBox.Show("Username or password cannot be blank. Please enter a valid value.");
                                    usernameTextBox.Focus();
                                }
                                else if (reader.HasRows == false && usernameTextBox.Text != "" && passwordTextBox.Text != "")
                                {
                                    if (passwordTextBox.Text == confirmPasswordTextBox.Text)
                                    {
                                        reader.Close();
                                        command.CommandText = $"INSERT INTO Customers VALUES (NULL, '{username}', '{password}', '{tierType}', '2022-01-01', '{email}', '{phone}', '{paymentType}', '{cardNum}', '{expiryDate}', '{cvv}')";
                                        command.ExecuteReader();
                                        MessageBox.Show("Sign-Up is successful. Returning to login page");
                                        logInForm.Show();
                                        this.Close();
                                    }
                                    else
                                    {
                                        MessageBox.Show("Passwords do not match or password is blank. Please try again.");
                                        confirmPasswordTextBox.Clear();
                                        passwordTextBox.Clear();
                                        passwordTextBox.Focus();
                                    }
                                }
                            }
                            else
                            {
                                MessageBox.Show("CVV is invalid. Please input a valid three-digit code.");
                                ccvTextBox.Focus();
                                ccvTextBox.SelectAll();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Card Number is invalid. Please input in the following format: XXXX-XXXX-XXXX-XXXX.");
                            cardNumTextBox.Focus();
                            cardNumTextBox.SelectAll();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid date. Please check input and try again.");
                        expiryDateTextBox.Focus();
                        expiryDateTextBox.SelectAll();
                    }
                }
                else
                {
                    MessageBox.Show("Phone number is invalid. Please input in the follwing format: (XXX)XXX-XXXX.");
                    phoneTextBox.Focus();
                    phoneTextBox.SelectAll();
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid email. If email is valid, please contact support.");
                emailTextBox.Focus();
                emailTextBox.SelectAll();
            }
        }

        private void continueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            continueButton_Click(sender, e);
        }

        private void confirmExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            MainForm mainForm = new MainForm();
            mainForm.Show();
        }

        private void returnButton_Click(object sender, EventArgs e)
        {
            confirmExitToolStripMenuItem_Click(sender, e);
        }

        private void returnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            returnButton_Click(sender, e);
        }
    }
}
