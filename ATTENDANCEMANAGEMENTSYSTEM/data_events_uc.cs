using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.Mozilla;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ATTENDANCEMANAGEMENTSYSTEM
{
    public partial class data_events_uc : UserControl
    {
        public data_events_uc()
        {
            InitializeComponent();
            fill_combo_box();
            dgvEvents.DataSource = fill_data();

            DataGridViewButtonColumn col_edit = new DataGridViewButtonColumn();
            col_edit.UseColumnTextForButtonValue = true;
            col_edit.Text = "Edit";
            col_edit.Name = "col_edit";
            dgvEvents.Columns.Add(col_edit);

            DataGridViewButtonColumn col_delete = new DataGridViewButtonColumn();
            col_delete.UseColumnTextForButtonValue = true;
            col_delete.Text = "Hapus";
            col_delete.Name = "col_delete";
            dgvEvents.Columns.Add(col_delete);
        }

        public DataTable fill_data()
        {
            string connection = "server=localhost; user id=root; password=; database=attendance_bc";
            string query = "SELECT * FROM event_view";

            MySqlConnection conn = new MySqlConnection(connection);
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

        public void fill_combo_box()
        {
            string connection = "server=localhost; user id=root; password=; database=attendance_bc";
            string query = "SELECT id, nama_lengkap FROM user WHERE role=\"instruktur\"";

            using (MySqlConnection conn = new MySqlConnection(connection))
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
                            comboBoxInstruktur.Items.Add(id + " " + nama);
                        }
                    }
                }
            }
        }

        public void display_combo_box()
        {
            string connection = "server=localhost; user id=root; password=; database=attendance_bc";
            string query = "SELECT id, nama_lengkap FROM user WHERE role=\"instruktur\"";
            MySqlConnection conn = new MySqlConnection(connection);
            conn.Open();
            MySqlCommand command = new MySqlCommand(query);
        }

        private void btn_tambah_Click(object sender, EventArgs e)
        {
            string connection = "server=localhost; user id=root; password=; database=attendance_bc";
            string query = "INSERT INTO event VALUES('', @nama_event, @tanggal, @tempat, @instruktur, @deskripsi)";

            DateTime date = dateTimePicker1.Value;

            if (this.textBoxEvent.Text == "" || date.ToString("yyyy-MM-dd") == "" || this.textBoxTempat.Text == "" || this.textBoxDeskripsi.Text == "")
            {
                MessageBox.Show("Silakan Isi Kolom Terlebih Dahulu!", "Gagal Tambah Data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            } else
            {
                using (MySqlConnection conn = new MySqlConnection(connection))
                {
                    conn.Open();
                    using (MySqlCommand command = new MySqlCommand(query, conn))
                    {
                        string id_instruktur = this.comboBoxInstruktur.Text.ToString();

                        string[] result = id_instruktur.Split(' ');
                        string get_id = result[0];

                        command.Parameters.AddWithValue("@nama_event", this.textBoxEvent.Text);
                        command.Parameters.AddWithValue("@tanggal", date.ToString("yyyy-MM-dd"));
                        command.Parameters.AddWithValue("@tempat", this.textBoxTempat.Text);
                        command.Parameters.AddWithValue("@instruktur", Convert.ToInt32(get_id));
                        command.Parameters.AddWithValue("@deskripsi", this.textBoxDeskripsi.Text);

                        int rowAffected = command.ExecuteNonQuery();
                        if (rowAffected > 0)
                        {
                            MessageBox.Show("Berhasil menambahkan Event Terbaru", "Sukses Tambah Event");
                        }
                    }
                }
                btn_load_Click(sender, e);
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            textBoxEvent.Text = string.Empty;
            textBoxTempat.Text = string.Empty;
            textBoxDeskripsi.Text = string.Empty;
            comboBoxInstruktur.Text = string.Empty;
            dateTimePicker1.Text = string.Empty;
            textBoxIdEditEvent.Text = string.Empty;
            textBoxDeskripsiEdit.Text = string.Empty;
            textBoxEventEdit.Text = string.Empty;
            textBoxTempatEdit.Text = string.Empty;
        }

        public void refresh_combo_box()
        {
            // Clear existing items
            comboBoxInstruktur.Items.Clear();

            // Fill ComboBox with updated data
            fill_combo_box();
        }

        private void btn_load_Click(object sender, EventArgs e)
        {
            dgvEvents.DataSource = fill_data();
            refresh_combo_box();
            display_combo_box();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dgvEvents_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // periksa apakah sel yang diklik adalah sel dari kolom
            if (e.RowIndex >= 0 && (e.ColumnIndex == dgvEvents.Columns["col_edit"].Index || e.ColumnIndex == dgvEvents.Columns["col_delete"].Index))
            {
                int id = e.RowIndex;
                string id_event = dgvEvents.Rows[id].Cells[2].Value.ToString();
                string nama_event = dgvEvents.Rows[id].Cells[3].Value.ToString();
                string tanggal = dgvEvents.Rows[id].Cells[4].Value.ToString();
                string tempat = dgvEvents.Rows[id].Cells[5].Value.ToString();
                string deskripsi = dgvEvents.Rows[id].Cells[8].Value.ToString();

                if (e.ColumnIndex == dgvEvents.Columns["col_edit"].Index)
                {
                    textBoxIdEditEvent.Text = id_event;
                    textBoxEventEdit.Text = nama_event;
                    textBoxTempatEdit.Text = tempat;
                    textBoxDeskripsiEdit.Text = deskripsi;
                }
                else if (e.ColumnIndex == dgvEvents.Columns["col_delete"].Index)
                {
                    textBoxIdEditEvent.Text = id_event;
                    col_delete_Click();
                    btn_load_Click(sender, e);
                }
            }
        }

        public void col_delete_Click()
        {
            string pesan = "Apakah anda yakin ingin menghapus data ini?";
            string judul = "Hapus Event";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(pesan, judul, buttons, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                string connection = "server=localhost; user id=root; password=; database=attendance_bc";
                string query = "DELETE FROM event WHERE id=@id";
                MySqlConnection conn = new MySqlConnection(connection);
                conn.Open();
                MySqlCommand command = new MySqlCommand(query, conn);
                command.Parameters.AddWithValue("@id", this.textBoxIdEditEvent.Text);

                int rowAffected = command.ExecuteNonQuery();
                if (rowAffected > 0)
                {
                    MessageBoxButtons tombol = MessageBoxButtons.OK;
                    MessageBox.Show("Berhasil menghapus data", "Sukses Hapus", tombol, MessageBoxIcon.Information);
                }
            }

        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            string connection = "server=localhost; user id=root; password=; database=attendance_bc";
            string query = "UPDATE event SET nama_event=@nama_event, tempat=@tempat, tanggal=@tanggal, deskripsi=@deskripsi WHERE id=@id";
            MySqlConnection conn = new MySqlConnection(connection);
            conn.Open();
            MySqlCommand command = new MySqlCommand(query, conn);

            DateTime tanggal = dtp_edit.Value;

            command.Parameters.AddWithValue("@id", this.textBoxIdEditEvent.Text);
            command.Parameters.AddWithValue("@nama_event", this.textBoxEventEdit.Text);
            command.Parameters.AddWithValue("@tempat", this.textBoxTempatEdit.Text);
            command.Parameters.AddWithValue("@tanggal", tanggal.ToString("yyyy-MM-dd"));
            command.Parameters.AddWithValue("@deskripsi", this.textBoxDeskripsiEdit.Text);

            int rowAffected = command.ExecuteNonQuery();
            if (rowAffected > 0)
            {
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show("Berhasil memperbarui data", "Sukses Edit Data", buttons, MessageBoxIcon.Information);
            }
            conn.Clone();
            // secara otomatis menampilkan data terbaru
            btn_load_Click(sender, e);
        }
    }
}
