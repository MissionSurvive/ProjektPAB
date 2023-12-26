namespace CarRental
{
    partial class CarForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CarForm));
            this.carPanel = new System.Windows.Forms.Panel();
            this.carNavBar = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button8 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.sAMOCHODYBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.carNavBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sAMOCHODYBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // carPanel
            // 
            this.carPanel.BackColor = System.Drawing.Color.Silver;
            this.carPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.carPanel.Location = new System.Drawing.Point(163, 0);
            this.carPanel.Name = "carPanel";
            this.carPanel.Size = new System.Drawing.Size(937, 681);
            this.carPanel.TabIndex = 1;
            // 
            // carNavBar
            // 
            this.carNavBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.carNavBar.Controls.Add(this.label1);
            this.carNavBar.Controls.Add(this.button8);
            this.carNavBar.Controls.Add(this.button3);
            this.carNavBar.Controls.Add(this.button2);
            this.carNavBar.Controls.Add(this.button1);
            this.carNavBar.Controls.Add(this.button6);
            this.carNavBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.carNavBar.Location = new System.Drawing.Point(0, 0);
            this.carNavBar.Name = "carNavBar";
            this.carNavBar.Size = new System.Drawing.Size(164, 681);
            this.carNavBar.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(21, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 25);
            this.label1.TabIndex = 12;
            this.label1.Text = "Samochody";
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button8.Image = ((System.Drawing.Image)(resources.GetObject("button8.Image")));
            this.button8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button8.Location = new System.Drawing.Point(0, 106);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(164, 54);
            this.button8.TabIndex = 9;
            this.button8.Text = "Samochody";
            this.button8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(0, 346);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(164, 54);
            this.button3.TabIndex = 11;
            this.button3.Text = "Paliwo";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(0, 286);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(164, 54);
            this.button2.TabIndex = 10;
            this.button2.Text = "Nadwozia";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(0, 226);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(164, 54);
            this.button1.TabIndex = 9;
            this.button1.Text = "Modele";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button6.Image = ((System.Drawing.Image)(resources.GetObject("button6.Image")));
            this.button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.Location = new System.Drawing.Point(0, 166);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(164, 54);
            this.button6.TabIndex = 8;
            this.button6.Text = "Marki";
            this.button6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // sAMOCHODYBindingSource
            // 
            this.sAMOCHODYBindingSource.DataMember = "SAMOCHODY";
            // 
            // carRentalCWDataSet
            // 
            // 
            // sAMOCHODYTableAdapter
            // 
            // 
            // CarForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1100, 681);
            this.Controls.Add(this.carNavBar);
            this.Controls.Add(this.carPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CarForm";
            this.Text = "CarForm";
            this.carNavBar.ResumeLayout(false);
            this.carNavBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sAMOCHODYBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource sAMOCHODYBindingSource;
        private System.Windows.Forms.Panel carPanel;
        private System.Windows.Forms.Panel carNavBar;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Label label1;
    }
}