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
        private string connectionDb = "server=localhost; user id=root; password=; database=attendance";
        public peserta_acara_uc()
        {
            InitializeComponent();
            fill_cb_event();
            fill_cb_user();
            dgv_peserta_acara.DataSource = fill_data();

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
            string query = "INSERT INTO kehadiran (id_event, id_user) VALUES (@event, @user)";
            using (MySqlConnection conn = new MySqlConnection(connectionDb))
            {
                conn.Open();
                using (MySqlCommand command = new MySqlCommand(query, conn))
                {
                    string id_event = this.comboBoxEvent.Text.ToString();
                    string[] result_id_event = id_event.Split(' ');
                    string get_id_event = result_id_event[0];

                    string id_user = this.comboBoxUser.Text.ToString();
                    string[] result_id_user = id_user.Split(' ');
                    string get_id_user = result_id_user[0];

                    command.Parameters.AddWithValue("@event", Convert.ToInt32(get_id_event));
                    command.Parameters.AddWithValue("@user", Convert.ToInt32(get_id_user));

                    int rowAffected = command.ExecuteNonQuery();
                    if (rowAffected > 0)
                    {
                        MessageBox.Show("Berhasil menambahkan Partisipan Baru!", "Sukses Tambah Event");
                    }
                }
            }
            btn_load_Click(sender, e);
        }

        public DataTable fill_data()
        {
            string query = "SELECT * FROM kehadiran_view";

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
        }
    }
}
