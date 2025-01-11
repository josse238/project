using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace project
{
    public partial class supplierForm : Form
    {
        public supplierForm()
        {
            InitializeComponent();
            comboBox_Taq_TambahProduk.Items.Add("baru");
            comboBox_Taq_TambahProduk.Items.Add("diskon");
            comboBox_Taq_TambahProduk.Items.Add("habis");
            comboBox_Taq_TambahProduk.Items.Add("no taq");
        }

        private void supplierForm_Load(object sender, EventArgs e)
        {

        }

        private void button_TambahProduk_Click(object sender, EventArgs e)
        {
            // Ambil data dari input form
            string fotoProduk = textBoxFotoProduk_TambahProduk.Text;
            string namaBarang = textBox_NamaBarang_TambahProduk.Text;
            string keterangan = textBox_Keterangan_TambahProduk.Text;
            decimal hargaModal = numericUpDownHargaModal_TambahProduk.Value;
            decimal hargaProduk = numericUpDown_HargaProduk_TambahProduk.Value;
            decimal hargaDiskon = numericUpDown_HargaDiskon_TambahProduk.Value;
            string kategori = textBox_Kategori_TambahProduk.Text;
            string taq = comboBox_Taq_TambahProduk.SelectedItem?.ToString(); // Nilai Taq

            // Validasi input
            if (string.IsNullOrWhiteSpace(namaBarang) || string.IsNullOrWhiteSpace(kategori) || hargaModal <= 0 || hargaProduk <= 0)
            {
                MessageBox.Show("Harap isi semua kolom wajib dengan benar!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Koneksi ke database
            string connectionString = "server=localhost;database=pad2024;uid=root;pwd=;";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Query untuk menambahkan data
                    string query = @"INSERT INTO Barang 
                            (Id_User, Foto_Produk, Nama_Barang, Keterangan, Harga_modal, Harga_produk, Harga_diskon, Kategori, Taq) 
                            VALUES 
                            (@Id_User, @Foto_Produk, @Nama_Barang, @Keterangan, @Harga_modal, @Harga_produk, @Harga_diskon, @Kategori, @Taq)";

                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        // Ganti ID_User sesuai kebutuhan Anda
                        int idUser = 1; // Contoh ID_User untuk pengguna yang sedang login
                        cmd.Parameters.AddWithValue("@Id_User", idUser);
                        cmd.Parameters.AddWithValue("@Foto_Produk", string.IsNullOrWhiteSpace(fotoProduk) ? null : fotoProduk);
                        cmd.Parameters.AddWithValue("@Nama_Barang", namaBarang);
                        cmd.Parameters.AddWithValue("@Keterangan", string.IsNullOrWhiteSpace(keterangan) ? null : keterangan);
                        cmd.Parameters.AddWithValue("@Harga_modal", hargaModal);
                        cmd.Parameters.AddWithValue("@Harga_produk", hargaProduk);
                        cmd.Parameters.AddWithValue("@Harga_diskon", hargaDiskon);
                        cmd.Parameters.AddWithValue("@Kategori", kategori);
                        cmd.Parameters.AddWithValue("@Taq", string.IsNullOrWhiteSpace(taq) ? "no taq" : taq);

                        // Eksekusi query
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Produk berhasil ditambahkan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Gagal menambahkan produk!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Terjadi kesalahan: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void textBoxFotoProduk_TambahProduk_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_NamaBarang_TambahProduk_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_Keterangan_TambahProduk_TextChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDownHargaModal_TambahProduk_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown_HargaProduk_TambahProduk_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown_HargaDiskon_TambahProduk_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox_Kategori_TambahProduk_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox_Taq_TambahProduk_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
