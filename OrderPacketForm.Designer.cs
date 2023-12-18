namespace CarRental
{
    partial class OrderPacketForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderPacketForm));
            this.PriceLabel = new System.Windows.Forms.Label();
            this.FilterButton = new System.Windows.Forms.Button();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.TableLabel = new System.Windows.Forms.Label();
            this.ContentTextBox = new System.Windows.Forms.TextBox();
            this.ContentLabel = new System.Windows.Forms.Label();
            this.PacketTextBox = new System.Windows.Forms.TextBox();
            this.PacketLabel = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDPAKIETDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nAZWADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zAWARTOSCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cENADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pAKIETYBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.carRentalCWDataSet = new CarRental.CarRentalCWDataSet();
            this.pAKIETYTableAdapter = new CarRental.CarRentalCWDataSetTableAdapters.PAKIETYTableAdapter();
            this.PriceNumeric = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pAKIETYBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carRentalCWDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PriceNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // PriceLabel
            // 
            this.PriceLabel.AutoSize = true;
            this.PriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PriceLabel.Location = new System.Drawing.Point(12, 555);
            this.PriceLabel.Name = "PriceLabel";
            this.PriceLabel.Size = new System.Drawing.Size(47, 20);
            this.PriceLabel.TabIndex = 124;
            this.PriceLabel.Text = "Cena";
            // 
            // FilterButton
            // 
            this.FilterButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FilterButton.Image = ((System.Drawing.Image)(resources.GetObject("FilterButton.Image")));
            this.FilterButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.FilterButton.Location = new System.Drawing.Point(761, 615);
            this.FilterButton.Name = "FilterButton";
            this.FilterButton.Size = new System.Drawing.Size(164, 54);
            this.FilterButton.TabIndex = 123;
            this.FilterButton.Text = "Filtruj";
            this.FilterButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.FilterButton.UseVisualStyleBackColor = true;
            // 
            // UpdateButton
            // 
            this.UpdateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.UpdateButton.Image = ((System.Drawing.Image)(resources.GetObject("UpdateButton.Image")));
            this.UpdateButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.UpdateButton.Location = new System.Drawing.Point(421, 615);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(164, 54);
            this.UpdateButton.TabIndex = 122;
            this.UpdateButton.Text = "Modyfikuj";
            this.UpdateButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.DeleteButton.Image = ((System.Drawing.Image)(resources.GetObject("DeleteButton.Image")));
            this.DeleteButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DeleteButton.Location = new System.Drawing.Point(591, 615);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(164, 54);
            this.DeleteButton.TabIndex = 121;
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
            this.AddButton.Location = new System.Drawing.Point(251, 615);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(164, 54);
            this.AddButton.TabIndex = 120;
            this.AddButton.Text = "Dodaj";
            this.AddButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // TableLabel
            // 
            this.TableLabel.AutoSize = true;
            this.TableLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TableLabel.Location = new System.Drawing.Point(9, 9);
            this.TableLabel.Name = "TableLabel";
            this.TableLabel.Size = new System.Drawing.Size(120, 37);
            this.TableLabel.TabIndex = 119;
            this.TableLabel.Text = "Pakiety";
            // 
            // ContentTextBox
            // 
            this.ContentTextBox.Location = new System.Drawing.Point(15, 532);
            this.ContentTextBox.Name = "ContentTextBox";
            this.ContentTextBox.Size = new System.Drawing.Size(165, 20);
            this.ContentTextBox.TabIndex = 128;
            // 
            // ContentLabel
            // 
            this.ContentLabel.AutoSize = true;
            this.ContentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ContentLabel.Location = new System.Drawing.Point(12, 509);
            this.ContentLabel.Name = "ContentLabel";
            this.ContentLabel.Size = new System.Drawing.Size(83, 20);
            this.ContentLabel.TabIndex = 127;
            this.ContentLabel.Text = "Zawartość";
            // 
            // PacketTextBox
            // 
            this.PacketTextBox.Location = new System.Drawing.Point(15, 486);
            this.PacketTextBox.Name = "PacketTextBox";
            this.PacketTextBox.Size = new System.Drawing.Size(165, 20);
            this.PacketTextBox.TabIndex = 130;
            // 
            // PacketLabel
            // 
            this.PacketLabel.AutoSize = true;
            this.PacketLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PacketLabel.Location = new System.Drawing.Point(12, 463);
            this.PacketLabel.Name = "PacketLabel";
            this.PacketLabel.Size = new System.Drawing.Size(113, 20);
            this.PacketLabel.TabIndex = 129;
            this.PacketLabel.Text = "Nazwa pakietu";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDPAKIETDataGridViewTextBoxColumn,
            this.nAZWADataGridViewTextBoxColumn,
            this.zAWARTOSCDataGridViewTextBoxColumn,
            this.cENADataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.pAKIETYBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(16, 50);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(909, 410);
            this.dataGridView1.TabIndex = 131;
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            // 
            // iDPAKIETDataGridViewTextBoxColumn
            // 
            this.iDPAKIETDataGridViewTextBoxColumn.DataPropertyName = "ID_PAKIET";
            this.iDPAKIETDataGridViewTextBoxColumn.HeaderText = "ID_PAKIET";
            this.iDPAKIETDataGridViewTextBoxColumn.Name = "iDPAKIETDataGridViewTextBoxColumn";
            this.iDPAKIETDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nAZWADataGridViewTextBoxColumn
            // 
            this.nAZWADataGridViewTextBoxColumn.DataPropertyName = "NAZWA";
            this.nAZWADataGridViewTextBoxColumn.HeaderText = "NAZWA";
            this.nAZWADataGridViewTextBoxColumn.Name = "nAZWADataGridViewTextBoxColumn";
            // 
            // zAWARTOSCDataGridViewTextBoxColumn
            // 
            this.zAWARTOSCDataGridViewTextBoxColumn.DataPropertyName = "ZAWARTOSC";
            this.zAWARTOSCDataGridViewTextBoxColumn.HeaderText = "ZAWARTOSC";
            this.zAWARTOSCDataGridViewTextBoxColumn.Name = "zAWARTOSCDataGridViewTextBoxColumn";
            // 
            // cENADataGridViewTextBoxColumn
            // 
            this.cENADataGridViewTextBoxColumn.DataPropertyName = "CENA";
            this.cENADataGridViewTextBoxColumn.HeaderText = "CENA";
            this.cENADataGridViewTextBoxColumn.Name = "cENADataGridViewTextBoxColumn";
            // 
            // pAKIETYBindingSource
            // 
            this.pAKIETYBindingSource.DataMember = "PAKIETY";
            this.pAKIETYBindingSource.DataSource = this.carRentalCWDataSet;
            // 
            // carRentalCWDataSet
            // 
            this.carRentalCWDataSet.DataSetName = "CarRentalCWDataSet";
            this.carRentalCWDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pAKIETYTableAdapter
            // 
            this.pAKIETYTableAdapter.ClearBeforeFill = true;
            // 
            // PriceNumeric
            // 
            this.PriceNumeric.DecimalPlaces = 2;
            this.PriceNumeric.Location = new System.Drawing.Point(15, 579);
            this.PriceNumeric.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.PriceNumeric.Name = "PriceNumeric";
            this.PriceNumeric.Size = new System.Drawing.Size(165, 20);
            this.PriceNumeric.TabIndex = 132;
            // 
            // OrderPacketForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(937, 681);
            this.Controls.Add(this.PriceNumeric);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.PacketTextBox);
            this.Controls.Add(this.PacketLabel);
            this.Controls.Add(this.ContentTextBox);
            this.Controls.Add(this.ContentLabel);
            this.Controls.Add(this.PriceLabel);
            this.Controls.Add(this.FilterButton);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.TableLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "OrderPacketForm";
            this.Text = "OrderOrderForm";
            this.Load += new System.EventHandler(this.OrderPacketForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pAKIETYBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carRentalCWDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PriceNumeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label PriceLabel;
        private System.Windows.Forms.Button FilterButton;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Label TableLabel;
        private System.Windows.Forms.TextBox ContentTextBox;
        private System.Windows.Forms.Label ContentLabel;
        private System.Windows.Forms.TextBox PacketTextBox;
        private System.Windows.Forms.Label PacketLabel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private CarRentalCWDataSet carRentalCWDataSet;
        private System.Windows.Forms.BindingSource pAKIETYBindingSource;
        private CarRentalCWDataSetTableAdapters.PAKIETYTableAdapter pAKIETYTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDPAKIETDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nAZWADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn zAWARTOSCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cENADataGridViewTextBoxColumn;
        private System.Windows.Forms.NumericUpDown PriceNumeric;
    }
}