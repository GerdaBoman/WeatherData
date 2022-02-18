namespace UI
{
    partial class HomePanel
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomePanel));
            this.panelHomeLabel = new System.Windows.Forms.Label();
            this.infolabel = new System.Windows.Forms.Label();
            this.browseButton = new System.Windows.Forms.Button();
            this.textFilePath = new System.Windows.Forms.TextBox();
            this.importButton = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.welcomeMessageLabel = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.importMessageStatusBar = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHomeLabel
            // 
            this.panelHomeLabel.AutoSize = true;
            this.panelHomeLabel.Font = new System.Drawing.Font("Segoe UI", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.panelHomeLabel.Location = new System.Drawing.Point(22, 22);
            this.panelHomeLabel.Name = "panelHomeLabel";
            this.panelHomeLabel.Size = new System.Drawing.Size(317, 72);
            this.panelHomeLabel.TabIndex = 0;
            this.panelHomeLabel.Text = "Home Panel";
            // 
            // infolabel
            // 
            this.infolabel.AutoSize = true;
            this.infolabel.Location = new System.Drawing.Point(94, 374);
            this.infolabel.Name = "infolabel";
            this.infolabel.Size = new System.Drawing.Size(99, 15);
            this.infolabel.TabIndex = 1;
            this.infolabel.Text = "Choose CSV  file: ";
            // 
            // browseButton
            // 
            this.browseButton.Location = new System.Drawing.Point(512, 374);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(75, 23);
            this.browseButton.TabIndex = 2;
            this.browseButton.Text = "Browse";
            this.browseButton.UseVisualStyleBackColor = true;
            this.browseButton.Click += new System.EventHandler(this.browseButton_Click);
            // 
            // textFilePath
            // 
            this.textFilePath.Location = new System.Drawing.Point(233, 374);
            this.textFilePath.Name = "textFilePath";
            this.textFilePath.Size = new System.Drawing.Size(245, 23);
            this.textFilePath.TabIndex = 3;
            // 
            // importButton
            // 
            this.importButton.Location = new System.Drawing.Point(512, 403);
            this.importButton.Name = "importButton";
            this.importButton.Size = new System.Drawing.Size(75, 23);
            this.importButton.TabIndex = 4;
            this.importButton.Text = "Import";
            this.importButton.UseVisualStyleBackColor = true;
            this.importButton.Click += new System.EventHandler(this.importButton_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // welcomeMessageLabel
            // 
            this.welcomeMessageLabel.AutoSize = true;
            this.welcomeMessageLabel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.welcomeMessageLabel.Location = new System.Drawing.Point(155, 104);
            this.welcomeMessageLabel.Name = "welcomeMessageLabel";
            this.welcomeMessageLabel.Size = new System.Drawing.Size(493, 252);
            this.welcomeMessageLabel.TabIndex = 5;
            this.welcomeMessageLabel.Text = resources.GetString("welcomeMessageLabel.Text");
            this.welcomeMessageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importMessageStatusBar});
            this.statusStrip1.Location = new System.Drawing.Point(0, 540);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(755, 22);
            this.statusStrip1.TabIndex = 6;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // importMessageStatusBar
            // 
            this.importMessageStatusBar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.importMessageStatusBar.Name = "importMessageStatusBar";
            this.importMessageStatusBar.Size = new System.Drawing.Size(0, 17);
            // 
            // HomePanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.welcomeMessageLabel);
            this.Controls.Add(this.importButton);
            this.Controls.Add(this.textFilePath);
            this.Controls.Add(this.browseButton);
            this.Controls.Add(this.infolabel);
            this.Controls.Add(this.panelHomeLabel);
            this.Name = "HomePanel";
            this.Size = new System.Drawing.Size(755, 562);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label panelHomeLabel;
        private Label infolabel;
        private Button browseButton;
        private TextBox textFilePath;
        private Button importButton;
        private OpenFileDialog openFileDialog1;
        private Label welcomeMessageLabel;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel importMessageStatusBar;
    }
}
