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

namespace project
{
    public partial class adminForm : Form
    {
        public adminForm()
        {
            InitializeComponent();
            comboBoxRole.Items.Add("admin");
            comboBoxRole.Items.Add("kasir");
            comboBoxRole.Items.Add("customer");
            comboBoxRole.Items.Add("pegawai");
            comboBoxRole.Items.Add("supplier"); 
            comboBoxJenisKelamin.Items.Add("laki-laki");
            comboBoxJenisKelamin.Items.Add("perempuan");
        }

        private void adminForm_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void dataGridViewUser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Pastikan baris valid dipilih
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewUser.Rows[e.RowIndex];

                // Ambil ID User dari kolom pertama (sesuaikan index kolom jika berbeda)
                selectedUserId = Convert.ToInt32(row.Cells["Id"].Value);

                // Tampilkan data yang dipilih pada input form (opsional, untuk verifikasi)
                textBoxNama_Lengkap.Text = row.Cells["nama_lengkap"].Value.ToString();
                numericUpDown_No_TLP.Value = Convert.ToDecimal(row.Cells["no_tlp"].Value);
                textBox_Email.Text = row.Cells["email"].Value.ToString();
                textBoxPassword.Text = row.Cells["password"].Value.ToString(); // Jangan tampilkan password di UI sebenarnya
                dateTimePickerTglLahir.Value = Convert.ToDateTime(row.Cells["tgl_lahir"].Value);
                comboBoxJenisKelamin.SelectedItem = row.Cells["jenis_kelamin"].Value.ToString();
                textBoxAlamat.Text = row.Cells["alamat"].Value.ToString();
                comboBoxRole.SelectedItem = row.Cells["role"].Value.ToString();
            }
        }

        private void buttonTambah_Click(object sender, EventArgs e)
        {
            // Ambil data dari input form
            string namaLengkap = textBoxNama_Lengkap.Text;
            string noTlp = numericUpDown_No_TLP.Value.ToString(); // Konversi ke string
            string email = textBox_Email.Text;
            string password = textBoxPassword.Text;
            DateTime tglLahir = dateTimePickerTglLahir.Value;
            string jenisKelamin = comboBoxJenisKelamin.SelectedItem?.ToString(); // Pastikan ada pilihan
            string alamat = textBoxAlamat.Text;
            string role = comboBoxRole.SelectedItem?.ToString(); // Pastikan ada pilihan

            // Validasi input
            if (string.IsNullOrWhiteSpace(namaLengkap) ||
                string.IsNullOrWhiteSpace(noTlp) ||
                string.IsNullOrWhiteSpace(email) ||
                string.IsNullOrWhiteSpace(password) ||
                string.IsNullOrWhiteSpace(jenisKelamin) ||
                string.IsNullOrWhiteSpace(alamat) ||
                string.IsNullOrWhiteSpace(role))
            {
                MessageBox.Show("Harap isi semua kolom dengan benar!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Koneksi ke database
            string connectionString = "server=localhost;database=pad2024;uid=root;pwd=;";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Query untuk menambahkan data user baru
                    string query = @"INSERT INTO User (nama_lengkap, no_tlp, email, password, tgl_lahir, jenis_kelamin, alamat, role) 
                             VALUES (@nama_lengkap, @no_tlp, @email, @password, @tgl_lahir, @jenis_kelamin, @alamat, @role)";

                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        // Mengatur parameter query
                        cmd.Parameters.AddWithValue("@nama_lengkap", namaLengkap);
                        cmd.Parameters.AddWithValue("@no_tlp", noTlp);
                        cmd.Parameters.AddWithValue("@email", email);
                        cmd.Parameters.AddWithValue("@password", password);
                        cmd.Parameters.AddWithValue("@tgl_lahir", tglLahir);
                        cmd.Parameters.AddWithValue("@jenis_kelamin", jenisKelamin);
                        cmd.Parameters.AddWithValue("@alamat", alamat);
                        cmd.Parameters.AddWithValue("@role", role);

                        // Eksekusi query
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("User berhasil ditambahkan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // Reset input form setelah berhasil
                            textBoxNama_Lengkap.Clear();
                            numericUpDown_No_TLP.Value = 0;
                            textBox_Email.Clear();
                            textBoxPassword.Clear();
                            comboBoxJenisKelamin.SelectedIndex = -1;
                            textBoxAlamat.Clear();
                            comboBoxRole.SelectedIndex = -1;
                        }
                        else
                        {
                            MessageBox.Show("Gagal menambahkan user!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Terjadi kesalahan: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                loadData();
            }
        }

        private void textBoxNama_Lengkap_TextChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown_No_TLP_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox_Email_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePickerTglLahir_ValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxJenisKelamin_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBoxAlamat_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxRole_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Reset input form setelah berhasil
            textBoxNama_Lengkap.Clear();
            numericUpDown_No_TLP.Value = 0;
            textBox_Email.Clear();
            textBoxPassword.Clear();
            comboBoxJenisKelamin.SelectedIndex = -1;
            textBoxAlamat.Clear();
            comboBoxRole.SelectedIndex = -1;
        }
        private int selectedUserId = -1;
        private void buttonHapus_Click(object sender, EventArgs e)
        {
            if (selectedUserId == -1)
            {
                MessageBox.Show("Pilih pengguna yang ingin dihapus!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Konfirmasi penghapusan
            DialogResult result = MessageBox.Show("Apakah Anda yakin ingin menghapus pengguna ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result != DialogResult.Yes)
            {
                return;
            }

            // Koneksi ke database
            string connectionString = "server=localhost;database=pad2024;uid=root;pwd=;";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Query untuk menghapus user berdasarkan ID
                    string query = "DELETE FROM User WHERE Id = @Id";

                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@Id", selectedUserId);

                        // Eksekusi query
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Pengguna berhasil dihapus!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // Reset form dan variabel global
                            selectedUserId = -1;
                        }
                        else
                        {
                            MessageBox.Show("Gagal menghapus pengguna!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Terjadi kesalahan: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            // Reload data ke DataGridView
            loadData();
        }
        private void loadData()
        {
            string connectionString = "server=localhost;database=pad2024;uid=root;pwd=;";

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    // Query untuk mengambil data User
                    string query = "SELECT Id, nama_lengkap, no_tlp, email, password, tgl_lahir, jenis_kelamin,  alamat, role FROM User";

                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();

                    // Mengisi DataTable dengan data dari database
                    adapter.Fill(dataTable);

                    // Mengatur DataSource DataGridView
                    dataGridViewUser.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Gagal memuat data User: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
             
        private void dataGridViewUser_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Pastikan baris valid dipilih
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewUser.Rows[e.RowIndex];

                // Ambil ID User dari kolom pertama (sesuaikan index kolom jika berbeda)
                selectedUserId = Convert.ToInt32(row.Cells["Id"].Value);

                // Tampilkan data yang dipilih pada input form (opsional, untuk verifikasi)
                textBoxNama_Lengkap.Text = row.Cells["nama_lengkap"].Value.ToString();
                numericUpDown_No_TLP.Value = Convert.ToDecimal(row.Cells["no_tlp"].Value);
                textBox_Email.Text = row.Cells["email"].Value.ToString();
                textBoxPassword.Text = row.Cells["password"].Value.ToString(); // Jangan tampilkan password di UI sebenarnya
                dateTimePickerTglLahir.Value = Convert.ToDateTime(row.Cells["tgl_lahir"].Value);
                comboBoxJenisKelamin.SelectedItem = row.Cells["jenis_kelamin"].Value.ToString();
                textBoxAlamat.Text = row.Cells["alamat"].Value.ToString();
                comboBoxRole.SelectedItem = row.Cells["role"].Value.ToString();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Pastikan ada data yang dipilih
            if (selectedUserId == -1)
            {
                MessageBox.Show("Pilih pengguna yang ingin diperbarui!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Ambil data dari form input
            string namaLengkap = textBoxNama_Lengkap.Text;
            string noTlp = numericUpDown_No_TLP.Value.ToString();
            string email = textBox_Email.Text;
            string password = textBoxPassword.Text;
            DateTime tglLahir = dateTimePickerTglLahir.Value;
            string jenisKelamin = comboBoxJenisKelamin.SelectedItem?.ToString();
            string alamat = textBoxAlamat.Text;
            string role = comboBoxRole.SelectedItem?.ToString();

            // Validasi input
            if (string.IsNullOrWhiteSpace(namaLengkap) ||
                string.IsNullOrWhiteSpace(noTlp) ||
                string.IsNullOrWhiteSpace(email) ||
                string.IsNullOrWhiteSpace(password) ||
                string.IsNullOrWhiteSpace(jenisKelamin) ||
                string.IsNullOrWhiteSpace(alamat) ||
                string.IsNullOrWhiteSpace(role))
            {
                MessageBox.Show("Harap isi semua kolom dengan benar!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Koneksi ke database
            string connectionString = "server=localhost;database=pad2024;uid=root;pwd=;";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Query untuk update data
                    string query = @"UPDATE User
                             SET nama_lengkap = @NamaLengkap, 
                                 no_tlp = @NoTlp, 
                                 email = @Email, 
                                 password = @Password, 
                                 tgl_lahir = @TglLahir, 
                                 jenis_kelamin = @JenisKelamin, 
                                 alamat = @Alamat, 
                                 role = @Role
                             WHERE Id = @Id";

                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        // Tambahkan parameter
                        cmd.Parameters.AddWithValue("@NamaLengkap", namaLengkap);
                        cmd.Parameters.AddWithValue("@NoTlp", noTlp);
                        cmd.Parameters.AddWithValue("@Email", email);
                        cmd.Parameters.AddWithValue("@Password", password); // Jangan simpan plaintext password di produksi
                        cmd.Parameters.AddWithValue("@TglLahir", tglLahir);
                        cmd.Parameters.AddWithValue("@JenisKelamin", jenisKelamin);
                        cmd.Parameters.AddWithValue("@Alamat", alamat);
                        cmd.Parameters.AddWithValue("@Role", role);
                        cmd.Parameters.AddWithValue("@Id", selectedUserId);

                        // Eksekusi query
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Data pengguna berhasil diperbarui!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // Reset form dan variabel
                            selectedUserId = -1;
                          
                        }
                        else
                        {
                            MessageBox.Show("Gagal memperbarui data pengguna!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Terjadi kesalahan: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            // Reload data ke DataGridView
            loadData();
        }
        

    }
}
