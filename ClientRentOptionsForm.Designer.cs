namespace CarRental
{
    partial class ClientRentOptionsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientRentOptionsForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID_PAKIET = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NAZWA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ZAWARTOSC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CENA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label8 = new System.Windows.Forms.Label();
            this.StartDatePicker = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.MonthRadio = new System.Windows.Forms.RadioButton();
            this.WeekRadio = new System.Windows.Forms.RadioButton();
            this.DayRadio = new System.Windows.Forms.RadioButton();
            this.LengthNumeric = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.EmployeeCombo = new System.Windows.Forms.ComboBox();
            this.SumTextBox = new System.Windows.Forms.TextBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LengthNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 25);
            this.label1.TabIndex = 133;
            this.label1.Text = "Wybierz pakiet";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(12, 269);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(299, 25);
            this.label2.TabIndex = 134;
            this.label2.Text = "Wskaż długość wypożyczenia";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_PAKIET,
            this.NAZWA,
            this.ZAWARTOSC,
            this.CENA});
            this.dataGridView1.Location = new System.Drawing.Point(17, 38);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(555, 228);
            this.dataGridView1.TabIndex = 135;
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            // 
            // ID_PAKIET
            // 
            this.ID_PAKIET.DataPropertyName = "ID_PAKIET";
            this.ID_PAKIET.HeaderText = "ID_PAKIET";
            this.ID_PAKIET.Name = "ID_PAKIET";
            this.ID_PAKIET.ReadOnly = true;
            // 
            // NAZWA
            // 
            this.NAZWA.DataPropertyName = "NAZWA";
            this.NAZWA.HeaderText = "NAZWA";
            this.NAZWA.Name = "NAZWA";
            this.NAZWA.ReadOnly = true;
            // 
            // ZAWARTOSC
            // 
            this.ZAWARTOSC.DataPropertyName = "ZAWARTOSC";
            this.ZAWARTOSC.HeaderText = "ZAWARTOSC";
            this.ZAWARTOSC.Name = "ZAWARTOSC";
            this.ZAWARTOSC.ReadOnly = true;
            // 
            // CENA
            // 
            this.CENA.DataPropertyName = "CENA";
            this.CENA.HeaderText = "CENA";
            this.CENA.Name = "CENA";
            this.CENA.ReadOnly = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(14, 303);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(133, 20);
            this.label8.TabIndex = 154;
            this.label8.Text = "Data rozpoczęcia";
            // 
            // StartDatePicker
            // 
            this.StartDatePicker.Location = new System.Drawing.Point(17, 326);
            this.StartDatePicker.Name = "StartDatePicker";
            this.StartDatePicker.Size = new System.Drawing.Size(200, 20);
            this.StartDatePicker.TabIndex = 153;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.MonthRadio);
            this.groupBox1.Controls.Add(this.WeekRadio);
            this.groupBox1.Controls.Add(this.DayRadio);
            this.groupBox1.Location = new System.Drawing.Point(223, 303);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(73, 100);
            this.groupBox1.TabIndex = 155;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Okres";
            // 
            // MonthRadio
            // 
            this.MonthRadio.AutoSize = true;
            this.MonthRadio.Location = new System.Drawing.Point(6, 72);
            this.MonthRadio.Name = "MonthRadio";
            this.MonthRadio.Size = new System.Drawing.Size(61, 17);
            this.MonthRadio.TabIndex = 2;
            this.MonthRadio.Text = "Miesiąc";
            this.MonthRadio.UseVisualStyleBackColor = true;
            this.MonthRadio.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // WeekRadio
            // 
            this.WeekRadio.AutoSize = true;
            this.WeekRadio.Location = new System.Drawing.Point(6, 49);
            this.WeekRadio.Name = "WeekRadio";
            this.WeekRadio.Size = new System.Drawing.Size(62, 17);
            this.WeekRadio.TabIndex = 1;
            this.WeekRadio.Text = "Tydzień";
            this.WeekRadio.UseVisualStyleBackColor = true;
            this.WeekRadio.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // DayRadio
            // 
            this.DayRadio.AutoSize = true;
            this.DayRadio.Checked = true;
            this.DayRadio.Location = new System.Drawing.Point(6, 26);
            this.DayRadio.Name = "DayRadio";
            this.DayRadio.Size = new System.Drawing.Size(52, 17);
            this.DayRadio.TabIndex = 0;
            this.DayRadio.TabStop = true;
            this.DayRadio.Text = "Dzień";
            this.DayRadio.UseVisualStyleBackColor = true;
            this.DayRadio.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // LengthNumeric
            // 
            this.LengthNumeric.Location = new System.Drawing.Point(18, 372);
            this.LengthNumeric.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.LengthNumeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.LengthNumeric.Name = "LengthNumeric";
            this.LengthNumeric.Size = new System.Drawing.Size(199, 20);
            this.LengthNumeric.TabIndex = 157;
            this.LengthNumeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.LengthNumeric.ValueChanged += new System.EventHandler(this.LengthNumeric_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(14, 349);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(138, 20);
            this.label6.TabIndex = 156;
            this.label6.Text = "Liczba dni/tyg/msc";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(13, 477);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 25);
            this.label3.TabIndex = 158;
            this.label3.Text = "SUMA";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(13, 406);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(390, 25);
            this.label4.TabIndex = 159;
            this.label4.Text = "Wybierz pracownika, który wyda pojazd";
            // 
            // EmployeeCombo
            // 
            this.EmployeeCombo.FormattingEnabled = true;
            this.EmployeeCombo.Location = new System.Drawing.Point(17, 444);
            this.EmployeeCombo.Name = "EmployeeCombo";
            this.EmployeeCombo.Size = new System.Drawing.Size(200, 21);
            this.EmployeeCombo.TabIndex = 160;
            // 
            // SumTextBox
            // 
            this.SumTextBox.Location = new System.Drawing.Point(18, 514);
            this.SumTextBox.Name = "SumTextBox";
            this.SumTextBox.ReadOnly = true;
            this.SumTextBox.Size = new System.Drawing.Size(120, 20);
            this.SumTextBox.TabIndex = 161;
            // 
            // AddButton
            // 
            this.AddButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.AddButton.Image = ((System.Drawing.Image)(resources.GetObject("AddButton.Image")));
            this.AddButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddButton.Location = new System.Drawing.Point(196, 495);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(185, 54);
            this.AddButton.TabIndex = 162;
            this.AddButton.Text = "Złóż zamówienie";
            this.AddButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(387, 495);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(185, 54);
            this.button2.TabIndex = 163;
            this.button2.Text = "Anuluj";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ClientRentOptionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(584, 561);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.SumTextBox);
            this.Controls.Add(this.EmployeeCombo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LengthNumeric);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.StartDatePicker);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "ClientRentOptionsForm";
            this.Text = "Składanie zamówienia";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LengthNumeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.DateTimePicker StartDatePicker;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton MonthRadio;
        private System.Windows.Forms.RadioButton WeekRadio;
        private System.Windows.Forms.RadioButton DayRadio;
        public System.Windows.Forms.NumericUpDown LengthNumeric;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox EmployeeCombo;
        private System.Windows.Forms.TextBox SumTextBox;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_PAKIET;
        private System.Windows.Forms.DataGridViewTextBoxColumn NAZWA;
        private System.Windows.Forms.DataGridViewTextBoxColumn ZAWARTOSC;
        private System.Windows.Forms.DataGridViewTextBoxColumn CENA;
    }
}