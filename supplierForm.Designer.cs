namespace project
{
    partial class supplierForm
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
            this.tambahProdukToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editProdukToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox_TambahProduk = new System.Windows.Forms.GroupBox();
            this.textBoxFotoProduk_TambahProduk = new System.Windows.Forms.TextBox();
            this.pictureBox_FotoProduk_TambahProduk = new System.Windows.Forms.PictureBox();
            this.textBox_NamaBarang_TambahProduk = new System.Windows.Forms.TextBox();
            this.textBox_Keterangan_TambahProduk = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.groupBox_TambahProduk.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_FotoProduk_TambahProduk)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tambahProdukToolStripMenuItem,
            this.editProdukToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tambahProdukToolStripMenuItem
            // 
            this.tambahProdukToolStripMenuItem.Name = "tambahProdukToolStripMenuItem";
            this.tambahProdukToolStripMenuItem.Size = new System.Drawing.Size(152, 29);
            this.tambahProdukToolStripMenuItem.Text = "Tambah Produk";
            // 
            // editProdukToolStripMenuItem
            // 
            this.editProdukToolStripMenuItem.Name = "editProdukToolStripMenuItem";
            this.editProdukToolStripMenuItem.Size = new System.Drawing.Size(120, 29);
            this.editProdukToolStripMenuItem.Text = "Edit Produk";
            // 
            // groupBox_TambahProduk
            // 
            this.groupBox_TambahProduk.Controls.Add(this.textBox_Keterangan_TambahProduk);
            this.groupBox_TambahProduk.Controls.Add(this.textBox_NamaBarang_TambahProduk);
            this.groupBox_TambahProduk.Controls.Add(this.pictureBox_FotoProduk_TambahProduk);
            this.groupBox_TambahProduk.Controls.Add(this.textBoxFotoProduk_TambahProduk);
            this.groupBox_TambahProduk.Location = new System.Drawing.Point(13, 36);
            this.groupBox_TambahProduk.Name = "groupBox_TambahProduk";
            this.groupBox_TambahProduk.Size = new System.Drawing.Size(776, 402);
            this.groupBox_TambahProduk.TabIndex = 1;
            this.groupBox_TambahProduk.TabStop = false;
            // 
            // textBoxFotoProduk_TambahProduk
            // 
            this.textBoxFotoProduk_TambahProduk.Location = new System.Drawing.Point(6, 25);
            this.textBoxFotoProduk_TambahProduk.Name = "textBoxFotoProduk_TambahProduk";
            this.textBoxFotoProduk_TambahProduk.Size = new System.Drawing.Size(256, 26);
            this.textBoxFotoProduk_TambahProduk.TabIndex = 0;
            this.textBoxFotoProduk_TambahProduk.Text = "Foto Produk";
            // 
            // pictureBox_FotoProduk_TambahProduk
            // 
            this.pictureBox_FotoProduk_TambahProduk.Location = new System.Drawing.Point(571, 25);
            this.pictureBox_FotoProduk_TambahProduk.Name = "pictureBox_FotoProduk_TambahProduk";
            this.pictureBox_FotoProduk_TambahProduk.Size = new System.Drawing.Size(199, 173);
            this.pictureBox_FotoProduk_TambahProduk.TabIndex = 1;
            this.pictureBox_FotoProduk_TambahProduk.TabStop = false;
            // 
            // textBox_NamaBarang_TambahProduk
            // 
            this.textBox_NamaBarang_TambahProduk.Location = new System.Drawing.Point(7, 66);
            this.textBox_NamaBarang_TambahProduk.Name = "textBox_NamaBarang_TambahProduk";
            this.textBox_NamaBarang_TambahProduk.Size = new System.Drawing.Size(256, 26);
            this.textBox_NamaBarang_TambahProduk.TabIndex = 2;
            this.textBox_NamaBarang_TambahProduk.Text = "Nama Produk";
            // 
            // textBox_Keterangan_TambahProduk
            // 
            this.textBox_Keterangan_TambahProduk.Location = new System.Drawing.Point(6, 109);
            this.textBox_Keterangan_TambahProduk.Name = "textBox_Keterangan_TambahProduk";
            this.textBox_Keterangan_TambahProduk.Size = new System.Drawing.Size(256, 26);
            this.textBox_Keterangan_TambahProduk.TabIndex = 3;
            this.textBox_Keterangan_TambahProduk.Text = "Keterangan  Produk";
            // 
            // supplierForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox_TambahProduk);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "supplierForm";
            this.Text = "supplierForm";
            this.Load += new System.EventHandler(this.supplierForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox_TambahProduk.ResumeLayout(false);
            this.groupBox_TambahProduk.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_FotoProduk_TambahProduk)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tambahProdukToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editProdukToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox_TambahProduk;
        private System.Windows.Forms.PictureBox pictureBox_FotoProduk_TambahProduk;
        private System.Windows.Forms.TextBox textBoxFotoProduk_TambahProduk;
        private System.Windows.Forms.TextBox textBox_Keterangan_TambahProduk;
        private System.Windows.Forms.TextBox textBox_NamaBarang_TambahProduk;
    }
}