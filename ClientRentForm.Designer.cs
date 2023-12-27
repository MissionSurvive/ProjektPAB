namespace CarRental
{
    partial class ClientRentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientRentForm));
            this.TableLabel = new System.Windows.Forms.Label();
            this.AddButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.FilterButton = new System.Windows.Forms.Button();
            this.RentalCombo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.FuelCombo = new System.Windows.Forms.ComboBox();
            this.ModelCombo = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.ColorTextBox = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.GearboxTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PowerDownTextBox = new System.Windows.Forms.TextBox();
            this.PowerUpTextBox = new System.Windows.Forms.TextBox();
            this.SeatsTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // TableLabel
            // 
            this.TableLabel.AutoSize = true;
            this.TableLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TableLabel.Location = new System.Drawing.Point(12, 9);
            this.TableLabel.Name = "TableLabel";
            this.TableLabel.Size = new System.Drawing.Size(290, 37);
            this.TableLabel.TabIndex = 3;
            this.TableLabel.Text = "Wybierz samochód";
            // 
            // AddButton
            // 
            this.AddButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.AddButton.Image = ((System.Drawing.Image)(resources.GetObject("AddButton.Image")));
            this.AddButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddButton.Location = new System.Drawing.Point(710, 615);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(164, 54);
            this.AddButton.TabIndex = 59;
            this.AddButton.Text = "Dodaj";
            this.AddButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(19, 49);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1025, 393);
            this.dataGridView1.TabIndex = 60;
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            // 
            // FilterButton
            // 
            this.FilterButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FilterButton.Image = ((System.Drawing.Image)(resources.GetObject("FilterButton.Image")));
            this.FilterButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.FilterButton.Location = new System.Drawing.Point(880, 615);
            this.FilterButton.Name = "FilterButton";
            this.FilterButton.Size = new System.Drawing.Size(164, 54);
            this.FilterButton.TabIndex = 62;
            this.FilterButton.Text = "Filtruj";
            this.FilterButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.FilterButton.UseVisualStyleBackColor = true;
            this.FilterButton.Click += new System.EventHandler(this.FilterButton_Click);
            // 
            // RentalCombo
            // 
            this.RentalCombo.DisplayMember = "MIASTO";
            this.RentalCombo.FormattingEnabled = true;
            this.RentalCombo.Location = new System.Drawing.Point(19, 569);
            this.RentalCombo.Name = "RentalCombo";
            this.RentalCombo.Size = new System.Drawing.Size(163, 21);
            this.RentalCombo.TabIndex = 143;
            this.RentalCombo.ValueMember = "ID_WYPOZYCZALNIA";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(15, 546);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 20);
            this.label3.TabIndex = 142;
            this.label3.Text = "Wypożyczalnia";
            // 
            // FuelCombo
            // 
            this.FuelCombo.DisplayMember = "ID_PALIWO";
            this.FuelCombo.FormattingEnabled = true;
            this.FuelCombo.Location = new System.Drawing.Point(19, 522);
            this.FuelCombo.Name = "FuelCombo";
            this.FuelCombo.Size = new System.Drawing.Size(163, 21);
            this.FuelCombo.TabIndex = 141;
            this.FuelCombo.ValueMember = "ID_PALIWO";
            // 
            // ModelCombo
            // 
            this.ModelCombo.DisplayMember = "ID_MODEL";
            this.ModelCombo.FormattingEnabled = true;
            this.ModelCombo.Location = new System.Drawing.Point(19, 475);
            this.ModelCombo.Name = "ModelCombo";
            this.ModelCombo.Size = new System.Drawing.Size(163, 21);
            this.ModelCombo.TabIndex = 140;
            this.ModelCombo.ValueMember = "ID_MODEL";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(15, 451);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 20);
            this.label4.TabIndex = 139;
            this.label4.Text = "Model";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(15, 499);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 20);
            this.label2.TabIndex = 138;
            this.label2.Text = "Paliwo";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label11.Location = new System.Drawing.Point(184, 545);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(45, 20);
            this.label11.TabIndex = 176;
            this.label11.Text = "Kolor";
            // 
            // ColorTextBox
            // 
            this.ColorTextBox.Location = new System.Drawing.Point(188, 569);
            this.ColorTextBox.Name = "ColorTextBox";
            this.ColorTextBox.Size = new System.Drawing.Size(164, 20);
            this.ColorTextBox.TabIndex = 174;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label14.Location = new System.Drawing.Point(357, 501);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(90, 20);
            this.label14.TabIndex = 181;
            this.label14.Text = "Ilość miejsc";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label13.Location = new System.Drawing.Point(357, 453);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(123, 20);
            this.label13.TabIndex = 180;
            this.label13.Text = "Skrzynia biegów";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label12.Location = new System.Drawing.Point(184, 453);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(61, 20);
            this.label12.TabIndex = 179;
            this.label12.Text = "Moc od";
            // 
            // GearboxTextBox
            // 
            this.GearboxTextBox.Location = new System.Drawing.Point(361, 478);
            this.GearboxTextBox.Name = "GearboxTextBox";
            this.GearboxTextBox.Size = new System.Drawing.Size(164, 20);
            this.GearboxTextBox.TabIndex = 178;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(184, 499);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 20);
            this.label1.TabIndex = 184;
            this.label1.Text = "Moc do";
            // 
            // PowerDownTextBox
            // 
            this.PowerDownTextBox.Location = new System.Drawing.Point(187, 475);
            this.PowerDownTextBox.Name = "PowerDownTextBox";
            this.PowerDownTextBox.Size = new System.Drawing.Size(164, 20);
            this.PowerDownTextBox.TabIndex = 185;
            // 
            // PowerUpTextBox
            // 
            this.PowerUpTextBox.Location = new System.Drawing.Point(188, 522);
            this.PowerUpTextBox.Name = "PowerUpTextBox";
            this.PowerUpTextBox.Size = new System.Drawing.Size(164, 20);
            this.PowerUpTextBox.TabIndex = 186;
            // 
            // SeatsTextBox
            // 
            this.SeatsTextBox.Location = new System.Drawing.Point(361, 522);
            this.SeatsTextBox.Name = "SeatsTextBox";
            this.SeatsTextBox.Size = new System.Drawing.Size(164, 20);
            this.SeatsTextBox.TabIndex = 187;
            // 
            // ClientRentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1056, 681);
            this.Controls.Add(this.SeatsTextBox);
            this.Controls.Add(this.PowerUpTextBox);
            this.Controls.Add(this.PowerDownTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.GearboxTextBox);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.ColorTextBox);
            this.Controls.Add(this.RentalCombo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.FuelCombo);
            this.Controls.Add(this.ModelCombo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.FilterButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.TableLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ClientRentForm";
            this.Text = "ClientRentForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TableLabel;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button FilterButton;
        public System.Windows.Forms.ComboBox RentalCombo;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.ComboBox FuelCombo;
        public System.Windows.Forms.ComboBox ModelCombo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label11;
        public System.Windows.Forms.TextBox ColorTextBox;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        public System.Windows.Forms.TextBox GearboxTextBox;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox PowerDownTextBox;
        public System.Windows.Forms.TextBox PowerUpTextBox;
        public System.Windows.Forms.TextBox SeatsTextBox;
    }
}