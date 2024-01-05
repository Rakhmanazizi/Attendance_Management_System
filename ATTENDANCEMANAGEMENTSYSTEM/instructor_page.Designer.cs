namespace ATTENDANCEMANAGEMENTSYSTEM
{
    partial class instructor_page
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
            this.btn_presensi = new System.Windows.Forms.Button();
            this.btn_event = new System.Windows.Forms.Button();
            this.btn_beranda = new System.Windows.Forms.Button();
            this.homeTitle = new System.Windows.Forms.Label();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.btn_logout = new System.Windows.Forms.Button();
            this.panelKonten = new System.Windows.Forms.Panel();
            this.welcome_user = new System.Windows.Forms.Label();
            this.panelSidebar.SuspendLayout();
            this.panelHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSidebar
            // 
            this.panelSidebar.BackColor = System.Drawing.Color.PapayaWhip;
            this.panelSidebar.Controls.Add(this.btn_presensi);
            this.panelSidebar.Controls.Add(this.btn_event);
            this.panelSidebar.Controls.Add(this.btn_beranda);
            this.panelSidebar.Controls.Add(this.homeTitle);
            this.panelSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSidebar.Location = new System.Drawing.Point(0, 0);
            this.panelSidebar.Name = "panelSidebar";
            this.panelSidebar.Size = new System.Drawing.Size(271, 450);
            this.panelSidebar.TabIndex = 0;
            // 
            // btn_presensi
            // 
            this.btn_presensi.Location = new System.Drawing.Point(32, 229);
            this.btn_presensi.Name = "btn_presensi";
            this.btn_presensi.Size = new System.Drawing.Size(193, 56);
            this.btn_presensi.TabIndex = 11;
            this.btn_presensi.Text = "Rekap Kehadiran";
            this.btn_presensi.UseVisualStyleBackColor = true;
            this.btn_presensi.Click += new System.EventHandler(this.btn_presensi_Click);
            // 
            // btn_event
            // 
            this.btn_event.Location = new System.Drawing.Point(32, 167);
            this.btn_event.Name = "btn_event";
            this.btn_event.Size = new System.Drawing.Size(193, 56);
            this.btn_event.TabIndex = 10;
            this.btn_event.Text = "Data Event";
            this.btn_event.UseVisualStyleBackColor = true;
            this.btn_event.Click += new System.EventHandler(this.btn_event_Click);
            // 
            // btn_beranda
            // 
            this.btn_beranda.Location = new System.Drawing.Point(32, 105);
            this.btn_beranda.Name = "btn_beranda";
            this.btn_beranda.Size = new System.Drawing.Size(193, 56);
            this.btn_beranda.TabIndex = 9;
            this.btn_beranda.Text = "Beranda";
            this.btn_beranda.UseVisualStyleBackColor = true;
            this.btn_beranda.Click += new System.EventHandler(this.btn_beranda_Click);
            // 
            // homeTitle
            // 
            this.homeTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeTitle.ForeColor = System.Drawing.Color.DarkOrange;
            this.homeTitle.Location = new System.Drawing.Point(27, 26);
            this.homeTitle.Name = "homeTitle";
            this.homeTitle.Size = new System.Drawing.Size(212, 49);
            this.homeTitle.TabIndex = 8;
            this.homeTitle.Text = "AMS App";
            this.homeTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.NavajoWhite;
            this.panelHeader.Controls.Add(this.welcome_user);
            this.panelHeader.Controls.Add(this.btn_logout);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(271, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(529, 91);
            this.panelHeader.TabIndex = 1;
            // 
            // btn_logout
            // 
            this.btn_logout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_logout.Location = new System.Drawing.Point(412, 24);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(105, 45);
            this.btn_logout.TabIndex = 1;
            this.btn_logout.Text = "Logout";
            this.btn_logout.UseVisualStyleBackColor = true;
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // panelKonten
            // 
            this.panelKonten.BackColor = System.Drawing.Color.Bisque;
            this.panelKonten.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelKonten.Location = new System.Drawing.Point(271, 91);
            this.panelKonten.Name = "panelKonten";
            this.panelKonten.Size = new System.Drawing.Size(529, 359);
            this.panelKonten.TabIndex = 2;
            // 
            // welcome_user
            // 
            this.welcome_user.AutoSize = true;
            this.welcome_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcome_user.ForeColor = System.Drawing.Color.DarkOrange;
            this.welcome_user.Location = new System.Drawing.Point(49, 36);
            this.welcome_user.Name = "welcome_user";
            this.welcome_user.Size = new System.Drawing.Size(53, 21);
            this.welcome_user.TabIndex = 2;
            this.welcome_user.Text = "label1";
            // 
            // instructor_page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelKonten);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.panelSidebar);
            this.Name = "instructor_page";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "instructor_page";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panelSidebar.ResumeLayout(false);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSidebar;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Panel panelKonten;
        private System.Windows.Forms.Label homeTitle;
        private System.Windows.Forms.Button btn_logout;
        private System.Windows.Forms.Button btn_presensi;
        private System.Windows.Forms.Button btn_event;
        private System.Windows.Forms.Button btn_beranda;
        private System.Windows.Forms.Label welcome_user;
    }
}