using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATTENDANCEMANAGEMENTSYSTEM
{
    public partial class data_presensi_uc : UserControl
    {
        private string connectionDb = "server=localhost; user id=root; password=; database=attendance_bc";
        public data_presensi_uc()
        {
            InitializeComponent();
            btn_load_Click(this, EventArgs.Empty);

            DataGridViewButtonColumn col_edit = new DataGridViewButtonColumn();
            col_edit.UseColumnTextForButtonValue = true;
            col_edit.Text = "Edit Status";
            col_edit.Name = "col_edit";
            dgv_rekap_kehadiran.Columns.Add(col_edit);
        }

        private DataTable fill_data()
        {
            DataTable dataTable = new DataTable();
            string query = "SELECT id AS \"No Urut\", nama_peserta AS \"Nama Peserta\",nama_event AS \"Nama Acara\", tempat, tanggal, nama_instruktur AS \"Nama Instruktur\", status FROM kehadiran_view";
            MySqlConnection conn = new MySqlConnection(connectionDb);
            conn.Open();
            MySqlCommand command = new MySqlCommand(query, conn);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            adapter.Fill(dataTable);
            return dataTable;
        }

        private void btn_load_Click(object sender, EventArgs e)
        {
            dgv_rekap_kehadiran.DataSource = fill_data();
        }

        private void dgv_rekap_kehadiran_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && (e.ColumnIndex == dgv_rekap_kehadiran.Columns["col_edit"].Index))
            {
                // ambil data dari baris yang diklik
                int id = e.RowIndex;

                string id_hadir = dgv_rekap_kehadiran.Rows[id].Cells[1].Value.ToString();
                string nama_peserta = dgv_rekap_kehadiran.Rows[id].Cells[2].Value.ToString();
                string nama_event = dgv_rekap_kehadiran.Rows[id].Cells[3].Value.ToString();
                string status_kehadiran = dgv_rekap_kehadiran.Rows[id].Cells[7].Value.ToString();

                // jika klik tombol edit maka akan tampil data baris yang diklik
                if (e.ColumnIndex == dgv_rekap_kehadiran.Columns["col_edit"].Index)
                {
                    textBoxIdKehadiran.Text = id_hadir;
                    textBoxNamaAcara.Text = nama_event;
                    textBoxNamaPeserta.Text = nama_peserta;
                    comboBoxStatusKehadiran.Text = status_kehadiran;
                }
            }
        }

        private void btn_simpan_Click(object sender, EventArgs e)
        {
            string query = "UPDATE kehadiran SET status=@status_kehadiran WHERE id=@id";
            MySqlConnection conn = new MySqlConnection(connectionDb);
            conn.Open();
            MySqlCommand command = new MySqlCommand(query, conn);
            command.Parameters.AddWithValue("@id", this.textBoxIdKehadiran.Text);
            command.Parameters.AddWithValue("@status_kehadiran", this.comboBoxStatusKehadiran.SelectedItem);
            int rowAffected = command.ExecuteNonQuery();
            if (rowAffected > 0)
            {
                MessageBox.Show("Berhasil Menandai Kehadiran Peserta", "Sukses Tandai Kehadiran", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            btn_load_Click(sender, e);
        }

        private void btn_export_csv_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "CSV files (*.csv)|*.csv";
            saveFileDialog.Title = "Export ke CSV";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;

                // Ambil data dari database sesuai nama event, waktu, dan instruktur
                DataTable dataTable = ambil_data_export();

                // Simpan data ke CSV
                simpan_data_csv(dataTable, filePath);

                MessageBox.Show("Data berhasil diekspor ke CSV.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private DataTable ambil_data_export()
        {
            // Sesuaikan query sesuai dengan kebutuhan Anda
            string query = "SELECT nama_event AS Event, tanggal AS Waktu, nama_instruktur AS Instruktur, " +
                           "COUNT(DISTINCT id_user) AS Jumlah_Peserta, " +
                           "SUM(CASE WHEN status = 'Hadir' THEN 1 ELSE 0 END) AS Jumlah_Hadir, " +
                           "SUM(CASE WHEN status = 'Telat' THEN 1 ELSE 0 END) AS Jumlah_Telat, " +
                           "SUM(CASE WHEN status = 'Absen' THEN 1 ELSE 0 END) AS Jumlah_Absen " +
                           "FROM kehadiran_view " +
                           "GROUP BY nama_event, tanggal, nama_instruktur";

            MySqlConnection conn = new MySqlConnection(connectionDb);
            conn.Open();
            MySqlCommand command = new MySqlCommand(query, conn);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            conn.Close();

            return dataTable;
        }

        private void simpan_data_csv(DataTable dataTable, string filePath)
        {
            try
            {
                StringBuilder sb = new StringBuilder();

                // Menulis header
                IEnumerable<string> columnNames = dataTable.Columns.Cast<DataColumn>().Select(column => column.ColumnName);
                sb.AppendLine(string.Join(",", columnNames));

                // Menulis baris data
                foreach (DataRow row in dataTable.Rows)
                {
                    IEnumerable<string> fields = row.ItemArray.Select(field => field.ToString());
                    sb.AppendLine(string.Join(",", fields));
                }

                File.WriteAllText(filePath, sb.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Terjadi kesalahan saat menyimpan data ke file CSV: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
