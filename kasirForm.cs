using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project
{
    public partial class kasirForm : Form
    {
        public kasirForm()
        {
            InitializeComponent();
            LoadDataBarang();
            LoadData();
        }
        private void LoadData()
        {
            string connectionString = "server=localhost;user=root;password=;database=pad2024;";
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM cart_kasir";
                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dataGridView1.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
        private void LoadDataBarang()
        {
            string connectionString = "server=localhost;user=root;password=;database=pad2024;";
            

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT Id_barang, Nama_Barang, Harga_produk, Harga_diskon, Jumlah_Produk, Taq FROM Barang";
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        // Set DataGridView DataSource
                        dataGridViewKasir.DataSource = dataTable;

                        // Atur header kolom (opsional)
                        dataGridViewKasir.Columns["Id_barang"].HeaderText = "ID Barang";
                        dataGridViewKasir.Columns["Nama_Barang"].HeaderText = "Nama Barang";
                        dataGridViewKasir.Columns["Harga_produk"].HeaderText = "Harga Produk";
                        dataGridViewKasir.Columns["Harga_diskon"].HeaderText = "Harga Diskon";
                        dataGridViewKasir.Columns["Jumlah_Produk"].HeaderText = "Jumlah Produk";
                        dataGridViewKasir.Columns["Taq"].HeaderText = "Taq";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Terjadi kesalahan: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void kasirForm_Load(object sender, EventArgs e)
        {

        }

        private void dataGridViewKasir_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void numericUpDown_Jumlah_Produk_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dataGridViewKasir_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Ambil jumlah produk dari kolom yang sesuai
                int jumlahProduk = Convert.ToInt32(dataGridViewKasir.Rows[e.RowIndex].Cells["Jumlah_Produk"].Value);

                // Atur nilai maksimum pada NumericUpDown
                numericUpDown_Jumlah_Produk.Maximum = jumlahProduk;
                numericUpDown_Jumlah_Produk.Value = 1; // Set nilai default jika diperlukan
            }
        }
    }
}
