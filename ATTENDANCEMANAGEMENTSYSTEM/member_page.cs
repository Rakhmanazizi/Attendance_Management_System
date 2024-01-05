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
    public partial class member_page : Form
    {
        private beranda_member beranda_Member;
        private history_member history_Member;
        public member_page()
        {
            InitializeComponent();
            txtWelcomeUser.Text = $"Selamat Datang, {UserSession.Username}";

            // inisisalisasi user control
            beranda_Member = new beranda_member();
            history_Member = new history_member();

            // 
            this.Controls.Add(beranda_Member);
            this.Controls.Add(history_Member);

            // tampilkan beranda page pertama kali
            btn_beranda_Click(this, EventArgs.Empty);
        }

        public void hidden_all_user_control()
        {
            beranda_Member.Visible = false;
            history_Member.Visible = false;
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
            beranda_Member.Dock = DockStyle.Fill;
            panelKonten.Controls.Add(beranda_Member);
            beranda_Member.Visible = true;
        }

        private void btn_history_Click(object sender, EventArgs e)
        {
            hidden_all_user_control();
            history_Member.Dock = DockStyle.Fill;
            panelKonten.Controls.Add(history_Member);
            history_Member.Visible = true;
        }
    }
}
