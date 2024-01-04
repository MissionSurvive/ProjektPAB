namespace CarRental
{
    partial class OrderOrderForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderOrderForm));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDZAMOWIENIEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDPAKIETDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDHISTORIADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDWYPOZYCZALNIADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDKLIENTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDSAMOCHODDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lICZBADNIDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cENAZAMOWIENIEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dATASTARTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dATAKONIECDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zAMOWIENIABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.allDataSet = new CarRental.AllDataSet();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.TableLabel = new System.Windows.Forms.Label();
            this.zAMOWIENIATableAdapter = new CarRental.AllDataSetTableAdapters.ZAMOWIENIATableAdapter();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.iDHISTORIADataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDPRACDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDZAMOWIENIEDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDKLIENTDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dATAWYDANIEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dATAPRZYJECIEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tANKOWANIEDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.iLOSCTANKOWANIEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kOSZTTANKOWANIEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kOLIZJADataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dATAKOLIZJADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kARAKOLIZJADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hISTORIAZAMOWIENIABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DeleteButton = new System.Windows.Forms.Button();
            this.hISTORIA_ZAMOWIENIATableAdapter = new CarRental.AllDataSetTableAdapters.HISTORIA_ZAMOWIENIATableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zAMOWIENIABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.allDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hISTORIAZAMOWIENIABindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDZAMOWIENIEDataGridViewTextBoxColumn,
            this.iDPAKIETDataGridViewTextBoxColumn,
            this.iDHISTORIADataGridViewTextBoxColumn,
            this.iDWYPOZYCZALNIADataGridViewTextBoxColumn,
            this.iDKLIENTDataGridViewTextBoxColumn,
            this.iDSAMOCHODDataGridViewTextBoxColumn,
            this.lICZBADNIDataGridViewTextBoxColumn,
            this.cENAZAMOWIENIEDataGridViewTextBoxColumn,
            this.dATASTARTDataGridViewTextBoxColumn,
            this.dATAKONIECDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.zAMOWIENIABindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(17, 51);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(909, 559);
            this.dataGridView1.TabIndex = 143;
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            // 
            // iDZAMOWIENIEDataGridViewTextBoxColumn
            // 
            this.iDZAMOWIENIEDataGridViewTextBoxColumn.DataPropertyName = "ID_ZAMOWIENIE";
            this.iDZAMOWIENIEDataGridViewTextBoxColumn.HeaderText = "ID_ZAMOWIENIE";
            this.iDZAMOWIENIEDataGridViewTextBoxColumn.Name = "iDZAMOWIENIEDataGridViewTextBoxColumn";
            this.iDZAMOWIENIEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iDPAKIETDataGridViewTextBoxColumn
            // 
            this.iDPAKIETDataGridViewTextBoxColumn.DataPropertyName = "ID_PAKIET";
            this.iDPAKIETDataGridViewTextBoxColumn.HeaderText = "ID_PAKIET";
            this.iDPAKIETDataGridViewTextBoxColumn.Name = "iDPAKIETDataGridViewTextBoxColumn";
            this.iDPAKIETDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iDHISTORIADataGridViewTextBoxColumn
            // 
            this.iDHISTORIADataGridViewTextBoxColumn.DataPropertyName = "ID_HISTORIA";
            this.iDHISTORIADataGridViewTextBoxColumn.HeaderText = "ID_HISTORIA";
            this.iDHISTORIADataGridViewTextBoxColumn.Name = "iDHISTORIADataGridViewTextBoxColumn";
            this.iDHISTORIADataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iDWYPOZYCZALNIADataGridViewTextBoxColumn
            // 
            this.iDWYPOZYCZALNIADataGridViewTextBoxColumn.DataPropertyName = "ID_WYPOZYCZALNIA";
            this.iDWYPOZYCZALNIADataGridViewTextBoxColumn.HeaderText = "ID_WYPOZYCZALNIA";
            this.iDWYPOZYCZALNIADataGridViewTextBoxColumn.Name = "iDWYPOZYCZALNIADataGridViewTextBoxColumn";
            this.iDWYPOZYCZALNIADataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iDKLIENTDataGridViewTextBoxColumn
            // 
            this.iDKLIENTDataGridViewTextBoxColumn.DataPropertyName = "ID_KLIENT";
            this.iDKLIENTDataGridViewTextBoxColumn.HeaderText = "ID_KLIENT";
            this.iDKLIENTDataGridViewTextBoxColumn.Name = "iDKLIENTDataGridViewTextBoxColumn";
            this.iDKLIENTDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iDSAMOCHODDataGridViewTextBoxColumn
            // 
            this.iDSAMOCHODDataGridViewTextBoxColumn.DataPropertyName = "ID_SAMOCHOD";
            this.iDSAMOCHODDataGridViewTextBoxColumn.HeaderText = "ID_SAMOCHOD";
            this.iDSAMOCHODDataGridViewTextBoxColumn.Name = "iDSAMOCHODDataGridViewTextBoxColumn";
            this.iDSAMOCHODDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lICZBADNIDataGridViewTextBoxColumn
            // 
            this.lICZBADNIDataGridViewTextBoxColumn.DataPropertyName = "LICZBA_DNI";
            this.lICZBADNIDataGridViewTextBoxColumn.HeaderText = "LICZBA_DNI";
            this.lICZBADNIDataGridViewTextBoxColumn.Name = "lICZBADNIDataGridViewTextBoxColumn";
            this.lICZBADNIDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cENAZAMOWIENIEDataGridViewTextBoxColumn
            // 
            this.cENAZAMOWIENIEDataGridViewTextBoxColumn.DataPropertyName = "CENA_ZAMOWIENIE";
            this.cENAZAMOWIENIEDataGridViewTextBoxColumn.HeaderText = "CENA_ZAMOWIENIE";
            this.cENAZAMOWIENIEDataGridViewTextBoxColumn.Name = "cENAZAMOWIENIEDataGridViewTextBoxColumn";
            this.cENAZAMOWIENIEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dATASTARTDataGridViewTextBoxColumn
            // 
            this.dATASTARTDataGridViewTextBoxColumn.DataPropertyName = "DATA_START";
            this.dATASTARTDataGridViewTextBoxColumn.HeaderText = "DATA_START";
            this.dATASTARTDataGridViewTextBoxColumn.Name = "dATASTARTDataGridViewTextBoxColumn";
            this.dATASTARTDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dATAKONIECDataGridViewTextBoxColumn
            // 
            this.dATAKONIECDataGridViewTextBoxColumn.DataPropertyName = "DATA_KONIEC";
            this.dATAKONIECDataGridViewTextBoxColumn.HeaderText = "DATA_KONIEC";
            this.dATAKONIECDataGridViewTextBoxColumn.Name = "dATAKONIECDataGridViewTextBoxColumn";
            this.dATAKONIECDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // zAMOWIENIABindingSource
            // 
            this.zAMOWIENIABindingSource.DataMember = "ZAMOWIENIA";
            this.zAMOWIENIABindingSource.DataSource = this.allDataSet;
            // 
            // allDataSet
            // 
            this.allDataSet.DataSetName = "AllDataSet";
            this.allDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // UpdateButton
            // 
            this.UpdateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.UpdateButton.Image = ((System.Drawing.Image)(resources.GetObject("UpdateButton.Image")));
            this.UpdateButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.UpdateButton.Location = new System.Drawing.Point(592, 616);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(164, 54);
            this.UpdateButton.TabIndex = 136;
            this.UpdateButton.Text = "Zarządzaj";
            this.UpdateButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // TableLabel
            // 
            this.TableLabel.AutoSize = true;
            this.TableLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TableLabel.Location = new System.Drawing.Point(10, 10);
            this.TableLabel.Name = "TableLabel";
            this.TableLabel.Size = new System.Drawing.Size(190, 37);
            this.TableLabel.TabIndex = 133;
            this.TableLabel.Text = "Zamówienia";
            // 
            // zAMOWIENIATableAdapter
            // 
            this.zAMOWIENIATableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDHISTORIADataGridViewTextBoxColumn1,
            this.iDPRACDataGridViewTextBoxColumn,
            this.iDZAMOWIENIEDataGridViewTextBoxColumn1,
            this.iDKLIENTDataGridViewTextBoxColumn1,
            this.dATAWYDANIEDataGridViewTextBoxColumn,
            this.dATAPRZYJECIEDataGridViewTextBoxColumn,
            this.tANKOWANIEDataGridViewCheckBoxColumn,
            this.iLOSCTANKOWANIEDataGridViewTextBoxColumn,
            this.kOSZTTANKOWANIEDataGridViewTextBoxColumn,
            this.kOLIZJADataGridViewCheckBoxColumn,
            this.dATAKOLIZJADataGridViewTextBoxColumn,
            this.kARAKOLIZJADataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.hISTORIAZAMOWIENIABindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(685, 51);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(240, 150);
            this.dataGridView2.TabIndex = 144;
            this.dataGridView2.Visible = false;
            // 
            // iDHISTORIADataGridViewTextBoxColumn1
            // 
            this.iDHISTORIADataGridViewTextBoxColumn1.DataPropertyName = "ID_HISTORIA";
            this.iDHISTORIADataGridViewTextBoxColumn1.HeaderText = "ID_HISTORIA";
            this.iDHISTORIADataGridViewTextBoxColumn1.Name = "iDHISTORIADataGridViewTextBoxColumn1";
            this.iDHISTORIADataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // iDPRACDataGridViewTextBoxColumn
            // 
            this.iDPRACDataGridViewTextBoxColumn.DataPropertyName = "ID_PRAC";
            this.iDPRACDataGridViewTextBoxColumn.HeaderText = "ID_PRAC";
            this.iDPRACDataGridViewTextBoxColumn.Name = "iDPRACDataGridViewTextBoxColumn";
            // 
            // iDZAMOWIENIEDataGridViewTextBoxColumn1
            // 
            this.iDZAMOWIENIEDataGridViewTextBoxColumn1.DataPropertyName = "ID_ZAMOWIENIE";
            this.iDZAMOWIENIEDataGridViewTextBoxColumn1.HeaderText = "ID_ZAMOWIENIE";
            this.iDZAMOWIENIEDataGridViewTextBoxColumn1.Name = "iDZAMOWIENIEDataGridViewTextBoxColumn1";
            // 
            // iDKLIENTDataGridViewTextBoxColumn1
            // 
            this.iDKLIENTDataGridViewTextBoxColumn1.DataPropertyName = "ID_KLIENT";
            this.iDKLIENTDataGridViewTextBoxColumn1.HeaderText = "ID_KLIENT";
            this.iDKLIENTDataGridViewTextBoxColumn1.Name = "iDKLIENTDataGridViewTextBoxColumn1";
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
            // DeleteButton
            // 
            this.DeleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.DeleteButton.Image = ((System.Drawing.Image)(resources.GetObject("DeleteButton.Image")));
            this.DeleteButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DeleteButton.Location = new System.Drawing.Point(762, 616);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(164, 54);
            this.DeleteButton.TabIndex = 135;
            this.DeleteButton.Text = "Usuń";
            this.DeleteButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // hISTORIA_ZAMOWIENIATableAdapter
            // 
            this.hISTORIA_ZAMOWIENIATableAdapter.ClearBeforeFill = true;
            // 
            // OrderOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(937, 681);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.TableLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "OrderOrderForm";
            this.Text = "OrderOrderForm";
            this.Load += new System.EventHandler(this.OrderOrderForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zAMOWIENIABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.allDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hISTORIAZAMOWIENIABindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.Label TableLabel;
        private AllDataSet allDataSet;
        private System.Windows.Forms.BindingSource zAMOWIENIABindingSource;
        private AllDataSetTableAdapters.ZAMOWIENIATableAdapter zAMOWIENIATableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDZAMOWIENIEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDPAKIETDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDHISTORIADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDWYPOZYCZALNIADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDKLIENTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDSAMOCHODDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lICZBADNIDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cENAZAMOWIENIEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dATASTARTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dATAKONIECDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.BindingSource hISTORIAZAMOWIENIABindingSource;
        private AllDataSetTableAdapters.HISTORIA_ZAMOWIENIATableAdapter hISTORIA_ZAMOWIENIATableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDHISTORIADataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDPRACDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDZAMOWIENIEDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDKLIENTDataGridViewTextBoxColumn1;
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