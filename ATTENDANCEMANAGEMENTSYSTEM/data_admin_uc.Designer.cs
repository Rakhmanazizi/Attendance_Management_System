namespace ATTENDANCEMANAGEMENTSYSTEM
{
    partial class data_admin_uc
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_load = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dgvDataAdmin = new System.Windows.Forms.DataGridView();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_tambah = new System.Windows.Forms.Button();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.textBoxNamaLengkap = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBxId = new System.Windows.Forms.TextBox();
            this.btn_clear_edit = new System.Windows.Forms.Button();
            this.textBoxPassEdit = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Edit = new System.Windows.Forms.Button();
            this.textBoxUserEdit = new System.Windows.Forms.TextBox();
            this.textBoxNamaEdit = new System.Windows.Forms.TextBox();
            this.textBoxIdEdit = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataAdmin)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_load
            // 
            this.btn_load.Location = new System.Drawing.Point(73, 265);
            this.btn_load.Name = "btn_load";
            this.btn_load.Size = new System.Drawing.Size(93, 41);
            this.btn_load.TabIndex = 20;
            this.btn_load.Text = "load";
            this.btn_load.UseVisualStyleBackColor = true;
            this.btn_load.Click += new System.EventHandler(this.btn_load_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.dgvDataAdmin, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(73, 312);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(887, 245);
            this.tableLayoutPanel1.TabIndex = 19;
            // 
            // dgvDataAdmin
            // 
            this.dgvDataAdmin.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDataAdmin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDataAdmin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDataAdmin.Location = new System.Drawing.Point(3, 3);
            this.dgvDataAdmin.Name = "dgvDataAdmin";
            this.dgvDataAdmin.RowHeadersWidth = 49;
            this.dgvDataAdmin.RowTemplate.Height = 24;
            this.dgvDataAdmin.Size = new System.Drawing.Size(881, 239);
            this.dgvDataAdmin.TabIndex = 0;
            this.dgvDataAdmin.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDataAdmin_CellContentClick);
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(176, 203);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(93, 41);
            this.btn_clear.TabIndex = 18;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_tambah
            // 
            this.btn_tambah.Location = new System.Drawing.Point(285, 203);
            this.btn_tambah.Name = "btn_tambah";
            this.btn_tambah.Size = new System.Drawing.Size(93, 41);
            this.btn_tambah.TabIndex = 17;
            this.btn_tambah.Text = "Tambah";
            this.btn_tambah.UseVisualStyleBackColor = true;
            this.btn_tambah.Click += new System.EventHandler(this.btn_tambah_Click);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(176, 149);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(202, 22);
            this.textBoxPassword.TabIndex = 16;
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Location = new System.Drawing.Point(176, 87);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(202, 22);
            this.textBoxUsername.TabIndex = 15;
            // 
            // textBoxNamaLengkap
            // 
            this.textBoxNamaLengkap.Location = new System.Drawing.Point(176, 31);
            this.textBoxNamaLengkap.Name = "textBoxNamaLengkap";
            this.textBoxNamaLengkap.Size = new System.Drawing.Size(202, 22);
            this.textBoxNamaLengkap.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(70, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 16);
            this.label3.TabIndex = 13;
            this.label3.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "Username";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "Nama Lengkap";
            // 
            // txtBxId
            // 
            this.txtBxId.Location = new System.Drawing.Point(860, 274);
            this.txtBxId.Name = "txtBxId";
            this.txtBxId.Size = new System.Drawing.Size(100, 22);
            this.txtBxId.TabIndex = 42;
            this.txtBxId.Visible = false;
            this.txtBxId.TextChanged += new System.EventHandler(this.txtBxId_TextChanged);
            // 
            // btn_clear_edit
            // 
            this.btn_clear_edit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_clear_edit.Location = new System.Drawing.Point(734, 230);
            this.btn_clear_edit.Name = "btn_clear_edit";
            this.btn_clear_edit.Size = new System.Drawing.Size(103, 34);
            this.btn_clear_edit.TabIndex = 41;
            this.btn_clear_edit.Text = "Clear";
            this.btn_clear_edit.UseVisualStyleBackColor = true;
            this.btn_clear_edit.Click += new System.EventHandler(this.btn_clear_edit_Click);
            // 
            // textBoxPassEdit
            // 
            this.textBoxPassEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxPassEdit.Location = new System.Drawing.Point(734, 182);
            this.textBoxPassEdit.Name = "textBoxPassEdit";
            this.textBoxPassEdit.Size = new System.Drawing.Size(223, 22);
            this.textBoxPassEdit.TabIndex = 40;
            this.textBoxPassEdit.TextChanged += new System.EventHandler(this.textBoxPassEdit_TextChanged);
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(628, 188);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 16);
            this.label7.TabIndex = 39;
            this.label7.Text = "Password";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // Edit
            // 
            this.Edit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Edit.Location = new System.Drawing.Point(857, 230);
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(103, 34);
            this.Edit.TabIndex = 38;
            this.Edit.Text = "Edit";
            this.Edit.UseVisualStyleBackColor = true;
            this.Edit.Click += new System.EventHandler(this.Edit_Click);
            // 
            // textBoxUserEdit
            // 
            this.textBoxUserEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxUserEdit.Location = new System.Drawing.Point(734, 132);
            this.textBoxUserEdit.Name = "textBoxUserEdit";
            this.textBoxUserEdit.Size = new System.Drawing.Size(223, 22);
            this.textBoxUserEdit.TabIndex = 37;
            this.textBoxUserEdit.TextChanged += new System.EventHandler(this.textBoxUserEdit_TextChanged);
            // 
            // textBoxNamaEdit
            // 
            this.textBoxNamaEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxNamaEdit.Location = new System.Drawing.Point(734, 81);
            this.textBoxNamaEdit.Name = "textBoxNamaEdit";
            this.textBoxNamaEdit.Size = new System.Drawing.Size(223, 22);
            this.textBoxNamaEdit.TabIndex = 36;
            this.textBoxNamaEdit.TextChanged += new System.EventHandler(this.textBoxNamaEdit_TextChanged);
            // 
            // textBoxIdEdit
            // 
            this.textBoxIdEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxIdEdit.Location = new System.Drawing.Point(734, 31);
            this.textBoxIdEdit.Name = "textBoxIdEdit";
            this.textBoxIdEdit.Size = new System.Drawing.Size(223, 22);
            this.textBoxIdEdit.TabIndex = 35;
            this.textBoxIdEdit.TextChanged += new System.EventHandler(this.textBoxIdEdit_TextChanged);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(628, 135);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 16);
            this.label6.TabIndex = 34;
            this.label6.Text = "Username";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(628, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 16);
            this.label5.TabIndex = 33;
            this.label5.Text = "Nama Lengkap";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(628, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 16);
            this.label4.TabIndex = 32;
            this.label4.Text = "ID Instruktur";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // data_admin_uc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.Controls.Add(this.txtBxId);
            this.Controls.Add(this.btn_clear_edit);
            this.Controls.Add(this.textBoxPassEdit);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Edit);
            this.Controls.Add(this.textBoxUserEdit);
            this.Controls.Add(this.textBoxNamaEdit);
            this.Controls.Add(this.textBoxIdEdit);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_load);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_tambah);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxUsername);
            this.Controls.Add(this.textBoxNamaLengkap);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "data_admin_uc";
            this.Size = new System.Drawing.Size(1030, 588);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataAdmin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_load;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView dgvDataAdmin;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_tambah;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.TextBox textBoxNamaLengkap;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBxId;
        private System.Windows.Forms.Button btn_clear_edit;
        private System.Windows.Forms.TextBox textBoxPassEdit;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button Edit;
        private System.Windows.Forms.TextBox textBoxUserEdit;
        private System.Windows.Forms.TextBox textBoxNamaEdit;
        private System.Windows.Forms.TextBox textBoxIdEdit;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
    }
}
