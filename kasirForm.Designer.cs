namespace project
{
    partial class kasirForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.kasirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkoutUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBoxKasir = new System.Windows.Forms.GroupBox();
            this.comboBoxTaq = new System.Windows.Forms.ComboBox();
            this.textBox_Search = new System.Windows.Forms.TextBox();
            this.buttonCheckout = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.button_Hapus = new System.Windows.Forms.Button();
            this.button_Update = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonTambah = new System.Windows.Forms.Button();
            this.label = new System.Windows.Forms.Label();
            this.numericUpDown_Jumlah_Produk = new System.Windows.Forms.NumericUpDown();
            this.dataGridViewKasir = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            this.groupBoxKasir.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Jumlah_Produk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKasir)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kasirToolStripMenuItem,
            this.checkoutUserToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1613, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // kasirToolStripMenuItem
            // 
            this.kasirToolStripMenuItem.Name = "kasirToolStripMenuItem";
            this.kasirToolStripMenuItem.Size = new System.Drawing.Size(65, 29);
            this.kasirToolStripMenuItem.Text = "Kasir";
            // 
            // checkoutUserToolStripMenuItem
            // 
            this.checkoutUserToolStripMenuItem.Name = "checkoutUserToolStripMenuItem";
            this.checkoutUserToolStripMenuItem.Size = new System.Drawing.Size(142, 29);
            this.checkoutUserToolStripMenuItem.Text = "Checkout User";
            // 
            // groupBoxKasir
            // 
            this.groupBoxKasir.Controls.Add(this.comboBoxTaq);
            this.groupBoxKasir.Controls.Add(this.textBox_Search);
            this.groupBoxKasir.Controls.Add(this.buttonCheckout);
            this.groupBoxKasir.Controls.Add(this.label1);
            this.groupBoxKasir.Controls.Add(this.numericUpDown1);
            this.groupBoxKasir.Controls.Add(this.button_Hapus);
            this.groupBoxKasir.Controls.Add(this.button_Update);
            this.groupBoxKasir.Controls.Add(this.dataGridView1);
            this.groupBoxKasir.Controls.Add(this.buttonTambah);
            this.groupBoxKasir.Controls.Add(this.label);
            this.groupBoxKasir.Controls.Add(this.numericUpDown_Jumlah_Produk);
            this.groupBoxKasir.Controls.Add(this.dataGridViewKasir);
            this.groupBoxKasir.Location = new System.Drawing.Point(12, 36);
            this.groupBoxKasir.Name = "groupBoxKasir";
            this.groupBoxKasir.Size = new System.Drawing.Size(1589, 447);
            this.groupBoxKasir.TabIndex = 1;
            this.groupBoxKasir.TabStop = false;
            // 
            // comboBoxTaq
            // 
            this.comboBoxTaq.FormattingEnabled = true;
            this.comboBoxTaq.Location = new System.Drawing.Point(255, 23);
            this.comboBoxTaq.Name = "comboBoxTaq";
            this.comboBoxTaq.Size = new System.Drawing.Size(159, 28);
            this.comboBoxTaq.TabIndex = 11;
            this.comboBoxTaq.Text = "Taq";
            this.comboBoxTaq.SelectedIndexChanged += new System.EventHandler(this.comboBoxTaq_SelectedIndexChanged);
            // 
            // textBox_Search
            // 
            this.textBox_Search.Location = new System.Drawing.Point(6, 25);
            this.textBox_Search.Name = "textBox_Search";
            this.textBox_Search.Size = new System.Drawing.Size(243, 26);
            this.textBox_Search.TabIndex = 10;
            this.textBox_Search.Text = "Search";
            this.textBox_Search.TextChanged += new System.EventHandler(this.textBox_Search_TextChanged);
            // 
            // buttonCheckout
            // 
            this.buttonCheckout.Location = new System.Drawing.Point(798, 380);
            this.buttonCheckout.Name = "buttonCheckout";
            this.buttonCheckout.Size = new System.Drawing.Size(127, 58);
            this.buttonCheckout.TabIndex = 9;
            this.buttonCheckout.Text = "Checkout";
            this.buttonCheckout.UseVisualStyleBackColor = true;
            this.buttonCheckout.Click += new System.EventHandler(this.buttonCheckout_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(931, 335);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Jumlah produk:";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(1054, 333);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 26);
            this.numericUpDown1.TabIndex = 7;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // button_Hapus
            // 
            this.button_Hapus.Location = new System.Drawing.Point(798, 252);
            this.button_Hapus.Name = "button_Hapus";
            this.button_Hapus.Size = new System.Drawing.Size(127, 58);
            this.button_Hapus.TabIndex = 6;
            this.button_Hapus.Text = "Hapus";
            this.button_Hapus.UseVisualStyleBackColor = true;
            this.button_Hapus.Click += new System.EventHandler(this.button_Hapus_Click);
            // 
            // button_Update
            // 
            this.button_Update.Location = new System.Drawing.Point(798, 316);
            this.button_Update.Name = "button_Update";
            this.button_Update.Size = new System.Drawing.Size(127, 58);
            this.button_Update.TabIndex = 5;
            this.button_Update.Text = "Update";
            this.button_Update.UseVisualStyleBackColor = true;
            this.button_Update.Click += new System.EventHandler(this.button_Update_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(798, 25);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(764, 218);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // buttonTambah
            // 
            this.buttonTambah.Location = new System.Drawing.Point(6, 348);
            this.buttonTambah.Name = "buttonTambah";
            this.buttonTambah.Size = new System.Drawing.Size(127, 58);
            this.buttonTambah.TabIndex = 3;
            this.buttonTambah.Text = "Tambah";
            this.buttonTambah.UseVisualStyleBackColor = true;
            this.buttonTambah.Click += new System.EventHandler(this.buttonTambah_Click);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(2, 316);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(117, 20);
            this.label.TabIndex = 2;
            this.label.Text = "Jumlah produk:";
            // 
            // numericUpDown_Jumlah_Produk
            // 
            this.numericUpDown_Jumlah_Produk.Location = new System.Drawing.Point(125, 316);
            this.numericUpDown_Jumlah_Produk.Name = "numericUpDown_Jumlah_Produk";
            this.numericUpDown_Jumlah_Produk.Size = new System.Drawing.Size(120, 26);
            this.numericUpDown_Jumlah_Produk.TabIndex = 1;
            this.numericUpDown_Jumlah_Produk.ValueChanged += new System.EventHandler(this.numericUpDown_Jumlah_Produk_ValueChanged);
            // 
            // dataGridViewKasir
            // 
            this.dataGridViewKasir.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewKasir.Location = new System.Drawing.Point(0, 69);
            this.dataGridViewKasir.Name = "dataGridViewKasir";
            this.dataGridViewKasir.RowHeadersWidth = 62;
            this.dataGridViewKasir.RowTemplate.Height = 28;
            this.dataGridViewKasir.Size = new System.Drawing.Size(764, 218);
            this.dataGridViewKasir.TabIndex = 0;
            this.dataGridViewKasir.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewKasir_CellClick);
            this.dataGridViewKasir.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewKasir_CellContentClick);
            // 
            // kasirForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1613, 495);
            this.Controls.Add(this.groupBoxKasir);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "kasirForm";
            this.Text = "kasirForm";
            this.Load += new System.EventHandler(this.kasirForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBoxKasir.ResumeLayout(false);
            this.groupBoxKasir.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Jumlah_Produk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKasir)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem kasirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkoutUserToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBoxKasir;
        private System.Windows.Forms.DataGridView dataGridViewKasir;
        private System.Windows.Forms.NumericUpDown numericUpDown_Jumlah_Produk;
        private System.Windows.Forms.Button buttonTambah;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button button_Hapus;
        private System.Windows.Forms.Button button_Update;
        private System.Windows.Forms.Button buttonCheckout;
        private System.Windows.Forms.TextBox textBox_Search;
        private System.Windows.Forms.ComboBox comboBoxTaq;
    }
}