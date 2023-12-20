namespace CarRental
{
    partial class ReportForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportForm));
            this.TableLabel = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.StartDatePicker = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.EmployeeCombo = new System.Windows.Forms.ComboBox();
            this.ReportRadio1 = new System.Windows.Forms.RadioButton();
            this.ReportRadio2 = new System.Windows.Forms.RadioButton();
            this.ReportRadio3 = new System.Windows.Forms.RadioButton();
            this.ReportRadio4 = new System.Windows.Forms.RadioButton();
            this.RadioGroup = new System.Windows.Forms.GroupBox();
            this.FilterButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.EndDatePicker = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.SumTextBox = new System.Windows.Forms.TextBox();
            this.allDataSet = new CarRental.AllDataSet();
            this.pRACOWNICYBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pRACOWNICYTableAdapter = new CarRental.AllDataSetTableAdapters.PRACOWNICYTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.RadioGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.allDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRACOWNICYBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // TableLabel
            // 
            this.TableLabel.AutoSize = true;
            this.TableLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TableLabel.Location = new System.Drawing.Point(12, 9);
            this.TableLabel.Name = "TableLabel";
            this.TableLabel.Size = new System.Drawing.Size(128, 37);
            this.TableLabel.TabIndex = 102;
            this.TableLabel.Text = "Raporty";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(19, 66);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1061, 277);
            this.dataGridView1.TabIndex = 103;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(14, 355);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 25);
            this.label1.TabIndex = 104;
            this.label1.Text = "Raport dzienny";
            // 
            // StartDatePicker
            // 
            this.StartDatePicker.Location = new System.Drawing.Point(19, 417);
            this.StartDatePicker.Name = "StartDatePicker";
            this.StartDatePicker.Size = new System.Drawing.Size(200, 20);
            this.StartDatePicker.TabIndex = 119;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(17, 393);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 20);
            this.label8.TabIndex = 118;
            this.label8.Text = "Dzień";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label12.Location = new System.Drawing.Point(17, 486);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(81, 20);
            this.label12.TabIndex = 138;
            this.label12.Text = "Pracownik";
            // 
            // EmployeeCombo
            // 
            this.EmployeeCombo.DataSource = this.pRACOWNICYBindingSource;
            this.EmployeeCombo.DisplayMember = "NAZWISKO_PRACOWNIK";
            this.EmployeeCombo.FormattingEnabled = true;
            this.EmployeeCombo.Location = new System.Drawing.Point(21, 509);
            this.EmployeeCombo.Name = "EmployeeCombo";
            this.EmployeeCombo.Size = new System.Drawing.Size(200, 21);
            this.EmployeeCombo.TabIndex = 137;
            this.EmployeeCombo.ValueMember = "ID_PRAC";
            // 
            // ReportRadio1
            // 
            this.ReportRadio1.AutoSize = true;
            this.ReportRadio1.Location = new System.Drawing.Point(6, 25);
            this.ReportRadio1.Name = "ReportRadio1";
            this.ReportRadio1.Size = new System.Drawing.Size(134, 24);
            this.ReportRadio1.TabIndex = 139;
            this.ReportRadio1.TabStop = true;
            this.ReportRadio1.Text = "Raport dzienny";
            this.ReportRadio1.UseVisualStyleBackColor = true;
            // 
            // ReportRadio2
            // 
            this.ReportRadio2.AutoSize = true;
            this.ReportRadio2.Location = new System.Drawing.Point(6, 55);
            this.ReportRadio2.Name = "ReportRadio2";
            this.ReportRadio2.Size = new System.Drawing.Size(121, 24);
            this.ReportRadio2.TabIndex = 140;
            this.ReportRadio2.TabStop = true;
            this.ReportRadio2.Text = "Raport od-do";
            this.ReportRadio2.UseVisualStyleBackColor = true;
            // 
            // ReportRadio3
            // 
            this.ReportRadio3.AutoSize = true;
            this.ReportRadio3.Location = new System.Drawing.Point(6, 85);
            this.ReportRadio3.Name = "ReportRadio3";
            this.ReportRadio3.Size = new System.Drawing.Size(160, 24);
            this.ReportRadio3.TabIndex = 141;
            this.ReportRadio3.TabStop = true;
            this.ReportRadio3.Text = "Raport pracownika";
            this.ReportRadio3.UseVisualStyleBackColor = true;
            // 
            // ReportRadio4
            // 
            this.ReportRadio4.AutoSize = true;
            this.ReportRadio4.Location = new System.Drawing.Point(6, 115);
            this.ReportRadio4.Name = "ReportRadio4";
            this.ReportRadio4.Size = new System.Drawing.Size(112, 24);
            this.ReportRadio4.TabIndex = 142;
            this.ReportRadio4.TabStop = true;
            this.ReportRadio4.Text = "Raport strat";
            this.ReportRadio4.UseVisualStyleBackColor = true;
            // 
            // RadioGroup
            // 
            this.RadioGroup.Controls.Add(this.ReportRadio1);
            this.RadioGroup.Controls.Add(this.ReportRadio4);
            this.RadioGroup.Controls.Add(this.ReportRadio2);
            this.RadioGroup.Controls.Add(this.ReportRadio3);
            this.RadioGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.RadioGroup.Location = new System.Drawing.Point(227, 393);
            this.RadioGroup.Name = "RadioGroup";
            this.RadioGroup.Size = new System.Drawing.Size(200, 144);
            this.RadioGroup.TabIndex = 143;
            this.RadioGroup.TabStop = false;
            this.RadioGroup.Text = "Wybór raportu";
            // 
            // FilterButton
            // 
            this.FilterButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FilterButton.Image = ((System.Drawing.Image)(resources.GetObject("FilterButton.Image")));
            this.FilterButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.FilterButton.Location = new System.Drawing.Point(752, 615);
            this.FilterButton.Name = "FilterButton";
            this.FilterButton.Size = new System.Drawing.Size(164, 54);
            this.FilterButton.TabIndex = 144;
            this.FilterButton.Text = "Generuj";
            this.FilterButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.FilterButton.UseVisualStyleBackColor = true;
            this.FilterButton.Click += new System.EventHandler(this.FilterButton_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(922, 615);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(164, 54);
            this.button1.TabIndex = 145;
            this.button1.Text = "Eksportuj";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // EndDatePicker
            // 
            this.EndDatePicker.Location = new System.Drawing.Point(21, 463);
            this.EndDatePicker.Name = "EndDatePicker";
            this.EndDatePicker.Size = new System.Drawing.Size(200, 20);
            this.EndDatePicker.TabIndex = 150;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.Location = new System.Drawing.Point(17, 439);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(30, 20);
            this.label9.TabIndex = 149;
            this.label9.Text = "Do";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label13.Location = new System.Drawing.Point(912, 350);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(56, 20);
            this.label13.TabIndex = 151;
            this.label13.Text = "SUMA";
            // 
            // SumTextBox
            // 
            this.SumTextBox.Location = new System.Drawing.Point(916, 374);
            this.SumTextBox.Name = "SumTextBox";
            this.SumTextBox.ReadOnly = true;
            this.SumTextBox.Size = new System.Drawing.Size(164, 20);
            this.SumTextBox.TabIndex = 152;
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
            // ReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1100, 681);
            this.Controls.Add(this.SumTextBox);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.EndDatePicker);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.FilterButton);
            this.Controls.Add(this.RadioGroup);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.EmployeeCombo);
            this.Controls.Add(this.StartDatePicker);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.TableLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ReportForm";
            this.Text = "ReportForm";
            this.Load += new System.EventHandler(this.ReportForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.RadioGroup.ResumeLayout(false);
            this.RadioGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.allDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRACOWNICYBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TableLabel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.DateTimePicker StartDatePicker;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox EmployeeCombo;
        private System.Windows.Forms.RadioButton ReportRadio1;
        private System.Windows.Forms.RadioButton ReportRadio2;
        private System.Windows.Forms.RadioButton ReportRadio3;
        private System.Windows.Forms.RadioButton ReportRadio4;
        private System.Windows.Forms.GroupBox RadioGroup;
        private System.Windows.Forms.Button FilterButton;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.DateTimePicker EndDatePicker;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox SumTextBox;
        private AllDataSet allDataSet;
        private System.Windows.Forms.BindingSource pRACOWNICYBindingSource;
        private AllDataSetTableAdapters.PRACOWNICYTableAdapter pRACOWNICYTableAdapter;
    }
}