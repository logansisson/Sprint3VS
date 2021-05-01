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

        class MyVariables 
        {
            public static List<String> titleList = new List<String>();
            public static List<String> listenList = new List<String>();
            public static List<String> likedList = new List<String>();
            public static List<String> repostList = new List<String>();
            public static List<String> commentList = new List<String>();
            public static string[] monthlyListens = new string[12];
            public static int index = 0;
        }

        public void getNewRecord()
        {
            var titleArray = MyVariables.titleList.ToArray();
            var listenArray = MyVariables.listenList.ToArray();
            var likedArray = MyVariables.likedList.ToArray();
            var repostArray = MyVariables.repostList.ToArray();
            var commentArray = MyVariables.commentList.ToArray();
            weeklyLabel.Text = $"{listenArray[titleListBox.SelectedIndex]}0,000 streams";
        }

        public void TrendingAnalyticsForm_Load(object sender, EventArgs e)
        {
            string weeklySong = "SELECT * From Weekly_Stats;";

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
                MyVariables.titleList.Add(reader["Title"].ToString());
                MyVariables.listenList.Add(reader["Listens"].ToString());
                MyVariables.likedList.Add(reader["likes"].ToString());
                MyVariables.repostList.Add(reader["reposts"].ToString());
                MyVariables.commentList.Add(reader["comments"].ToString());
            }
            reader.Close();
            var titleArray = MyVariables.titleList.ToArray();
            var listenArray = MyVariables.listenList.ToArray();
            var likedArray = MyVariables.likedList.ToArray();
            var repostArray = MyVariables.repostList.ToArray();
            var commentArray = MyVariables.commentList.ToArray();
            for (int i = 0; i < titleArray.Count(); i++)
            {
                titleListBox.Items.Add(titleArray[i]);
            }
            titleListBox.SelectedIndex = 0;
            weeklyLabel.Text = $"{listenArray[titleListBox.SelectedIndex]}0,000 streams";
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
            command.CommandText = $"select Title, Listens from Monthly_Stats;";
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                monthlyListBox.Items.Add(reader["Title"].ToString());
                MyVariables.monthlyListens.SetValue(reader["Listens"].ToString(), MyVariables.index);
                MyVariables.index++;
            }
            reader.Close();
            monthlyListBox.SelectedIndex = 0;
            monthlyListBox_SelectedIndexChanged(sender, e);
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            this.Close();
            MainForm mainForm = new MainForm();
            mainForm.Show();
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
            getNewRecord();
        }

        private void monthlyListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            trackLabel.Text = $"{MyVariables.monthlyListens[monthlyListBox.SelectedIndex]}0,000 streams";
        }
    }
}
