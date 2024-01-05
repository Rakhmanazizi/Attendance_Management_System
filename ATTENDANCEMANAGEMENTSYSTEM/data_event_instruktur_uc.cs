using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATTENDANCEMANAGEMENTSYSTEM
{
    public partial class data_event_instruktur_uc : UserControl
    {
        private string username_instruktur = UserSession.Username;

        public data_event_instruktur_uc()
        {
            InitializeComponent();
            dgvEventInst.DataSource = fill_data();
            

            DataGridViewButtonColumn col_edit = new DataGridViewButtonColumn();
            col_edit.UseColumnTextForButtonValue = true;
            col_edit.Text = "Edit";
            col_edit.Name = "col_edit";
            dgvEventInst.Columns.Add(col_edit);

            DataGridViewButtonColumn col_delete = new DataGridViewButtonColumn();
            col_delete.UseColumnTextForButtonValue = true;
            col_delete.Text = "Hapus";
            col_delete.Name = "col_delete";
            dgvEventInst.Columns.Add(col_delete);
        }

        private int get_id_instruktur()
        {
            int id_instruktur = 0;
            string connection = "server=localhost; user id=root; password=; database=attendance_bc";
            string query = $"SELECT id FROM user WHERE username=@username";
            using (MySqlConnection conn = new MySqlConnection(connection))
            {
                conn.Open();
                using (MySqlCommand command = new MySqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@username", username_instruktur);

                    object result = command.ExecuteScalar();
                    if (result != null)
                    {
                        id_instruktur = Convert.ToInt32(result);
                    }
                }
            }
            return id_instruktur;
        }

        //private void button1_Click(object sender, EventArgs e)

        private DataTable fill_data()
        {
            string connection = "server=localhost; user id=root; password=; database=attendance_bc";
            string query = $"SELECT * FROM event_view WHERE instruktur=@username";

            int get_id = get_id_instruktur();
            MySqlConnection conn = new MySqlConnection(connection);
            MySqlCommand command = new MySqlCommand(query, conn);
            command.Parameters.AddWithValue("@username", get_id);
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter(command);
            DataTable dataTable = new DataTable();

            try
            {
                conn.Open();
                dataAdapter.Fill(dataTable);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error", ex.Message);
            }
            finally
            {
                conn.Close();
            }

            return dataTable;
        }

        private void btn_tambah_Click(object sender, EventArgs e)
        {
            string connection = "server=localhost; user id=root; password=; database=attendance_bc";
            string query = "INSERT INTO event VALUES('', @nama_event, @tanggal, @tempat, @instruktur, @deskripsi)";

            using (MySqlConnection conn = new MySqlConnection(connection))
            {
                conn.Open();
                using (MySqlCommand command = new MySqlCommand(query, conn))
                {

                    DateTime date = dtp_tanggal.Value;
                    int id_instruktur = get_id_instruktur();

                    command.Parameters.AddWithValue("@nama_event", this.textBoxEvent.Text);
                    command.Parameters.AddWithValue("@tanggal", date.ToString("yyyy-MM-dd"));
                    command.Parameters.AddWithValue("@tempat", this.textBoxTempat.Text);
                    command.Parameters.AddWithValue("@instruktur", id_instruktur);
                    command.Parameters.AddWithValue("@deskripsi", this.textBoxDeksripsi.Text);

                    int rowAffected = command.ExecuteNonQuery();
                    if (rowAffected > 0)
                    {
                        MessageBox.Show("Berhasil menambahkan Event Terbaru", "Sukses Tambah Event");
                    }
                }
            }
            btn_load_Click(sender, e);
        }

        private void btn_load_Click(object sender, EventArgs e)
        {
            dgvEventInst.DataSource = fill_data();
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            textBoxDeksripsi.Text = string.Empty;
            textBoxEvent.Text = string.Empty;
            textBoxTempat.Text = string.Empty;
            textBoxDeskripsiEdit.Text = string.Empty;
            textBoxEventEdit.Text = string.Empty;
            textBoxTempatEdit.Text = string.Empty;
            textBoxIdEditEvent.Text = string.Empty;
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
                if(rowAffected > 0)
                {
                    MessageBoxButtons tombol = MessageBoxButtons.OK;
                    MessageBox.Show("Berhasil menghapus data", "Sukses Hapus", tombol, MessageBoxIcon.Information );
                }
            }
            
        }

        private void dgvEventInst_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // periksa apakah sel yang diklik adalah sel dari kolom
            if (e.RowIndex >= 0 && (e.ColumnIndex == dgvEventInst.Columns["col_edit"].Index || e.ColumnIndex == dgvEventInst.Columns["col_delete"].Index))
            {
                int id = e.RowIndex;
                string id_event = dgvEventInst.Rows[id].Cells[2].Value.ToString();
                string nama_event = dgvEventInst.Rows[id].Cells[3].Value.ToString();
                string tanggal = dgvEventInst.Rows[id].Cells[4].Value.ToString();
                string tempat = dgvEventInst.Rows[id].Cells[5].Value.ToString();
                string deskripsi = dgvEventInst.Rows[id].Cells[7].Value.ToString();

                if (e.ColumnIndex == dgvEventInst.Columns["col_edit"].Index)
                {
                    textBoxIdEditEvent.Text = id_event;
                    textBoxEventEdit.Text = nama_event;
                    textBoxTempatEdit.Text = tempat;
                    textBoxDeskripsiEdit.Text = deskripsi;
                }
                else if (e.ColumnIndex == dgvEventInst.Columns["col_delete"].Index)
                {
                    textBoxIdEditEvent.Text = id_event;
                    col_delete_Click();
                    btn_load_Click(sender, e);
                }
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
    
}
