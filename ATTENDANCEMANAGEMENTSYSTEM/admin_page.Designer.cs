namespace ATTENDANCEMANAGEMENTSYSTEM
{
    partial class admin_page
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelSidebar = new System.Windows.Forms.Panel();
            this.homeTitle = new System.Windows.Forms.Label();
            this.btn_hadir = new System.Windows.Forms.Button();
            this.btn_event = new System.Windows.Forms.Button();
            this.btn_admin = new System.Windows.Forms.Button();
            this.btn_instructor = new System.Windows.Forms.Button();
            this.btn_member = new System.Windows.Forms.Button();
            this.btn_beranda = new System.Windows.Forms.Button();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.welcomeTxt = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.panelKonten = new System.Windows.Forms.Panel();
            this.btn_peserta_acara = new System.Windows.Forms.Button();
            this.panelSidebar.SuspendLayout();
            this.panelHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSidebar
            // 
            this.panelSidebar.BackColor = System.Drawing.Color.PapayaWhip;
            this.panelSidebar.Controls.Add(this.btn_peserta_acara);
            this.panelSidebar.Controls.Add(this.homeTitle);
            this.panelSidebar.Controls.Add(this.btn_hadir);
            this.panelSidebar.Controls.Add(this.btn_event);
            this.panelSidebar.Controls.Add(this.btn_admin);
            this.panelSidebar.Controls.Add(this.btn_instructor);
            this.panelSidebar.Controls.Add(this.btn_member);
            this.panelSidebar.Controls.Add(this.btn_beranda);
            this.panelSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSidebar.ForeColor = System.Drawing.Color.DarkOrange;
            this.panelSidebar.Location = new System.Drawing.Point(0, 0);
            this.panelSidebar.Name = "panelSidebar";
            this.panelSidebar.Size = new System.Drawing.Size(271, 450);
            this.panelSidebar.TabIndex = 0;
            // 
            // homeTitle
            // 
            this.homeTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeTitle.Location = new System.Drawing.Point(28, 25);
            this.homeTitle.Name = "homeTitle";
            this.homeTitle.Size = new System.Drawing.Size(212, 49);
            this.homeTitle.TabIndex = 6;
            this.homeTitle.Text = "AMS App";
            this.homeTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_hadir
            // 
            this.btn_hadir.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_hadir.Location = new System.Drawing.Point(28, 379);
            this.btn_hadir.Name = "btn_hadir";
            this.btn_hadir.Size = new System.Drawing.Size(212, 42);
            this.btn_hadir.TabIndex = 5;
            this.btn_hadir.Text = "Rekap Kehadiran";
            this.btn_hadir.UseVisualStyleBackColor = true;
            this.btn_hadir.Click += new System.EventHandler(this.btn_hadir_Click);
            // 
            // btn_event
            // 
            this.btn_event.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_event.Location = new System.Drawing.Point(28, 283);
            this.btn_event.Name = "btn_event";
            this.btn_event.Size = new System.Drawing.Size(212, 42);
            this.btn_event.TabIndex = 4;
            this.btn_event.Text = "Event";
            this.btn_event.UseVisualStyleBackColor = true;
            this.btn_event.Click += new System.EventHandler(this.btn_event_Click);
            // 
            // btn_admin
            // 
            this.btn_admin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_admin.Location = new System.Drawing.Point(28, 235);
            this.btn_admin.Name = "btn_admin";
            this.btn_admin.Size = new System.Drawing.Size(212, 42);
            this.btn_admin.TabIndex = 3;
            this.btn_admin.Text = "Data Admin";
            this.btn_admin.UseVisualStyleBackColor = true;
            this.btn_admin.Click += new System.EventHandler(this.btn_admin_Click);
            // 
            // btn_instructor
            // 
            this.btn_instructor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_instructor.Location = new System.Drawing.Point(28, 187);
            this.btn_instructor.Name = "btn_instructor";
            this.btn_instructor.Size = new System.Drawing.Size(212, 42);
            this.btn_instructor.TabIndex = 2;
            this.btn_instructor.Text = "Data Instruktur";
            this.btn_instructor.UseVisualStyleBackColor = true;
            this.btn_instructor.Click += new System.EventHandler(this.btn_instructor_Click);
            // 
            // btn_member
            // 
            this.btn_member.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_member.Location = new System.Drawing.Point(28, 139);
            this.btn_member.Name = "btn_member";
            this.btn_member.Size = new System.Drawing.Size(212, 42);
            this.btn_member.TabIndex = 1;
            this.btn_member.Text = "Data Member";
            this.btn_member.UseVisualStyleBackColor = true;
            this.btn_member.Click += new System.EventHandler(this.btn_member_Click);
            // 
            // btn_beranda
            // 
            this.btn_beranda.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_beranda.Location = new System.Drawing.Point(28, 91);
            this.btn_beranda.Name = "btn_beranda";
            this.btn_beranda.Size = new System.Drawing.Size(212, 42);
            this.btn_beranda.TabIndex = 0;
            this.btn_beranda.Text = "Beranda";
            this.btn_beranda.UseVisualStyleBackColor = true;
            this.btn_beranda.Click += new System.EventHandler(this.btn_beranda_Click);
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.NavajoWhite;
            this.panelHeader.Controls.Add(this.welcomeTxt);
            this.panelHeader.Controls.Add(this.btnLogout);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(271, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(529, 91);
            this.panelHeader.TabIndex = 1;
            // 
            // welcomeTxt
            // 
            this.welcomeTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeTxt.ForeColor = System.Drawing.Color.DarkOrange;
            this.welcomeTxt.Location = new System.Drawing.Point(6, 23);
            this.welcomeTxt.Name = "welcomeTxt";
            this.welcomeTxt.Size = new System.Drawing.Size(277, 45);
            this.welcomeTxt.TabIndex = 1;
            this.welcomeTxt.Text = "Selamat Datang, User";
            this.welcomeTxt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnLogout
            // 
            this.btnLogout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogout.Location = new System.Drawing.Point(412, 25);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(105, 45);
            this.btnLogout.TabIndex = 0;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // panelKonten
            // 
            this.panelKonten.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelKonten.Location = new System.Drawing.Point(271, 91);
            this.panelKonten.Name = "panelKonten";
            this.panelKonten.Size = new System.Drawing.Size(529, 359);
            this.panelKonten.TabIndex = 2;
            // 
            // btn_peserta_acara
            // 
            this.btn_peserta_acara.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_peserta_acara.Location = new System.Drawing.Point(28, 331);
            this.btn_peserta_acara.Name = "btn_peserta_acara";
            this.btn_peserta_acara.Size = new System.Drawing.Size(212, 42);
            this.btn_peserta_acara.TabIndex = 7;
            this.btn_peserta_acara.Text = "Peserta Event";
            this.btn_peserta_acara.UseVisualStyleBackColor = true;
            this.btn_peserta_acara.Click += new System.EventHandler(this.btn_peserta_acara_Click);
            // 
            // admin_page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelKonten);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.panelSidebar);
            this.Name = "admin_page";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "admin_page";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panelSidebar.ResumeLayout(false);
            this.panelHeader.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSidebar;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Panel panelKonten;
        private System.Windows.Forms.Label homeTitle;
        private System.Windows.Forms.Button btn_hadir;
        private System.Windows.Forms.Button btn_event;
        private System.Windows.Forms.Button btn_admin;
        private System.Windows.Forms.Button btn_instructor;
        private System.Windows.Forms.Button btn_member;
        private System.Windows.Forms.Button btn_beranda;
        private System.Windows.Forms.Label welcomeTxt;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btn_peserta_acara;
    }
}