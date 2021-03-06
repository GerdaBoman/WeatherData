namespace UI
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
            this.ListViewer = new System.Windows.Forms.ListView();
            this.Date = new System.Windows.Forms.ColumnHeader();
            this.Location = new System.Windows.Forms.ColumnHeader();
            this.Temperature = new System.Windows.Forms.ColumnHeader();
            this.Humidity = new System.Windows.Forms.ColumnHeader();
            this.moldRisk = new System.Windows.Forms.ColumnHeader();
            this.Reveal = new System.Windows.Forms.Button();
            this.resultLabel = new System.Windows.Forms.Label();
            this.resultView = new System.Windows.Forms.ListView();
            this.DateResults = new System.Windows.Forms.ColumnHeader();
            this.LocationResults = new System.Windows.Forms.ColumnHeader();
            this.TempResults = new System.Windows.Forms.ColumnHeader();
            this.HumResults = new System.Windows.Forms.ColumnHeader();
            this.MoldResults = new System.Windows.Forms.ColumnHeader();
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
            this.statusStripInside = new System.Windows.Forms.StatusStrip();
            this.updateMessageStrip = new System.Windows.Forms.ToolStripStatusLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.MoldRiskLabelIndex = new System.Windows.Forms.Label();
            this.officalAutumnLAbel = new System.Windows.Forms.Label();
            this.autumnResults = new System.Windows.Forms.Label();
            this.officialWinterDayLabel = new System.Windows.Forms.Label();
            this.winterResultsLabel = new System.Windows.Forms.Label();
            this.panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.weatherBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.weatherBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.weatherBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.weatherBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.weatherBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roboGenderContextBindingSource)).BeginInit();
            this.statusStripInside.SuspendLayout();
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
            this.panelMenu.Size = new System.Drawing.Size(194, 566);
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
            this.exitButton.Location = new System.Drawing.Point(0, 514);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(194, 52);
            this.exitButton.TabIndex = 6;
            this.exitButton.Tag = "Exit";
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.ExitButton_Click);
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
            this.homeButton.Click += new System.EventHandler(this.HomeButton_Click);
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
            // ListViewer
            // 
            this.ListViewer.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Date,
            this.Location,
            this.Temperature,
            this.Humidity,
            this.moldRisk});
            this.ListViewer.Location = new System.Drawing.Point(226, 185);
            this.ListViewer.Name = "ListViewer";
            this.ListViewer.Size = new System.Drawing.Size(408, 318);
            this.ListViewer.TabIndex = 18;
            this.ListViewer.UseCompatibleStateImageBehavior = false;
            this.ListViewer.View = System.Windows.Forms.View.Details;
            this.ListViewer.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.ListViewer_SelectedIndexChanged);
            // 
            // Date
            // 
            this.Date.Text = "Date";
            this.Date.Width = 50;
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
            this.moldRisk.Width = 65;
            // 
            // Reveal
            // 
            this.Reveal.FlatAppearance.BorderSize = 0;
            this.Reveal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Reveal.Location = new System.Drawing.Point(590, 29);
            this.Reveal.Name = "Reveal";
            this.Reveal.Size = new System.Drawing.Size(75, 23);
            this.Reveal.TabIndex = 22;
            this.Reveal.UseVisualStyleBackColor = true;
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Location = new System.Drawing.Point(661, 138);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(42, 15);
            this.resultLabel.TabIndex = 21;
            this.resultLabel.Text = "Result:";
            // 
            // resultView
            // 
            this.resultView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.DateResults,
            this.LocationResults,
            this.TempResults,
            this.HumResults,
            this.MoldResults});
            this.resultView.Location = new System.Drawing.Point(661, 156);
            this.resultView.Name = "resultView";
            this.resultView.Size = new System.Drawing.Size(315, 121);
            this.resultView.TabIndex = 20;
            this.resultView.UseCompatibleStateImageBehavior = false;
            this.resultView.View = System.Windows.Forms.View.Details;
            // 
            // DateResults
            // 
            this.DateResults.Text = "Date";
            this.DateResults.Width = 70;
            // 
            // LocationResults
            // 
            this.LocationResults.Text = "Location";
            // 
            // TempResults
            // 
            this.TempResults.Text = "Temperature";
            // 
            // HumResults
            // 
            this.HumResults.Text = "Humidity";
            // 
            // MoldResults
            // 
            this.MoldResults.Text = "Mold Risk";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(690, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 15);
            this.label1.TabIndex = 19;
            this.label1.Text = "Average Temperature and Humidity per day";
            // 
            // showButton
            // 
            this.showButton.Location = new System.Drawing.Point(758, 116);
            this.showButton.Name = "showButton";
            this.showButton.Size = new System.Drawing.Size(75, 23);
            this.showButton.TabIndex = 17;
            this.showButton.Text = "Show";
            this.showButton.UseVisualStyleBackColor = true;
            this.showButton.Click += new System.EventHandler(this.ShowButton_Click);
            // 
            // insideCheckBox
            // 
            this.insideCheckBox.AutoSize = true;
            this.insideCheckBox.Location = new System.Drawing.Point(702, 91);
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
            this.outsideCheckBox.Location = new System.Drawing.Point(836, 89);
            this.outsideCheckBox.Name = "outsideCheckBox";
            this.outsideCheckBox.Size = new System.Drawing.Size(66, 22);
            this.outsideCheckBox.TabIndex = 16;
            this.outsideCheckBox.Text = "Outside";
            this.outsideCheckBox.UseCompatibleTextRendering = true;
            this.outsideCheckBox.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(702, 60);
            this.dateTimePicker1.MaxDate = new System.DateTime(2016, 11, 30, 0, 0, 0, 0);
            this.dateTimePicker1.MinDate = new System.DateTime(2016, 10, 1, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 23);
            this.dateTimePicker1.TabIndex = 14;
            this.dateTimePicker1.Value = new System.DateTime(2016, 10, 1, 0, 0, 0, 0);
            // 
            // statusStripInside
            // 
            this.statusStripInside.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStripInside.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.updateMessageStrip});
            this.statusStripInside.Location = new System.Drawing.Point(194, 544);
            this.statusStripInside.Name = "statusStripInside";
            this.statusStripInside.Size = new System.Drawing.Size(835, 22);
            this.statusStripInside.TabIndex = 23;
            this.statusStripInside.Text = "statusStrip1";
            // 
            // updateMessageStrip
            // 
            this.updateMessageStrip.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.updateMessageStrip.Name = "updateMessageStrip";
            this.updateMessageStrip.Size = new System.Drawing.Size(0, 17);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::UI.Properties.Resources.b7b9175d8dba8065f71d0d7a8bba9d91;
            this.pictureBox1.Location = new System.Drawing.Point(690, 319);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(265, 184);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(226, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 21);
            this.label2.TabIndex = 25;
            this.label2.Text = "Mold Risk index:";
            // 
            // MoldRiskLabelIndex
            // 
            this.MoldRiskLabelIndex.AutoSize = true;
            this.MoldRiskLabelIndex.Location = new System.Drawing.Point(226, 113);
            this.MoldRiskLabelIndex.Name = "MoldRiskLabelIndex";
            this.MoldRiskLabelIndex.Size = new System.Drawing.Size(272, 60);
            this.MoldRiskLabelIndex.TabIndex = 26;
            this.MoldRiskLabelIndex.Text = "0 = No risk\r\n1 = Mold would possibly growth  after > 8 weeks\r\n2 = Mold would poss" +
    "ibly growth  within 4-8 weeks\r\n3 = Mold would possibly growth  0-4 weeks";
            // 
            // officalAutumnLAbel
            // 
            this.officalAutumnLAbel.AutoSize = true;
            this.officalAutumnLAbel.Location = new System.Drawing.Point(225, 506);
            this.officalAutumnLAbel.Name = "officalAutumnLAbel";
            this.officalAutumnLAbel.Size = new System.Drawing.Size(130, 15);
            this.officalAutumnLAbel.TabIndex = 27;
            this.officalAutumnLAbel.Text = "Meterological Autumn:";
            // 
            // autumnResults
            // 
            this.autumnResults.AutoSize = true;
            this.autumnResults.Location = new System.Drawing.Point(355, 506);
            this.autumnResults.Name = "autumnResults";
            this.autumnResults.Size = new System.Drawing.Size(0, 15);
            this.autumnResults.TabIndex = 28;
            // 
            // officialWinterDayLabel
            // 
            this.officialWinterDayLabel.AutoSize = true;
            this.officialWinterDayLabel.Location = new System.Drawing.Point(435, 506);
            this.officialWinterDayLabel.Name = "officialWinterDayLabel";
            this.officialWinterDayLabel.Size = new System.Drawing.Size(128, 15);
            this.officialWinterDayLabel.TabIndex = 29;
            this.officialWinterDayLabel.Text = "Meteorological Winter:";
            // 
            // winterResultsLabel
            // 
            this.winterResultsLabel.AutoSize = true;
            this.winterResultsLabel.Location = new System.Drawing.Point(563, 506);
            this.winterResultsLabel.Name = "winterResultsLabel";
            this.winterResultsLabel.Size = new System.Drawing.Size(0, 15);
            this.winterResultsLabel.TabIndex = 30;
            // 
            // InsideForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 566);
            this.ControlBox = false;
            this.Controls.Add(this.winterResultsLabel);
            this.Controls.Add(this.officialWinterDayLabel);
            this.Controls.Add(this.autumnResults);
            this.Controls.Add(this.officalAutumnLAbel);
            this.Controls.Add(this.Reveal);
            this.Controls.Add(this.MoldRiskLabelIndex);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.statusStripInside);
            this.Controls.Add(this.ListViewer);
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
            this.Text = "Weather Data";
            this.Load += new System.EventHandler(this.InsideForm_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.weatherBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.weatherBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.weatherBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.weatherBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.weatherBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roboGenderContextBindingSource)).EndInit();
            this.statusStripInside.ResumeLayout(false);
            this.statusStripInside.PerformLayout();
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
        public ListView ListViewer;
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
        private StatusStrip statusStripInside;
        private ToolStripStatusLabel updateMessageStrip;
        private PictureBox pictureBox1;
        private Label label2;
        private Label MoldRiskLabelIndex;
        private ColumnHeader DateResults;
        private ColumnHeader LocationResults;
        private ColumnHeader TempResults;
        private ColumnHeader HumResults;
        private ColumnHeader MoldResults;
        private Label officalAutumnLAbel;
        private Label autumnResults;
        private Label officialWinterDayLabel;
        private Label winterResultsLabel;
    }
}