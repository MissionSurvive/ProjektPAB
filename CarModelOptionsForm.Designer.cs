namespace CarRental
{
    partial class CarModelOptionsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CarModelOptionsForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.YearTextBox = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.SegmentTextBox = new System.Windows.Forms.TextBox();
            this.GenerationTextBox = new System.Windows.Forms.TextBox();
            this.ModelTextBox = new System.Windows.Forms.TextBox();
            this.ChassisCombo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BrandCombo = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.allDataSet = new CarRental.AllDataSet();
            this.mARKIBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mARKITableAdapter = new CarRental.AllDataSetTableAdapters.MARKITableAdapter();
            this.rODZAJENADWOZIABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rODZAJE_NADWOZIATableAdapter = new CarRental.AllDataSetTableAdapters.RODZAJE_NADWOZIATableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.allDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mARKIBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rODZAJENADWOZIABindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 25);
            this.label1.TabIndex = 14;
            this.label1.Text = "Dane ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(15, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 20);
            this.label2.TabIndex = 91;
            this.label2.Text = "Rocznik";
            // 
            // YearTextBox
            // 
            this.YearTextBox.Location = new System.Drawing.Point(19, 209);
            this.YearTextBox.Name = "YearTextBox";
            this.YearTextBox.Size = new System.Drawing.Size(164, 20);
            this.YearTextBox.TabIndex = 90;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label17.Location = new System.Drawing.Point(13, 279);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(74, 20);
            this.label17.TabIndex = 89;
            this.label17.Text = "Segment";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label16.Location = new System.Drawing.Point(12, 231);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(83, 20);
            this.label16.TabIndex = 88;
            this.label16.Text = "Generacja";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label15.Location = new System.Drawing.Point(13, 138);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(113, 20);
            this.label15.TabIndex = 87;
            this.label15.Text = "Nazwa modelu";
            // 
            // SegmentTextBox
            // 
            this.SegmentTextBox.Location = new System.Drawing.Point(16, 302);
            this.SegmentTextBox.Name = "SegmentTextBox";
            this.SegmentTextBox.Size = new System.Drawing.Size(164, 20);
            this.SegmentTextBox.TabIndex = 86;
            // 
            // GenerationTextBox
            // 
            this.GenerationTextBox.Location = new System.Drawing.Point(16, 256);
            this.GenerationTextBox.Name = "GenerationTextBox";
            this.GenerationTextBox.Size = new System.Drawing.Size(164, 20);
            this.GenerationTextBox.TabIndex = 85;
            // 
            // ModelTextBox
            // 
            this.ModelTextBox.Location = new System.Drawing.Point(17, 162);
            this.ModelTextBox.Name = "ModelTextBox";
            this.ModelTextBox.Size = new System.Drawing.Size(415, 20);
            this.ModelTextBox.TabIndex = 84;
            // 
            // ChassisCombo
            // 
            this.ChassisCombo.DataSource = this.rODZAJENADWOZIABindingSource;
            this.ChassisCombo.DisplayMember = "NAZWA_NADWOZIE";
            this.ChassisCombo.FormattingEnabled = true;
            this.ChassisCombo.Location = new System.Drawing.Point(17, 115);
            this.ChassisCombo.Name = "ChassisCombo";
            this.ChassisCombo.Size = new System.Drawing.Size(163, 21);
            this.ChassisCombo.TabIndex = 83;
            this.ChassisCombo.ValueMember = "ID_NADWOZIE";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(13, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 20);
            this.label3.TabIndex = 82;
            this.label3.Text = "Nadwozie";
            // 
            // BrandCombo
            // 
            this.BrandCombo.DataSource = this.mARKIBindingSource;
            this.BrandCombo.DisplayMember = "NAZWA_MARKA";
            this.BrandCombo.FormattingEnabled = true;
            this.BrandCombo.Location = new System.Drawing.Point(17, 68);
            this.BrandCombo.Name = "BrandCombo";
            this.BrandCombo.Size = new System.Drawing.Size(163, 21);
            this.BrandCombo.TabIndex = 81;
            this.BrandCombo.ValueMember = "ID_MARKA";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(13, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 20);
            this.label4.TabIndex = 80;
            this.label4.Text = "Marka";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(608, 495);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(164, 54);
            this.button2.TabIndex = 131;
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
            this.UpdateButton.TabIndex = 130;
            this.UpdateButton.Text = "Modyfikuj";
            this.UpdateButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.AddButton.Image = ((System.Drawing.Image)(resources.GetObject("AddButton.Image")));
            this.AddButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddButton.Location = new System.Drawing.Point(268, 495);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(164, 54);
            this.AddButton.TabIndex = 129;
            this.AddButton.Text = "Dodaj";
            this.AddButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // allDataSet
            // 
            this.allDataSet.DataSetName = "AllDataSet";
            this.allDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mARKIBindingSource
            // 
            this.mARKIBindingSource.DataMember = "MARKI";
            this.mARKIBindingSource.DataSource = this.allDataSet;
            // 
            // mARKITableAdapter
            // 
            this.mARKITableAdapter.ClearBeforeFill = true;
            // 
            // rODZAJENADWOZIABindingSource
            // 
            this.rODZAJENADWOZIABindingSource.DataMember = "RODZAJE_NADWOZIA";
            this.rODZAJENADWOZIABindingSource.DataSource = this.allDataSet;
            // 
            // rODZAJE_NADWOZIATableAdapter
            // 
            this.rODZAJE_NADWOZIATableAdapter.ClearBeforeFill = true;
            // 
            // CarModelOptionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.YearTextBox);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.SegmentTextBox);
            this.Controls.Add(this.GenerationTextBox);
            this.Controls.Add(this.ModelTextBox);
            this.Controls.Add(this.ChassisCombo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BrandCombo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Name = "CarModelOptionsForm";
            this.Text = "Zarządzanie modelami";
            this.Load += new System.EventHandler(this.CarModelOptionsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.allDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mARKIBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rODZAJENADWOZIABindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.Button AddButton;
        public System.Windows.Forms.TextBox YearTextBox;
        public System.Windows.Forms.TextBox SegmentTextBox;
        public System.Windows.Forms.TextBox GenerationTextBox;
        public System.Windows.Forms.TextBox ModelTextBox;
        public System.Windows.Forms.ComboBox ChassisCombo;
        public System.Windows.Forms.ComboBox BrandCombo;
        private AllDataSet allDataSet;
        private System.Windows.Forms.BindingSource mARKIBindingSource;
        private AllDataSetTableAdapters.MARKITableAdapter mARKITableAdapter;
        private System.Windows.Forms.BindingSource rODZAJENADWOZIABindingSource;
        private AllDataSetTableAdapters.RODZAJE_NADWOZIATableAdapter rODZAJE_NADWOZIATableAdapter;
    }
}