namespace UI
{
    partial class InsidePanel
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
            this.components = new System.ComponentModel.Container();
            this.panelInsideLabel = new System.Windows.Forms.Label();
            this.weatherBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.roboGenderContextBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.weatherBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.weatherBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.datumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.platsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tempDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.luftfuktighetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.weatherBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.updateButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.weatherBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roboGenderContextBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.weatherBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.weatherBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.weatherBindingSource3)).BeginInit();
            this.SuspendLayout();
            // 
            // panelInsideLabel
            // 
            this.panelInsideLabel.AutoSize = true;
            this.panelInsideLabel.Font = new System.Drawing.Font("Segoe UI", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.panelInsideLabel.Location = new System.Drawing.Point(23, 24);
            this.panelInsideLabel.Name = "panelInsideLabel";
            this.panelInsideLabel.Size = new System.Drawing.Size(313, 72);
            this.panelInsideLabel.TabIndex = 0;
            this.panelInsideLabel.Text = "Inside Panel";
            // 
            // weatherBindingSource1
            // 
            this.weatherBindingSource1.DataSource = typeof(DataAccess.Models.Weather);
            // 
            // roboGenderContextBindingSource
            // 
            this.roboGenderContextBindingSource.DataSource = typeof(DataAccess.Data.RoboGenderContext);
            // 
            // weatherBindingSource
            // 
            this.weatherBindingSource.DataSource = typeof(DataAccess.Models.Weather);
            // 
            // weatherBindingSource2
            // 
            this.weatherBindingSource2.DataSource = typeof(DataAccess.Models.Weather);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.datumDataGridViewTextBoxColumn,
            this.platsDataGridViewTextBoxColumn,
            this.tempDataGridViewTextBoxColumn,
            this.luftfuktighetDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.weatherBindingSource3;
            this.dataGridView1.Location = new System.Drawing.Point(23, 120);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(450, 379);
            this.dataGridView1.TabIndex = 1;
            // 
            // datumDataGridViewTextBoxColumn
            // 
            this.datumDataGridViewTextBoxColumn.DataPropertyName = "Datum";
            this.datumDataGridViewTextBoxColumn.HeaderText = "Datum";
            this.datumDataGridViewTextBoxColumn.Name = "datumDataGridViewTextBoxColumn";
            // 
            // platsDataGridViewTextBoxColumn
            // 
            this.platsDataGridViewTextBoxColumn.DataPropertyName = "Plats";
            this.platsDataGridViewTextBoxColumn.HeaderText = "Plats";
            this.platsDataGridViewTextBoxColumn.Name = "platsDataGridViewTextBoxColumn";
            // 
            // tempDataGridViewTextBoxColumn
            // 
            this.tempDataGridViewTextBoxColumn.DataPropertyName = "Temp";
            this.tempDataGridViewTextBoxColumn.HeaderText = "Temp";
            this.tempDataGridViewTextBoxColumn.Name = "tempDataGridViewTextBoxColumn";
            // 
            // luftfuktighetDataGridViewTextBoxColumn
            // 
            this.luftfuktighetDataGridViewTextBoxColumn.DataPropertyName = "Luftfuktighet";
            this.luftfuktighetDataGridViewTextBoxColumn.HeaderText = "Luftfuktighet";
            this.luftfuktighetDataGridViewTextBoxColumn.Name = "luftfuktighetDataGridViewTextBoxColumn";
            // 
            // weatherBindingSource3
            // 
            this.weatherBindingSource3.DataSource = typeof(DataAccess.Models.Weather);
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(358, 52);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(75, 23);
            this.updateButton.TabIndex = 2;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // InsidePanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panelInsideLabel);
            this.Name = "InsidePanel";
            this.Size = new System.Drawing.Size(713, 522);
            ((System.ComponentModel.ISupportInitialize)(this.weatherBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roboGenderContextBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.weatherBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.weatherBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.weatherBindingSource3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label panelInsideLabel;
        private BindingSource weatherBindingSource1;
        private BindingSource roboGenderContextBindingSource;
        private BindingSource weatherBindingSource;
        private BindingSource weatherBindingSource2;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn datumDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn platsDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn tempDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn luftfuktighetDataGridViewTextBoxColumn;
        private BindingSource weatherBindingSource3;
        private Button updateButton;
    }
}
