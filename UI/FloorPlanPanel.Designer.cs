namespace UI
{
    partial class FloorPlanPanel
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
            this.panelPicFloorPlan = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.panelPicFloorPlan)).BeginInit();
            this.SuspendLayout();
            // 
            // panelPicFloorPlan
            // 
            this.panelPicFloorPlan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPicFloorPlan.Image = global::UI.Properties.Resources.planlösning;
            this.panelPicFloorPlan.Location = new System.Drawing.Point(0, 0);
            this.panelPicFloorPlan.Name = "panelPicFloorPlan";
            this.panelPicFloorPlan.Size = new System.Drawing.Size(654, 462);
            this.panelPicFloorPlan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.panelPicFloorPlan.TabIndex = 0;
            this.panelPicFloorPlan.TabStop = false;
            // 
            // FloorPlanPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panelPicFloorPlan);
            this.Name = "FloorPlanPanel";
            this.Size = new System.Drawing.Size(654, 462);
            ((System.ComponentModel.ISupportInitialize)(this.panelPicFloorPlan)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox panelPicFloorPlan;
    }
}
