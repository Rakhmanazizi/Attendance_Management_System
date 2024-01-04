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
    public partial class instructor_page : Form
    {
        private beranda_instruktur_uc beranda;
        private data_event_instruktur_uc data_event;
        private data_presensi_instruktur_uc data_presensi;

        public instructor_page()
        {
            InitializeComponent();
            welcomeTextInst.Text = "Selamat datang, " + UserSession.Username;

            // buat inisisalisasai
            beranda = new beranda_instruktur_uc();
            data_event = new data_event_instruktur_uc();
            data_presensi = new data_presensi_instruktur_uc();

            // tambahkan
            this.Controls.Add( beranda );
            this.Controls.Add( data_event );
            this.Controls.Add( data_presensi );

            btn_beranda_Click(this, EventArgs.Empty);
        }

        public void hidden_all_user_control()
        {
            beranda.Visible = false;
            data_presensi.Visible = false;
            data_event.Visible = false;
        }

        private void btn_logout_Click(object sender, EventArgs e)
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

        private void btn_event_Click(object sender, EventArgs e)
        {
            hidden_all_user_control();
            data_event.Dock = DockStyle.Fill;
            panelKonten.Controls.Add(data_event);
            data_event.Visible = true;
        }

        private void btn_presensi_Click(object sender, EventArgs e)
        {
            hidden_all_user_control();
            data_presensi.Dock = DockStyle.Fill;
            panelKonten.Controls.Add(data_presensi);
            data_presensi.Visible = true;
        }
    }
}
