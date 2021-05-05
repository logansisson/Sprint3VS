
namespace Sprint3
{
    partial class SupportForm
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
            this.topicComboBox = new System.Windows.Forms.ComboBox();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.submitButton = new System.Windows.Forms.Button();
            this.returnButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // topicComboBox
            // 
            this.topicComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.topicComboBox.FormattingEnabled = true;
            this.topicComboBox.Items.AddRange(new object[] {
            "Error",
            "Payment Info",
            "Account Info",
            "Recommendation",
            "Other"});
            this.topicComboBox.Location = new System.Drawing.Point(36, 21);
            this.topicComboBox.Name = "topicComboBox";
            this.topicComboBox.Size = new System.Drawing.Size(158, 21);
            this.topicComboBox.TabIndex = 0;
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.AcceptsReturn = true;
            this.descriptionTextBox.Location = new System.Drawing.Point(36, 64);
            this.descriptionTextBox.MaxLength = 255;
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(208, 131);
            this.descriptionTextBox.TabIndex = 1;
            this.descriptionTextBox.Text = "Enter a description of your selected topic";
            this.descriptionTextBox.Enter += new System.EventHandler(this.descriptionTextBox_Enter);
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(36, 229);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(223, 20);
            this.emailTextBox.TabIndex = 2;
            this.emailTextBox.Text = "Enter your contact email";
            this.emailTextBox.Enter += new System.EventHandler(this.emailTextBox_Enter);
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(36, 321);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(75, 23);
            this.submitButton.TabIndex = 3;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // returnButton
            // 
            this.returnButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.returnButton.Location = new System.Drawing.Point(184, 321);
            this.returnButton.Name = "returnButton";
            this.returnButton.Size = new System.Drawing.Size(75, 23);
            this.returnButton.TabIndex = 4;
            this.returnButton.Text = "Return";
            this.returnButton.UseVisualStyleBackColor = true;
            this.returnButton.Click += new System.EventHandler(this.returnButton_Click);
            // 
            // SupportForm
            // 
            this.AcceptButton = this.submitButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.LightSalmon;
            this.CancelButton = this.returnButton;
            this.ClientSize = new System.Drawing.Size(302, 396);
            this.Controls.Add(this.returnButton);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(this.topicComboBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "SupportForm";
            this.Text = "Contact Support";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox topicComboBox;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Button returnButton;
    }
}