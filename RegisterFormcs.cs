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

namespace Sprint3
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
            emailComboBox.SelectedIndex = 0;
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void continueButton_Click(object sender, EventArgs e)
        {
            LogInForm logInForm = new LogInForm();
            string username = usernameTextBox.Text;
            string password = passwordTextBox.Text;
            string email = emailTextBox.Text + emailComboBox.SelectedItem;
            string phone = phoneTextBox.Text;
            string cardNum = cardNumTextBox.Text;
            string expiryDate = expiryDateTextBox.Text;
            string ccv = ccvTextBox.Text;
            string paymentType;
            char tierType;
            DateTime memExpiryDate = DateTime.Now;
            memExpiryDate = memExpiryDate.AddYears(1);
            string membershipExpiryDate = memExpiryDate.Date.ToString();

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
            else if (reader.HasRows == false)
            {
                if (passwordTextBox.Text == confirmPasswordTextBox.Text)
                {
                    reader.Close();
                    command.CommandText = $"INSERT INTO Customers VALUES (NULL, '{username}', '{password}', '{tierType}', '2022-01-01', '{email}', '{phone}', '{paymentType}', '{cardNum}', '{expiryDate}', '{ccv}')";
                    command.ExecuteReader();
                    MessageBox.Show("Sign-Up is successful. Returning to login page");
                    logInForm.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Passwords do not match. Please try again.");
                }
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
    }
}
