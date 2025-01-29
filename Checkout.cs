using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project
{
    public partial class Checkout : Form
    {
        public Checkout()
        {
            InitializeComponent();
            pictureBox1.Visible = false;
            groupBox1.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;    
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            UpdateKembalian();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void UpdateKembalian()
        {
            // Ambil nilai dari numericUpDown1 dan numericUpDown2
            decimal total = numericUpDown1.Value;
            decimal bayar = numericUpDown2.Value;

            // Hitung kembalian
            decimal kembalian = bayar - total;

            // Tampilkan hasil di label3
            label3.Text = $"Kembalian Rp {kembalian}";
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            UpdateKembalian();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Checkout_Load(object sender, EventArgs e)
        {

        }
    }
}
