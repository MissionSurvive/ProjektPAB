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
            this.FilterCheck = new System.Windows.Forms.CheckBox();
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
            this.AddButton.Text = "Wybierz";
            this.AddButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(19, 49);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
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
            // FilterCheck
            // 
            this.FilterCheck.AutoSize = true;
            this.FilterCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FilterCheck.Location = new System.Drawing.Point(880, 585);
            this.FilterCheck.Name = "FilterCheck";
            this.FilterCheck.Size = new System.Drawing.Size(126, 24);
            this.FilterCheck.TabIndex = 188;
            this.FilterCheck.Text = "Włącz filtrację";
            this.FilterCheck.UseVisualStyleBackColor = true;
            this.FilterCheck.CheckedChanged += new System.EventHandler(this.FilterCheck_CheckedChanged);
            // 
            // ClientRentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1056, 681);
            this.Controls.Add(this.FilterCheck);
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
        private System.Windows.Forms.CheckBox FilterCheck;
    }
}