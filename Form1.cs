using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sprint3
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void logInButton_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            LogInForm logInForm = new LogInForm();
            logInForm.Show();
            this.Hide();
        }

        private void confirmExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void logInToolStripMenuItem_Click(object sender, EventArgs e)
        {
            logInButton_Click(sender, e);
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            RegisterForm registerForm = new RegisterForm();
            registerForm.Show();
            this.Hide();
        }

        private void registerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            registerButton_Click(sender, e);
        }

        private void supportButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This feature is not yet functional.");
        }
    }
}
