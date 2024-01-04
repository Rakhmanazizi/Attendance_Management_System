namespace ATTENDANCEMANAGEMENTSYSTEM
{
    partial class data_user_uc
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxNamaLengkap = new System.Windows.Forms.TextBox();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.btn_tambah = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dgvDataMember = new System.Windows.Forms.DataGridView();
            this.btn_load = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxIdEdit = new System.Windows.Forms.TextBox();
            this.textBoxNamaEdit = new System.Windows.Forms.TextBox();
            this.textBoxUserEdit = new System.Windows.Forms.TextBox();
            this.Edit = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxPassEdit = new System.Windows.Forms.TextBox();
            this.txtBxIdUs = new System.Windows.Forms.TextBox();
            this.btn_clear_edit = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataMember)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nama Lengkap";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Username";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Password";
            // 
            // textBoxNamaLengkap
            // 
            this.textBoxNamaLengkap.Location = new System.Drawing.Point(154, 37);
            this.textBoxNamaLengkap.Name = "textBoxNamaLengkap";
            this.textBoxNamaLengkap.Size = new System.Drawing.Size(223, 22);
            this.textBoxNamaLengkap.TabIndex = 3;
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Location = new System.Drawing.Point(154, 84);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(223, 22);
            this.textBoxUsername.TabIndex = 4;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(154, 135);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(223, 22);
            this.textBoxPassword.TabIndex = 5;
            // 
            // btn_tambah
            // 
            this.btn_tambah.Location = new System.Drawing.Point(274, 194);
            this.btn_tambah.Name = "btn_tambah";
            this.btn_tambah.Size = new System.Drawing.Size(103, 34);
            this.btn_tambah.TabIndex = 6;
            this.btn_tambah.Text = "Tambah";
            this.btn_tambah.UseVisualStyleBackColor = true;
            this.btn_tambah.Click += new System.EventHandler(this.btn_tambah_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(154, 194);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(103, 34);
            this.btn_clear.TabIndex = 7;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.dgvDataMember, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(51, 303);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(930, 222);
            this.tableLayoutPanel1.TabIndex = 8;
            // 
            // dgvDataMember
            // 
            this.dgvDataMember.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDataMember.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDataMember.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDataMember.Location = new System.Drawing.Point(3, 3);
            this.dgvDataMember.Name = "dgvDataMember";
            this.dgvDataMember.RowHeadersWidth = 49;
            this.dgvDataMember.RowTemplate.Height = 24;
            this.dgvDataMember.Size = new System.Drawing.Size(924, 216);
            this.dgvDataMember.TabIndex = 0;
            this.dgvDataMember.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDataMember_CellContentClick);
            // 
            // btn_load
            // 
            this.btn_load.Location = new System.Drawing.Point(54, 252);
            this.btn_load.Name = "btn_load";
            this.btn_load.Size = new System.Drawing.Size(103, 34);
            this.btn_load.TabIndex = 9;
            this.btn_load.Text = "load";
            this.btn_load.UseVisualStyleBackColor = true;
            this.btn_load.Click += new System.EventHandler(this.btn_load_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(577, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "ID Member";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(577, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "Nama Lengkap";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(577, 141);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "Username";
            // 
            // textBoxIdEdit
            // 
            this.textBoxIdEdit.Location = new System.Drawing.Point(683, 37);
            this.textBoxIdEdit.Name = "textBoxIdEdit";
            this.textBoxIdEdit.Size = new System.Drawing.Size(223, 22);
            this.textBoxIdEdit.TabIndex = 13;
            // 
            // textBoxNamaEdit
            // 
            this.textBoxNamaEdit.Location = new System.Drawing.Point(683, 87);
            this.textBoxNamaEdit.Name = "textBoxNamaEdit";
            this.textBoxNamaEdit.Size = new System.Drawing.Size(223, 22);
            this.textBoxNamaEdit.TabIndex = 14;
            // 
            // textBoxUserEdit
            // 
            this.textBoxUserEdit.Location = new System.Drawing.Point(683, 138);
            this.textBoxUserEdit.Name = "textBoxUserEdit";
            this.textBoxUserEdit.Size = new System.Drawing.Size(223, 22);
            this.textBoxUserEdit.TabIndex = 15;
            // 
            // Edit
            // 
            this.Edit.Location = new System.Drawing.Point(806, 236);
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(103, 34);
            this.Edit.TabIndex = 16;
            this.Edit.Text = "Edit";
            this.Edit.UseVisualStyleBackColor = true;
            this.Edit.Click += new System.EventHandler(this.Edit_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(577, 194);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 16);
            this.label7.TabIndex = 17;
            this.label7.Text = "Username";
            // 
            // textBoxPassEdit
            // 
            this.textBoxPassEdit.Location = new System.Drawing.Point(683, 188);
            this.textBoxPassEdit.Name = "textBoxPassEdit";
            this.textBoxPassEdit.Size = new System.Drawing.Size(223, 22);
            this.textBoxPassEdit.TabIndex = 18;
            // 
            // txtBxIdUs
            // 
            this.txtBxIdUs.Location = new System.Drawing.Point(806, 536);
            this.txtBxIdUs.Name = "txtBxIdUs";
            this.txtBxIdUs.Size = new System.Drawing.Size(100, 22);
            this.txtBxIdUs.TabIndex = 19;
            this.txtBxIdUs.Visible = false;
            // 
            // btn_clear_edit
            // 
            this.btn_clear_edit.Location = new System.Drawing.Point(683, 236);
            this.btn_clear_edit.Name = "btn_clear_edit";
            this.btn_clear_edit.Size = new System.Drawing.Size(103, 34);
            this.btn_clear_edit.TabIndex = 20;
            this.btn_clear_edit.Text = "Clear";
            this.btn_clear_edit.UseVisualStyleBackColor = true;
            this.btn_clear_edit.Click += new System.EventHandler(this.btn_clear_edit_Click);
            // 
            // data_user_uc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.Controls.Add(this.btn_clear_edit);
            this.Controls.Add(this.txtBxIdUs);
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
            this.Name = "data_user_uc";
            this.Size = new System.Drawing.Size(1030, 558);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataMember)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxNamaLengkap;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Button btn_tambah;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView dgvDataMember;
        private System.Windows.Forms.Button btn_load;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxIdEdit;
        private System.Windows.Forms.TextBox textBoxNamaEdit;
        private System.Windows.Forms.TextBox textBoxUserEdit;
        private System.Windows.Forms.Button Edit;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxPassEdit;
        private System.Windows.Forms.TextBox txtBxIdUs;
        private System.Windows.Forms.Button btn_clear_edit;
    }
}
