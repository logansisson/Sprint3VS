using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using MySql.Data.MySqlClient;

namespace Sprint3
{
    public partial class SupportForm : Form
    {
        public SupportForm()
        {
            InitializeComponent();
        }
        private void descriptionTextBox_Enter(object sender, EventArgs e)
        {
            if (descriptionTextBox.Text == "Enter a description of your selected topic")
            {
                descriptionTextBox.Text = "";
            }
        }
        private void emailTextBox_Enter(object sender, EventArgs e)
        {
            if (emailTextBox.Text == "Enter your contact email")
            {
                emailTextBox.Text = "";
            }
        }

        private void returnButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            string email = emailTextBox.Text;
            string description = descriptionTextBox.Text;
            bool isEmail = Regex.IsMatch(email, @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z", RegexOptions.IgnoreCase);
            if (isEmail == false)
            {
                MessageBox.Show("Please enter a valid email.");
                emailTextBox.Focus();
                emailTextBox.SelectAll();
            }
            else
            {
                if (topicComboBox.SelectedIndex == -1)
                {
                    MessageBox.Show("You must select a topic from the dropdown box.");
                }
                else
                {
                    string topic = topicComboBox.SelectedItem.ToString();
                    char type = topic.ElementAt(0);
                    if (description != "")
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
                        command.CommandText = $"INSERT INTO SupportLogs VALUES (NULL, NULL, NULL, \'{type}\', \"{email}\", NULL, \"{description}\")";
                        command.ExecuteReader();
                        connection.Close();
                        MessageBox.Show("Your Support Log has been created. Please allow us 24 hours to review and respond to your ticket.");
                        returnButton_Click(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("You cannot have a blank description!");
                        descriptionTextBox.Focus();
                    }
                }
            }
        }
    }
}
