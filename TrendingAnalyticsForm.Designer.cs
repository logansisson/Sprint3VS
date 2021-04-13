
namespace Sprint3
{
    partial class TrendingAnalyticsForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TrendingAnalyticsForm));
            this.usernameLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.paymentInfoLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.tierLabel = new System.Windows.Forms.Label();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.trackLabel = new System.Windows.Forms.Label();
            this.logoutButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.punkRadioButton = new System.Windows.Forms.RadioButton();
            this.countryRadioButton = new System.Windows.Forms.RadioButton();
            this.hiphopRadioButton = new System.Windows.Forms.RadioButton();
            this.listensLabel = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showAccountInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.group4DataSet = new Sprint3.group4DataSet();
            this.albumsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.albumsTableAdapter = new Sprint3.group4DataSetTableAdapters.AlbumsTableAdapter();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.displayButton = new System.Windows.Forms.Button();
            this.weeklyLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.group4DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.albumsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLabel.Location = new System.Drawing.Point(12, 66);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(0, 24);
            this.usernameLabel.TabIndex = 1;
            this.usernameLabel.Visible = false;
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLabel.Location = new System.Drawing.Point(12, 123);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(0, 24);
            this.passwordLabel.TabIndex = 3;
            this.passwordLabel.Visible = false;
            // 
            // paymentInfoLabel
            // 
            this.paymentInfoLabel.AutoSize = true;
            this.paymentInfoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paymentInfoLabel.Location = new System.Drawing.Point(12, 179);
            this.paymentInfoLabel.Name = "paymentInfoLabel";
            this.paymentInfoLabel.Size = new System.Drawing.Size(0, 24);
            this.paymentInfoLabel.TabIndex = 5;
            this.paymentInfoLabel.Visible = false;
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailLabel.Location = new System.Drawing.Point(12, 226);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(0, 24);
            this.emailLabel.TabIndex = 7;
            this.emailLabel.Visible = false;
            // 
            // tierLabel
            // 
            this.tierLabel.AutoSize = true;
            this.tierLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tierLabel.Location = new System.Drawing.Point(12, 281);
            this.tierLabel.Name = "tierLabel";
            this.tierLabel.Size = new System.Drawing.Size(0, 24);
            this.tierLabel.TabIndex = 9;
            this.tierLabel.Visible = false;
            // 
            // phoneLabel
            // 
            this.phoneLabel.AutoSize = true;
            this.phoneLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneLabel.Location = new System.Drawing.Point(12, 330);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(0, 24);
            this.phoneLabel.TabIndex = 11;
            this.phoneLabel.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 271);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(308, 74);
            this.label2.TabIndex = 12;
            this.label2.Text = "Most Played Track \r\nby Genre:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // trackLabel
            // 
            this.trackLabel.AutoSize = true;
            this.trackLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trackLabel.Location = new System.Drawing.Point(47, 362);
            this.trackLabel.Name = "trackLabel";
            this.trackLabel.Size = new System.Drawing.Size(86, 31);
            this.trackLabel.TabIndex = 13;
            this.trackLabel.Text = "label4";
            // 
            // logoutButton
            // 
            this.logoutButton.Location = new System.Drawing.Point(522, 662);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(115, 51);
            this.logoutButton.TabIndex = 14;
            this.logoutButton.Text = "Log Out";
            this.logoutButton.UseVisualStyleBackColor = true;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.punkRadioButton);
            this.groupBox1.Controls.Add(this.countryRadioButton);
            this.groupBox1.Controls.Add(this.hiphopRadioButton);
            this.groupBox1.Location = new System.Drawing.Point(100, 476);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(189, 141);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select a Genre:";
            // 
            // punkRadioButton
            // 
            this.punkRadioButton.AutoSize = true;
            this.punkRadioButton.Location = new System.Drawing.Point(18, 106);
            this.punkRadioButton.Name = "punkRadioButton";
            this.punkRadioButton.Size = new System.Drawing.Size(50, 17);
            this.punkRadioButton.TabIndex = 2;
            this.punkRadioButton.Text = "Punk";
            this.punkRadioButton.UseVisualStyleBackColor = true;
            this.punkRadioButton.CheckedChanged += new System.EventHandler(this.punkRadioButton_CheckedChanged);
            // 
            // countryRadioButton
            // 
            this.countryRadioButton.AutoSize = true;
            this.countryRadioButton.Location = new System.Drawing.Point(18, 72);
            this.countryRadioButton.Name = "countryRadioButton";
            this.countryRadioButton.Size = new System.Drawing.Size(61, 17);
            this.countryRadioButton.TabIndex = 1;
            this.countryRadioButton.Text = "Country";
            this.countryRadioButton.UseVisualStyleBackColor = true;
            this.countryRadioButton.CheckedChanged += new System.EventHandler(this.countryRadioButton_CheckedChanged);
            // 
            // hiphopRadioButton
            // 
            this.hiphopRadioButton.AutoSize = true;
            this.hiphopRadioButton.Checked = true;
            this.hiphopRadioButton.Location = new System.Drawing.Point(18, 36);
            this.hiphopRadioButton.Name = "hiphopRadioButton";
            this.hiphopRadioButton.Size = new System.Drawing.Size(62, 17);
            this.hiphopRadioButton.TabIndex = 0;
            this.hiphopRadioButton.TabStop = true;
            this.hiphopRadioButton.Text = "Hip hop";
            this.hiphopRadioButton.UseVisualStyleBackColor = true;
            this.hiphopRadioButton.CheckedChanged += new System.EventHandler(this.hiphopRadioButton_CheckedChanged);
            // 
            // listensLabel
            // 
            this.listensLabel.AutoSize = true;
            this.listensLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listensLabel.Location = new System.Drawing.Point(47, 421);
            this.listensLabel.Name = "listensLabel";
            this.listensLabel.Size = new System.Drawing.Size(86, 31);
            this.listensLabel.TabIndex = 16;
            this.listensLabel.Text = "label4";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Silver;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(935, 24);
            this.menuStrip1.TabIndex = 18;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewToolStripMenuItem,
            this.logoutToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showAccountInfoToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // showAccountInfoToolStripMenuItem
            // 
            this.showAccountInfoToolStripMenuItem.Name = "showAccountInfoToolStripMenuItem";
            this.showAccountInfoToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.showAccountInfoToolStripMenuItem.Text = "Show Account Info";
            this.showAccountInfoToolStripMenuItem.Click += new System.EventHandler(this.showAccountInfoToolStripMenuItem_Click);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // group4DataSet
            // 
            this.group4DataSet.DataSetName = "group4DataSet";
            this.group4DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // albumsBindingSource
            // 
            this.albumsBindingSource.DataMember = "Albums";
            this.albumsBindingSource.DataSource = this.group4DataSet;
            // 
            // albumsTableAdapter
            // 
            this.albumsTableAdapter.ClearBeforeFill = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Sprint3.Properties.Resources.fours;
            this.pictureBox1.Location = new System.Drawing.Point(378, 66);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(198, 164);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // displayButton
            // 
            this.displayButton.Location = new System.Drawing.Point(319, 662);
            this.displayButton.Name = "displayButton";
            this.displayButton.Size = new System.Drawing.Size(115, 51);
            this.displayButton.TabIndex = 20;
            this.displayButton.Text = "Show Account Information";
            this.displayButton.UseVisualStyleBackColor = true;
            this.displayButton.Click += new System.EventHandler(this.displayButton_Click);
            // 
            // weeklyLabel
            // 
            this.weeklyLabel.AutoSize = true;
            this.weeklyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weeklyLabel.Location = new System.Drawing.Point(622, 362);
            this.weeklyLabel.Name = "weeklyLabel";
            this.weeklyLabel.Size = new System.Drawing.Size(68, 31);
            this.weeklyLabel.TabIndex = 21;
            this.weeklyLabel.Text = "Test";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(551, 261);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(308, 74);
            this.label1.TabIndex = 22;
            this.label1.Text = "Most Played Track \r\nthis Week:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // TrendingAnalyticsForm
            // 
            this.AcceptButton = this.displayButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSalmon;
            this.ClientSize = new System.Drawing.Size(935, 764);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.weeklyLabel);
            this.Controls.Add(this.displayButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.listensLabel);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.logoutButton);
            this.Controls.Add(this.trackLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.phoneLabel);
            this.Controls.Add(this.tierLabel);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.paymentInfoLabel);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "TrendingAnalyticsForm";
            this.Text = " ";
            this.Load += new System.EventHandler(this.TrendingAnalyticsForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.group4DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.albumsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label paymentInfoLabel;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label tierLabel;
        private System.Windows.Forms.Label phoneLabel;
        private group4DataSet group4DataSet;
        private System.Windows.Forms.BindingSource albumsBindingSource;
        private group4DataSetTableAdapters.AlbumsTableAdapter albumsTableAdapter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label trackLabel;
        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton punkRadioButton;
        private System.Windows.Forms.RadioButton countryRadioButton;
        private System.Windows.Forms.RadioButton hiphopRadioButton;
        private System.Windows.Forms.Label listensLabel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showAccountInfoToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button displayButton;
        private System.Windows.Forms.Label weeklyLabel;
        private System.Windows.Forms.Label label1;
    }
}