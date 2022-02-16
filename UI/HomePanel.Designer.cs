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
            this.panelHomeLabel = new System.Windows.Forms.Label();
            this.infolabel = new System.Windows.Forms.Label();
            this.browseButton = new System.Windows.Forms.Button();
            this.textFilePath = new System.Windows.Forms.TextBox();
            this.importButton = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.importProgressBar = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // panelHomeLabel
            // 
            this.panelHomeLabel.AutoSize = true;
            this.panelHomeLabel.Font = new System.Drawing.Font("Segoe UI", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.panelHomeLabel.Location = new System.Drawing.Point(63, 27);
            this.panelHomeLabel.Name = "panelHomeLabel";
            this.panelHomeLabel.Size = new System.Drawing.Size(317, 72);
            this.panelHomeLabel.TabIndex = 0;
            this.panelHomeLabel.Text = "Home Panel";
            // 
            // infolabel
            // 
            this.infolabel.AutoSize = true;
            this.infolabel.Location = new System.Drawing.Point(98, 186);
            this.infolabel.Name = "infolabel";
            this.infolabel.Size = new System.Drawing.Size(99, 15);
            this.infolabel.TabIndex = 1;
            this.infolabel.Text = "Choose CSV  file: ";
            // 
            // browseButton
            // 
            this.browseButton.Location = new System.Drawing.Point(462, 182);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(75, 23);
            this.browseButton.TabIndex = 2;
            this.browseButton.Text = "Browse";
            this.browseButton.UseVisualStyleBackColor = true;
            this.browseButton.Click += new System.EventHandler(this.browseButton_Click);
            // 
            // textFilePath
            // 
            this.textFilePath.Location = new System.Drawing.Point(203, 183);
            this.textFilePath.Name = "textFilePath";
            this.textFilePath.Size = new System.Drawing.Size(245, 23);
            this.textFilePath.TabIndex = 3;
            // 
            // importButton
            // 
            this.importButton.Location = new System.Drawing.Point(462, 211);
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
            // importProgressBar
            // 
            this.importProgressBar.Location = new System.Drawing.Point(348, 212);
            this.importProgressBar.Name = "importProgressBar";
            this.importProgressBar.Size = new System.Drawing.Size(100, 23);
            this.importProgressBar.TabIndex = 5;
            // 
            // HomePanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.importProgressBar);
            this.Controls.Add(this.importButton);
            this.Controls.Add(this.textFilePath);
            this.Controls.Add(this.browseButton);
            this.Controls.Add(this.infolabel);
            this.Controls.Add(this.panelHomeLabel);
            this.Name = "HomePanel";
            this.Size = new System.Drawing.Size(649, 501);
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
        private ProgressBar importProgressBar;
    }
}
