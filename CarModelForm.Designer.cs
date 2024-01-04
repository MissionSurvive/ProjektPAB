namespace CarRental
{
    partial class CarModelForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CarModelForm));
            this.TableLabel = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDMODELDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDMARKADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDNADWOZIEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nAZWAMODELDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rOCZNIKDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gENERACJADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sEGMENTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FilterButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.ModelTextBox = new System.Windows.Forms.TextBox();
            this.ModelLabel = new System.Windows.Forms.Label();
            this.FilterCheck = new System.Windows.Forms.CheckBox();
            this.allDataSet = new CarRental.AllDataSet();
            this.mODELETableAdapter = new CarRental.AllDataSetTableAdapters.MODELETableAdapter();
            this.mODELEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.allDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mODELEBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // TableLabel
            // 
            this.TableLabel.AutoSize = true;
            this.TableLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TableLabel.Location = new System.Drawing.Point(12, 9);
            this.TableLabel.Name = "TableLabel";
            this.TableLabel.Size = new System.Drawing.Size(120, 37);
            this.TableLabel.TabIndex = 13;
            this.TableLabel.Text = "Modele";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDMODELDataGridViewTextBoxColumn,
            this.iDMARKADataGridViewTextBoxColumn,
            this.iDNADWOZIEDataGridViewTextBoxColumn,
            this.nAZWAMODELDataGridViewTextBoxColumn,
            this.rOCZNIKDataGridViewTextBoxColumn,
            this.gENERACJADataGridViewTextBoxColumn,
            this.sEGMENTDataGridViewTextBoxColumn});
            this.dataGridView1.Location = new System.Drawing.Point(19, 50);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(906, 507);
            this.dataGridView1.TabIndex = 21;
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            // 
            // iDMODELDataGridViewTextBoxColumn
            // 
            this.iDMODELDataGridViewTextBoxColumn.DataPropertyName = "ID_MODEL";
            this.iDMODELDataGridViewTextBoxColumn.HeaderText = "ID_MODEL";
            this.iDMODELDataGridViewTextBoxColumn.Name = "iDMODELDataGridViewTextBoxColumn";
            this.iDMODELDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iDMARKADataGridViewTextBoxColumn
            // 
            this.iDMARKADataGridViewTextBoxColumn.DataPropertyName = "ID_MARKA";
            this.iDMARKADataGridViewTextBoxColumn.HeaderText = "ID_MARKA";
            this.iDMARKADataGridViewTextBoxColumn.Name = "iDMARKADataGridViewTextBoxColumn";
            this.iDMARKADataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iDNADWOZIEDataGridViewTextBoxColumn
            // 
            this.iDNADWOZIEDataGridViewTextBoxColumn.DataPropertyName = "ID_NADWOZIE";
            this.iDNADWOZIEDataGridViewTextBoxColumn.HeaderText = "ID_NADWOZIE";
            this.iDNADWOZIEDataGridViewTextBoxColumn.Name = "iDNADWOZIEDataGridViewTextBoxColumn";
            this.iDNADWOZIEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nAZWAMODELDataGridViewTextBoxColumn
            // 
            this.nAZWAMODELDataGridViewTextBoxColumn.DataPropertyName = "NAZWA_MODEL";
            this.nAZWAMODELDataGridViewTextBoxColumn.HeaderText = "NAZWA_MODEL";
            this.nAZWAMODELDataGridViewTextBoxColumn.Name = "nAZWAMODELDataGridViewTextBoxColumn";
            this.nAZWAMODELDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rOCZNIKDataGridViewTextBoxColumn
            // 
            this.rOCZNIKDataGridViewTextBoxColumn.DataPropertyName = "ROCZNIK";
            this.rOCZNIKDataGridViewTextBoxColumn.HeaderText = "ROCZNIK";
            this.rOCZNIKDataGridViewTextBoxColumn.Name = "rOCZNIKDataGridViewTextBoxColumn";
            this.rOCZNIKDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // gENERACJADataGridViewTextBoxColumn
            // 
            this.gENERACJADataGridViewTextBoxColumn.DataPropertyName = "GENERACJA";
            this.gENERACJADataGridViewTextBoxColumn.HeaderText = "GENERACJA";
            this.gENERACJADataGridViewTextBoxColumn.Name = "gENERACJADataGridViewTextBoxColumn";
            this.gENERACJADataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sEGMENTDataGridViewTextBoxColumn
            // 
            this.sEGMENTDataGridViewTextBoxColumn.DataPropertyName = "SEGMENT";
            this.sEGMENTDataGridViewTextBoxColumn.HeaderText = "SEGMENT";
            this.sEGMENTDataGridViewTextBoxColumn.Name = "sEGMENTDataGridViewTextBoxColumn";
            this.sEGMENTDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // FilterButton
            // 
            this.FilterButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FilterButton.Image = ((System.Drawing.Image)(resources.GetObject("FilterButton.Image")));
            this.FilterButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.FilterButton.Location = new System.Drawing.Point(761, 615);
            this.FilterButton.Name = "FilterButton";
            this.FilterButton.Size = new System.Drawing.Size(164, 54);
            this.FilterButton.TabIndex = 65;
            this.FilterButton.Text = "Filtruj";
            this.FilterButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.FilterButton.UseVisualStyleBackColor = true;
            this.FilterButton.Click += new System.EventHandler(this.FilterButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.DeleteButton.Image = ((System.Drawing.Image)(resources.GetObject("DeleteButton.Image")));
            this.DeleteButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DeleteButton.Location = new System.Drawing.Point(591, 615);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(164, 54);
            this.DeleteButton.TabIndex = 63;
            this.DeleteButton.Text = "Usuń";
            this.DeleteButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.AddButton.Image = ((System.Drawing.Image)(resources.GetObject("AddButton.Image")));
            this.AddButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddButton.Location = new System.Drawing.Point(421, 615);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(164, 54);
            this.AddButton.TabIndex = 62;
            this.AddButton.Text = "Zarządzaj";
            this.AddButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // ModelTextBox
            // 
            this.ModelTextBox.Location = new System.Drawing.Point(19, 586);
            this.ModelTextBox.Name = "ModelTextBox";
            this.ModelTextBox.Size = new System.Drawing.Size(165, 20);
            this.ModelTextBox.TabIndex = 132;
            // 
            // ModelLabel
            // 
            this.ModelLabel.AutoSize = true;
            this.ModelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ModelLabel.Location = new System.Drawing.Point(16, 563);
            this.ModelLabel.Name = "ModelLabel";
            this.ModelLabel.Size = new System.Drawing.Size(113, 20);
            this.ModelLabel.TabIndex = 131;
            this.ModelLabel.Text = "Nazwa modelu";
            // 
            // FilterCheck
            // 
            this.FilterCheck.AutoSize = true;
            this.FilterCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FilterCheck.Location = new System.Drawing.Point(761, 586);
            this.FilterCheck.Name = "FilterCheck";
            this.FilterCheck.Size = new System.Drawing.Size(126, 24);
            this.FilterCheck.TabIndex = 134;
            this.FilterCheck.Text = "Włącz filtrację";
            this.FilterCheck.UseVisualStyleBackColor = true;
            this.FilterCheck.CheckedChanged += new System.EventHandler(this.FilterCheck_CheckedChanged);
            // 
            // allDataSet
            // 
            this.allDataSet.DataSetName = "AllDataSet";
            this.allDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mODELETableAdapter
            // 
            this.mODELETableAdapter.ClearBeforeFill = true;
            // 
            // mODELEBindingSource
            // 
            this.mODELEBindingSource.DataMember = "MODELE";
            // 
            // CarModelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(937, 681);
            this.Controls.Add(this.FilterCheck);
            this.Controls.Add(this.ModelTextBox);
            this.Controls.Add(this.ModelLabel);
            this.Controls.Add(this.FilterButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.TableLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CarModelForm";
            this.Text = "CarMakeForm";
            this.Load += new System.EventHandler(this.CarModelForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.allDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mODELEBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label TableLabel;
        private System.Windows.Forms.Button FilterButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox ModelTextBox;
        private System.Windows.Forms.Label ModelLabel;
        private System.Windows.Forms.CheckBox FilterCheck;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDMODELDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDMARKADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDNADWOZIEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nAZWAMODELDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rOCZNIKDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gENERACJADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sEGMENTDataGridViewTextBoxColumn;
        private AllDataSet allDataSet;
        private AllDataSetTableAdapters.MODELETableAdapter mODELETableAdapter;
        private System.Windows.Forms.BindingSource mODELEBindingSource;
    }
}