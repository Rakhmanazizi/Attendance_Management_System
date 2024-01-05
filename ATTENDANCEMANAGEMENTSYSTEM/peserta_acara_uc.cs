using MySql.Data.MySqlClient;
using NuGet.Protocol.Plugins;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATTENDANCEMANAGEMENTSYSTEM
{
    public partial class peserta_acara_uc : UserControl
    {
        private string connectionDb = "server=localhost; user id=root; password=; database=db_attendance_ams";
        public peserta_acara_uc()
        {
            InitializeComponent();
            fill_cb_event();
            fill_cb_user();
            dgv_peserta_acara.DataSource = fill_data();
            DataGridViewButtonColumn col_delete = new DataGridViewButtonColumn();
            col_delete.UseColumnTextForButtonValue = true;
            col_delete.Text = "Hapus";
            col_delete.Name = "col_delete";
            dgv_peserta_acara.Columns.Add(col_delete);
        }

        public void fill_cb_user()
        {
            string query = "SELECT id, nama_lengkap FROM user WHERE role=\"member\"";
            using (MySqlConnection conn = new MySqlConnection(connectionDb))
            {
                using (MySqlCommand command = new MySqlCommand(query, conn))
                {
                    conn.Open();

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            // Assuming your_column is of type string
                            string id = reader["id"].ToString();
                            string nama = reader["nama_lengkap"].ToString();
                            comboBoxUser.Items.Add(id + " " + nama);
                        }
                    }
                }
            }
        }

        public void fill_cb_event()
        {
            string query = "SELECT id, nama_event FROM event";
            using (MySqlConnection conn = new MySqlConnection(connectionDb))
            {
                using (MySqlCommand command = new MySqlCommand(query, conn))
                {
                    conn.Open();

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            // Assuming your_column is of type string
                            string id = reader["id"].ToString();
                            string nama = reader["nama_event"].ToString();
                            comboBoxEvent.Items.Add(id + " " + nama);
                        }
                    }
                }
            }
        }



        private void btn_tambah_Click(object sender, EventArgs e)
        {
            if (comboBoxEvent.Text == "" || comboBoxUser.Text == "")
            {
                MessageBox.Show("Silakan isi kolom terlebih dahulu!", "Gagal Tambah Data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            } else
            {
                // Mendapatkan ID event dan ID user dari selected item ComboBox
                string id_event = comboBoxEvent.SelectedItem.ToString().Split(' ')[0];
                string id_user = comboBoxUser.SelectedItem.ToString().Split(' ')[0];

                // Mengecek apakah user sudah terdaftar untuk event tertentu
                if (!cek_user_terdaftar_acara(id_event, id_user))
                {
                    // Jika belum terdaftar, tambahkan kehadiran baru
                    string query = "INSERT INTO kehadiran (id_event, id_user) VALUES (@event, @user)";
                    using (MySqlConnection conn = new MySqlConnection(connectionDb))
                    {
                        conn.Open();
                        using (MySqlCommand command = new MySqlCommand(query, conn))
                        {
                            command.Parameters.AddWithValue("@event", Convert.ToInt32(id_event));
                            command.Parameters.AddWithValue("@user", Convert.ToInt32(id_user));

                            int rowAffected = command.ExecuteNonQuery();
                            if (rowAffected > 0)
                            {
                                MessageBox.Show("Berhasil menambahkan Partisipan Baru!", "Sukses Tambah Event");
                            }
                        }
                    }
                    btn_load_Click(sender, e);
                }
                else
                {
                    MessageBox.Show("Peserta sudah terdaftar dalam acara ini.", "Gagal Tambah Event", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private bool cek_user_terdaftar_acara(string id_event, string id_user)
        {
            // Mengecek apakah user sudah terdaftar pada event tertentu
            string query = "SELECT COUNT(*) FROM kehadiran WHERE id_event = @event AND id_user = @user";
            using (MySqlConnection conn = new MySqlConnection(connectionDb))
            {
                conn.Open();
                using (MySqlCommand command = new MySqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@event", Convert.ToInt32(id_event));
                    command.Parameters.AddWithValue("@user", Convert.ToInt32(id_user));
                    int count = Convert.ToInt32(command.ExecuteScalar());
                    return count > 0;
                }
            }
        }

        public DataTable fill_data()
        {
            string query = "SELECT id as \"No Urut\", nama_peserta AS \"Nama Peserta\", nama_event AS \"Nama Event\", tempat, tanggal, nama_instruktur AS \"Nama Instruktur\" FROM kehadiran_view";

            MySqlConnection conn = new MySqlConnection(connectionDb);
            MySqlCommand command = new MySqlCommand(query, conn);
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter(command);
            DataTable dataTable = new DataTable();

            try
            {
                conn.Open();
                dataAdapter.Fill(dataTable);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error");
            }
            finally
            {
                conn.Close();
            }

            return dataTable;
        }

        private void btn_load_Click(object sender, EventArgs e)
        {
            dgv_peserta_acara.DataSource = fill_data();
            refresh_combo_box();
        }

        public void refresh_combo_box()
        {
            // Clear existing items
            comboBoxEvent.Items.Clear();
            comboBoxUser.Items.Clear ();

            // Fill ComboBox with updated data
            fill_cb_event();
            fill_cb_user();
        }

        private void dgv_peserta_acara_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >=0 && (e.ColumnIndex == dgv_peserta_acara.Columns["col_delete"].Index))
            {
                // ambil data dari baris yang diklik
                int id = e.RowIndex;

                string id_peserta = dgv_peserta_acara.Rows[id].Cells[1].Value.ToString();

                if (e.ColumnIndex == dgv_peserta_acara.Columns["col_delete"].Index)
                {
                    // Tombol Delete diklik
                    // Lakukan sesuatu, misalnya konfirmasi penghapusan
                    txtBoxIdPeserta.Text = id_peserta;
                    col_delete_Click();
                }
            }
        }

        private void col_delete_Click()
        {
            string pesan = $"Anda yakin ingin menghapus data?";
            string judul = "Delete Data";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(pesan, judul, buttons, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Lakukan aksi penghapusan
                string connection = "server=localhost; user id=root; password=; database=db_attendance_ams";
                string query = "DELETE FROM kehadiran WHERE id=@id";
                MySqlConnection conn = new MySqlConnection(connection);
                conn.Open();
                MySqlCommand command = new MySqlCommand(query, conn);
                command.Parameters.AddWithValue("id", this.txtBoxIdPeserta.Text);
                int rowAffected = command.ExecuteNonQuery();
                if (rowAffected > 0)
                {
                    MessageBoxButtons tombol = MessageBoxButtons.OK;
                    MessageBox.Show("Suskes hapus data", "Hapus Data", tombol, MessageBoxIcon.Information);
                }
            }
            btn_load_Click(this, EventArgs.Empty);
        }
    }
}
