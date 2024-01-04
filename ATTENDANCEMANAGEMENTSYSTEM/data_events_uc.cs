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
        }

        public DataTable fill_data()
        {
            string connection = "server=localhost; user id=root; password=; database=attendance";
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
            string connection = "server=localhost; user id=root; password=; database=attendance";
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
            string connection = "server=localhost; user id=root; password=; database=attendance";
            string query = "SELECT id, nama_lengkap FROM user WHERE role=\"instruktur\"";
            MySqlConnection conn = new MySqlConnection(connection);
            conn.Open();
            MySqlCommand command = new MySqlCommand(query);
        }

        private void btn_tambah_Click(object sender, EventArgs e)
        {
            string connection = "server=localhost; user id=root; password=; database=attendance";
            string query = "INSERT INTO event VALUES('', @nama_event, @tanggal, @tempat, @instruktur)";

            using (MySqlConnection conn = new MySqlConnection(connection))
            {
                conn.Open ();
                using (MySqlCommand command = new MySqlCommand(query, conn))
                {
                    string id_instruktur = this.comboBoxInstruktur.Text.ToString();

                    string[] result = id_instruktur.Split(' ');
                    string get_id = result[0];

                    DateTime date = dateTimePicker1.Value;

                    command.Parameters.AddWithValue("@nama_event", this.textBoxEvent.Text);
                    command.Parameters.AddWithValue("@tanggal", date.ToString("yyyy-MM-dd"));
                    command.Parameters.AddWithValue("@tempat", this.textBoxTempat.Text);
                    command.Parameters.AddWithValue("@instruktur", Convert.ToInt32(get_id));

                    int rowAffected = command.ExecuteNonQuery();
                    if (rowAffected > 0)
                    {
                        MessageBox.Show("Berhasil menambahkan Event Terbaru", "Sukses Tambah Event");
                    }
                }
            }
            btn_load_Click(sender, e);
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            textBoxEvent.Text = string.Empty;
            textBoxTempat.Text = string.Empty;
            comboBoxInstruktur.Text = string.Empty;
            dateTimePicker1.Text = string.Empty;
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
    }
}
