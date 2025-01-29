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
        private DataTable dataTable;
        public kasirForm()
        {
            InitializeComponent();
            LoadDataBarang();
            LoadData();
            comboBoxTaq.Items.Add("baru");
            comboBoxTaq.Items.Add("diskon");
            comboBoxTaq.Items.Add("habis");
            comboBoxTaq.Items.Add("no taq");
        }
        private int selectedIdCart; // Menyimpan id_cart yang dipilih
        private int selectedIdBarang; // Menyimpan Id_barang yang dipilih
        private string selectedNamaBarang;
        private decimal selectedHargaProduk;
        private decimal selectedHargaDiskon;
        private int selectedJumlahProduk;
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
                    string query = "SELECT Id_barang, Nama_Barang, Harga_produk, Harga_diskon, Jumlah_Produk, Taq, Kategori FROM Barang";
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                    {
                        dataTable = new DataTable(); // Inisialisasi DataTable
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
                        dataGridViewKasir.Columns["Kategori"].HeaderText = "Kategori";
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
                // Ambil data dari baris yang dipilih
                selectedIdBarang = Convert.ToInt32(dataGridViewKasir.Rows[e.RowIndex].Cells["Id_barang"].Value);
                selectedNamaBarang = dataGridViewKasir.Rows[e.RowIndex].Cells["Nama_Barang"].Value.ToString();
                selectedHargaProduk = Convert.ToDecimal(dataGridViewKasir.Rows[e.RowIndex].Cells["Harga_produk"].Value);
                selectedHargaDiskon = Convert.ToDecimal(dataGridViewKasir.Rows[e.RowIndex].Cells["Harga_diskon"].Value);
                selectedJumlahProduk = Convert.ToInt32(dataGridViewKasir.Rows[e.RowIndex].Cells["Jumlah_Produk"].Value);

                // Atur nilai maksimum dan nilai saat ini pada NumericUpDown
                numericUpDown_Jumlah_Produk.Maximum = selectedJumlahProduk;
                numericUpDown_Jumlah_Produk.Value = 1; // Set nilai default jika diperlukan
            }
        
        }

        private void buttonTambah_Click(object sender, EventArgs e)
        {
            // Hitung total berdasarkan jumlah produk dan harga diskon
            decimal total = selectedHargaDiskon * selectedJumlahProduk;
            decimal JumlahProduk = numericUpDown_Jumlah_Produk.Value;
            // Koneksi ke database
            string connectionString = "server=localhost;user=root;password=;database=pad2024;";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "INSERT INTO cart_kasir (id_Kasir, nama_produk, jumlah_produk_awal, harga_awal, harga_diskon, jumlah_produk_update, total) " +
                                   "VALUES (@Id_User, @nama_produk, @jumlah_produk_awal, @harga_awal, @harga_diskon, @jumlah_produk_update, @total)";

                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        // Menambahkan parameter
                        cmd.Parameters.AddWithValue("@Id_User", Form1.LoggedInUserId); // Id_User yang sedang login
                        cmd.Parameters.AddWithValue("@nama_produk", selectedNamaBarang);
                        cmd.Parameters.AddWithValue("@jumlah_produk_awal", JumlahProduk);
                        cmd.Parameters.AddWithValue("@harga_awal", selectedHargaProduk);
                        cmd.Parameters.AddWithValue("@harga_diskon", selectedHargaDiskon);
                        cmd.Parameters.AddWithValue("@jumlah_produk_update", JumlahProduk); // Atur sesuai kebutuhan
                        cmd.Parameters.AddWithValue("@total", total);

                        // Eksekusi perintah
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Data berhasil ditambahkan ke cart.");
                        LoadData();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Terjadi kesalahan: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void textBox_Search_TextChanged(object sender, EventArgs e)
        {
            string filterExpression = $"Nama_Barang LIKE '%{textBox_Search.Text}%'";
            DataView dataView = new DataView(dataTable);
            dataView.RowFilter = filterExpression;

            // Set DataGridView DataSource ke DataView yang sudah difilter
            dataGridViewKasir.DataSource = dataView;
        }

        private void comboBoxTaq_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedTaq = comboBoxTaq.SelectedItem.ToString();
            string filterExpression = $"Taq = '{selectedTaq}'";
            DataView dataView = new DataView(dataTable);
            dataView.RowFilter = filterExpression;

            // Set DataGridView DataSource ke DataView yang sudah difilter
            dataGridViewKasir.DataSource = dataView;
        }

        private void button_Hapus_Click(object sender, EventArgs e)
        {
            // Koneksi ke database
            string connectionString = "server=localhost;user=root;password=;database=pad2024;";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "UPDATE cart_kasir SET hapus_pilihan = 'iya' WHERE id_cart = @id_cart";

                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        // Menambahkan parameter
                        cmd.Parameters.AddWithValue("@id_cart", selectedIdCart);

                        // Eksekusi perintah
                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Data berhasil dihapus dari pilihan.");
                            // Anda mungkin ingin memuat ulang DataGridView setelah penghapusan
                            LoadData(); // Pastikan Anda memiliki metode ini untuk memuat ulang data
                        }
                        else
                        {
                            MessageBox.Show("Tidak ada data yang dihapus.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Terjadi kesalahan: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Pastikan sel yang diklik adalah sel data (bukan header)
            if (e.RowIndex >= 0)
            {
                // Ambil id_cart dari baris yang dipilih
                selectedIdCart = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["id_cart"].Value);
            }
        }

        private void buttonCheckout_Click(object sender, EventArgs e)
        {
            Checkout co = new Checkout();
            co.ShowDialog();
        }

        private void button_Update_Click(object sender, EventArgs e)
        {
            // Mengubah nilai update_pilihan menjadi 'iya'
            string updatePilihan = "iya";

            // Mengambil nilai dari numericUpDown1 untuk jumlah_produk_update
            int jumlahProdukUpdate = (int)numericUpDown1.Value;

            // Panggil metode untuk melakukan update ke database
            UpdateDatabase(updatePilihan, jumlahProdukUpdate, selectedIdCart);
        }
        private void UpdateDatabase(string updatePilihan, int jumlahProdukUpdate, int rowId)
        {
            // Logika untuk melakukan update ke database
            // Misalnya menggunakan ADO.NET atau ORM seperti Entity Framework

            // Contoh query SQL (pastikan untuk menggunakan parameter untuk menghindari SQL Injection)
            string query = "UPDATE cart_kasir SET update_pilihan = @updatePilihan, jumlah_produk_update = @jumlahProdukUpdate WHERE id = @rowId";
            string connectionString = "server=localhost;user=root;password=;database=pad2024;";
            using (SqlConnection connection = new SqlConnection("connectionString"))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@updatePilihan", updatePilihan);
                    command.Parameters.AddWithValue("@jumlahProdukUpdate", jumlahProdukUpdate);
                    command.Parameters.AddWithValue("@rowId", rowId); // Menggunakan ID baris yang dipilih

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }

            // Tampilkan pesan sukses atau lakukan tindakan lain setelah update
            MessageBox.Show("Data berhasil diupdate.");
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
