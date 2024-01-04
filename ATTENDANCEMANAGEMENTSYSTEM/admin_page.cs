using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATTENDANCEMANAGEMENTSYSTEM
{
    public partial class admin_page : Form
    {
        private beranda_uc beranda;
        private data_user_uc data_user;
        private data_instructor_uc data_instructor;
        private data_admin_uc data_admin;
        private data_events_uc data_events;
        private data_presensi_uc data_presensi;
        private peserta_acara_uc peserta_acara;

        public admin_page()
        {
            InitializeComponent();
            welcomeTxt.Text = $"Selamat Datang, {UserSession.Username}";

            // inisialisasi user control
            beranda = new beranda_uc(); ;
            data_user = new data_user_uc();
            data_instructor = new data_instructor_uc();
            data_admin = new data_admin_uc();
            data_events = new data_events_uc();
            data_presensi = new data_presensi_uc();
            peserta_acara = new peserta_acara_uc();

            // tambahkan user control
            this.Controls.Add( beranda );
            this.Controls.Add( data_user );
            this.Controls.Add( data_instructor );
            this.Controls.Add( data_admin );
            this.Controls.Add( data_events );
            this.Controls.Add( data_presensi );
            this.Controls.Add( peserta_acara );

            btn_beranda_Click(this, EventArgs.Empty);
        }

        public void hidden_all_user_control()
        {
            beranda.Visible = false;
            data_user.Visible = false;
            data_admin.Visible = false;
            data_instructor.Visible = false;
            data_events.Visible = false;
            data_presensi.Visible = false;
            peserta_acara.Visible = false;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            string pesan = "Anda yakin ingin keluar dari sistem?";
            string judul = "Konfirmasi Logout";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(pesan, judul, buttons, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                UserSession.clearSession();
                this.Hide();
                login_page login_Page = new login_page();
                login_Page.Show();
            }
            
        }

        private void btn_beranda_Click(object sender, EventArgs e)
        {
            hidden_all_user_control();
            beranda.Dock = DockStyle.Fill;
            panelKonten.Controls.Add(beranda);
            beranda.Visible = true;
        }

        private void btn_member_Click(object sender, EventArgs e)
        {
            hidden_all_user_control();
            data_user.Dock = DockStyle.Fill;
            panelKonten.Controls.Add(data_user);
            data_user.Visible = true;
        }

        private void btn_instructor_Click(object sender, EventArgs e)
        {
            hidden_all_user_control();
            data_instructor.Dock = DockStyle.Fill;
            panelKonten.Controls.Add(data_instructor);
            data_instructor.Visible = true;
        }

        private void btn_admin_Click(object sender, EventArgs e)
        {
            hidden_all_user_control();
            data_admin.Dock = DockStyle.Fill;
            panelKonten.Controls.Add(data_admin);
            data_admin.Visible = true;
        }

        private void btn_event_Click(object sender, EventArgs e)
        {
            hidden_all_user_control();
            data_events.Dock = DockStyle.Fill;
            panelKonten.Controls.Add(data_events);
            data_events.Visible = true;
        }

        private void btn_peserta_acara_Click(object sender, EventArgs e)
        {
            hidden_all_user_control();
            peserta_acara.Dock = DockStyle.Fill;
            panelKonten.Controls.Add(peserta_acara);
            peserta_acara.Visible = true;
        }

        private void btn_hadir_Click(object sender, EventArgs e)
        {
            hidden_all_user_control();
            data_presensi.Dock = DockStyle.Fill;
            panelKonten.Controls.Add(data_presensi);
            data_presensi.Visible = true;
        }
    }
}
