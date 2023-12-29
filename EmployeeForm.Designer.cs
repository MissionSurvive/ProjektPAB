namespace CarRental
{
    partial class EmployeeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeForm));
            this.FilterButton = new System.Windows.Forms.Button();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.TableLabel = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.iDKONPRACOWNIKDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDROLADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDPRACDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nAZWAPRACOWNIKDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hASLOPRACOWNIKDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kONTAPRACOWNIKOWBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.allDataSet = new CarRental.AllDataSet();
            this.iDPRACDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDKONPRACOWNIKDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDWYPOZYCZALNIADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iMIEPRACOWNIKDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nAZWISKOPRACOWNIKDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pESELPRACOWNIKDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tELEFONPRACOWNIKDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTANOWISKODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dATAZATRUDNIENIADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wYNAGRODZENIEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pREMIADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRACOWNICYBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pRACOWNICYTableAdapter = new CarRental.AllDataSetTableAdapters.PRACOWNICYTableAdapter();
            this.kONTA_PRACOWNIKOWTableAdapter = new CarRental.AllDataSetTableAdapters.KONTA_PRACOWNIKOWTableAdapter();
            this.SurnameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.ModelLabel = new System.Windows.Forms.Label();
            this.FilterCheck = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kONTAPRACOWNIKOWBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.allDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRACOWNICYBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // FilterButton
            // 
            this.FilterButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FilterButton.Image = ((System.Drawing.Image)(resources.GetObject("FilterButton.Image")));
            this.FilterButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.FilterButton.Location = new System.Drawing.Point(928, 618);
            this.FilterButton.Name = "FilterButton";
            this.FilterButton.Size = new System.Drawing.Size(164, 54);
            this.FilterButton.TabIndex = 105;
            this.FilterButton.Text = "Filtruj";
            this.FilterButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.FilterButton.UseVisualStyleBackColor = true;
            this.FilterButton.Click += new System.EventHandler(this.FilterButton_Click);
            // 
            // UpdateButton
            // 
            this.UpdateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.UpdateButton.Image = ((System.Drawing.Image)(resources.GetObject("UpdateButton.Image")));
            this.UpdateButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.UpdateButton.Location = new System.Drawing.Point(588, 618);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(164, 54);
            this.UpdateButton.TabIndex = 104;
            this.UpdateButton.Text = "Zarządzaj";
            this.UpdateButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.DeleteButton.Image = ((System.Drawing.Image)(resources.GetObject("DeleteButton.Image")));
            this.DeleteButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DeleteButton.Location = new System.Drawing.Point(758, 618);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(164, 54);
            this.DeleteButton.TabIndex = 103;
            this.DeleteButton.Text = "Usuń";
            this.DeleteButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // TableLabel
            // 
            this.TableLabel.AutoSize = true;
            this.TableLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TableLabel.Location = new System.Drawing.Point(9, 9);
            this.TableLabel.Name = "TableLabel";
            this.TableLabel.Size = new System.Drawing.Size(180, 37);
            this.TableLabel.TabIndex = 101;
            this.TableLabel.Text = "Pracownicy";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDPRACDataGridViewTextBoxColumn,
            this.iDKONPRACOWNIKDataGridViewTextBoxColumn,
            this.iDWYPOZYCZALNIADataGridViewTextBoxColumn,
            this.iMIEPRACOWNIKDataGridViewTextBoxColumn,
            this.nAZWISKOPRACOWNIKDataGridViewTextBoxColumn,
            this.pESELPRACOWNIKDataGridViewTextBoxColumn,
            this.tELEFONPRACOWNIKDataGridViewTextBoxColumn,
            this.sTANOWISKODataGridViewTextBoxColumn,
            this.dATAZATRUDNIENIADataGridViewTextBoxColumn,
            this.wYNAGRODZENIEDataGridViewTextBoxColumn,
            this.pREMIADataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.pRACOWNICYBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(16, 50);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1072, 466);
            this.dataGridView1.TabIndex = 106;
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDKONPRACOWNIKDataGridViewTextBoxColumn1,
            this.iDROLADataGridViewTextBoxColumn,
            this.iDPRACDataGridViewTextBoxColumn1,
            this.nAZWAPRACOWNIKDataGridViewTextBoxColumn,
            this.hASLOPRACOWNIKDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.kONTAPRACOWNIKOWBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(644, 50);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(444, 466);
            this.dataGridView2.TabIndex = 107;
            this.dataGridView2.Visible = false;
            // 
            // iDKONPRACOWNIKDataGridViewTextBoxColumn1
            // 
            this.iDKONPRACOWNIKDataGridViewTextBoxColumn1.DataPropertyName = "ID_KON_PRACOWNIK";
            this.iDKONPRACOWNIKDataGridViewTextBoxColumn1.HeaderText = "ID_KON_PRACOWNIK";
            this.iDKONPRACOWNIKDataGridViewTextBoxColumn1.Name = "iDKONPRACOWNIKDataGridViewTextBoxColumn1";
            this.iDKONPRACOWNIKDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // iDROLADataGridViewTextBoxColumn
            // 
            this.iDROLADataGridViewTextBoxColumn.DataPropertyName = "ID_ROLA";
            this.iDROLADataGridViewTextBoxColumn.HeaderText = "ID_ROLA";
            this.iDROLADataGridViewTextBoxColumn.Name = "iDROLADataGridViewTextBoxColumn";
            // 
            // iDPRACDataGridViewTextBoxColumn1
            // 
            this.iDPRACDataGridViewTextBoxColumn1.DataPropertyName = "ID_PRAC";
            this.iDPRACDataGridViewTextBoxColumn1.HeaderText = "ID_PRAC";
            this.iDPRACDataGridViewTextBoxColumn1.Name = "iDPRACDataGridViewTextBoxColumn1";
            // 
            // nAZWAPRACOWNIKDataGridViewTextBoxColumn
            // 
            this.nAZWAPRACOWNIKDataGridViewTextBoxColumn.DataPropertyName = "NAZWA_PRACOWNIK";
            this.nAZWAPRACOWNIKDataGridViewTextBoxColumn.HeaderText = "NAZWA_PRACOWNIK";
            this.nAZWAPRACOWNIKDataGridViewTextBoxColumn.Name = "nAZWAPRACOWNIKDataGridViewTextBoxColumn";
            // 
            // hASLOPRACOWNIKDataGridViewTextBoxColumn
            // 
            this.hASLOPRACOWNIKDataGridViewTextBoxColumn.DataPropertyName = "HASLO_PRACOWNIK";
            this.hASLOPRACOWNIKDataGridViewTextBoxColumn.HeaderText = "HASLO_PRACOWNIK";
            this.hASLOPRACOWNIKDataGridViewTextBoxColumn.Name = "hASLOPRACOWNIKDataGridViewTextBoxColumn";
            // 
            // kONTAPRACOWNIKOWBindingSource
            // 
            this.kONTAPRACOWNIKOWBindingSource.DataMember = "KONTA_PRACOWNIKOW";
            this.kONTAPRACOWNIKOWBindingSource.DataSource = this.allDataSet;
            // 
            // allDataSet
            // 
            this.allDataSet.DataSetName = "AllDataSet";
            this.allDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // iDPRACDataGridViewTextBoxColumn
            // 
            this.iDPRACDataGridViewTextBoxColumn.DataPropertyName = "ID_PRAC";
            this.iDPRACDataGridViewTextBoxColumn.HeaderText = "ID_PRAC";
            this.iDPRACDataGridViewTextBoxColumn.Name = "iDPRACDataGridViewTextBoxColumn";
            this.iDPRACDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iDKONPRACOWNIKDataGridViewTextBoxColumn
            // 
            this.iDKONPRACOWNIKDataGridViewTextBoxColumn.DataPropertyName = "ID_KON_PRACOWNIK";
            this.iDKONPRACOWNIKDataGridViewTextBoxColumn.HeaderText = "ID_KON_PRACOWNIK";
            this.iDKONPRACOWNIKDataGridViewTextBoxColumn.Name = "iDKONPRACOWNIKDataGridViewTextBoxColumn";
            // 
            // iDWYPOZYCZALNIADataGridViewTextBoxColumn
            // 
            this.iDWYPOZYCZALNIADataGridViewTextBoxColumn.DataPropertyName = "ID_WYPOZYCZALNIA";
            this.iDWYPOZYCZALNIADataGridViewTextBoxColumn.HeaderText = "ID_WYPOZYCZALNIA";
            this.iDWYPOZYCZALNIADataGridViewTextBoxColumn.Name = "iDWYPOZYCZALNIADataGridViewTextBoxColumn";
            // 
            // iMIEPRACOWNIKDataGridViewTextBoxColumn
            // 
            this.iMIEPRACOWNIKDataGridViewTextBoxColumn.DataPropertyName = "IMIE_PRACOWNIK";
            this.iMIEPRACOWNIKDataGridViewTextBoxColumn.HeaderText = "IMIE_PRACOWNIK";
            this.iMIEPRACOWNIKDataGridViewTextBoxColumn.Name = "iMIEPRACOWNIKDataGridViewTextBoxColumn";
            // 
            // nAZWISKOPRACOWNIKDataGridViewTextBoxColumn
            // 
            this.nAZWISKOPRACOWNIKDataGridViewTextBoxColumn.DataPropertyName = "NAZWISKO_PRACOWNIK";
            this.nAZWISKOPRACOWNIKDataGridViewTextBoxColumn.HeaderText = "NAZWISKO_PRACOWNIK";
            this.nAZWISKOPRACOWNIKDataGridViewTextBoxColumn.Name = "nAZWISKOPRACOWNIKDataGridViewTextBoxColumn";
            // 
            // pESELPRACOWNIKDataGridViewTextBoxColumn
            // 
            this.pESELPRACOWNIKDataGridViewTextBoxColumn.DataPropertyName = "PESEL_PRACOWNIK";
            this.pESELPRACOWNIKDataGridViewTextBoxColumn.HeaderText = "PESEL_PRACOWNIK";
            this.pESELPRACOWNIKDataGridViewTextBoxColumn.Name = "pESELPRACOWNIKDataGridViewTextBoxColumn";
            // 
            // tELEFONPRACOWNIKDataGridViewTextBoxColumn
            // 
            this.tELEFONPRACOWNIKDataGridViewTextBoxColumn.DataPropertyName = "TELEFON_PRACOWNIK";
            this.tELEFONPRACOWNIKDataGridViewTextBoxColumn.HeaderText = "TELEFON_PRACOWNIK";
            this.tELEFONPRACOWNIKDataGridViewTextBoxColumn.Name = "tELEFONPRACOWNIKDataGridViewTextBoxColumn";
            // 
            // sTANOWISKODataGridViewTextBoxColumn
            // 
            this.sTANOWISKODataGridViewTextBoxColumn.DataPropertyName = "STANOWISKO";
            this.sTANOWISKODataGridViewTextBoxColumn.HeaderText = "STANOWISKO";
            this.sTANOWISKODataGridViewTextBoxColumn.Name = "sTANOWISKODataGridViewTextBoxColumn";
            // 
            // dATAZATRUDNIENIADataGridViewTextBoxColumn
            // 
            this.dATAZATRUDNIENIADataGridViewTextBoxColumn.DataPropertyName = "DATA_ZATRUDNIENIA";
            this.dATAZATRUDNIENIADataGridViewTextBoxColumn.HeaderText = "DATA_ZATRUDNIENIA";
            this.dATAZATRUDNIENIADataGridViewTextBoxColumn.Name = "dATAZATRUDNIENIADataGridViewTextBoxColumn";
            // 
            // wYNAGRODZENIEDataGridViewTextBoxColumn
            // 
            this.wYNAGRODZENIEDataGridViewTextBoxColumn.DataPropertyName = "WYNAGRODZENIE";
            this.wYNAGRODZENIEDataGridViewTextBoxColumn.HeaderText = "WYNAGRODZENIE";
            this.wYNAGRODZENIEDataGridViewTextBoxColumn.Name = "wYNAGRODZENIEDataGridViewTextBoxColumn";
            // 
            // pREMIADataGridViewTextBoxColumn
            // 
            this.pREMIADataGridViewTextBoxColumn.DataPropertyName = "PREMIA";
            this.pREMIADataGridViewTextBoxColumn.HeaderText = "PREMIA";
            this.pREMIADataGridViewTextBoxColumn.Name = "pREMIADataGridViewTextBoxColumn";
            // 
            // pRACOWNICYBindingSource
            // 
            this.pRACOWNICYBindingSource.DataMember = "PRACOWNICY";
            this.pRACOWNICYBindingSource.DataSource = this.allDataSet;
            // 
            // pRACOWNICYTableAdapter
            // 
            this.pRACOWNICYTableAdapter.ClearBeforeFill = true;
            // 
            // kONTA_PRACOWNIKOWTableAdapter
            // 
            this.kONTA_PRACOWNIKOWTableAdapter.ClearBeforeFill = true;
            // 
            // SurnameTextBox
            // 
            this.SurnameTextBox.Location = new System.Drawing.Point(16, 591);
            this.SurnameTextBox.Name = "SurnameTextBox";
            this.SurnameTextBox.Size = new System.Drawing.Size(165, 20);
            this.SurnameTextBox.TabIndex = 140;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(13, 568);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 20);
            this.label1.TabIndex = 139;
            this.label1.Text = "Nazwisko";
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(16, 545);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(165, 20);
            this.NameTextBox.TabIndex = 138;
            // 
            // ModelLabel
            // 
            this.ModelLabel.AutoSize = true;
            this.ModelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ModelLabel.Location = new System.Drawing.Point(13, 522);
            this.ModelLabel.Name = "ModelLabel";
            this.ModelLabel.Size = new System.Drawing.Size(39, 20);
            this.ModelLabel.TabIndex = 137;
            this.ModelLabel.Text = "Imię";
            // 
            // FilterCheck
            // 
            this.FilterCheck.AutoSize = true;
            this.FilterCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FilterCheck.Location = new System.Drawing.Point(928, 587);
            this.FilterCheck.Name = "FilterCheck";
            this.FilterCheck.Size = new System.Drawing.Size(126, 24);
            this.FilterCheck.TabIndex = 141;
            this.FilterCheck.Text = "Włącz filtrację";
            this.FilterCheck.UseVisualStyleBackColor = true;
            this.FilterCheck.CheckedChanged += new System.EventHandler(this.FilterCheck_CheckedChanged);
            // 
            // EmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1100, 681);
            this.Controls.Add(this.FilterCheck);
            this.Controls.Add(this.SurnameTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.ModelLabel);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.FilterButton);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.TableLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EmployeeForm";
            this.Text = "EmployeeForm";
            this.Load += new System.EventHandler(this.EmployeeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kONTAPRACOWNIKOWBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.allDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRACOWNICYBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button FilterButton;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Label TableLabel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private AllDataSet allDataSet;
        private System.Windows.Forms.BindingSource pRACOWNICYBindingSource;
        private AllDataSetTableAdapters.PRACOWNICYTableAdapter pRACOWNICYTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDPRACDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDKONPRACOWNIKDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDWYPOZYCZALNIADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iMIEPRACOWNIKDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nAZWISKOPRACOWNIKDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pESELPRACOWNIKDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tELEFONPRACOWNIKDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTANOWISKODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dATAZATRUDNIENIADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wYNAGRODZENIEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pREMIADataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource kONTAPRACOWNIKOWBindingSource;
        private AllDataSetTableAdapters.KONTA_PRACOWNIKOWTableAdapter kONTA_PRACOWNIKOWTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDKONPRACOWNIKDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDROLADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDPRACDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nAZWAPRACOWNIKDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hASLOPRACOWNIKDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox SurnameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.Label ModelLabel;
        private System.Windows.Forms.CheckBox FilterCheck;
    }
}