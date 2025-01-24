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
    public partial class customerForm : Form
    {
        public customerForm()
        {
            InitializeComponent();
        }

        private void customerForm_Load(object sender, EventArgs e)
        {

        }
        private void LoadBarang(int idUser)
        {
            string connectionString = "server=localhost;user=root;password=;database=pad2024;";
            string query = "SELECT Id_barang, Foto_Produk, Nama_Barang, Harga_produk, Harga_diskon, Taq, JumlahProduk " +
                           "" +
                           "FROM Barang";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Id", idUser);
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        flowLayoutPanelBarang.Controls.Clear();

                        while (reader.Read())
                        {
                            // Membuat panel sebagai card
                            Panel card = new Panel
                            {
                                Width = 200,
                                Height = 300,
                                Margin = new Padding(10),
                                BorderStyle = BorderStyle.FixedSingle
                            };

                            // Taq
                            Label lblTaq = new Label
                            {
                                Text = reader["Taq"].ToString(),
                                ForeColor = Color.White,
                                BackColor = Color.Blue, // Ubah sesuai warna taq
                                Dock = DockStyle.Top,
                                TextAlign = ContentAlignment.MiddleCenter
                            };

                            // Foto Produk
                            PictureBox picture = new PictureBox
                            {
                                ImageLocation = reader["Foto_Produk"].ToString(),
                                SizeMode = PictureBoxSizeMode.StretchImage,
                                Width = 180,
                                Height = 150,
                                Margin = new Padding(10)
                            };

                            // Nama Barang
                            Label lblNamaBarang = new Label
                            {
                                Text = reader["Nama_Barang"].ToString(),
                                AutoSize = false,
                                Dock = DockStyle.Top,
                                TextAlign = ContentAlignment.MiddleCenter
                            };

                            // Harga
                            decimal hargaProduk = reader.GetDecimal("Harga_produk");
                            decimal hargaDiskon = reader.GetDecimal("Harga_diskon");

                            Label lblHarga = new Label
                            {
                                Text = hargaProduk == hargaDiskon
                                    ? $"Rp {hargaProduk:N2}"
                                    : $"Rp {hargaDiskon:N2} (Diskon)",
                                Dock = DockStyle.Top,
                                ForeColor = Color.Red,
                                TextAlign = ContentAlignment.MiddleCenter
                            };

                            // Tombol - Jumlah +
                            Panel panelJumlah = new Panel { Height = 30, Dock = DockStyle.Bottom };

                            Button btnMinus = new Button { Text = "-", Width = 30, Dock = DockStyle.Left };
                            Label lblJumlah = new Label
                            {
                                Text = "0",
                                TextAlign = ContentAlignment.MiddleCenter,
                                Dock = DockStyle.Fill
                            };
                            Button btnPlus = new Button { Text = "+", Width = 30, Dock = DockStyle.Right };

                            panelJumlah.Controls.Add(btnMinus);
                            panelJumlah.Controls.Add(lblJumlah);
                            panelJumlah.Controls.Add(btnPlus);

                            // Event tombol
                            int maxJumlah = reader.GetInt32("JumlahProduk");
                            btnPlus.Click += (s, e) =>
                            {
                                int jumlah = int.Parse(lblJumlah.Text);
                                if (jumlah < maxJumlah)
                                    lblJumlah.Text = (jumlah + 1).ToString();
                            };
                            btnMinus.Click += (s, e) =>
                            {
                                int jumlah = int.Parse(lblJumlah.Text);
                                if (jumlah > 0)
                                    lblJumlah.Text = (jumlah - 1).ToString();
                            };

                            // Menambahkan elemen ke card
                            card.Controls.Add(panelJumlah);
                            card.Controls.Add(lblHarga);
                            card.Controls.Add(lblNamaBarang);
                            card.Controls.Add(picture);
                            card.Controls.Add(lblTaq);

                            // Menambahkan card ke FlowLayoutPanel
                            flowLayoutPanelBarang.Controls.Add(card);
                        }
                    }
                }
            }
        }
        private void flowLayoutPanelBarang_Paint(object sender, PaintEventArgs e)
        {
            int idUser = Form1.LoggedInUserId;
            LoadBarang(idUser);

                // Pastikan scroll bar muncul jika dibutuhkan
                flowLayoutPanelBarang.AutoScroll = true;
                flowLayoutPanelBarang.WrapContents = false; // Agar item ditampilkan dalam satu kolom
                flowLayoutPanelBarang.FlowDirection = FlowDirection.TopDown; // Atur arah elemen vertikal
            }
        }
    }
