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
            this.panelMenu = new System.Windows.Forms.Panel();
            this.floorPlanButton = new FontAwesome.Sharp.IconButton();
            this.exitButton = new FontAwesome.Sharp.IconButton();
            this.outsideButton = new FontAwesome.Sharp.IconButton();
            this.insideButton = new FontAwesome.Sharp.IconButton();
            this.homeButton = new FontAwesome.Sharp.IconButton();
            this.menuIcon = new FontAwesome.Sharp.IconButton();
            this.groupName = new System.Windows.Forms.Label();
            this.homePanel1 = new UI.HomePanel();
            this.insidePanel1 = new UI.InsidePanel();
            this.outsidePanel1 = new UI.OutsidePanel();
            this.floorPlanPanel1 = new UI.FloorPlanPanel();
            this.panelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(69)))), ((int)(((byte)(89)))));
            this.panelMenu.Controls.Add(this.floorPlanButton);
            this.panelMenu.Controls.Add(this.exitButton);
            this.panelMenu.Controls.Add(this.outsideButton);
            this.panelMenu.Controls.Add(this.insideButton);
            this.panelMenu.Controls.Add(this.homeButton);
            this.panelMenu.Controls.Add(this.menuIcon);
            this.panelMenu.Controls.Add(this.groupName);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(200, 948);
            this.panelMenu.TabIndex = 0;
            // 
            // floorPlanButton
            // 
            this.floorPlanButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.floorPlanButton.FlatAppearance.BorderSize = 0;
            this.floorPlanButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.floorPlanButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.floorPlanButton.ForeColor = System.Drawing.Color.White;
            this.floorPlanButton.IconChar = FontAwesome.Sharp.IconChar.HouseUser;
            this.floorPlanButton.IconColor = System.Drawing.Color.White;
            this.floorPlanButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.floorPlanButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.floorPlanButton.Location = new System.Drawing.Point(0, 840);
            this.floorPlanButton.Name = "floorPlanButton";
            this.floorPlanButton.Size = new System.Drawing.Size(200, 56);
            this.floorPlanButton.TabIndex = 7;
            this.floorPlanButton.Tag = "Floor Plan";
            this.floorPlanButton.Text = "Floor Plan";
            this.floorPlanButton.UseVisualStyleBackColor = true;
            this.floorPlanButton.Click += new System.EventHandler(this.floorPlanButton_Click);
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
            this.exitButton.Location = new System.Drawing.Point(0, 896);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(200, 52);
            this.exitButton.TabIndex = 6;
            this.exitButton.Tag = "Exit";
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // outsideButton
            // 
            this.outsideButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.outsideButton.FlatAppearance.BorderSize = 0;
            this.outsideButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.outsideButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.outsideButton.ForeColor = System.Drawing.Color.White;
            this.outsideButton.IconChar = FontAwesome.Sharp.IconChar.Tree;
            this.outsideButton.IconColor = System.Drawing.Color.White;
            this.outsideButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.outsideButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.outsideButton.Location = new System.Drawing.Point(0, 186);
            this.outsideButton.Name = "outsideButton";
            this.outsideButton.Size = new System.Drawing.Size(200, 56);
            this.outsideButton.TabIndex = 4;
            this.outsideButton.Tag = "Outside Temperature";
            this.outsideButton.Text = "Outside";
            this.outsideButton.UseVisualStyleBackColor = true;
            this.outsideButton.Click += new System.EventHandler(this.outsideButton_Click);
            // 
            // insideButton
            // 
            this.insideButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.insideButton.FlatAppearance.BorderSize = 0;
            this.insideButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.insideButton.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.insideButton.ForeColor = System.Drawing.Color.White;
            this.insideButton.IconChar = FontAwesome.Sharp.IconChar.HouseUser;
            this.insideButton.IconColor = System.Drawing.Color.White;
            this.insideButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.insideButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.insideButton.Location = new System.Drawing.Point(0, 130);
            this.insideButton.Name = "insideButton";
            this.insideButton.Size = new System.Drawing.Size(200, 56);
            this.insideButton.TabIndex = 3;
            this.insideButton.Tag = "Inside Temperature";
            this.insideButton.Text = "Inside ";
            this.insideButton.UseVisualStyleBackColor = true;
            this.insideButton.Click += new System.EventHandler(this.insideButton_Click);
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
            this.homeButton.Size = new System.Drawing.Size(200, 56);
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
            this.menuIcon.Location = new System.Drawing.Point(116, 12);
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
            // homePanel1
            // 
            this.homePanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.homePanel1.Location = new System.Drawing.Point(200, 0);
            this.homePanel1.Name = "homePanel1";
            this.homePanel1.Size = new System.Drawing.Size(1129, 948);
            this.homePanel1.TabIndex = 1;
            // 
            // insidePanel1
            // 
            this.insidePanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.insidePanel1.Location = new System.Drawing.Point(200, 0);
            this.insidePanel1.Name = "insidePanel1";
            this.insidePanel1.Size = new System.Drawing.Size(1129, 948);
            this.insidePanel1.TabIndex = 2;
            // 
            // outsidePanel1
            // 
            this.outsidePanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.outsidePanel1.Location = new System.Drawing.Point(200, 0);
            this.outsidePanel1.Name = "outsidePanel1";
            this.outsidePanel1.Size = new System.Drawing.Size(1129, 948);
            this.outsidePanel1.TabIndex = 3;
            // 
            // floorPlanPanel1
            // 
            this.floorPlanPanel1.BackColor = System.Drawing.Color.White;
            this.floorPlanPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.floorPlanPanel1.Location = new System.Drawing.Point(200, 0);
            this.floorPlanPanel1.Name = "floorPlanPanel1";
            this.floorPlanPanel1.Size = new System.Drawing.Size(1129, 948);
            this.floorPlanPanel1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1329, 948);
            this.Controls.Add(this.floorPlanPanel1);
            this.Controls.Add(this.outsidePanel1);
            this.Controls.Add(this.insidePanel1);
            this.Controls.Add(this.homePanel1);
            this.Controls.Add(this.panelMenu);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Robo Gender Weather";
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panelMenu;
        private FontAwesome.Sharp.IconButton exitButton;
        private FontAwesome.Sharp.IconButton outsideButton;
        private FontAwesome.Sharp.IconButton insideButton;
        private FontAwesome.Sharp.IconButton homeButton;
        private FontAwesome.Sharp.IconButton menuIcon;
        private Label groupName;
        private FontAwesome.Sharp.IconButton floorPlanButton;
        private HomePanel homePanel1;
        private InsidePanel insidePanel1;
        private OutsidePanel outsidePanel1;
        private FloorPlanPanel floorPlanPanel1;
    }
}