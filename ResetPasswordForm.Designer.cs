
namespace Sprint3
{
    partial class ResetPasswordForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ResetPasswordForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.cardTextBox = new System.Windows.Forms.TextBox();
            this.getPasswordButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(173, 225);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(173, 297);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Email Address:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(173, 374);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Card Number:";
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Location = new System.Drawing.Point(372, 222);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(294, 26);
            this.usernameTextBox.TabIndex = 0;
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(372, 294);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(294, 26);
            this.emailTextBox.TabIndex = 1;
            // 
            // cardTextBox
            // 
            this.cardTextBox.Location = new System.Drawing.Point(372, 371);
            this.cardTextBox.Name = "cardTextBox";
            this.cardTextBox.Size = new System.Drawing.Size(294, 26);
            this.cardTextBox.TabIndex = 2;
            // 
            // getPasswordButton
            // 
            this.getPasswordButton.Location = new System.Drawing.Point(212, 570);
            this.getPasswordButton.Name = "getPasswordButton";
            this.getPasswordButton.Size = new System.Drawing.Size(153, 41);
            this.getPasswordButton.TabIndex = 6;
            this.getPasswordButton.Text = "Retrieve Password";
            this.getPasswordButton.UseVisualStyleBackColor = true;
            this.getPasswordButton.Click += new System.EventHandler(this.getPasswordButton_Click);
            // 
            // backButton
            // 
            this.backButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.backButton.Location = new System.Drawing.Point(478, 570);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(100, 41);
            this.backButton.TabIndex = 7;
            this.backButton.Text = "Go Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // ResetPasswordForm
            // 
            this.AcceptButton = this.getPasswordButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSalmon;
            this.CancelButton = this.backButton;
            this.ClientSize = new System.Drawing.Size(790, 750);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.getPasswordButton);
            this.Controls.Add(this.cardTextBox);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.usernameTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ResetPasswordForm";
            this.Text = "Forgot Password";
            this.Load += new System.EventHandler(this.ResetPasswordForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox cardTextBox;
        private System.Windows.Forms.Button getPasswordButton;
        private System.Windows.Forms.Button backButton;
    }
}