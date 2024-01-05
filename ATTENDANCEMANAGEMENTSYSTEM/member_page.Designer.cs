namespace ATTENDANCEMANAGEMENTSYSTEM
{
    partial class member_page
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
            this.panelHeader = new System.Windows.Forms.Panel();
            this.txtWelcomeUser = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.panelKonten = new System.Windows.Forms.Panel();
            this.btn_beranda = new System.Windows.Forms.Button();
            this.btn_history = new System.Windows.Forms.Button();
            this.panelSidebar.SuspendLayout();
            this.panelHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSidebar
            // 
            this.panelSidebar.BackColor = System.Drawing.Color.PapayaWhip;
            this.panelSidebar.Controls.Add(this.btn_history);
            this.panelSidebar.Controls.Add(this.btn_beranda);
            this.panelSidebar.Controls.Add(this.homeTitle);
            this.panelSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSidebar.Location = new System.Drawing.Point(0, 0);
            this.panelSidebar.Name = "panelSidebar";
            this.panelSidebar.Size = new System.Drawing.Size(271, 450);
            this.panelSidebar.TabIndex = 1;
            // 
            // homeTitle
            // 
            this.homeTitle.BackColor = System.Drawing.Color.NavajoWhite;
            this.homeTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeTitle.ForeColor = System.Drawing.Color.DarkOrange;
            this.homeTitle.Location = new System.Drawing.Point(27, 25);
            this.homeTitle.Name = "homeTitle";
            this.homeTitle.Size = new System.Drawing.Size(212, 49);
            this.homeTitle.TabIndex = 7;
            this.homeTitle.Text = "AMS App";
            this.homeTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.NavajoWhite;
            this.panelHeader.Controls.Add(this.txtWelcomeUser);
            this.panelHeader.Controls.Add(this.btnLogout);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(271, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(529, 91);
            this.panelHeader.TabIndex = 2;
            // 
            // txtWelcomeUser
            // 
            this.txtWelcomeUser.AutoSize = true;
            this.txtWelcomeUser.Location = new System.Drawing.Point(37, 39);
            this.txtWelcomeUser.Name = "txtWelcomeUser";
            this.txtWelcomeUser.Size = new System.Drawing.Size(44, 16);
            this.txtWelcomeUser.TabIndex = 2;
            this.txtWelcomeUser.Text = "label1";
            // 
            // btnLogout
            // 
            this.btnLogout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogout.Location = new System.Drawing.Point(412, 25);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(105, 45);
            this.btnLogout.TabIndex = 1;
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
            this.panelKonten.TabIndex = 3;
            // 
            // btn_beranda
            // 
            this.btn_beranda.Location = new System.Drawing.Point(32, 128);
            this.btn_beranda.Name = "btn_beranda";
            this.btn_beranda.Size = new System.Drawing.Size(207, 55);
            this.btn_beranda.TabIndex = 8;
            this.btn_beranda.Text = "Beranda";
            this.btn_beranda.UseVisualStyleBackColor = true;
            this.btn_beranda.Click += new System.EventHandler(this.btn_beranda_Click);
            // 
            // btn_history
            // 
            this.btn_history.Location = new System.Drawing.Point(32, 189);
            this.btn_history.Name = "btn_history";
            this.btn_history.Size = new System.Drawing.Size(207, 55);
            this.btn_history.TabIndex = 9;
            this.btn_history.Text = "Riwayat Acara";
            this.btn_history.UseVisualStyleBackColor = true;
            this.btn_history.Click += new System.EventHandler(this.btn_history_Click);
            // 
            // member_page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelKonten);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.panelSidebar);
            this.Name = "member_page";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "member_page";
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
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label txtWelcomeUser;
        private System.Windows.Forms.Button btn_history;
        private System.Windows.Forms.Button btn_beranda;
    }
}