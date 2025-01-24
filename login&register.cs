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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            SignIngroupBox1.Visible = true;
            SignUpgroupBox2.Visible = false;
            comboBoxRole_SignUp.Items.Add("admin");
            comboBoxRole_SignUp.Items.Add("kasir");
            comboBoxRole_SignUp.Items.Add("customer");
            comboBoxRole_SignUp.Items.Add("pegawai");
            comboBoxRole_SignUp.Items.Add("supplier");

        }
        public static int LoggedInUserId;
        private void SingnUp_button_Click(object sender, EventArgs e)
        {
            SignUpgroupBox2.Visible=true;
            SignIngroupBox1.Visible = false;
        }

        private void SignUpgroupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignIngroupBox1.Visible = true;
            SignUpgroupBox2.Visible = false;
        }

        private void SignUpbutton_Click(object sender, EventArgs e)
        {
            // Mendapatkan data dari form
            string namaLengkap = Name_SignUp_textBox.Text;
            string noTlp = Tlp_textBox.Text;
            string email = Email_SignUp_textBox.Text;
            string password = Password_SignUp_textBox.Text;
            DateTime tglLahir = dateTimePicker_tgl_lahir_SignUp.Value;
            string jenisKelamin = radioButton_Male_SignUp.Checked ? "laki-laki" : "perempuan";
            string alamat = textBoxAddress_SignUp.Text;
            string role = comboBoxRole_SignUp.SelectedItem?.ToString();

            // Validasi input
            if (string.IsNullOrWhiteSpace(namaLengkap) ||
                string.IsNullOrWhiteSpace(noTlp) ||
                string.IsNullOrWhiteSpace(email) ||
                string.IsNullOrWhiteSpace(password) ||
                string.IsNullOrWhiteSpace(alamat) ||
                string.IsNullOrWhiteSpace(role))
            {
                MessageBox.Show("Semua field harus diisi!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Hashing password (opsional, gunakan library seperti BCrypt.Net)
            // string hashedPassword = BCrypt.Net.BCrypt.HashPassword(password);

            string connectionString = "server=localhost;database=pad2024;uid=root;pwd=;";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = "INSERT INTO USER (nama_lengkap, no_tlp, email, PASSWORD, tgl_lahir, jenis_kelamin, alamat, ROLE) " +
                                   "VALUES (@nama_lengkap, @no_tlp, @email, @password, @tgl_lahir, @jenis_kelamin, @alamat, @role)";

                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        // Menambahkan parameter untuk mencegah SQL Injection
                        cmd.Parameters.AddWithValue("@nama_lengkap", namaLengkap);
                        cmd.Parameters.AddWithValue("@no_tlp", noTlp);
                        cmd.Parameters.AddWithValue("@email", email);
                        cmd.Parameters.AddWithValue("@password", password); // Gunakan hashedPassword jika menggunakan hashing
                        cmd.Parameters.AddWithValue("@tgl_lahir", tglLahir);
                        cmd.Parameters.AddWithValue("@jenis_kelamin", jenisKelamin);
                        cmd.Parameters.AddWithValue("@alamat", alamat);
                        cmd.Parameters.AddWithValue("@role", role);

                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Pendaftaran berhasil!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Terjadi kesalahan: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            SignIngroupBox1.Visible = true;
            SignUpgroupBox2.Visible = false;
        }

        private void SignInbutton2_Click(object sender, EventArgs e)
        {
            SignIngroupBox1.Visible = true;
            SignUpgroupBox2.Visible = false;
        }

        private void radioButton_Male_SignUp_CheckedChanged(object sender, EventArgs e)
        {
            radioButton_Female_SignUp.Checked = false;
        }

        private void radioButton_Female_SignUp_CheckedChanged(object sender, EventArgs e)
        {
            radioButton_Male_SignUp.Checked = false;
        }

        
        private void Sign_In_button_Click(object sender, EventArgs e)
        {
            string namaLengkap = Name_SignIntextBox.Text;
            string password = Password_SignIn_textBox.Text;

            if (string.IsNullOrWhiteSpace(namaLengkap) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Nama dan Password harus diisi!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string connectionString = "server=localhost;database=pad2024;uid=root;pwd=;";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT Id, ROLE FROM USER WHERE nama_lengkap = @nama_lengkap AND PASSWORD = @password";

                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@nama_lengkap", namaLengkap);
                        cmd.Parameters.AddWithValue("@password", password);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Ambil Id_User dan Role
                                LoggedInUserId = reader.GetInt32("Id");
                                string userRole = reader.GetString("ROLE");

                                // Arahkan pengguna ke halaman sesuai role
                                switch (userRole)
                                {
                                     // Arahkan pengguna ke halaman berdasarkan role
                                    case "admin":
                                        MessageBox.Show("Selamat datang, Admin!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        // Buka halaman Admin
                                        adminForm adminForm = new adminForm();
                                        adminForm.Show();
                                        break;

                                    case "kasir":
                                        MessageBox.Show("Selamat datang, Kasir!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        // Buka halaman Kasir
                                        kasirForm kasirForm = new kasirForm();
                                        kasirForm.Show();
                                        break;

                                    case "customer":
                                        MessageBox.Show("Selamat datang, Customer!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        // Buka halaman Customer
                                        customerForm customerForm = new customerForm();
                                        customerForm.Show();
                                        break;

                                    case "pegawai":
                                        MessageBox.Show("Selamat datang, Pegawai!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        // Buka halaman Pegawai
                                        pegawaiForm pegawaiForm = new pegawaiForm();
                                        pegawaiForm.Show();
                                        break;

                                    case "supplier":
                                        MessageBox.Show("Selamat datang, Supplier!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        // Buka halaman Supplier
                                        supplierForm supplierForm = new supplierForm();
                                        supplierForm.Show();
                                        break;

                                    default:
                                        MessageBox.Show("Role tidak dikenal!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        break;

                                }
                            
                            }
                            else
                            {
                                MessageBox.Show("Nama atau Password salah!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void Name_SignUp_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Tlp_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Email_SignUp_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Password_SignUp_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker_tgl_lahir_SignUp_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBoxAddress_SignUp_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxRole_SignUp_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Name_SignIntextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Password_SignIn_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void SignUpgroupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }
    }
}
