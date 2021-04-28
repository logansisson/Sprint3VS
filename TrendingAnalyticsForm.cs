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

        public void TrendingAnalyticsForm_Load(object sender, EventArgs e)
        {
            string weeklySong = "SELECT * From Weekly_Stats;";
            var titleList = new List<String>();
            var listenList = new List<String>();
            var likedList = new List<String>();
            var repostList = new List<String>();
            var commentList = new List<String>();

            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
            builder.Server = "209.106.201.103";
            builder.UserID = "dbstudent18";
            builder.Password = "longwhale63";
            builder.Database = "group4";
            MySqlConnection connection = new MySqlConnection(builder.ToString());
            MySqlCommand command = new MySqlCommand();
            connection.Open();
            command.Connection = connection;
            command.CommandText = weeklySong;
            MySqlDataReader reader = command.ExecuteReader();
            reader.Read();
            while (reader.Read())
            {
                titleList.Add(reader["Title"].ToString());
                listenList.Add(reader["SUM(isListened)"].ToString());
                likedList.Add(reader["SUM(isLiked)"].ToString());
                repostList.Add(reader["SUM(isReposted)"].ToString());
                commentList.Add(reader["SUM(isCommented)"].ToString());
            }
            reader.Close();
            var titleArray = titleList.ToArray();
            var listenArray = listenList.ToArray();
            var likedArray = likedList.ToArray();
            var repostArray = repostList.ToArray();
            var commentArray = commentList.ToArray();
            for (int i = 0; i < titleArray.Count(); i++)
            {
                titleListBox.Items.Add(titleArray[i]);
            }
            titleListBox.SelectedIndex = 0;
            weeklyLabel.Text = listenArray[titleListBox.SelectedIndex];
            command.CommandText = $"SELECT * FROM Customers WHERE username = \"{LogInForm.username}\"";
            usernameLabel.Text = LogInForm.username;
            reader = command.ExecuteReader();
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
            command.CommandText = $"SELECT title FROM Monthly_Stats where SUM(isListened) = (SELECT MAX() AS maxListens FROM Tracks WHERE genre = \"{hiphopRadioButton.Text}\")";
            reader = command.ExecuteReader();
            if (reader.Read())
            {
                trackLabel.Text = reader["title"].ToString();
                reader.Close();
                command.CommandText = $"select Artists.name from Tracks INNER JOIN Albums ON Tracks.albumId = Albums.albumId INNER JOIN Artists on Albums.artistId = Artists.artistId WHERE Tracks.title = \"{trackLabel.Text}\"";
                reader = command.ExecuteReader();
                reader.Read();
                trackLabel.Text += $" By {reader["name"].ToString()}";
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
            MainForm mainForm = new MainForm();
            mainForm.Show();
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
                command.CommandText = $"select Artists.name from Tracks INNER JOIN Albums ON Tracks.albumId = Albums.albumId INNER JOIN Artists on Albums.artistId = Artists.artistId WHERE Tracks.title = \"{trackLabel.Text}\"";
                reader = command.ExecuteReader();
                reader.Read();
                trackLabel.Text += $" By {reader["name"].ToString()}";
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
                command.CommandText = $"select Artists.name from Tracks INNER JOIN Albums ON Tracks.albumId = Albums.albumId INNER JOIN Artists on Albums.artistId = Artists.artistId WHERE Tracks.title = \"{trackLabel.Text}\"";
                reader = command.ExecuteReader();
                reader.Read();
                trackLabel.Text += $" By {reader["name"].ToString()}";
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
                command.CommandText = $"select Artists.name from Tracks INNER JOIN Albums ON Tracks.albumId = Albums.albumId INNER JOIN Artists on Albums.artistId = Artists.artistId WHERE Tracks.title = \"{trackLabel.Text}\"";
                reader = command.ExecuteReader();
                reader.Read();
                trackLabel.Text += $" By {reader["name"].ToString()}";
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

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            logoutButton_Click(sender, e);
        }

        private void displayButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Username: {LogInForm.username} \n Email: {emailLabel.Text} \n Tier: {tierLabel.Text} \n Phone Number: {phoneLabel.Text} \n ");
        }

        private void showAccountInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            displayButton_Click(sender, e);
        }

        public void titleListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
    }
}
