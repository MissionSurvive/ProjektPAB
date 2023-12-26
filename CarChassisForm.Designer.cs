namespace CarRental
{
    partial class CarChassisForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CarChassisForm));
            this.ChassisLabel = new System.Windows.Forms.Label();
            this.ChassisTextBox = new System.Windows.Forms.TextBox();
            this.FilterButton = new System.Windows.Forms.Button();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.TableLabel = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.allDataSet = new CarRental.AllDataSet();
            this.rODZAJENADWOZIABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rODZAJE_NADWOZIATableAdapter = new CarRental.AllDataSetTableAdapters.RODZAJE_NADWOZIATableAdapter();
            this.iDNADWOZIEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nAZWANADWOZIEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.allDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rODZAJENADWOZIABindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ChassisLabel
            // 
            this.ChassisLabel.AutoSize = true;
            this.ChassisLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ChassisLabel.Location = new System.Drawing.Point(15, 557);
            this.ChassisLabel.Name = "ChassisLabel";
            this.ChassisLabel.Size = new System.Drawing.Size(128, 20);
            this.ChassisLabel.TabIndex = 97;
            this.ChassisLabel.Text = "Nazwa nadwozia";
            // 
            // ChassisTextBox
            // 
            this.ChassisTextBox.Location = new System.Drawing.Point(19, 581);
            this.ChassisTextBox.Name = "ChassisTextBox";
            this.ChassisTextBox.Size = new System.Drawing.Size(164, 20);
            this.ChassisTextBox.TabIndex = 96;
            // 
            // FilterButton
            // 
            this.FilterButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FilterButton.Image = ((System.Drawing.Image)(resources.GetObject("FilterButton.Image")));
            this.FilterButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.FilterButton.Location = new System.Drawing.Point(761, 616);
            this.FilterButton.Name = "FilterButton";
            this.FilterButton.Size = new System.Drawing.Size(164, 54);
            this.FilterButton.TabIndex = 85;
            this.FilterButton.Text = "Filtruj";
            this.FilterButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.FilterButton.UseVisualStyleBackColor = true;
            // 
            // UpdateButton
            // 
            this.UpdateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.UpdateButton.Image = ((System.Drawing.Image)(resources.GetObject("UpdateButton.Image")));
            this.UpdateButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.UpdateButton.Location = new System.Drawing.Point(421, 616);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(164, 54);
            this.UpdateButton.TabIndex = 84;
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
            this.DeleteButton.Location = new System.Drawing.Point(591, 616);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(164, 54);
            this.DeleteButton.TabIndex = 83;
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
            this.AddButton.Location = new System.Drawing.Point(251, 616);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(164, 54);
            this.AddButton.TabIndex = 82;
            this.AddButton.Text = "Dodaj";
            this.AddButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // TableLabel
            // 
            this.TableLabel.AutoSize = true;
            this.TableLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TableLabel.Location = new System.Drawing.Point(12, 10);
            this.TableLabel.Name = "TableLabel";
            this.TableLabel.Size = new System.Drawing.Size(159, 37);
            this.TableLabel.TabIndex = 80;
            this.TableLabel.Text = "Nadwozia";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDNADWOZIEDataGridViewTextBoxColumn,
            this.nAZWANADWOZIEDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.rODZAJENADWOZIABindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(19, 51);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(906, 503);
            this.dataGridView1.TabIndex = 98;
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            // 
            // allDataSet
            // 
            this.allDataSet.DataSetName = "AllDataSet";
            this.allDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // iDNADWOZIEDataGridViewTextBoxColumn
            // 
            this.iDNADWOZIEDataGridViewTextBoxColumn.DataPropertyName = "ID_NADWOZIE";
            this.iDNADWOZIEDataGridViewTextBoxColumn.HeaderText = "ID_NADWOZIE";
            this.iDNADWOZIEDataGridViewTextBoxColumn.Name = "iDNADWOZIEDataGridViewTextBoxColumn";
            this.iDNADWOZIEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nAZWANADWOZIEDataGridViewTextBoxColumn
            // 
            this.nAZWANADWOZIEDataGridViewTextBoxColumn.DataPropertyName = "NAZWA_NADWOZIE";
            this.nAZWANADWOZIEDataGridViewTextBoxColumn.HeaderText = "NAZWA_NADWOZIE";
            this.nAZWANADWOZIEDataGridViewTextBoxColumn.Name = "nAZWANADWOZIEDataGridViewTextBoxColumn";
            // 
            // CarChassisForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(937, 681);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.ChassisLabel);
            this.Controls.Add(this.ChassisTextBox);
            this.Controls.Add(this.FilterButton);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.TableLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CarChassisForm";
            this.Text = "CarChassisForm";
            this.Load += new System.EventHandler(this.CarChassisForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.allDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rODZAJENADWOZIABindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ChassisLabel;
        private System.Windows.Forms.TextBox ChassisTextBox;
        private System.Windows.Forms.Button FilterButton;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Label TableLabel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private AllDataSet allDataSet;
        private System.Windows.Forms.BindingSource rODZAJENADWOZIABindingSource;
        private AllDataSetTableAdapters.RODZAJE_NADWOZIATableAdapter rODZAJE_NADWOZIATableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDNADWOZIEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nAZWANADWOZIEDataGridViewTextBoxColumn;
    }
}