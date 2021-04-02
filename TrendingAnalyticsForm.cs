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
    public partial class TrendingAnalyticsForm : Form
    {
        public TrendingAnalyticsForm()
        {
            InitializeComponent();
        }

        private void TrendingAnalyticsForm_Load(object sender, EventArgs e)
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
            command.CommandText = $"SELECT * FROM Customers WHERE username = \"{LogInForm.username}\"";
            usernameLabel.Text = LogInForm.username;
            MySqlDataReader reader = command.ExecuteReader();
            string tierType;
            if (reader.Read())
            {
                passwordLabel.Text = reader["password"].ToString();
                tierType = reader["tier"].ToString();
                if (tierType == "E")
                {
                    tierLabel.Text = "Enterprise";
                }
                else if (tierType == "S")
                {
                    tierLabel.Text = "Starter";
                }
                else
                    tierLabel.Text = "Unlimited";
                emailLabel.Text = reader["email"].ToString();
                phoneLabel.Text = reader["phone"].ToString();
                paymentInfoLabel.Text = reader["cardNum"].ToString();
                 if (phoneLabel.Text == null || phoneLabel.Text == "")
                {
                    phoneLabel.Text = "No Phone Number on file.";
                }
             }
            reader.Close();
            command.CommandText = $"SELECT title FROM Tracks where listens = (SELECT MAX(listens) AS maxListens FROM Tracks WHERE genre = \"{hiphopRadioButton.Text}\")";
            reader = command.ExecuteReader();
            if (reader.Read())
            {
                trackLabel.Text = reader["title"].ToString();
                reader.Close();
                command.CommandText = $"SELECT MAX(listens) AS maxListens FROM Tracks WHERE genre = \"{hiphopRadioButton.Text}\"";
                reader = command.ExecuteReader();
                reader.Read();
                listensLabel.Text = reader["maxListens"].ToString() + " streams";
            }
            reader.Close();
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void hiphopRadioButton_CheckedChanged(object sender, EventArgs e)
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
            if (punkRadioButton.Checked)
            {
                command.CommandText = $"SELECT title FROM Tracks where listens = (SELECT MAX(listens) AS maxListens FROM Tracks WHERE genre = \"{punkRadioButton.Text}\")";
                MySqlDataReader reader = command.ExecuteReader();
                reader.Read();
                trackLabel.Text = reader["title"].ToString();
                reader.Close();
                command.CommandText = $"SELECT MAX(listens) AS maxListens FROM Tracks WHERE genre = \"{punkRadioButton.Text}\"";
                reader = command.ExecuteReader();
                reader.Read();
                listensLabel.Text = reader["maxListens"].ToString() + " streams";
            }
            else if (countryRadioButton.Checked)
            {
                command.CommandText = $"SELECT title FROM Tracks where listens = (SELECT MAX(listens) AS maxListens FROM Tracks WHERE genre = \"{countryRadioButton.Text}\")";
                MySqlDataReader reader = command.ExecuteReader();
                reader.Read();
                trackLabel.Text = reader["title"].ToString();
                reader.Close();
                command.CommandText = $"SELECT MAX(listens) AS maxListens FROM Tracks WHERE genre = \"{countryRadioButton.Text}\"";
                reader = command.ExecuteReader();
                reader.Read();
                listensLabel.Text = reader["maxListens"].ToString() + " streams";
            }
            else
            {
                command.CommandText = $"SELECT title FROM Tracks where listens = (SELECT MAX(listens) AS maxListens FROM Tracks WHERE genre = \"{hiphopRadioButton.Text}\")";
                MySqlDataReader reader = command.ExecuteReader();
                reader.Read();
                trackLabel.Text = reader["title"].ToString();
                reader.Close();
                command.CommandText = $"SELECT MAX(listens) AS maxListens FROM Tracks WHERE genre = \"{hiphopRadioButton.Text}\"";
                reader = command.ExecuteReader();
                reader.Read();
                listensLabel.Text = reader["maxListens"].ToString() + " streams";
            }
        }

        private void countryRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            hiphopRadioButton_CheckedChanged(sender, e);
        }

        private void punkRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            hiphopRadioButton_CheckedChanged(sender, e);
        }

        private void displayCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (displayCheckBox.Checked)
            {
                usernameLabel.Visible = true;
                passwordLabel.Visible = true;
                tierLabel.Visible = true;
                emailLabel.Visible = true;
                phoneLabel.Visible = true;
                paymentInfoLabel.Visible = true;
            }
            else
            {
                usernameLabel.Visible = false;
                passwordLabel.Visible = false;
                tierLabel.Visible = false;
                emailLabel.Visible = false;
                phoneLabel.Visible = false;
                paymentInfoLabel.Visible = false;
            }
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            logoutButton_Click(sender, e);
        }

        private void showAccountInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            displayCheckBox.Checked = true;
        }

        private void hideAccountInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            displayCheckBox.Checked = false;
        }
    }
}
