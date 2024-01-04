using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ATTENDANCEMANAGEMENTSYSTEM
{
    public partial class login_page : Form
    {
        public login_page()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            // membuat variabel koneksi untuk megambil data MySql
            string connection = "server=localhost; user id=root; password=; database=attendance";
            // membuat query SELECT
            string query = "SELECT * FROM user WHERE username=@username AND password=@password AND role=@role";

            // membuat koneksi dengan MySql
            using (MySqlConnection conn = new MySqlConnection(connection))
            {
                // membuka koneksi
                conn.Open();
                using (MySqlCommand command = new MySqlCommand(query, conn))
                {
                    try
                    {
                        // gunakan paramter
                        command.Parameters.AddWithValue("@username", this.textBoxUsername.Text);
                        command.Parameters.AddWithValue("@password", this.textBoxPassword.Text);
                        command.Parameters.AddWithValue("@role", this.comboBoxRoleUser.SelectedItem);

                        command.ExecuteNonQuery();
                        DataTable dt = new DataTable();
                        MySqlDataAdapter dataAdapter = new MySqlDataAdapter(command);
                        dataAdapter.Fill(dt);
                        int i = 0;
                        i = Convert.ToInt32(dt.Rows.Count.ToString());
                        if (i > 0)
                        {
                            string role = comboBoxRoleUser.SelectedItem.ToString();
                            UserSession.setLogin(this.textBoxUsername.Text);
                            String pesan = "Berhasil Masuk ke Sistem";
                            string judul = "Sukses Login";
                            MessageBoxButtons buttons = MessageBoxButtons.OK;
                            MessageBox.Show(pesan, judul, buttons, MessageBoxIcon.Information);
                            this.Hide();
                            switch (role)
                            {
                                case "admin":
                                    admin_page admin_Page = new admin_page();
                                    admin_Page.Show();
                                    break;
                                case "instruktur":
                                    instructor_page instructor_Page = new instructor_page();
                                    instructor_Page.Show();
                                    break;
                                case "member":
                                    member_page member_Page = new member_page();
                                    member_Page.Show();
                                    break;
                            }
                        } else
                        {
                            string pesan = "Gagal Login. Username dan Password tidak tersedia";
                            string judul = "Gagal Login";
                            MessageBoxButtons buttons = MessageBoxButtons.OK;
                            MessageBox.Show(pesan, judul, buttons, MessageBoxIcon.Warning);
                        }
                    }
                    catch (Exception)
                    {
                        
                    }
                    finally
                    {
                        conn.Close();
                    }
                }
            }
        }

        private void login_page_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
