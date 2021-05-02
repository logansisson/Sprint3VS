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
using MySql.Data.MySqlClient;
using MySql.Data;


namespace Sprint3
{
    public partial class LogInForm : Form
    {
        public static string username = "";


        public LogInForm()
        {
            InitializeComponent();

        }

        private void LogInForm_Load(object sender, EventArgs e)
        {

        }

        public void button1_Click(object sender, EventArgs e)
        {
            username = usernameTextBox.Text;
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
            builder.Server = "209.106.201.103";
            builder.UserID = "dbstudent18";
            builder.Password = "longwhale63";
            builder.Database = "group4";
            MySqlConnection connection = new MySqlConnection(builder.ToString());
            MySqlCommand command = new MySqlCommand();
            connection.Open();
            command.Connection = connection;
            command.CommandText = $"SELECT * FROM Customers WHERE username = \"{username}\"";
            MySqlDataReader reader = command.ExecuteReader();
            reader.Read();
            if (usernameTextBox.Text != "" || passwordTextBox.Text != "")
            {
                try
                {
                    if (usernameTextBox.Text == (reader["username"].ToString()) && passwordTextBox.Text.Equals(reader["password"].ToString()))
                    {
                        username = usernameTextBox.Text;
                        TrendingAnalyticsForm trendingAnalyticsForm = new TrendingAnalyticsForm();
                        trendingAnalyticsForm.Show();
                        this.Close();
                    }
                }
                catch (Exception)
                {

                    MessageBox.Show("Invalid Login. Please try again.");
                    passwordTextBox.Clear();
                    usernameTextBox.Focus();
                    usernameTextBox.SelectAll();
                }
                connection.Close();
            }
            else
            {
                MessageBox.Show("Username or password cannot be blank! Please try again.");
                usernameTextBox.Focus();
            }
        }

        private void confirmExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            MainForm mainForm = new MainForm();
            mainForm.Show();
        }

        private void logInToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button1_Click(sender, e);
        }

        private void returnButton_Click(object sender, EventArgs e)
        {
            confirmExitToolStripMenuItem_Click(sender, e);
        }

        private void returnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            returnButton_Click(sender, e);
        }

        private void passwordButton_Click(object sender, EventArgs e)
        {
            this.Close();
            ResetPasswordForm resetPasswordForm = new ResetPasswordForm();
            resetPasswordForm.Show();
        }
    }
}
