using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace ATTENDANCEMANAGEMENTSYSTEM
{
    public partial class data_user_uc : UserControl
    {
        private object sender;
        private EventArgs e;

        public data_user_uc()
        {
            InitializeComponent();
            //this.Edit.Click += new System.EventHandler(this.Edit_Click);
            fill_data();
            DataGridViewButtonColumn col_edit = new DataGridViewButtonColumn();
            col_edit.UseColumnTextForButtonValue = true;
            col_edit.Text = "Edit";
            col_edit.Name = "col_edit";
            dgvDataMember.Columns.Add(col_edit);

            DataGridViewButtonColumn col_delete = new DataGridViewButtonColumn();
            col_delete.UseColumnTextForButtonValue = true;
            col_delete.Text = "Hapus";
            col_delete.Name = "col_delete";
            dgvDataMember.Columns.Add(col_delete);

            //dgvDataMember.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDataMember_CellContentClick);
        }

        private void btn_tambah_Click(object sender, EventArgs e)
        {
            string connection = "server=localhost; user id=root; password=; database=attendance";
            string query = "INSERT INTO user (nama_lengkap, username, password, role) VALUES(@nama_lengkap, @username, @password, \"member\")";

            if (this.textBoxNamaLengkap.Text == "" || this.textBoxUsername.Text == "" || this.textBoxPassword.Text == "")
            {
                MessageBox.Show("Silakan isi kolom terlebih dahulu", "Gagal Tambah Data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            } else
            {
                using (MySqlConnection conn = new MySqlConnection(connection))
                {
                    conn.Open();
                    using (MySqlCommand command = new MySqlCommand(query, conn))
                    {
                        try
                        {
                            command.Parameters.AddWithValue("@nama_lengkap", this.textBoxNamaLengkap.Text);
                            command.Parameters.AddWithValue("@username", this.textBoxUsername.Text);
                            command.Parameters.AddWithValue("@password", this.textBoxPassword.Text);

                            int rowAffected = command.ExecuteNonQuery();
                            if (rowAffected > 0)
                            {
                                string pesan = "Berhasil menambahkan data member";
                                string judul = "Sukses Tambah Member";
                                MessageBoxButtons buttons = MessageBoxButtons.OK;
                                MessageBox.Show(pesan, judul, buttons, MessageBoxIcon.Information);
                                btn_load_Click(sender, e);
                            }
                        }
                        catch (MySqlException ex)
                        {
                            if (ex.Number == 1062)
                            {
                                // Menggunakan ekspresi reguler untuk mengekstrak informasi dari pesan kesalahan
                                var match = Regex.Match(ex.Message, @"Duplicate entry '(.*?)' for key '(.*?)'");
                                if (match.Success)
                                {
                                    string duplicateEntry = match.Groups[1].Value;
                                    string keyName = match.Groups[2].Value;
                                    string psn = "";
                                    if (keyName == "password_unique")
                                    {
                                        psn = "password";
                                    }
                                    else
                                    {
                                        psn = "username";
                                    }

                                    string pesan = $"{psn} {duplicateEntry} sudah dipakai. Silakan isi dengan yang lain";
                                    string judul = "Error Duplikat";
                                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                                    MessageBox.Show(pesan, judul, buttons, MessageBoxIcon.Error);
                                }
                            }
                        }
                    }
                    conn.Close();
                }
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            textBoxNamaLengkap.Text = string.Empty;
            textBoxUsername.Text = string.Empty;
            textBoxPassword.Text = string.Empty;

            textBoxUserEdit.Text = string.Empty;
            textBoxIdEdit.Text = string.Empty;
            textBoxNamaEdit.Text = string.Empty;
            textBoxPassEdit.Text = string.Empty;
        }

        public DataTable get_data_member()
        {
            string connection = "server=localhost; user id=root; password=; database=attendance";
            string query = "SELECT * FROM user WHERE role=\"member\"";

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

        public void fill_data()
        {
            dgvDataMember.DataSource = get_data_member();
        }

        private void btn_load_Click(object sender, EventArgs e)
        {
            fill_data();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Edit_Click(object sender, EventArgs e)
        {
            string connection = "server=localhost; user id=root; password=; database=attendance";
            string query = "UPDATE user SET nama_lengkap=@nama_lengkap, username=@username, password=@password WHERE id=@id";

            MySqlConnection conn = new MySqlConnection(connection);
            conn.Open();
            MySqlCommand command = new MySqlCommand(query, conn);
            command.Parameters.AddWithValue("@id", Convert.ToInt32(this.textBoxIdEdit.Text));
            command.Parameters.AddWithValue("@nama_lengkap", this.textBoxNamaEdit.Text);
            command.Parameters.AddWithValue("@username", this.textBoxUserEdit.Text);
            command.Parameters.AddWithValue("@password", this.textBoxPassEdit.Text);

            int rowAffected = command.ExecuteNonQuery();
            if (rowAffected > 0)
            {
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show("Berhasil memperbarui data", "Sukses Edit Data", buttons, MessageBoxIcon.Information);
            }
            // secara otomatis menampilkan data terbaru
            btn_load_Click(sender, e);
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
                string connection = "server=localhost; user id=root; password=; database=attendance";
                string query = "DELETE FROM user WHERE id=@id";
                MySqlConnection conn = new MySqlConnection(connection);
                conn.Open();
                MySqlCommand command = new MySqlCommand(query, conn);
                command.Parameters.AddWithValue("id", this.txtBxIdUs.Text);
                int rowAffected = command.ExecuteNonQuery();
                if (rowAffected > 0)
                {
                    MessageBoxButtons tombol = MessageBoxButtons.OK;
                    MessageBox.Show("Suskes hapus data", "Hapus Data", tombol, MessageBoxIcon.Information);
                }
            }

            btn_load_Click(sender, e);
        }

        private void btn_load_Click(object sender, object e)
        {
            throw new NotImplementedException();
        }

        private void dgvDataMember_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Periksa apakah sel yang diklik adalah sel dari kolom tombol
            if (e.RowIndex >= 0 && (e.ColumnIndex == dgvDataMember.Columns["col_edit"].Index || e.ColumnIndex == dgvDataMember.Columns["col_delete"].Index))
            {
                // Ambil data dari baris yang diklik
                int id = e.RowIndex;
                /*string nama = dgvDataMember.Rows[id].Cells["NamaColumn"].Value.ToString();
                string username = dgvDataMember.Rows[id].Cells["UsernameColumn"].Value.ToString();
                string password = dgvDataMember.Rows[id].Cells["PasswordColumn"].Value.ToString();
                */
                // int id = Convert.ToInt32(dgvDataMember.CurrentCell.RowIndex.ToString());
                string id_user = dgvDataMember.Rows[id].Cells[2].Value.ToString();
                string username  = dgvDataMember.Rows[id].Cells[3].Value.ToString();
                string nama_lengkap   = dgvDataMember.Rows[id].Cells[4].Value.ToString();
                string password  = dgvDataMember.Rows[id].Cells[5].Value.ToString();

                // Lakukan sesuatu berdasarkan tombol yang diklik
                if (e.ColumnIndex == dgvDataMember.Columns["col_edit"].Index)
                {
                    // Tombol Edit diklik
                    // Lakukan sesuatu, misalnya tampilkan data di TextBox
                    textBoxIdEdit.Text = id_user;
                    textBoxNamaEdit.Text = nama_lengkap;
                    textBoxUserEdit.Text = username;
                    textBoxPassEdit.Text = password;
                }
                else if (e.ColumnIndex == dgvDataMember.Columns["col_delete"].Index)
                {
                    // Tombol Delete diklik
                    // Lakukan sesuatu, misalnya konfirmasi penghapusan
                    txtBxIdUs.Text = id_user;
                    col_delete_Click();
                }
            }
        }

        private void btn_clear_edit_Click(object sender, EventArgs e)
        {
            textBoxIdEdit.Text = string.Empty;
            textBoxNamaEdit.Text = string.Empty;
            textBoxPassEdit.Text = string.Empty;
            textBoxUserEdit.Text = string.Empty;
        }
    }
}
