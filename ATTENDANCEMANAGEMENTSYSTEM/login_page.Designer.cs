namespace ATTENDANCEMANAGEMENTSYSTEM
{
    partial class login_page
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.comboBoxRoleUser = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_login = new System.Windows.Forms.Button();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBoxTampilPass = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkOrange;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 107);
            this.panel1.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(135, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(524, 32);
            this.label4.TabIndex = 0;
            this.label4.Text = "ATTENDACE MANAGEMENT SYSTEM";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel2.BackColor = System.Drawing.Color.BurlyWood;
            this.panel2.Controls.Add(this.checkBoxTampilPass);
            this.panel2.Controls.Add(this.comboBoxRoleUser);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.btn_login);
            this.panel2.Controls.Add(this.textBoxPassword);
            this.panel2.Controls.Add(this.textBoxUsername);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(140, 142);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(519, 405);
            this.panel2.TabIndex = 1;
            // 
            // comboBoxRoleUser
            // 
            this.comboBoxRoleUser.FormattingEnabled = true;
            this.comboBoxRoleUser.Items.AddRange(new object[] {
            "admin",
            "instruktur",
            "member"});
            this.comboBoxRoleUser.Location = new System.Drawing.Point(154, 203);
            this.comboBoxRoleUser.Name = "comboBoxRoleUser";
            this.comboBoxRoleUser.Size = new System.Drawing.Size(264, 24);
            this.comboBoxRoleUser.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(61, 211);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "Role User\r\n";
            // 
            // btn_login
            // 
            this.btn_login.Location = new System.Drawing.Point(177, 320);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(159, 53);
            this.btn_login.TabIndex = 5;
            this.btn_login.Text = "LOGIN";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(154, 148);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(264, 22);
            this.textBoxPassword.TabIndex = 4;
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Location = new System.Drawing.Point(154, 89);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(264, 22);
            this.textBoxUsername.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Pasword";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Username";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(172, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "LOGIN FORM";
            // 
            // checkBoxTampilPass
            // 
            this.checkBoxTampilPass.AutoSize = true;
            this.checkBoxTampilPass.Location = new System.Drawing.Point(64, 252);
            this.checkBoxTampilPass.Name = "checkBoxTampilPass";
            this.checkBoxTampilPass.Size = new System.Drawing.Size(153, 20);
            this.checkBoxTampilPass.TabIndex = 8;
            this.checkBoxTampilPass.Text = "Tampilkan Password";
            this.checkBoxTampilPass.UseVisualStyleBackColor = true;
            // this.checkBoxTampilPass.CheckedChanged += new System.EventHandler(this.checkBoxTampilPass_CheckedChanged);
            // 
            // login_page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 510);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "login_page";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.login_page_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxRoleUser;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox checkBoxTampilPass;
    }
}

