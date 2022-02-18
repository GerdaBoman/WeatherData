namespace UI
{
    partial class RawDataPanel
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
            this.rawdataLabel = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.weatherBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.datumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.platsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tempDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.luftfuktighetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.weatherBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // rawdataLabel
            // 
            this.rawdataLabel.AutoSize = true;
            this.rawdataLabel.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rawdataLabel.Location = new System.Drawing.Point(59, 50);
            this.rawdataLabel.Name = "rawdataLabel";
            this.rawdataLabel.Size = new System.Drawing.Size(189, 54);
            this.rawdataLabel.TabIndex = 0;
            this.rawdataLabel.Text = "Raw Data";
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
            this.dataGridView1.DataSource = this.weatherBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(198, 126);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(443, 390);
            this.dataGridView1.TabIndex = 1;
            // 
            // weatherBindingSource
            // 
            this.weatherBindingSource.DataSource = typeof(DataAccess.Models.Weather);
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
            // RawDataPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.rawdataLabel);
            this.Name = "RawDataPanel";
            this.Size = new System.Drawing.Size(824, 621);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.weatherBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label rawdataLabel;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn datumDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn platsDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn tempDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn luftfuktighetDataGridViewTextBoxColumn;
        private BindingSource weatherBindingSource;
    }
}
