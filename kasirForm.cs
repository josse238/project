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
        }

        private void LoadDataBarang()
        {
            string connectionString = "server=localhost;user=root;password=;database=pad2024;";
            string query = "SELECT Id_barang, Nama_Barang, Harga_produk, Harga_diskon, JumlahProduk, Taq FROM Barang";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
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
                        dataGridViewKasir.Columns["JumlahProduk"].HeaderText = "Jumlah Produk";
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
    }
}
