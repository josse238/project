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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            this.groupBoxKasir.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.menuStrip1.Size = new System.Drawing.Size(1426, 33);
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
            this.groupBoxKasir.Controls.Add(this.dataGridView1);
            this.groupBoxKasir.Location = new System.Drawing.Point(12, 36);
            this.groupBoxKasir.Name = "groupBoxKasir";
            this.groupBoxKasir.Size = new System.Drawing.Size(799, 414);
            this.groupBoxKasir.TabIndex = 1;
            this.groupBoxKasir.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 25);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(764, 218);
            this.dataGridView1.TabIndex = 0;
            // 
            // kasirForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1426, 465);
            this.Controls.Add(this.groupBoxKasir);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "kasirForm";
            this.Text = "kasirForm";
            this.Load += new System.EventHandler(this.kasirForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBoxKasir.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem kasirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkoutUserToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBoxKasir;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}