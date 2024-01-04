namespace CarRental
{
    partial class LoginForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ClientRadio = new System.Windows.Forms.RadioButton();
            this.EmployeeRadio = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(179, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Panel logowania";
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Location = new System.Drawing.Point(189, 136);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(245, 20);
            this.usernameTextBox.TabIndex = 1;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(189, 192);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '*';
            this.passwordTextBox.Size = new System.Drawing.Size(245, 20);
            this.passwordTextBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(189, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nazwa użytkownika";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(192, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Hasło";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ClientRadio);
            this.groupBox1.Controls.Add(this.EmployeeRadio);
            this.groupBox1.Location = new System.Drawing.Point(186, 231);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(245, 71);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Zaloguj jako:";
            // 
            // ClientRadio
            // 
            this.ClientRadio.AutoSize = true;
            this.ClientRadio.Location = new System.Drawing.Point(161, 29);
            this.ClientRadio.Name = "ClientRadio";
            this.ClientRadio.Size = new System.Drawing.Size(51, 17);
            this.ClientRadio.TabIndex = 1;
            this.ClientRadio.Text = "Klient";
            this.ClientRadio.UseVisualStyleBackColor = true;
            // 
            // EmployeeRadio
            // 
            this.EmployeeRadio.AutoSize = true;
            this.EmployeeRadio.Checked = true;
            this.EmployeeRadio.Location = new System.Drawing.Point(27, 29);
            this.EmployeeRadio.Name = "EmployeeRadio";
            this.EmployeeRadio.Size = new System.Drawing.Size(75, 17);
            this.EmployeeRadio.TabIndex = 0;
            this.EmployeeRadio.TabStop = true;
            this.EmployeeRadio.Text = "Pracownik";
            this.EmployeeRadio.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(189, 317);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 57);
            this.button1.TabIndex = 6;
            this.button1.Text = "Zaloguj";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(321, 317);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(110, 57);
            this.button2.TabIndex = 7;
            this.button2.Text = "Zarejestruj";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.usernameTextBox);
            this.Controls.Add(this.label1);
            this.Name = "LoginForm";
            this.Text = "Logowanie do aplikacji";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton ClientRadio;
        private System.Windows.Forms.RadioButton EmployeeRadio;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}