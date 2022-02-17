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
            this.weatherBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.weatherBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.refreshButton = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.insideCheckBox = new System.Windows.Forms.CheckBox();
            this.outsideCheckBox = new System.Windows.Forms.CheckBox();
            this.showButton = new System.Windows.Forms.Button();
            this.listBox = new System.Windows.Forms.ListBox();
            this.listView1 = new System.Windows.Forms.ListView();
            ((System.ComponentModel.ISupportInitialize)(this.weatherBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roboGenderContextBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.weatherBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.weatherBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.weatherBindingSource4)).BeginInit();
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
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.datumDataGridViewTextBoxColumn,
            this.platsDataGridViewTextBoxColumn,
            this.tempDataGridViewTextBoxColumn,
            this.luftfuktighetDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.weatherBindingSource4;
            this.dataGridView1.Location = new System.Drawing.Point(23, 120);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(476, 560);
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
            // weatherBindingSource4
            // 
            this.weatherBindingSource4.DataSource = typeof(DataAccess.Models.Weather);
            // 
            // refreshButton
            // 
            this.refreshButton.Location = new System.Drawing.Point(358, 52);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(75, 23);
            this.refreshButton.TabIndex = 2;
            this.refreshButton.Text = "Refresh";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(577, 52);
            this.dateTimePicker1.MaxDate = new System.DateTime(2016, 11, 30, 0, 0, 0, 0);
            this.dateTimePicker1.MinDate = new System.DateTime(2016, 10, 1, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 23);
            this.dateTimePicker1.TabIndex = 3;
            this.dateTimePicker1.Value = new System.DateTime(2016, 10, 1, 0, 0, 0, 0);
            // 
            // insideCheckBox
            // 
            this.insideCheckBox.AutoSize = true;
            this.insideCheckBox.Location = new System.Drawing.Point(574, 99);
            this.insideCheckBox.Name = "insideCheckBox";
            this.insideCheckBox.Size = new System.Drawing.Size(57, 19);
            this.insideCheckBox.TabIndex = 4;
            this.insideCheckBox.Text = "Inside";
            this.insideCheckBox.UseVisualStyleBackColor = true;
            // 
            // outsideCheckBox
            // 
            this.outsideCheckBox.AutoSize = true;
            this.outsideCheckBox.Location = new System.Drawing.Point(716, 99);
            this.outsideCheckBox.Name = "outsideCheckBox";
            this.outsideCheckBox.Size = new System.Drawing.Size(66, 22);
            this.outsideCheckBox.TabIndex = 5;
            this.outsideCheckBox.Text = "Outside";
            this.outsideCheckBox.UseCompatibleTextRendering = true;
            this.outsideCheckBox.UseVisualStyleBackColor = true;
            // 
            // showButton
            // 
            this.showButton.Location = new System.Drawing.Point(641, 141);
            this.showButton.Name = "showButton";
            this.showButton.Size = new System.Drawing.Size(75, 23);
            this.showButton.TabIndex = 6;
            this.showButton.Text = "Show";
            this.showButton.UseVisualStyleBackColor = true;
            this.showButton.Click += new System.EventHandler(this.showButton_Click);
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.ItemHeight = 15;
            this.listBox.Location = new System.Drawing.Point(522, 189);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(344, 109);
            this.listBox.TabIndex = 7;
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(522, 358);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(344, 89);
            this.listView1.TabIndex = 8;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // InsidePanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.showButton);
            this.Controls.Add(this.outsideCheckBox);
            this.Controls.Add(this.insideCheckBox);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panelInsideLabel);
            this.Name = "InsidePanel";
            this.Size = new System.Drawing.Size(895, 683);
            ((System.ComponentModel.ISupportInitialize)(this.weatherBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roboGenderContextBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.weatherBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.weatherBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.weatherBindingSource4)).EndInit();
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
        private Button refreshButton;
        private DateTimePicker dateTimePicker1;
        private CheckBox insideCheckBox;
        private CheckBox outsideCheckBox;
        private Button showButton;
        private BindingSource weatherBindingSource4;
        private ListBox listBox;
        private ListView listView1;
    }
}
