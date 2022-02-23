namespace UI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.exitButton = new FontAwesome.Sharp.IconButton();
            this.WeatherDataButton = new FontAwesome.Sharp.IconButton();
            this.homeButton = new FontAwesome.Sharp.IconButton();
            this.menuIcon = new FontAwesome.Sharp.IconButton();
            this.groupName = new System.Windows.Forms.Label();
            this.welcomeMessageLabel = new System.Windows.Forms.Label();
            this.importButton = new System.Windows.Forms.Button();
            this.textFilePath = new System.Windows.Forms.TextBox();
            this.browseButton = new System.Windows.Forms.Button();
            this.infolabel = new System.Windows.Forms.Label();
            this.panelHomeLabel = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.importMessageStatusBar = new System.Windows.Forms.ToolStripStatusLabel();
            this.importMessageBar = new System.Windows.Forms.ToolStripStatusLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelMenu.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(69)))), ((int)(((byte)(89)))));
            this.panelMenu.Controls.Add(this.exitButton);
            this.panelMenu.Controls.Add(this.WeatherDataButton);
            this.panelMenu.Controls.Add(this.homeButton);
            this.panelMenu.Controls.Add(this.menuIcon);
            this.panelMenu.Controls.Add(this.groupName);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(194, 562);
            this.panelMenu.TabIndex = 0;
            // 
            // exitButton
            // 
            this.exitButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.exitButton.FlatAppearance.BorderSize = 0;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.exitButton.ForeColor = System.Drawing.Color.White;
            this.exitButton.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.exitButton.IconColor = System.Drawing.Color.White;
            this.exitButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.exitButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.exitButton.Location = new System.Drawing.Point(0, 510);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(194, 52);
            this.exitButton.TabIndex = 6;
            this.exitButton.Tag = "Exit";
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // WeatherDataButton
            // 
            this.WeatherDataButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.WeatherDataButton.FlatAppearance.BorderSize = 0;
            this.WeatherDataButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.WeatherDataButton.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.WeatherDataButton.ForeColor = System.Drawing.Color.White;
            this.WeatherDataButton.IconChar = FontAwesome.Sharp.IconChar.Snowflake;
            this.WeatherDataButton.IconColor = System.Drawing.Color.White;
            this.WeatherDataButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.WeatherDataButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.WeatherDataButton.Location = new System.Drawing.Point(0, 130);
            this.WeatherDataButton.Name = "WeatherDataButton";
            this.WeatherDataButton.Size = new System.Drawing.Size(194, 56);
            this.WeatherDataButton.TabIndex = 3;
            this.WeatherDataButton.Tag = "Inside Temperature";
            this.WeatherDataButton.Text = "           Weather Data\r\n\r\n";
            this.WeatherDataButton.UseVisualStyleBackColor = true;
            this.WeatherDataButton.Click += new System.EventHandler(this.insideButton_Click);
            // 
            // homeButton
            // 
            this.homeButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.homeButton.FlatAppearance.BorderSize = 0;
            this.homeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.homeButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.homeButton.ForeColor = System.Drawing.Color.White;
            this.homeButton.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.homeButton.IconColor = System.Drawing.Color.White;
            this.homeButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.homeButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.homeButton.Location = new System.Drawing.Point(0, 74);
            this.homeButton.Name = "homeButton";
            this.homeButton.Size = new System.Drawing.Size(194, 56);
            this.homeButton.TabIndex = 2;
            this.homeButton.Tag = "Home";
            this.homeButton.Text = "Home";
            this.homeButton.UseVisualStyleBackColor = true;
            this.homeButton.Click += new System.EventHandler(this.homeButton_Click);
            // 
            // menuIcon
            // 
            this.menuIcon.FlatAppearance.BorderSize = 0;
            this.menuIcon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menuIcon.IconChar = FontAwesome.Sharp.IconChar.Bars;
            this.menuIcon.IconColor = System.Drawing.Color.White;
            this.menuIcon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuIcon.IconSize = 30;
            this.menuIcon.Location = new System.Drawing.Point(107, 12);
            this.menuIcon.Name = "menuIcon";
            this.menuIcon.Size = new System.Drawing.Size(72, 41);
            this.menuIcon.TabIndex = 1;
            this.menuIcon.UseVisualStyleBackColor = true;
            // 
            // groupName
            // 
            this.groupName.AutoSize = true;
            this.groupName.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupName.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupName.ForeColor = System.Drawing.Color.White;
            this.groupName.Location = new System.Drawing.Point(0, 0);
            this.groupName.Name = "groupName";
            this.groupName.Size = new System.Drawing.Size(110, 74);
            this.groupName.TabIndex = 0;
            this.groupName.Text = "Robo \r\nGender";
            this.groupName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // welcomeMessageLabel
            // 
            this.welcomeMessageLabel.AutoSize = true;
            this.welcomeMessageLabel.BackColor = System.Drawing.Color.Transparent;
            this.welcomeMessageLabel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.welcomeMessageLabel.Location = new System.Drawing.Point(349, 196);
            this.welcomeMessageLabel.Name = "welcomeMessageLabel";
            this.welcomeMessageLabel.Size = new System.Drawing.Size(493, 252);
            this.welcomeMessageLabel.TabIndex = 11;
            this.welcomeMessageLabel.Text = resources.GetString("welcomeMessageLabel.Text");
            this.welcomeMessageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // importButton
            // 
            this.importButton.Location = new System.Drawing.Point(744, 144);
            this.importButton.Name = "importButton";
            this.importButton.Size = new System.Drawing.Size(75, 23);
            this.importButton.TabIndex = 10;
            this.importButton.Text = "Import";
            this.importButton.UseVisualStyleBackColor = true;
            this.importButton.Click += new System.EventHandler(this.importButton_Click);
            // 
            // textFilePath
            // 
            this.textFilePath.Location = new System.Drawing.Point(465, 115);
            this.textFilePath.Name = "textFilePath";
            this.textFilePath.Size = new System.Drawing.Size(245, 23);
            this.textFilePath.TabIndex = 9;
            // 
            // browseButton
            // 
            this.browseButton.Location = new System.Drawing.Point(744, 115);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(75, 23);
            this.browseButton.TabIndex = 8;
            this.browseButton.Text = "Browse";
            this.browseButton.UseVisualStyleBackColor = true;
            this.browseButton.Click += new System.EventHandler(this.browseButton_Click);
            // 
            // infolabel
            // 
            this.infolabel.AutoSize = true;
            this.infolabel.Location = new System.Drawing.Point(326, 115);
            this.infolabel.Name = "infolabel";
            this.infolabel.Size = new System.Drawing.Size(99, 15);
            this.infolabel.TabIndex = 7;
            this.infolabel.Text = "Choose CSV  file: ";
            // 
            // panelHomeLabel
            // 
            this.panelHomeLabel.AutoSize = true;
            this.panelHomeLabel.Font = new System.Drawing.Font("Segoe UI", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.panelHomeLabel.Location = new System.Drawing.Point(207, 7);
            this.panelHomeLabel.Name = "panelHomeLabel";
            this.panelHomeLabel.Size = new System.Drawing.Size(190, 72);
            this.panelHomeLabel.TabIndex = 6;
            this.panelHomeLabel.Text = "Home ";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importMessageStatusBar,
            this.importMessageBar});
            this.statusStrip1.Location = new System.Drawing.Point(194, 540);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(780, 22);
            this.statusStrip1.TabIndex = 12;
            // 
            // importMessageStatusBar
            // 
            this.importMessageStatusBar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.importMessageStatusBar.Name = "importMessageStatusBar";
            this.importMessageStatusBar.Size = new System.Drawing.Size(0, 17);
            // 
            // importMessageBar
            // 
            this.importMessageBar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.importMessageBar.Name = "importMessageBar";
            this.importMessageBar.Size = new System.Drawing.Size(0, 17);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::UI.Properties.Resources._5f18d89c79362f875744a59d750f0a65;
<<<<<<< Updated upstream
            this.pictureBox1.Location = new System.Drawing.Point(228, 320);
=======
            this.pictureBox1.Location = new System.Drawing.Point(249, 324);
>>>>>>> Stashed changes
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(263, 177);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(974, 562);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.welcomeMessageLabel);
            this.Controls.Add(this.importButton);
            this.Controls.Add(this.textFilePath);
            this.Controls.Add(this.browseButton);
            this.Controls.Add(this.infolabel);
            this.Controls.Add(this.panelHomeLabel);
            this.Controls.Add(this.panelMenu);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Robo Gender Weather";
            this.TopMost = true;
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panelMenu;
        private FontAwesome.Sharp.IconButton exitButton;
        private FontAwesome.Sharp.IconButton WeatherDataButton;
        private FontAwesome.Sharp.IconButton homeButton;
        private FontAwesome.Sharp.IconButton menuIcon;
        private Label groupName;
        private Label welcomeMessageLabel;
        private Button importButton;
        private TextBox textFilePath;
        private Button browseButton;
        private Label infolabel;
        private Label panelHomeLabel;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel importMessageStatusBar;
        private ToolStripStatusLabel importMessageBar;
        private PictureBox pictureBox1;
    }
}