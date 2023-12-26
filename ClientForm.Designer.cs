namespace CarRental
{
    partial class ClientForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientForm));
            this.FilterButton = new System.Windows.Forms.Button();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.TableLabel = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.allDataSet = new CarRental.AllDataSet();
            this.kLIENCIBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kLIENCITableAdapter = new CarRental.AllDataSetTableAdapters.KLIENCITableAdapter();
            this.iDKLIENTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDKONKLIENTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iMIEKLIENTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nAZWISKOKLIENTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pESELKLIENTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tELEFONKLIENTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fAXDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nIPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kONTAKLIENTOWBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kONTA_KLIENTOWTableAdapter = new CarRental.AllDataSetTableAdapters.KONTA_KLIENTOWTableAdapter();
            this.iDKONKLIENTDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDROLADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDKLIENTDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nAZWAKLIENTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hASLOKLIENTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.allDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kLIENCIBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kONTAKLIENTOWBindingSource)).BeginInit();
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
            this.FilterButton.TabIndex = 110;
            this.FilterButton.Text = "Filtruj";
            this.FilterButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.FilterButton.UseVisualStyleBackColor = true;
            // 
            // UpdateButton
            // 
            this.UpdateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.UpdateButton.Image = ((System.Drawing.Image)(resources.GetObject("UpdateButton.Image")));
            this.UpdateButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.UpdateButton.Location = new System.Drawing.Point(588, 618);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(164, 54);
            this.UpdateButton.TabIndex = 109;
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
            this.DeleteButton.TabIndex = 108;
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
            this.TableLabel.Size = new System.Drawing.Size(110, 37);
            this.TableLabel.TabIndex = 107;
            this.TableLabel.Text = "Klienci";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDKLIENTDataGridViewTextBoxColumn,
            this.iDKONKLIENTDataGridViewTextBoxColumn,
            this.iMIEKLIENTDataGridViewTextBoxColumn,
            this.nAZWISKOKLIENTDataGridViewTextBoxColumn,
            this.pESELKLIENTDataGridViewTextBoxColumn,
            this.tELEFONKLIENTDataGridViewTextBoxColumn,
            this.fAXDataGridViewTextBoxColumn,
            this.nIPDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.kLIENCIBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(16, 50);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1072, 562);
            this.dataGridView1.TabIndex = 111;
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDKONKLIENTDataGridViewTextBoxColumn1,
            this.iDROLADataGridViewTextBoxColumn,
            this.iDKLIENTDataGridViewTextBoxColumn1,
            this.nAZWAKLIENTDataGridViewTextBoxColumn,
            this.hASLOKLIENTDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.kONTAKLIENTOWBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(657, 50);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(431, 562);
            this.dataGridView2.TabIndex = 112;
            this.dataGridView2.Visible = false;
            // 
            // allDataSet
            // 
            this.allDataSet.DataSetName = "AllDataSet";
            this.allDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kLIENCIBindingSource
            // 
            this.kLIENCIBindingSource.DataMember = "KLIENCI";
            this.kLIENCIBindingSource.DataSource = this.allDataSet;
            // 
            // kLIENCITableAdapter
            // 
            this.kLIENCITableAdapter.ClearBeforeFill = true;
            // 
            // iDKLIENTDataGridViewTextBoxColumn
            // 
            this.iDKLIENTDataGridViewTextBoxColumn.DataPropertyName = "ID_KLIENT";
            this.iDKLIENTDataGridViewTextBoxColumn.HeaderText = "ID_KLIENT";
            this.iDKLIENTDataGridViewTextBoxColumn.Name = "iDKLIENTDataGridViewTextBoxColumn";
            this.iDKLIENTDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iDKONKLIENTDataGridViewTextBoxColumn
            // 
            this.iDKONKLIENTDataGridViewTextBoxColumn.DataPropertyName = "iD_KON_KLIENT";
            this.iDKONKLIENTDataGridViewTextBoxColumn.HeaderText = "iD_KON_KLIENT";
            this.iDKONKLIENTDataGridViewTextBoxColumn.Name = "iDKONKLIENTDataGridViewTextBoxColumn";
            // 
            // iMIEKLIENTDataGridViewTextBoxColumn
            // 
            this.iMIEKLIENTDataGridViewTextBoxColumn.DataPropertyName = "IMIE_KLIENT";
            this.iMIEKLIENTDataGridViewTextBoxColumn.HeaderText = "IMIE_KLIENT";
            this.iMIEKLIENTDataGridViewTextBoxColumn.Name = "iMIEKLIENTDataGridViewTextBoxColumn";
            // 
            // nAZWISKOKLIENTDataGridViewTextBoxColumn
            // 
            this.nAZWISKOKLIENTDataGridViewTextBoxColumn.DataPropertyName = "NAZWISKO_KLIENT";
            this.nAZWISKOKLIENTDataGridViewTextBoxColumn.HeaderText = "NAZWISKO_KLIENT";
            this.nAZWISKOKLIENTDataGridViewTextBoxColumn.Name = "nAZWISKOKLIENTDataGridViewTextBoxColumn";
            // 
            // pESELKLIENTDataGridViewTextBoxColumn
            // 
            this.pESELKLIENTDataGridViewTextBoxColumn.DataPropertyName = "PESEL_KLIENT";
            this.pESELKLIENTDataGridViewTextBoxColumn.HeaderText = "PESEL_KLIENT";
            this.pESELKLIENTDataGridViewTextBoxColumn.Name = "pESELKLIENTDataGridViewTextBoxColumn";
            // 
            // tELEFONKLIENTDataGridViewTextBoxColumn
            // 
            this.tELEFONKLIENTDataGridViewTextBoxColumn.DataPropertyName = "TELEFON_KLIENT";
            this.tELEFONKLIENTDataGridViewTextBoxColumn.HeaderText = "TELEFON_KLIENT";
            this.tELEFONKLIENTDataGridViewTextBoxColumn.Name = "tELEFONKLIENTDataGridViewTextBoxColumn";
            // 
            // fAXDataGridViewTextBoxColumn
            // 
            this.fAXDataGridViewTextBoxColumn.DataPropertyName = "FAX";
            this.fAXDataGridViewTextBoxColumn.HeaderText = "FAX";
            this.fAXDataGridViewTextBoxColumn.Name = "fAXDataGridViewTextBoxColumn";
            // 
            // nIPDataGridViewTextBoxColumn
            // 
            this.nIPDataGridViewTextBoxColumn.DataPropertyName = "NIP";
            this.nIPDataGridViewTextBoxColumn.HeaderText = "NIP";
            this.nIPDataGridViewTextBoxColumn.Name = "nIPDataGridViewTextBoxColumn";
            // 
            // kONTAKLIENTOWBindingSource
            // 
            this.kONTAKLIENTOWBindingSource.DataMember = "KONTA_KLIENTOW";
            this.kONTAKLIENTOWBindingSource.DataSource = this.allDataSet;
            // 
            // kONTA_KLIENTOWTableAdapter
            // 
            this.kONTA_KLIENTOWTableAdapter.ClearBeforeFill = true;
            // 
            // iDKONKLIENTDataGridViewTextBoxColumn1
            // 
            this.iDKONKLIENTDataGridViewTextBoxColumn1.DataPropertyName = "iD_KON_KLIENT";
            this.iDKONKLIENTDataGridViewTextBoxColumn1.HeaderText = "iD_KON_KLIENT";
            this.iDKONKLIENTDataGridViewTextBoxColumn1.Name = "iDKONKLIENTDataGridViewTextBoxColumn1";
            this.iDKONKLIENTDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // iDROLADataGridViewTextBoxColumn
            // 
            this.iDROLADataGridViewTextBoxColumn.DataPropertyName = "ID_ROLA";
            this.iDROLADataGridViewTextBoxColumn.HeaderText = "ID_ROLA";
            this.iDROLADataGridViewTextBoxColumn.Name = "iDROLADataGridViewTextBoxColumn";
            // 
            // iDKLIENTDataGridViewTextBoxColumn1
            // 
            this.iDKLIENTDataGridViewTextBoxColumn1.DataPropertyName = "ID_KLIENT";
            this.iDKLIENTDataGridViewTextBoxColumn1.HeaderText = "ID_KLIENT";
            this.iDKLIENTDataGridViewTextBoxColumn1.Name = "iDKLIENTDataGridViewTextBoxColumn1";
            // 
            // nAZWAKLIENTDataGridViewTextBoxColumn
            // 
            this.nAZWAKLIENTDataGridViewTextBoxColumn.DataPropertyName = "NAZWA_KLIENT";
            this.nAZWAKLIENTDataGridViewTextBoxColumn.HeaderText = "NAZWA_KLIENT";
            this.nAZWAKLIENTDataGridViewTextBoxColumn.Name = "nAZWAKLIENTDataGridViewTextBoxColumn";
            // 
            // hASLOKLIENTDataGridViewTextBoxColumn
            // 
            this.hASLOKLIENTDataGridViewTextBoxColumn.DataPropertyName = "HASLO_KLIENT";
            this.hASLOKLIENTDataGridViewTextBoxColumn.HeaderText = "HASLO_KLIENT";
            this.hASLOKLIENTDataGridViewTextBoxColumn.Name = "hASLOKLIENTDataGridViewTextBoxColumn";
            // 
            // ClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1100, 681);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.FilterButton);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.TableLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ClientForm";
            this.Text = "ClientForm";
            this.Load += new System.EventHandler(this.ClientForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.allDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kLIENCIBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kONTAKLIENTOWBindingSource)).EndInit();
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
        private System.Windows.Forms.BindingSource kLIENCIBindingSource;
        private AllDataSetTableAdapters.KLIENCITableAdapter kLIENCITableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDKLIENTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDKONKLIENTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iMIEKLIENTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nAZWISKOKLIENTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pESELKLIENTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tELEFONKLIENTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fAXDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nIPDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource kONTAKLIENTOWBindingSource;
        private AllDataSetTableAdapters.KONTA_KLIENTOWTableAdapter kONTA_KLIENTOWTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDKONKLIENTDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDROLADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDKLIENTDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nAZWAKLIENTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hASLOKLIENTDataGridViewTextBoxColumn;
    }
}