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
using System.Diagnostics.Eventing.Reader;


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
            comboBox_Taq_EditProduk.Items.Add("baru");
            comboBox_Taq_EditProduk.Items.Add("diskon");
            comboBox_Taq_EditProduk.Items.Add("habis");
            comboBox_Taq_EditProduk.Items.Add("no taq");
            LoadDataBarang();
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
            int Jumlah_Produk = ((int)numericUpDownJumlahProduk.Value);
            string Barcode = textBox_Barcode.Text;
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
                            (Id_User, Foto_Produk, Nama_Barang, Keterangan, Harga_modal, Harga_produk, Harga_diskon, Kategori, Taq, Jumlah_Produk, Barcode) 
                            VALUES 
                            (@Id_User, @Foto_Produk, @Nama_Barang, @Keterangan, @Harga_modal, @Harga_produk, @Harga_diskon, @Kategori, @Taq, @Jumlah_Produk, @Barcode)";

                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        // Ganti ID_User sesuai kebutuhan Anda
                        int idUser = Form1.LoggedInUserId; // ID pengguna login
                        cmd.Parameters.AddWithValue("@Id_User", idUser);
                        cmd.Parameters.AddWithValue("@Foto_Produk", string.IsNullOrWhiteSpace(fotoProduk) ? null : fotoProduk);
                        cmd.Parameters.AddWithValue("@Nama_Barang", namaBarang);
                        cmd.Parameters.AddWithValue("@Keterangan", string.IsNullOrWhiteSpace(keterangan) ? null : keterangan);
                        cmd.Parameters.AddWithValue("@Harga_modal", hargaModal);
                        cmd.Parameters.AddWithValue("@Harga_produk", hargaProduk);
                        cmd.Parameters.AddWithValue("@Harga_diskon", hargaDiskon);
                        cmd.Parameters.AddWithValue("@Kategori", kategori);
                        cmd.Parameters.AddWithValue("@Jumlah_Produk", Jumlah_Produk);
                        cmd.Parameters.AddWithValue("@Barcode", Barcode);
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
            LoadDataBarang();
        }

        private void textBoxFotoProduk_TambahProduk_TextChanged(object sender, EventArgs e)
        {
            string url = textBoxFotoProduk_TambahProduk.Text;

            // Validasi apakah input bukan kosong
            if (!string.IsNullOrWhiteSpace(url))
            {
                try
                {
                    // Load gambar dari URL ke PictureBox
                    pictureBox_FotoProduk_TambahProduk.Load(url);
                }
                catch (Exception)
                {
                    // Jika URL tidak valid atau gagal memuat gambar
                    MessageBox.Show("URL gambar tidak valid. Pastikan URL adalah link gambar yang benar!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    pictureBox_FotoProduk_TambahProduk.Image = null; // Reset PictureBox
                }
            }
            else
            {
                // Reset PictureBox jika input kosong
                pictureBox_FotoProduk_TambahProduk.Image = null;
            }
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

        private void pictureBox_FotoProduk_TambahProduk_Click(object sender, EventArgs e)
        {
            // Opsional: Anda bisa membuka URL gambar di browser ketika PictureBox diklik
            string url = textBoxFotoProduk_TambahProduk.Text;

            if (!string.IsNullOrWhiteSpace(url))
            {
                try
                {
                    System.Diagnostics.Process.Start(url); // Membuka URL di browser
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Gagal membuka URL: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void tambahProdukToolStripMenuItem_Click(object sender, EventArgs e)
        {
            groupBox_TambahProduk.Visible = true;
            groupBox_EditProduk.Visible = false;
        }
        private void LoadDataBarang()
        {
            string connectionString = "server=localhost;user=root;password=;database=pad2024;";
            string query = "SELECT Id_barang, Id_User, Foto_Produk, Nama_Barang, Keterangan, Harga_modal, Harga_produk, Harga_diskon, Kategori, Taq, created_at, updated_at,  Jumlah_Produk, Barcode " +
                           "FROM Barang WHERE Id_User = @Id_User";

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        // Tambahkan parameter Id_User
                        cmd.Parameters.AddWithValue("@Id_User", Form1.LoggedInUserId);

                        // Isi DataTable dengan hasil query
                        MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        // Tampilkan data di DataGridView
                        dataGridView_EditProduk.DataSource = dataTable;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Gagal memuat data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void dataGridView_EditProduk_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Ambil baris yang dipilih
                DataGridViewRow selectedRow = dataGridView_EditProduk.Rows[e.RowIndex];

                // Set nilai ke elemen input sesuai dengan kolom data
                textBox_FotoProduk_EditProduk.Text = selectedRow.Cells["Foto_Produk"].Value?.ToString() ?? "";
                textBox_NamaProduk_EditProduk.Text = selectedRow.Cells["Nama_Barang"].Value?.ToString() ?? "";
                textBox_KeteranganProduk_EditProduk.Text = selectedRow.Cells["Keterangan"].Value?.ToString() ?? "";
                numericUpDown_HargaModal_EditProduk.Value = Convert.ToDecimal(selectedRow.Cells["Harga_modal"].Value ?? 0);
                numericUpDown_HargaProduk_EditProduk.Value = Convert.ToDecimal(selectedRow.Cells["Harga_produk"].Value ?? 0);
                numericUpDown_HargaDiskon_EditProduk.Value = Convert.ToDecimal(selectedRow.Cells["Harga_diskon"].Value ?? 0);
                textBox_KategoriProduk_EditProduk.Text = selectedRow.Cells["Kategori"].Value?.ToString() ?? "";
                comboBox_Taq_EditProduk.SelectedItem = selectedRow.Cells["Taq"].Value?.ToString();
                numericUpDown_JumlahProdukEdit.Value = Convert.ToDecimal(selectedRow.Cells["Jumlah_Produk"].Value ?? 0);
                textBoxBarcodeEdit.Text = selectedRow.Cells["Barcode"].Value?.ToString() ?? "";
            }
        }

        private void textBox_FotoProduk_EditProduk_TextChanged(object sender, EventArgs e)
        {
            string imageUrl = textBox_FotoProduk_EditProduk.Text; // Ambil URL dari textbox
            try
            {
                // Pastikan URL tidak kosong
                if (!string.IsNullOrWhiteSpace(imageUrl))
                {
                    // Load gambar dari URL
                    pictureBox_EditProduk.Load(imageUrl);
                }
                else
                {
                    // Kosongkan gambar jika URL kosong
                    pictureBox_EditProduk.Image = null;
                }
            }
            catch (Exception ex)
            {
                // Jika terjadi error (contoh: URL tidak valid), tampilkan pesan
                MessageBox.Show($"Gagal memuat gambar: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                pictureBox_EditProduk.Image = null; // Kosongkan gambar jika terjadi error
            }
        }

        private void button_Delete_EditProduk_Click(object sender, EventArgs e)
        {
            // Pastikan baris dipilih
            if (dataGridView_EditProduk.SelectedRows.Count > 0)
            {
                // Ambil ID Barang dari baris yang dipilih
                DataGridViewRow selectedRow = dataGridView_EditProduk.SelectedRows[0];
                string idBarang = selectedRow.Cells["Id_barang"].Value.ToString();

                // Konfirmasi penghapusan
                DialogResult result = MessageBox.Show("Apakah Anda yakin ingin menghapus data ini?", "Konfirmasi Hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    string connectionString = "server=localhost;user=root;password=;database=pad2024;";
                    string query = "DELETE FROM Barang WHERE Id_barang = @Id_barang";

                    try
                    {
                        using (MySqlConnection connection = new MySqlConnection(connectionString))
                        {
                            connection.Open();

                            // Buat command untuk eksekusi query
                            using (MySqlCommand command = new MySqlCommand(query, connection))
                            {
                                command.Parameters.AddWithValue("@Id_barang", idBarang);

                                // Eksekusi query
                                int rowsAffected = command.ExecuteNonQuery();

                                if (rowsAffected > 0)
                                {
                                    MessageBox.Show("Data berhasil dihapus!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    // Refresh DataGridView
                                    LoadDataBarang();
                                }
                                else
                                {
                                    MessageBox.Show("Data gagal dihapus!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Terjadi kesalahan: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Silakan pilih baris yang ingin dihapus!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void textBox_NamaProduk_EditProduk_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_KeteranganProduk_EditProduk_TextChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown_HargaModal_EditProduk_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown_HargaProduk_EditProduk_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown_HargaDiskon_EditProduk_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox_KategoriProduk_EditProduk_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_Update_EditProduk_Click(object sender, EventArgs e)
        {
            // Pastikan baris dipilih di DataGridView
            if (dataGridView_EditProduk.SelectedRows.Count > 0)
            {

                try
                {
                    // Ambil baris yang dipilih
                    DataGridViewRow selectedRow = dataGridView_EditProduk.SelectedRows[0];

                    // Ambil ID barang dari kolom "Id_barang"
                    int idBarang = Convert.ToInt32(selectedRow.Cells["Id_barang"].Value);

                    // Ambil data dari input form
                    string fotoProduk = textBox_FotoProduk_EditProduk.Text;
                    string namaBarang = textBox_NamaProduk_EditProduk.Text;
                    string keterangan = textBox_KeteranganProduk_EditProduk.Text;
                    decimal hargaModal = numericUpDown_HargaModal_EditProduk.Value;
                    decimal hargaProduk = numericUpDown_HargaProduk_EditProduk.Value;
                    decimal hargaDiskon = numericUpDown_HargaDiskon_EditProduk.Value;
                    string kategori = textBox_KategoriProduk_EditProduk.Text;
                    string taq = comboBox_Taq_EditProduk.SelectedItem?.ToString() ?? "no taq";

                    string connectionString = "server=localhost;user=root;password=;database=pad2024;";
                    // SQL untuk update data
                    string query = @"
                UPDATE Barang
                SET 
                    Foto_Produk = @Foto_Produk,
                    Nama_Barang = @Nama_Barang,
                    Keterangan = @Keterangan,
                    Harga_modal = @Harga_modal,
                    Harga_produk = @Harga_produk,
                    Harga_diskon = @Harga_diskon,
                    Kategori = @Kategori,
                    Taq = @Taq,
                    updated_at = CURRENT_TIMESTAMP
                WHERE Id_barang = @Id_barang";

                    // Eksekusi query menggunakan SqlCommand
                    using (MySqlConnection connection = new MySqlConnection(connectionString))
                    {
                        using (MySqlCommand command = new MySqlCommand(query, connection))
                        {
                            // Tambahkan parameter
                            command.Parameters.AddWithValue("@Foto_Produk", fotoProduk);
                            command.Parameters.AddWithValue("@Nama_Barang", namaBarang);
                            command.Parameters.AddWithValue("@Keterangan", keterangan);
                            command.Parameters.AddWithValue("@Harga_modal", hargaModal);
                            command.Parameters.AddWithValue("@Harga_produk", hargaProduk);
                            command.Parameters.AddWithValue("@Harga_diskon", hargaDiskon);
                            command.Parameters.AddWithValue("@Kategori", kategori);
                            command.Parameters.AddWithValue("@Taq", taq);
                            command.Parameters.AddWithValue("@Id_barang", idBarang);

                            // Buka koneksi dan eksekusi query
                            connection.Open();
                            int rowsAffected = command.ExecuteNonQuery();
                            connection.Close();

                            // Berikan feedback ke pengguna
                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Data berhasil diperbarui.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                // Perbarui DataGridView dengan data baru
                                selectedRow.Cells["Foto_Produk"].Value = fotoProduk;
                                selectedRow.Cells["Nama_Barang"].Value = namaBarang;
                                selectedRow.Cells["Keterangan"].Value = keterangan;
                                selectedRow.Cells["Harga_modal"].Value = hargaModal;
                                selectedRow.Cells["Harga_produk"].Value = hargaProduk;
                                selectedRow.Cells["Harga_diskon"].Value = hargaDiskon;
                                selectedRow.Cells["Kategori"].Value = kategori;
                                selectedRow.Cells["Taq"].Value = taq;
                            }
                            else
                            {
                                MessageBox.Show("Tidak ada data yang diperbarui.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Terjadi kesalahan: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Pilih baris yang ingin diperbarui terlebih dahulu.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void pictureBox_EditProduk_Click(object sender, EventArgs e)
        {

        }

        private void editProdukToolStripMenuItem_Click(object sender, EventArgs e)
        {
            groupBox_EditProduk.Visible = true;
            groupBox_TambahProduk.Visible = false;
        }

        private void groupBox_EditProduk_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView_EditProduk_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Ambil baris yang dipilih
                DataGridViewRow selectedRow = dataGridView_EditProduk.Rows[e.RowIndex];

                // Set nilai ke elemen input sesuai dengan kolom data
                textBox_FotoProduk_EditProduk.Text = selectedRow.Cells["Foto_Produk"].Value?.ToString() ?? "";
                textBox_NamaProduk_EditProduk.Text = selectedRow.Cells["Nama_Barang"].Value?.ToString() ?? "";
                textBox_KeteranganProduk_EditProduk.Text = selectedRow.Cells["Keterangan"].Value?.ToString() ?? "";
                numericUpDown_HargaModal_EditProduk.Value = Convert.ToDecimal(selectedRow.Cells["Harga_modal"].Value ?? 0);
                numericUpDown_HargaProduk_EditProduk.Value = Convert.ToDecimal(selectedRow.Cells["Harga_produk"].Value ?? 0);
                numericUpDown_HargaDiskon_EditProduk.Value = Convert.ToDecimal(selectedRow.Cells["Harga_diskon"].Value ?? 0);
                textBox_KategoriProduk_EditProduk.Text = selectedRow.Cells["Kategori"].Value?.ToString() ?? "";
                comboBox_Taq_EditProduk.SelectedItem = selectedRow.Cells["Taq"].Value?.ToString();
                numericUpDown_JumlahProdukEdit.Value = Convert.ToDecimal(selectedRow.Cells["Jumlah_Produk"].Value ?? 0);
                textBoxBarcodeEdit.Text = selectedRow.Cells["Barcode"].Value?.ToString() ?? "";
            }
        }

        private void numericUpDownJumlahProduk_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}