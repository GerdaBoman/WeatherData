namespace UI
{
    partial class OutsidePanel
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
            this.panelOutsideLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // panelOutsideLabel
            // 
            this.panelOutsideLabel.AutoSize = true;
            this.panelOutsideLabel.Font = new System.Drawing.Font("Segoe UI", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.panelOutsideLabel.Location = new System.Drawing.Point(112, 99);
            this.panelOutsideLabel.Name = "panelOutsideLabel";
            this.panelOutsideLabel.Size = new System.Drawing.Size(445, 89);
            this.panelOutsideLabel.TabIndex = 0;
            this.panelOutsideLabel.Text = "Outside Panel";
            // 
            // OutsidePanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelOutsideLabel);
            this.Name = "OutsidePanel";
            this.Size = new System.Drawing.Size(751, 559);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label panelOutsideLabel;
    }
}
