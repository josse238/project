namespace project
{
    partial class adminForm
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
            this.dataGridViewUser = new System.Windows.Forms.DataGridView();
            this.textBoxNama_Lengkap = new System.Windows.Forms.TextBox();
            this.numericUpDown_Id = new System.Windows.Forms.NumericUpDown();
            this.labelId = new System.Windows.Forms.Label();
            this.numericUpDown_No_TLP = new System.Windows.Forms.NumericUpDown();
            this.labelNoTLP = new System.Windows.Forms.Label();
            this.textBox_Email = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.dateTimePickerTglLahir = new System.Windows.Forms.DateTimePicker();
            this.comboBoxJenisKelamin = new System.Windows.Forms.ComboBox();
            this.textBoxAlamat = new System.Windows.Forms.TextBox();
            this.comboBoxRole = new System.Windows.Forms.ComboBox();
            this.buttonTambah = new System.Windows.Forms.Button();
            this.buttonHapus = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Id)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_No_TLP)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewUser
            // 
            this.dataGridViewUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUser.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewUser.Name = "dataGridViewUser";
            this.dataGridViewUser.RowHeadersWidth = 62;
            this.dataGridViewUser.RowTemplate.Height = 28;
            this.dataGridViewUser.Size = new System.Drawing.Size(776, 239);
            this.dataGridViewUser.TabIndex = 0;
            this.dataGridViewUser.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewUser_CellClick);
            this.dataGridViewUser.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewUser_CellContentClick);
            // 
            // textBoxNama_Lengkap
            // 
            this.textBoxNama_Lengkap.Location = new System.Drawing.Point(12, 285);
            this.textBoxNama_Lengkap.Name = "textBoxNama_Lengkap";
            this.textBoxNama_Lengkap.Size = new System.Drawing.Size(288, 26);
            this.textBoxNama_Lengkap.TabIndex = 1;
            this.textBoxNama_Lengkap.Text = "Nama_Lengkap";
            this.textBoxNama_Lengkap.TextChanged += new System.EventHandler(this.textBoxNama_Lengkap_TextChanged);
            // 
            // numericUpDown_Id
            // 
            this.numericUpDown_Id.Enabled = false;
            this.numericUpDown_Id.Location = new System.Drawing.Point(56, 253);
            this.numericUpDown_Id.Name = "numericUpDown_Id";
            this.numericUpDown_Id.Size = new System.Drawing.Size(244, 26);
            this.numericUpDown_Id.TabIndex = 2;
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Location = new System.Drawing.Point(8, 255);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(31, 20);
            this.labelId.TabIndex = 3;
            this.labelId.Text = "Id: ";
            // 
            // numericUpDown_No_TLP
            // 
            this.numericUpDown_No_TLP.Location = new System.Drawing.Point(87, 319);
            this.numericUpDown_No_TLP.Name = "numericUpDown_No_TLP";
            this.numericUpDown_No_TLP.Size = new System.Drawing.Size(213, 26);
            this.numericUpDown_No_TLP.TabIndex = 4;
            this.numericUpDown_No_TLP.ValueChanged += new System.EventHandler(this.numericUpDown_No_TLP_ValueChanged);
            // 
            // labelNoTLP
            // 
            this.labelNoTLP.AutoSize = true;
            this.labelNoTLP.Location = new System.Drawing.Point(12, 319);
            this.labelNoTLP.Name = "labelNoTLP";
            this.labelNoTLP.Size = new System.Drawing.Size(69, 20);
            this.labelNoTLP.TabIndex = 5;
            this.labelNoTLP.Text = "No TLP: ";
            // 
            // textBox_Email
            // 
            this.textBox_Email.Location = new System.Drawing.Point(16, 351);
            this.textBox_Email.Name = "textBox_Email";
            this.textBox_Email.Size = new System.Drawing.Size(288, 26);
            this.textBox_Email.TabIndex = 6;
            this.textBox_Email.Text = "Email";
            this.textBox_Email.TextChanged += new System.EventHandler(this.textBox_Email_TextChanged);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(16, 383);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(288, 26);
            this.textBoxPassword.TabIndex = 7;
            this.textBoxPassword.Text = "Password";
            this.textBoxPassword.TextChanged += new System.EventHandler(this.textBoxPassword_TextChanged);
            // 
            // dateTimePickerTglLahir
            // 
            this.dateTimePickerTglLahir.Location = new System.Drawing.Point(12, 415);
            this.dateTimePickerTglLahir.Name = "dateTimePickerTglLahir";
            this.dateTimePickerTglLahir.Size = new System.Drawing.Size(292, 26);
            this.dateTimePickerTglLahir.TabIndex = 8;
            this.dateTimePickerTglLahir.ValueChanged += new System.EventHandler(this.dateTimePickerTglLahir_ValueChanged);
            // 
            // comboBoxJenisKelamin
            // 
            this.comboBoxJenisKelamin.FormattingEnabled = true;
            this.comboBoxJenisKelamin.Location = new System.Drawing.Point(16, 447);
            this.comboBoxJenisKelamin.Name = "comboBoxJenisKelamin";
            this.comboBoxJenisKelamin.Size = new System.Drawing.Size(292, 28);
            this.comboBoxJenisKelamin.TabIndex = 9;
            this.comboBoxJenisKelamin.Text = "Jenis Kelamin";
            this.comboBoxJenisKelamin.SelectedIndexChanged += new System.EventHandler(this.comboBoxJenisKelamin_SelectedIndexChanged);
            // 
            // textBoxAlamat
            // 
            this.textBoxAlamat.Location = new System.Drawing.Point(16, 481);
            this.textBoxAlamat.Name = "textBoxAlamat";
            this.textBoxAlamat.Size = new System.Drawing.Size(288, 26);
            this.textBoxAlamat.TabIndex = 10;
            this.textBoxAlamat.Text = "Alamat";
            this.textBoxAlamat.TextChanged += new System.EventHandler(this.textBoxAlamat_TextChanged);
            // 
            // comboBoxRole
            // 
            this.comboBoxRole.FormattingEnabled = true;
            this.comboBoxRole.Location = new System.Drawing.Point(16, 513);
            this.comboBoxRole.Name = "comboBoxRole";
            this.comboBoxRole.Size = new System.Drawing.Size(292, 28);
            this.comboBoxRole.TabIndex = 11;
            this.comboBoxRole.Text = "Role";
            this.comboBoxRole.SelectedIndexChanged += new System.EventHandler(this.comboBoxRole_SelectedIndexChanged);
            // 
            // buttonTambah
            // 
            this.buttonTambah.Location = new System.Drawing.Point(322, 255);
            this.buttonTambah.Name = "buttonTambah";
            this.buttonTambah.Size = new System.Drawing.Size(75, 34);
            this.buttonTambah.TabIndex = 12;
            this.buttonTambah.Text = "Tambah";
            this.buttonTambah.UseVisualStyleBackColor = true;
            this.buttonTambah.Click += new System.EventHandler(this.buttonTambah_Click);
            // 
            // buttonHapus
            // 
            this.buttonHapus.Location = new System.Drawing.Point(322, 335);
            this.buttonHapus.Name = "buttonHapus";
            this.buttonHapus.Size = new System.Drawing.Size(75, 34);
            this.buttonHapus.TabIndex = 13;
            this.buttonHapus.Text = "Hapus";
            this.buttonHapus.UseVisualStyleBackColor = true;
            this.buttonHapus.Click += new System.EventHandler(this.buttonHapus_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(322, 375);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 34);
            this.button2.TabIndex = 14;
            this.button2.Text = "Clear";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(322, 295);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 34);
            this.button3.TabIndex = 15;
            this.button3.Text = "Edit";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // adminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 547);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.buttonHapus);
            this.Controls.Add(this.buttonTambah);
            this.Controls.Add(this.comboBoxRole);
            this.Controls.Add(this.textBoxAlamat);
            this.Controls.Add(this.comboBoxJenisKelamin);
            this.Controls.Add(this.dateTimePickerTglLahir);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBox_Email);
            this.Controls.Add(this.labelNoTLP);
            this.Controls.Add(this.numericUpDown_No_TLP);
            this.Controls.Add(this.labelId);
            this.Controls.Add(this.numericUpDown_Id);
            this.Controls.Add(this.textBoxNama_Lengkap);
            this.Controls.Add(this.dataGridViewUser);
            this.Name = "adminForm";
            this.Text = "adminForm";
            this.Load += new System.EventHandler(this.adminForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Id)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_No_TLP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewUser;
        private System.Windows.Forms.TextBox textBoxNama_Lengkap;
        private System.Windows.Forms.NumericUpDown numericUpDown_Id;
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.NumericUpDown numericUpDown_No_TLP;
        private System.Windows.Forms.Label labelNoTLP;
        private System.Windows.Forms.TextBox textBox_Email;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.DateTimePicker dateTimePickerTglLahir;
        private System.Windows.Forms.ComboBox comboBoxJenisKelamin;
        private System.Windows.Forms.TextBox textBoxAlamat;
        private System.Windows.Forms.ComboBox comboBoxRole;
        private System.Windows.Forms.Button buttonTambah;
        private System.Windows.Forms.Button buttonHapus;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}