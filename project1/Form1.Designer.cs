namespace project1
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.Update = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.Insert = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textUsername = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textEmail = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textPassword = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.rbFemale = new System.Windows.Forms.RadioButton();
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.textContact = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textAddress = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textAge = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Controls.Add(this.Update);
            this.panel1.Controls.Add(this.Delete);
            this.panel1.Controls.Add(this.Insert);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.textUsername);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.textEmail);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.textPassword);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.rbFemale);
            this.panel1.Controls.Add(this.rbMale);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.textContact);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.textAddress);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.textAge);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.textName);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1306, 732);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Update
            // 
            this.Update.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Update.Location = new System.Drawing.Point(582, 462);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(143, 50);
            this.Update.TabIndex = 28;
            this.Update.Text = "Update";
            this.Update.UseVisualStyleBackColor = true;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // Delete
            // 
            this.Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete.Location = new System.Drawing.Point(935, 462);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(143, 50);
            this.Delete.TabIndex = 27;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.button2_Click);
            // 
            // Insert
            // 
            this.Insert.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Insert.Location = new System.Drawing.Point(202, 462);
            this.Insert.Name = "Insert";
            this.Insert.Size = new System.Drawing.Size(143, 50);
            this.Insert.TabIndex = 26;
            this.Insert.Text = "Insert";
            this.Insert.UseVisualStyleBackColor = true;
            this.Insert.Click += new System.EventHandler(this.Insert_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 527);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1306, 205);
            this.dataGridView1.TabIndex = 25;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // textUsername
            // 
            this.textUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textUsername.Location = new System.Drawing.Point(840, 397);
            this.textUsername.Name = "textUsername";
            this.textUsername.Size = new System.Drawing.Size(269, 30);
            this.textUsername.TabIndex = 24;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(695, 397);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(117, 25);
            this.label9.TabIndex = 23;
            this.label9.Text = "Username:";
            // 
            // textEmail
            // 
            this.textEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEmail.Location = new System.Drawing.Point(840, 323);
            this.textEmail.Name = "textEmail";
            this.textEmail.Size = new System.Drawing.Size(269, 30);
            this.textEmail.TabIndex = 22;
            this.textEmail.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(695, 323);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 25);
            this.label8.TabIndex = 21;
            this.label8.Text = "Email:";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // textPassword
            // 
            this.textPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textPassword.Location = new System.Drawing.Point(202, 397);
            this.textPassword.Name = "textPassword";
            this.textPassword.PasswordChar = '*';
            this.textPassword.Size = new System.Drawing.Size(269, 30);
            this.textPassword.TabIndex = 14;
            this.textPassword.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(61, 402);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 25);
            this.label7.TabIndex = 13;
            this.label7.Text = "Password:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // rbFemale
            // 
            this.rbFemale.AutoSize = true;
            this.rbFemale.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbFemale.Location = new System.Drawing.Point(345, 323);
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.Size = new System.Drawing.Size(104, 29);
            this.rbFemale.TabIndex = 12;
            this.rbFemale.TabStop = true;
            this.rbFemale.Text = "Female";
            this.rbFemale.UseVisualStyleBackColor = true;
            // 
            // rbMale
            // 
            this.rbMale.AutoSize = true;
            this.rbMale.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMale.Location = new System.Drawing.Point(202, 323);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(80, 29);
            this.rbMale.TabIndex = 11;
            this.rbMale.TabStop = true;
            this.rbMale.Text = "Male";
            this.rbMale.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(78, 323);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 25);
            this.label6.TabIndex = 10;
            this.label6.Text = "Gender :";
            // 
            // textContact
            // 
            this.textContact.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textContact.Location = new System.Drawing.Point(840, 254);
            this.textContact.Name = "textContact";
            this.textContact.Size = new System.Drawing.Size(269, 30);
            this.textContact.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(695, 254);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "Contact :";
            // 
            // textAddress
            // 
            this.textAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textAddress.Location = new System.Drawing.Point(202, 249);
            this.textAddress.Name = "textAddress";
            this.textAddress.Size = new System.Drawing.Size(269, 30);
            this.textAddress.TabIndex = 7;
            this.textAddress.TextChanged += new System.EventHandler(this.textAddress_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(69, 252);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Address :";
            // 
            // textAge
            // 
            this.textAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textAge.Location = new System.Drawing.Point(840, 180);
            this.textAge.Name = "textAge";
            this.textAge.Size = new System.Drawing.Size(269, 30);
            this.textAge.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(731, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Age :";
            // 
            // textName
            // 
            this.textName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textName.Location = new System.Drawing.Point(202, 175);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(269, 30);
            this.textName.TabIndex = 3;
            this.textName.TextChanged += new System.EventHandler(this.textName_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(93, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 98);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1306, 10);
            this.panel3.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1306, 98);
            this.panel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(563, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(283, 52);
            this.label1.TabIndex = 0;
            this.label1.Text = "Signup Form";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1306, 732);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.TextBox textContact;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textAddress;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textAge;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rbFemale;
        private System.Windows.Forms.RadioButton rbMale;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textPassword;
        private System.Windows.Forms.TextBox textEmail;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textUsername;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button Insert;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Update;
        private System.Windows.Forms.Button Delete;
    }
}

