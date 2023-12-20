namespace CarRental
{
    partial class OrderHistoryOptionsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderHistoryOptionsForm));
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.EndDatePicker = new System.Windows.Forms.DateTimePicker();
            this.StartDatePicker = new System.Windows.Forms.DateTimePicker();
            this.PriceNumeric = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.CountNumeric = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.EmployeeCombo = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.FueledCheck = new System.Windows.Forms.CheckBox();
            this.CollisionCheck = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.CollisionDatePicker = new System.Windows.Forms.DateTimePicker();
            this.PenaltyNumeric = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.allDataSet = new CarRental.AllDataSet();
            this.pRACOWNICYBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pRACOWNICYTableAdapter = new CarRental.AllDataSetTableAdapters.PRACOWNICYTableAdapter();
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
            ((System.ComponentModel.ISupportInitialize)(this.PriceNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CountNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PenaltyNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.allDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRACOWNICYBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.Location = new System.Drawing.Point(12, 139);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(137, 20);
            this.label9.TabIndex = 170;
            this.label9.Text = "Data zakończenia";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(13, 93);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(133, 20);
            this.label8.TabIndex = 169;
            this.label8.Text = "Data rozpoczęcia";
            // 
            // EndDatePicker
            // 
            this.EndDatePicker.Location = new System.Drawing.Point(16, 162);
            this.EndDatePicker.Name = "EndDatePicker";
            this.EndDatePicker.Size = new System.Drawing.Size(200, 20);
            this.EndDatePicker.TabIndex = 168;
            // 
            // StartDatePicker
            // 
            this.StartDatePicker.Location = new System.Drawing.Point(16, 116);
            this.StartDatePicker.Name = "StartDatePicker";
            this.StartDatePicker.Size = new System.Drawing.Size(200, 20);
            this.StartDatePicker.TabIndex = 167;
            // 
            // PriceNumeric
            // 
            this.PriceNumeric.DecimalPlaces = 2;
            this.PriceNumeric.Location = new System.Drawing.Point(17, 300);
            this.PriceNumeric.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.PriceNumeric.Name = "PriceNumeric";
            this.PriceNumeric.Size = new System.Drawing.Size(163, 20);
            this.PriceNumeric.TabIndex = 166;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(13, 277);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(134, 20);
            this.label7.TabIndex = 165;
            this.label7.Text = "Koszt tankowania";
            // 
            // CountNumeric
            // 
            this.CountNumeric.Location = new System.Drawing.Point(16, 254);
            this.CountNumeric.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.CountNumeric.Name = "CountNumeric";
            this.CountNumeric.Size = new System.Drawing.Size(164, 20);
            this.CountNumeric.TabIndex = 164;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(12, 228);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 20);
            this.label6.TabIndex = 163;
            this.label6.Text = "Ilość tankowań";
            // 
            // EmployeeCombo
            // 
            this.EmployeeCombo.DataSource = this.pRACOWNICYBindingSource;
            this.EmployeeCombo.DisplayMember = "NAZWISKO_PRACOWNIK";
            this.EmployeeCombo.FormattingEnabled = true;
            this.EmployeeCombo.Location = new System.Drawing.Point(17, 69);
            this.EmployeeCombo.Name = "EmployeeCombo";
            this.EmployeeCombo.Size = new System.Drawing.Size(163, 21);
            this.EmployeeCombo.TabIndex = 158;
            this.EmployeeCombo.ValueMember = "ID_PRAC";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(13, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 20);
            this.label4.TabIndex = 157;
            this.label4.Text = "Pracownik";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 25);
            this.label1.TabIndex = 156;
            this.label1.Text = "Historia zamówienia";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(13, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 20);
            this.label2.TabIndex = 171;
            this.label2.Text = "Tankowanie";
            // 
            // FueledCheck
            // 
            this.FueledCheck.AutoSize = true;
            this.FueledCheck.Location = new System.Drawing.Point(16, 208);
            this.FueledCheck.Name = "FueledCheck";
            this.FueledCheck.Size = new System.Drawing.Size(70, 17);
            this.FueledCheck.TabIndex = 172;
            this.FueledCheck.Text = "TAK/NIE";
            this.FueledCheck.UseVisualStyleBackColor = true;
            // 
            // CollisionCheck
            // 
            this.CollisionCheck.AutoSize = true;
            this.CollisionCheck.Location = new System.Drawing.Point(16, 346);
            this.CollisionCheck.Name = "CollisionCheck";
            this.CollisionCheck.Size = new System.Drawing.Size(70, 17);
            this.CollisionCheck.TabIndex = 174;
            this.CollisionCheck.Text = "TAK/NIE";
            this.CollisionCheck.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(13, 323);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 20);
            this.label3.TabIndex = 173;
            this.label3.Text = "Kolizja";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label10.Location = new System.Drawing.Point(12, 366);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(85, 20);
            this.label10.TabIndex = 176;
            this.label10.Text = "Data kolizji";
            // 
            // CollisionDatePicker
            // 
            this.CollisionDatePicker.Location = new System.Drawing.Point(16, 389);
            this.CollisionDatePicker.Name = "CollisionDatePicker";
            this.CollisionDatePicker.Size = new System.Drawing.Size(200, 20);
            this.CollisionDatePicker.TabIndex = 175;
            // 
            // PenaltyNumeric
            // 
            this.PenaltyNumeric.DecimalPlaces = 2;
            this.PenaltyNumeric.Location = new System.Drawing.Point(16, 438);
            this.PenaltyNumeric.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.PenaltyNumeric.Name = "PenaltyNumeric";
            this.PenaltyNumeric.Size = new System.Drawing.Size(164, 20);
            this.PenaltyNumeric.TabIndex = 178;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(12, 412);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 20);
            this.label5.TabIndex = 177;
            this.label5.Text = "Kara za kolizję";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(608, 495);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(164, 54);
            this.button2.TabIndex = 181;
            this.button2.Text = "Anuluj";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // UpdateButton
            // 
            this.UpdateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.UpdateButton.Image = ((System.Drawing.Image)(resources.GetObject("UpdateButton.Image")));
            this.UpdateButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.UpdateButton.Location = new System.Drawing.Point(438, 495);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(164, 54);
            this.UpdateButton.TabIndex = 180;
            this.UpdateButton.Text = "Modyfikuj";
            this.UpdateButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
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
            this.dataGridView1.Location = new System.Drawing.Point(222, 69);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(550, 389);
            this.dataGridView1.TabIndex = 182;
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            // 
            // allDataSet
            // 
            this.allDataSet.DataSetName = "AllDataSet";
            this.allDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // OrderHistoryOptionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.PenaltyNumeric);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.CollisionDatePicker);
            this.Controls.Add(this.CollisionCheck);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.FueledCheck);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.EndDatePicker);
            this.Controls.Add(this.StartDatePicker);
            this.Controls.Add(this.PriceNumeric);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.CountNumeric);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.EmployeeCombo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Name = "OrderHistoryOptionsForm";
            this.Text = "Zarządzanie historią zamówienia";
            this.Load += new System.EventHandler(this.OrderHistoryOptionsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PriceNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CountNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PenaltyNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.allDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRACOWNICYBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.DataGridView dataGridView1;
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
        public System.Windows.Forms.DateTimePicker EndDatePicker;
        public System.Windows.Forms.DateTimePicker StartDatePicker;
        public System.Windows.Forms.NumericUpDown PriceNumeric;
        public System.Windows.Forms.NumericUpDown CountNumeric;
        public System.Windows.Forms.ComboBox EmployeeCombo;
        public System.Windows.Forms.CheckBox FueledCheck;
        public System.Windows.Forms.CheckBox CollisionCheck;
        public System.Windows.Forms.DateTimePicker CollisionDatePicker;
        public System.Windows.Forms.NumericUpDown PenaltyNumeric;
    }
}