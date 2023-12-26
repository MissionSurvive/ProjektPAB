namespace CarRental
{
    partial class CarCarForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CarCarForm));
            this.label1 = new System.Windows.Forms.Label();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.FilterButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
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
            this.cENADZIENDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cENATYDZIENDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cENAMIESIACDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kAUCJADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sAMOCHODYBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.allDataSet = new CarRental.AllDataSet();
            this.sAMOCHODYTableAdapter = new CarRental.AllDataSetTableAdapters.SAMOCHODYTableAdapter();
            this.wYPOZYCZALNIEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rODZAJEPALIWABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rODZAJE_PALIWATableAdapter = new CarRental.AllDataSetTableAdapters.RODZAJE_PALIWATableAdapter();
            this.wYPOZYCZALNIETableAdapter = new CarRental.AllDataSetTableAdapters.WYPOZYCZALNIETableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sAMOCHODYBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.allDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wYPOZYCZALNIEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rODZAJEPALIWABindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 37);
            this.label1.TabIndex = 3;
            this.label1.Text = "Samochody";
            // 
            // DeleteButton
            // 
            this.DeleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.DeleteButton.Image = ((System.Drawing.Image)(resources.GetObject("DeleteButton.Image")));
            this.DeleteButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DeleteButton.Location = new System.Drawing.Point(591, 615);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(164, 54);
            this.DeleteButton.TabIndex = 20;
            this.DeleteButton.Text = "Usuń";
            this.DeleteButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.button5_Click);
            // 
            // UpdateButton
            // 
            this.UpdateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.UpdateButton.Image = ((System.Drawing.Image)(resources.GetObject("UpdateButton.Image")));
            this.UpdateButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.UpdateButton.Location = new System.Drawing.Point(421, 615);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(164, 54);
            this.UpdateButton.TabIndex = 19;
            this.UpdateButton.Text = "Dodaj";
            this.UpdateButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // FilterButton
            // 
            this.FilterButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FilterButton.Image = ((System.Drawing.Image)(resources.GetObject("FilterButton.Image")));
            this.FilterButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.FilterButton.Location = new System.Drawing.Point(761, 615);
            this.FilterButton.Name = "FilterButton";
            this.FilterButton.Size = new System.Drawing.Size(164, 54);
            this.FilterButton.TabIndex = 57;
            this.FilterButton.Text = "Filtruj";
            this.FilterButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.FilterButton.UseVisualStyleBackColor = true;
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
            this.cENADZIENDataGridViewTextBoxColumn,
            this.cENATYDZIENDataGridViewTextBoxColumn,
            this.cENAMIESIACDataGridViewTextBoxColumn,
            this.kAUCJADataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.sAMOCHODYBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(19, 50);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(906, 559);
            this.dataGridView1.TabIndex = 58;
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
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
            // sAMOCHODYBindingSource
            // 
            this.sAMOCHODYBindingSource.DataMember = "SAMOCHODY";
            this.sAMOCHODYBindingSource.DataSource = this.allDataSet;
            // 
            // allDataSet
            // 
            this.allDataSet.DataSetName = "AllDataSet";
            this.allDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sAMOCHODYTableAdapter
            // 
            this.sAMOCHODYTableAdapter.ClearBeforeFill = true;
            // 
            // wYPOZYCZALNIEBindingSource
            // 
            this.wYPOZYCZALNIEBindingSource.DataMember = "WYPOZYCZALNIE";
            this.wYPOZYCZALNIEBindingSource.DataSource = this.allDataSet;
            // 
            // rODZAJEPALIWABindingSource
            // 
            this.rODZAJEPALIWABindingSource.DataMember = "RODZAJE_PALIWA";
            this.rODZAJEPALIWABindingSource.DataSource = this.allDataSet;
            // 
            // rODZAJE_PALIWATableAdapter
            // 
            this.rODZAJE_PALIWATableAdapter.ClearBeforeFill = true;
            // 
            // wYPOZYCZALNIETableAdapter
            // 
            this.wYPOZYCZALNIETableAdapter.ClearBeforeFill = true;
            // 
            // CarCarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(937, 681);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.FilterButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CarCarForm";
            this.Text = "CarCarForm";
            this.Load += new System.EventHandler(this.CarCarForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sAMOCHODYBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.allDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wYPOZYCZALNIEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rODZAJEPALIWABindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.Button FilterButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private AllDataSet allDataSet;
        private System.Windows.Forms.BindingSource sAMOCHODYBindingSource;
        private AllDataSetTableAdapters.SAMOCHODYTableAdapter sAMOCHODYTableAdapter;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn cENADZIENDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cENATYDZIENDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cENAMIESIACDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kAUCJADataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource rODZAJEPALIWABindingSource;
        private AllDataSetTableAdapters.RODZAJE_PALIWATableAdapter rODZAJE_PALIWATableAdapter;
        private System.Windows.Forms.BindingSource wYPOZYCZALNIEBindingSource;
        private AllDataSetTableAdapters.WYPOZYCZALNIETableAdapter wYPOZYCZALNIETableAdapter;
    }
}