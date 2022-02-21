﻿namespace UI
{
    partial class InsideForm
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
            this.panelMenu = new System.Windows.Forms.Panel();
            this.exitButton = new FontAwesome.Sharp.IconButton();
            this.WeatherDataButton = new FontAwesome.Sharp.IconButton();
            this.homeButton = new FontAwesome.Sharp.IconButton();
            this.menuIcon = new FontAwesome.Sharp.IconButton();
            this.groupName = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.Date = new System.Windows.Forms.ColumnHeader();
            this.Location = new System.Windows.Forms.ColumnHeader();
            this.Temperature = new System.Windows.Forms.ColumnHeader();
            this.Humidity = new System.Windows.Forms.ColumnHeader();
            this.moldRisk = new System.Windows.Forms.ColumnHeader();
            this.Reveal = new System.Windows.Forms.Button();
            this.resultLabel = new System.Windows.Forms.Label();
            this.resultView = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.showButton = new System.Windows.Forms.Button();
            this.insideCheckBox = new System.Windows.Forms.CheckBox();
            this.weatherBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.panelInsideLabel = new System.Windows.Forms.Label();
            this.weatherBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.weatherBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.weatherBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.weatherBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.roboGenderContextBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.outsideCheckBox = new System.Windows.Forms.CheckBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.weatherBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.weatherBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.weatherBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.weatherBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.weatherBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roboGenderContextBindingSource)).BeginInit();
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
            this.panelMenu.Size = new System.Drawing.Size(194, 638);
            this.panelMenu.TabIndex = 1;
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
            this.exitButton.Location = new System.Drawing.Point(0, 586);
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
            this.WeatherDataButton.Click += new System.EventHandler(this.WeatherDataButton_Click);
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
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Date,
            this.Location,
            this.Temperature,
            this.Humidity,
            this.moldRisk});
            this.listView1.Location = new System.Drawing.Point(210, 152);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(426, 346);
            this.listView1.TabIndex = 18;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.listView1_SelectedIndexChanged);
            // 
            // Date
            // 
            this.Date.Text = "Date";
            this.Date.Width = 90;
            // 
            // Location
            // 
            this.Location.Text = "Location";
            this.Location.Width = 90;
            // 
            // Temperature
            // 
            this.Temperature.Text = "Temperature";
            this.Temperature.Width = 90;
            // 
            // Humidity
            // 
            this.Humidity.Text = "Humidity";
            this.Humidity.Width = 90;
            // 
            // moldRisk
            // 
            this.moldRisk.Text = "Mold Risk";
            this.moldRisk.Width = 90;
            // 
            // Reveal
            // 
            this.Reveal.Location = new System.Drawing.Point(355, 107);
            this.Reveal.Name = "Reveal";
            this.Reveal.Size = new System.Drawing.Size(75, 23);
            this.Reveal.TabIndex = 22;
            this.Reveal.Text = "Reveal";
            this.Reveal.UseVisualStyleBackColor = true;
            this.Reveal.Click += new System.EventHandler(this.Reveal_Click);
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Location = new System.Drawing.Point(657, 350);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(42, 15);
            this.resultLabel.TabIndex = 21;
            this.resultLabel.Text = "Result:";
            // 
            // resultView
            // 
            this.resultView.Location = new System.Drawing.Point(657, 377);
            this.resultView.Name = "resultView";
            this.resultView.Size = new System.Drawing.Size(272, 121);
            this.resultView.TabIndex = 20;
            this.resultView.UseCompatibleStateImageBehavior = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(674, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 15);
            this.label1.TabIndex = 19;
            this.label1.Text = "Average Temperatur and Humidity per day";
            // 
            // showButton
            // 
            this.showButton.Location = new System.Drawing.Point(752, 265);
            this.showButton.Name = "showButton";
            this.showButton.Size = new System.Drawing.Size(75, 23);
            this.showButton.TabIndex = 17;
            this.showButton.Text = "Show";
            this.showButton.UseVisualStyleBackColor = true;
            this.showButton.Click += new System.EventHandler(this.showButton_Click);
            // 
            // insideCheckBox
            // 
            this.insideCheckBox.AutoSize = true;
            this.insideCheckBox.Location = new System.Drawing.Point(689, 229);
            this.insideCheckBox.Name = "insideCheckBox";
            this.insideCheckBox.Size = new System.Drawing.Size(57, 19);
            this.insideCheckBox.TabIndex = 15;
            this.insideCheckBox.Text = "Inside";
            this.insideCheckBox.UseVisualStyleBackColor = true;
            // 
            // panelInsideLabel
            // 
            this.panelInsideLabel.AutoSize = true;
            this.panelInsideLabel.Font = new System.Drawing.Font("Segoe UI", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.panelInsideLabel.Location = new System.Drawing.Point(198, 7);
            this.panelInsideLabel.Name = "panelInsideLabel";
            this.panelInsideLabel.Size = new System.Drawing.Size(354, 72);
            this.panelInsideLabel.TabIndex = 13;
            this.panelInsideLabel.Text = "Weather Data";
            // 
            // outsideCheckBox
            // 
            this.outsideCheckBox.AutoSize = true;
            this.outsideCheckBox.Location = new System.Drawing.Point(823, 227);
            this.outsideCheckBox.Name = "outsideCheckBox";
            this.outsideCheckBox.Size = new System.Drawing.Size(66, 22);
            this.outsideCheckBox.TabIndex = 16;
            this.outsideCheckBox.Text = "Outside";
            this.outsideCheckBox.UseCompatibleTextRendering = true;
            this.outsideCheckBox.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(689, 198);
            this.dateTimePicker1.MaxDate = new System.DateTime(2016, 11, 30, 0, 0, 0, 0);
            this.dateTimePicker1.MinDate = new System.DateTime(2016, 10, 1, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 23);
            this.dateTimePicker1.TabIndex = 14;
            this.dateTimePicker1.Value = new System.DateTime(2016, 10, 1, 0, 0, 0, 0);
            // 
            // InsideForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 638);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.Reveal);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.resultView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.showButton);
            this.Controls.Add(this.insideCheckBox);
            this.Controls.Add(this.panelInsideLabel);
            this.Controls.Add(this.outsideCheckBox);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.panelMenu);
            this.Name = "InsideForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InsideForm";
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.weatherBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.weatherBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.weatherBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.weatherBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.weatherBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roboGenderContextBindingSource)).EndInit();
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
        public ListView listView1;
        private ColumnHeader Date;
        private ColumnHeader Location;
        private ColumnHeader Temperature;
        private ColumnHeader Humidity;
        private ColumnHeader moldRisk;
        private Button Reveal;
        private Label resultLabel;
        private ListView resultView;
        private Label label1;
        private Button showButton;
        private CheckBox insideCheckBox;
        private BindingSource weatherBindingSource1;
        private Label panelInsideLabel;
        private BindingSource weatherBindingSource3;
        private BindingSource weatherBindingSource4;
        private BindingSource weatherBindingSource2;
        private BindingSource weatherBindingSource;
        private BindingSource roboGenderContextBindingSource;
        private CheckBox outsideCheckBox;
        private DateTimePicker dateTimePicker1;
    }
}