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
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
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
            this.menuStrip1.Size = new System.Drawing.Size(1613, 36);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // kasirToolStripMenuItem
            // 
            this.kasirToolStripMenuItem.Name = "kasirToolStripMenuItem";
            this.kasirToolStripMenuItem.Size = new System.Drawing.Size(65, 30);
            this.kasirToolStripMenuItem.Text = "Kasir";
            // 
            // checkoutUserToolStripMenuItem
            // 
            this.checkoutUserToolStripMenuItem.Name = "checkoutUserToolStripMenuItem";
            this.checkoutUserToolStripMenuItem.Size = new System.Drawing.Size(142, 30);
            this.checkoutUserToolStripMenuItem.Text = "Checkout User";
            // 
            // groupBoxKasir
            // 
            this.groupBoxKasir.Controls.Add(this.label1);
            this.groupBoxKasir.Controls.Add(this.numericUpDown1);
            this.groupBoxKasir.Controls.Add(this.button2);
            this.groupBoxKasir.Controls.Add(this.button1);
            this.groupBoxKasir.Controls.Add(this.dataGridView1);
            this.groupBoxKasir.Controls.Add(this.buttonTambah);
            this.groupBoxKasir.Controls.Add(this.label);
            this.groupBoxKasir.Controls.Add(this.numericUpDown_Jumlah_Produk);
            this.groupBoxKasir.Controls.Add(this.dataGridViewKasir);
            this.groupBoxKasir.Location = new System.Drawing.Point(12, 36);
            this.groupBoxKasir.Name = "groupBoxKasir";
            this.groupBoxKasir.Size = new System.Drawing.Size(1589, 425);
            this.groupBoxKasir.TabIndex = 1;
            this.groupBoxKasir.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(931, 301);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Jumlah produk:";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(1054, 299);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 26);
            this.numericUpDown1.TabIndex = 7;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(798, 252);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(127, 58);
            this.button2.TabIndex = 6;
            this.button2.Text = "Hapus";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(798, 316);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 58);
            this.button1.TabIndex = 5;
            this.button1.Text = "Update";
            this.button1.UseVisualStyleBackColor = true;
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
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // buttonTambah
            // 
            this.buttonTambah.Location = new System.Drawing.Point(10, 301);
            this.buttonTambah.Name = "buttonTambah";
            this.buttonTambah.Size = new System.Drawing.Size(127, 58);
            this.buttonTambah.TabIndex = 3;
            this.buttonTambah.Text = "Tambah";
            this.buttonTambah.UseVisualStyleBackColor = true;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(6, 271);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(117, 20);
            this.label.TabIndex = 2;
            this.label.Text = "Jumlah produk:";
            // 
            // numericUpDown_Jumlah_Produk
            // 
            this.numericUpDown_Jumlah_Produk.Location = new System.Drawing.Point(129, 269);
            this.numericUpDown_Jumlah_Produk.Name = "numericUpDown_Jumlah_Produk";
            this.numericUpDown_Jumlah_Produk.Size = new System.Drawing.Size(120, 26);
            this.numericUpDown_Jumlah_Produk.TabIndex = 1;
            // 
            // dataGridViewKasir
            // 
            this.dataGridViewKasir.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewKasir.Location = new System.Drawing.Point(6, 25);
            this.dataGridViewKasir.Name = "dataGridViewKasir";
            this.dataGridViewKasir.RowHeadersWidth = 62;
            this.dataGridViewKasir.RowTemplate.Height = 28;
            this.dataGridViewKasir.Size = new System.Drawing.Size(764, 218);
            this.dataGridViewKasir.TabIndex = 0;
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
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}