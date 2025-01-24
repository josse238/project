namespace project
{
    partial class customerForm
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
            this.flowLayoutPanelBarang = new System.Windows.Forms.FlowLayoutPanel();
            this.dataGridViewUserItem = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUserItem)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanelBarang
            // 
            this.flowLayoutPanelBarang.Location = new System.Drawing.Point(12, 12);
            this.flowLayoutPanelBarang.Name = "flowLayoutPanelBarang";
            this.flowLayoutPanelBarang.Size = new System.Drawing.Size(776, 426);
            this.flowLayoutPanelBarang.TabIndex = 1;
            this.flowLayoutPanelBarang.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanelBarang_Paint);
            // 
            // dataGridViewUserItem
            // 
            this.dataGridViewUserItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUserItem.Location = new System.Drawing.Point(813, 12);
            this.dataGridViewUserItem.Name = "dataGridViewUserItem";
            this.dataGridViewUserItem.RowHeadersWidth = 62;
            this.dataGridViewUserItem.RowTemplate.Height = 28;
            this.dataGridViewUserItem.Size = new System.Drawing.Size(773, 423);
            this.dataGridViewUserItem.TabIndex = 0;
            // 
            // customerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1603, 450);
            this.Controls.Add(this.dataGridViewUserItem);
            this.Controls.Add(this.flowLayoutPanelBarang);
            this.Name = "customerForm";
            this.Text = "customerForm";
            this.Load += new System.EventHandler(this.customerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUserItem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelBarang;
        private System.Windows.Forms.DataGridView dataGridViewUserItem;
    }
}