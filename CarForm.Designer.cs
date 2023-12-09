namespace CarRental
{
    partial class CarForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.carRentalCWDataSet = new CarRental.CarRentalCWDataSet();
            this.sAMOCHODYBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sAMOCHODYTableAdapter = new CarRental.CarRentalCWDataSetTableAdapters.SAMOCHODYTableAdapter();
            this.iDSAMOCHODDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDPALIWODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDMODELDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDWYPOZYCZALNIADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zDJECIEDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.kOLORDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRZEBIEGDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vINDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pOJEMNOSCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mOCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sKRZYNIADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mIEJSCADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dOSTEPNOSCDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.cENADZIENDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cENATYDZIENDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cENAMIESIACDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kAUCJADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carRentalCWDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sAMOCHODYBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDSAMOCHODDataGridViewTextBoxColumn,
            this.iDPALIWODataGridViewTextBoxColumn,
            this.iDMODELDataGridViewTextBoxColumn,
            this.iDWYPOZYCZALNIADataGridViewTextBoxColumn,
            this.zDJECIEDataGridViewImageColumn,
            this.kOLORDataGridViewTextBoxColumn,
            this.pRZEBIEGDataGridViewTextBoxColumn,
            this.vINDataGridViewTextBoxColumn,
            this.pOJEMNOSCDataGridViewTextBoxColumn,
            this.mOCDataGridViewTextBoxColumn,
            this.sKRZYNIADataGridViewTextBoxColumn,
            this.mIEJSCADataGridViewTextBoxColumn,
            this.dOSTEPNOSCDataGridViewCheckBoxColumn,
            this.cENADZIENDataGridViewTextBoxColumn,
            this.cENATYDZIENDataGridViewTextBoxColumn,
            this.cENAMIESIACDataGridViewTextBoxColumn,
            this.kAUCJADataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.sAMOCHODYBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1076, 358);
            this.dataGridView1.TabIndex = 0;
            // 
            // carRentalCWDataSet
            // 
            this.carRentalCWDataSet.DataSetName = "CarRentalCWDataSet";
            this.carRentalCWDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sAMOCHODYBindingSource
            // 
            this.sAMOCHODYBindingSource.DataMember = "SAMOCHODY";
            this.sAMOCHODYBindingSource.DataSource = this.carRentalCWDataSet;
            // 
            // sAMOCHODYTableAdapter
            // 
            this.sAMOCHODYTableAdapter.ClearBeforeFill = true;
            // 
            // iDSAMOCHODDataGridViewTextBoxColumn
            // 
            this.iDSAMOCHODDataGridViewTextBoxColumn.DataPropertyName = "ID_SAMOCHOD";
            this.iDSAMOCHODDataGridViewTextBoxColumn.HeaderText = "ID_SAMOCHOD";
            this.iDSAMOCHODDataGridViewTextBoxColumn.Name = "iDSAMOCHODDataGridViewTextBoxColumn";
            this.iDSAMOCHODDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iDPALIWODataGridViewTextBoxColumn
            // 
            this.iDPALIWODataGridViewTextBoxColumn.DataPropertyName = "ID_PALIWO";
            this.iDPALIWODataGridViewTextBoxColumn.HeaderText = "ID_PALIWO";
            this.iDPALIWODataGridViewTextBoxColumn.Name = "iDPALIWODataGridViewTextBoxColumn";
            // 
            // iDMODELDataGridViewTextBoxColumn
            // 
            this.iDMODELDataGridViewTextBoxColumn.DataPropertyName = "ID_MODEL";
            this.iDMODELDataGridViewTextBoxColumn.HeaderText = "ID_MODEL";
            this.iDMODELDataGridViewTextBoxColumn.Name = "iDMODELDataGridViewTextBoxColumn";
            // 
            // iDWYPOZYCZALNIADataGridViewTextBoxColumn
            // 
            this.iDWYPOZYCZALNIADataGridViewTextBoxColumn.DataPropertyName = "ID_WYPOZYCZALNIA";
            this.iDWYPOZYCZALNIADataGridViewTextBoxColumn.HeaderText = "ID_WYPOZYCZALNIA";
            this.iDWYPOZYCZALNIADataGridViewTextBoxColumn.Name = "iDWYPOZYCZALNIADataGridViewTextBoxColumn";
            // 
            // zDJECIEDataGridViewImageColumn
            // 
            this.zDJECIEDataGridViewImageColumn.DataPropertyName = "ZDJECIE";
            this.zDJECIEDataGridViewImageColumn.HeaderText = "ZDJECIE";
            this.zDJECIEDataGridViewImageColumn.Name = "zDJECIEDataGridViewImageColumn";
            // 
            // kOLORDataGridViewTextBoxColumn
            // 
            this.kOLORDataGridViewTextBoxColumn.DataPropertyName = "KOLOR";
            this.kOLORDataGridViewTextBoxColumn.HeaderText = "KOLOR";
            this.kOLORDataGridViewTextBoxColumn.Name = "kOLORDataGridViewTextBoxColumn";
            // 
            // pRZEBIEGDataGridViewTextBoxColumn
            // 
            this.pRZEBIEGDataGridViewTextBoxColumn.DataPropertyName = "PRZEBIEG";
            this.pRZEBIEGDataGridViewTextBoxColumn.HeaderText = "PRZEBIEG";
            this.pRZEBIEGDataGridViewTextBoxColumn.Name = "pRZEBIEGDataGridViewTextBoxColumn";
            // 
            // vINDataGridViewTextBoxColumn
            // 
            this.vINDataGridViewTextBoxColumn.DataPropertyName = "VIN";
            this.vINDataGridViewTextBoxColumn.HeaderText = "VIN";
            this.vINDataGridViewTextBoxColumn.Name = "vINDataGridViewTextBoxColumn";
            // 
            // pOJEMNOSCDataGridViewTextBoxColumn
            // 
            this.pOJEMNOSCDataGridViewTextBoxColumn.DataPropertyName = "POJEMNOSC";
            this.pOJEMNOSCDataGridViewTextBoxColumn.HeaderText = "POJEMNOSC";
            this.pOJEMNOSCDataGridViewTextBoxColumn.Name = "pOJEMNOSCDataGridViewTextBoxColumn";
            // 
            // mOCDataGridViewTextBoxColumn
            // 
            this.mOCDataGridViewTextBoxColumn.DataPropertyName = "MOC";
            this.mOCDataGridViewTextBoxColumn.HeaderText = "MOC";
            this.mOCDataGridViewTextBoxColumn.Name = "mOCDataGridViewTextBoxColumn";
            // 
            // sKRZYNIADataGridViewTextBoxColumn
            // 
            this.sKRZYNIADataGridViewTextBoxColumn.DataPropertyName = "SKRZYNIA";
            this.sKRZYNIADataGridViewTextBoxColumn.HeaderText = "SKRZYNIA";
            this.sKRZYNIADataGridViewTextBoxColumn.Name = "sKRZYNIADataGridViewTextBoxColumn";
            // 
            // mIEJSCADataGridViewTextBoxColumn
            // 
            this.mIEJSCADataGridViewTextBoxColumn.DataPropertyName = "MIEJSCA";
            this.mIEJSCADataGridViewTextBoxColumn.HeaderText = "MIEJSCA";
            this.mIEJSCADataGridViewTextBoxColumn.Name = "mIEJSCADataGridViewTextBoxColumn";
            // 
            // dOSTEPNOSCDataGridViewCheckBoxColumn
            // 
            this.dOSTEPNOSCDataGridViewCheckBoxColumn.DataPropertyName = "DOSTEPNOSC";
            this.dOSTEPNOSCDataGridViewCheckBoxColumn.HeaderText = "DOSTEPNOSC";
            this.dOSTEPNOSCDataGridViewCheckBoxColumn.Name = "dOSTEPNOSCDataGridViewCheckBoxColumn";
            // 
            // cENADZIENDataGridViewTextBoxColumn
            // 
            this.cENADZIENDataGridViewTextBoxColumn.DataPropertyName = "CENA_DZIEN";
            this.cENADZIENDataGridViewTextBoxColumn.HeaderText = "CENA_DZIEN";
            this.cENADZIENDataGridViewTextBoxColumn.Name = "cENADZIENDataGridViewTextBoxColumn";
            // 
            // cENATYDZIENDataGridViewTextBoxColumn
            // 
            this.cENATYDZIENDataGridViewTextBoxColumn.DataPropertyName = "CENA_TYDZIEN";
            this.cENATYDZIENDataGridViewTextBoxColumn.HeaderText = "CENA_TYDZIEN";
            this.cENATYDZIENDataGridViewTextBoxColumn.Name = "cENATYDZIENDataGridViewTextBoxColumn";
            // 
            // cENAMIESIACDataGridViewTextBoxColumn
            // 
            this.cENAMIESIACDataGridViewTextBoxColumn.DataPropertyName = "CENA_MIESIAC";
            this.cENAMIESIACDataGridViewTextBoxColumn.HeaderText = "CENA_MIESIAC";
            this.cENAMIESIACDataGridViewTextBoxColumn.Name = "cENAMIESIACDataGridViewTextBoxColumn";
            // 
            // kAUCJADataGridViewTextBoxColumn
            // 
            this.kAUCJADataGridViewTextBoxColumn.DataPropertyName = "KAUCJA";
            this.kAUCJADataGridViewTextBoxColumn.HeaderText = "KAUCJA";
            this.kAUCJADataGridViewTextBoxColumn.Name = "kAUCJADataGridViewTextBoxColumn";
            // 
            // CarForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1100, 382);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CarForm";
            this.Text = "CarForm";
            this.Load += new System.EventHandler(this.CarForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carRentalCWDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sAMOCHODYBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private CarRentalCWDataSet carRentalCWDataSet;
        private System.Windows.Forms.BindingSource sAMOCHODYBindingSource;
        private CarRentalCWDataSetTableAdapters.SAMOCHODYTableAdapter sAMOCHODYTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDSAMOCHODDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDPALIWODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDMODELDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDWYPOZYCZALNIADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn zDJECIEDataGridViewImageColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kOLORDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRZEBIEGDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vINDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pOJEMNOSCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mOCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sKRZYNIADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mIEJSCADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dOSTEPNOSCDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cENADZIENDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cENATYDZIENDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cENAMIESIACDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kAUCJADataGridViewTextBoxColumn;
    }
}