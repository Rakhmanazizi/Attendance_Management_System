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
    public partial class history_member : UserControl
    {
        private string connectionDb = "server=localhost; user id=root; password=; database=db_attendance_ams";
        private string username = UserSession.Username;
        public history_member()
        {
            InitializeComponent();
            dgv_history_event.DataSource = fill_data();
        }

        private int get_user_id()
        {
            int user_id = 0;
            string query = $"SELECT id FROM user WHERE username=@username";
            using (MySqlConnection conn = new MySqlConnection(connectionDb))
            {
                conn.Open();
                using (MySqlCommand command = new MySqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@username", username);

                    object result = command.ExecuteScalar();
                    if (result != null)
                    {
                        user_id = Convert.ToInt32(result);
                    }
                }
            }
            return user_id;
        }

        private string get_user_name()
        {
            string user_full_name = "";
            int user_id = get_user_id();
            string query = "SELECT nama_lengkap FROM user WHERE id=@id";
            using (MySqlConnection conn = new MySqlConnection(connectionDb))
            {
                conn.Open() ;
                using (MySqlCommand command = new MySqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@id", user_id);

                    object result = command.ExecuteScalar();
                    if (result != null)
                    {
                        user_full_name = (string)result;
                    }
                }
            }
                return user_full_name;
        }

        private DataTable fill_data()
        {
            int id_user = get_user_id();
            string query = "SELECT id AS \"No Urut\", nama_peserta AS \"Nama Peserta\", nama_event AS \"Nama Event\", tempat AS \"Tempat\", tanggal AS \"Tanggal\", nama_instruktur AS \"Nama Instruktur\" FROM kehadiran_view WHERE id_user=@id_user";
            MySqlConnection conn = new MySqlConnection (connectionDb);
            conn.Open();
            MySqlCommand command = new MySqlCommand(query, conn);
            command.Parameters.AddWithValue("@id_user", id_user);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            conn.Close();
            return dt;
        }

        private void btn_load_Click(object sender, EventArgs e)
        {
            dgv_history_event.DataSource = fill_data();
        }
    }
}
