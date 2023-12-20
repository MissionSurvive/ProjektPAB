namespace CarRental
{
    partial class OrderHistoryForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderHistoryForm));
            this.TableLabel = new System.Windows.Forms.Label();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.FilterButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDHISTORIADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDPRACDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDZAMOWIENIEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDKLIENTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dATAWYDANIEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dATAPRZYJECIEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tANKOWANIEDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.iLOSCTANKOWANIEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kOSZTTANKOWANIEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kOLIZJADataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dATAKOLIZJADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kARAKOLIZJADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hISTORIAZAMOWIENIABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.allDataSet = new CarRental.AllDataSet();
            this.hISTORIA_ZAMOWIENIATableAdapter = new CarRental.AllDataSetTableAdapters.HISTORIA_ZAMOWIENIATableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hISTORIAZAMOWIENIABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.allDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // TableLabel
            // 
            this.TableLabel.AutoSize = true;
            this.TableLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TableLabel.Location = new System.Drawing.Point(9, 9);
            this.TableLabel.Name = "TableLabel";
            this.TableLabel.Size = new System.Drawing.Size(279, 37);
            this.TableLabel.TabIndex = 108;
            this.TableLabel.Text = "Historia zamówień";
            // 
            // UpdateButton
            // 
            this.UpdateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.UpdateButton.Image = ((System.Drawing.Image)(resources.GetObject("UpdateButton.Image")));
            this.UpdateButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.UpdateButton.Location = new System.Drawing.Point(754, 618);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(164, 54);
            this.UpdateButton.TabIndex = 110;
            this.UpdateButton.Text = "Zarządzaj";
            this.UpdateButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // FilterButton
            // 
            this.FilterButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FilterButton.Image = ((System.Drawing.Image)(resources.GetObject("FilterButton.Image")));
            this.FilterButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.FilterButton.Location = new System.Drawing.Point(924, 618);
            this.FilterButton.Name = "FilterButton";
            this.FilterButton.Size = new System.Drawing.Size(164, 54);
            this.FilterButton.TabIndex = 111;
            this.FilterButton.Text = "Filtruj";
            this.FilterButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.FilterButton.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDHISTORIADataGridViewTextBoxColumn,
            this.iDPRACDataGridViewTextBoxColumn,
            this.iDZAMOWIENIEDataGridViewTextBoxColumn,
            this.iDKLIENTDataGridViewTextBoxColumn,
            this.dATAWYDANIEDataGridViewTextBoxColumn,
            this.dATAPRZYJECIEDataGridViewTextBoxColumn,
            this.tANKOWANIEDataGridViewCheckBoxColumn,
            this.iLOSCTANKOWANIEDataGridViewTextBoxColumn,
            this.kOSZTTANKOWANIEDataGridViewTextBoxColumn,
            this.kOLIZJADataGridViewCheckBoxColumn,
            this.dATAKOLIZJADataGridViewTextBoxColumn,
            this.kARAKOLIZJADataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.hISTORIAZAMOWIENIABindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(16, 50);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1072, 562);
            this.dataGridView1.TabIndex = 112;
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            // 
            // iDHISTORIADataGridViewTextBoxColumn
            // 
            this.iDHISTORIADataGridViewTextBoxColumn.DataPropertyName = "ID_HISTORIA";
            this.iDHISTORIADataGridViewTextBoxColumn.HeaderText = "ID_HISTORIA";
            this.iDHISTORIADataGridViewTextBoxColumn.Name = "iDHISTORIADataGridViewTextBoxColumn";
            this.iDHISTORIADataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iDPRACDataGridViewTextBoxColumn
            // 
            this.iDPRACDataGridViewTextBoxColumn.DataPropertyName = "ID_PRAC";
            this.iDPRACDataGridViewTextBoxColumn.HeaderText = "ID_PRAC";
            this.iDPRACDataGridViewTextBoxColumn.Name = "iDPRACDataGridViewTextBoxColumn";
            // 
            // iDZAMOWIENIEDataGridViewTextBoxColumn
            // 
            this.iDZAMOWIENIEDataGridViewTextBoxColumn.DataPropertyName = "ID_ZAMOWIENIE";
            this.iDZAMOWIENIEDataGridViewTextBoxColumn.HeaderText = "ID_ZAMOWIENIE";
            this.iDZAMOWIENIEDataGridViewTextBoxColumn.Name = "iDZAMOWIENIEDataGridViewTextBoxColumn";
            // 
            // iDKLIENTDataGridViewTextBoxColumn
            // 
            this.iDKLIENTDataGridViewTextBoxColumn.DataPropertyName = "ID_KLIENT";
            this.iDKLIENTDataGridViewTextBoxColumn.HeaderText = "ID_KLIENT";
            this.iDKLIENTDataGridViewTextBoxColumn.Name = "iDKLIENTDataGridViewTextBoxColumn";
            // 
            // dATAWYDANIEDataGridViewTextBoxColumn
            // 
            this.dATAWYDANIEDataGridViewTextBoxColumn.DataPropertyName = "DATA_WYDANIE";
            this.dATAWYDANIEDataGridViewTextBoxColumn.HeaderText = "DATA_WYDANIE";
            this.dATAWYDANIEDataGridViewTextBoxColumn.Name = "dATAWYDANIEDataGridViewTextBoxColumn";
            // 
            // dATAPRZYJECIEDataGridViewTextBoxColumn
            // 
            this.dATAPRZYJECIEDataGridViewTextBoxColumn.DataPropertyName = "DATA_PRZYJECIE";
            this.dATAPRZYJECIEDataGridViewTextBoxColumn.HeaderText = "DATA_PRZYJECIE";
            this.dATAPRZYJECIEDataGridViewTextBoxColumn.Name = "dATAPRZYJECIEDataGridViewTextBoxColumn";
            // 
            // tANKOWANIEDataGridViewCheckBoxColumn
            // 
            this.tANKOWANIEDataGridViewCheckBoxColumn.DataPropertyName = "TANKOWANIE";
            this.tANKOWANIEDataGridViewCheckBoxColumn.HeaderText = "TANKOWANIE";
            this.tANKOWANIEDataGridViewCheckBoxColumn.Name = "tANKOWANIEDataGridViewCheckBoxColumn";
            // 
            // iLOSCTANKOWANIEDataGridViewTextBoxColumn
            // 
            this.iLOSCTANKOWANIEDataGridViewTextBoxColumn.DataPropertyName = "ILOSC_TANKOWANIE";
            this.iLOSCTANKOWANIEDataGridViewTextBoxColumn.HeaderText = "ILOSC_TANKOWANIE";
            this.iLOSCTANKOWANIEDataGridViewTextBoxColumn.Name = "iLOSCTANKOWANIEDataGridViewTextBoxColumn";
            // 
            // kOSZTTANKOWANIEDataGridViewTextBoxColumn
            // 
            this.kOSZTTANKOWANIEDataGridViewTextBoxColumn.DataPropertyName = "KOSZT_TANKOWANIE";
            this.kOSZTTANKOWANIEDataGridViewTextBoxColumn.HeaderText = "KOSZT_TANKOWANIE";
            this.kOSZTTANKOWANIEDataGridViewTextBoxColumn.Name = "kOSZTTANKOWANIEDataGridViewTextBoxColumn";
            // 
            // kOLIZJADataGridViewCheckBoxColumn
            // 
            this.kOLIZJADataGridViewCheckBoxColumn.DataPropertyName = "KOLIZJA";
            this.kOLIZJADataGridViewCheckBoxColumn.HeaderText = "KOLIZJA";
            this.kOLIZJADataGridViewCheckBoxColumn.Name = "kOLIZJADataGridViewCheckBoxColumn";
            // 
            // dATAKOLIZJADataGridViewTextBoxColumn
            // 
            this.dATAKOLIZJADataGridViewTextBoxColumn.DataPropertyName = "DATA_KOLIZJA";
            this.dATAKOLIZJADataGridViewTextBoxColumn.HeaderText = "DATA_KOLIZJA";
            this.dATAKOLIZJADataGridViewTextBoxColumn.Name = "dATAKOLIZJADataGridViewTextBoxColumn";
            // 
            // kARAKOLIZJADataGridViewTextBoxColumn
            // 
            this.kARAKOLIZJADataGridViewTextBoxColumn.DataPropertyName = "KARA_KOLIZJA";
            this.kARAKOLIZJADataGridViewTextBoxColumn.HeaderText = "KARA_KOLIZJA";
            this.kARAKOLIZJADataGridViewTextBoxColumn.Name = "kARAKOLIZJADataGridViewTextBoxColumn";
            // 
            // hISTORIAZAMOWIENIABindingSource
            // 
            this.hISTORIAZAMOWIENIABindingSource.DataMember = "HISTORIA_ZAMOWIENIA";
            this.hISTORIAZAMOWIENIABindingSource.DataSource = this.allDataSet;
            // 
            // allDataSet
            // 
            this.allDataSet.DataSetName = "AllDataSet";
            this.allDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hISTORIA_ZAMOWIENIATableAdapter
            // 
            this.hISTORIA_ZAMOWIENIATableAdapter.ClearBeforeFill = true;
            // 
            // OrderHistoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1100, 681);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.FilterButton);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.TableLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "OrderHistoryForm";
            this.Text = "OrderHistoryForm";
            this.Load += new System.EventHandler(this.OrderHistoryForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hISTORIAZAMOWIENIABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.allDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TableLabel;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.Button FilterButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private AllDataSet allDataSet;
        private System.Windows.Forms.BindingSource hISTORIAZAMOWIENIABindingSource;
        private AllDataSetTableAdapters.HISTORIA_ZAMOWIENIATableAdapter hISTORIA_ZAMOWIENIATableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDHISTORIADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDPRACDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDZAMOWIENIEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDKLIENTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dATAWYDANIEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dATAPRZYJECIEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn tANKOWANIEDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iLOSCTANKOWANIEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kOSZTTANKOWANIEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn kOLIZJADataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dATAKOLIZJADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kARAKOLIZJADataGridViewTextBoxColumn;
    }
}