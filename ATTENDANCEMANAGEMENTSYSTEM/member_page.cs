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
        public member_page()
        {
            InitializeComponent();
            txtWelcomeUser.Text = $"Selamat Datang, {UserSession.Username}";
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
    }
}
