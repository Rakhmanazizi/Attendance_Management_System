namespace ATTENDANCEMANAGEMENTSYSTEM
{
    partial class data_instructor_uc
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxNamaLengkap = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.btn_tambah = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dgvDataInstruktur = new System.Windows.Forms.DataGridView();
            this.btn_load = new System.Windows.Forms.Button();
            this.textBoxPassEdit = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Edit = new System.Windows.Forms.Button();
            this.textBoxUserEdit = new System.Windows.Forms.TextBox();
            this.textBoxNamaEdit = new System.Windows.Forms.TextBox();
            this.textBoxIdEdit = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBxId = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataInstruktur)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nama Lengkap";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Username";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Password";
            // 
            // textBoxNamaLengkap
            // 
            this.textBoxNamaLengkap.Location = new System.Drawing.Point(121, 26);
            this.textBoxNamaLengkap.Name = "textBoxNamaLengkap";
            this.textBoxNamaLengkap.Size = new System.Drawing.Size(202, 22);
            this.textBoxNamaLengkap.TabIndex = 3;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(19, 19);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Location = new System.Drawing.Point(121, 82);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(202, 22);
            this.textBoxUsername.TabIndex = 5;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(121, 144);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(202, 22);
            this.textBoxPassword.TabIndex = 6;
            // 
            // btn_tambah
            // 
            this.btn_tambah.Location = new System.Drawing.Point(230, 198);
            this.btn_tambah.Name = "btn_tambah";
            this.btn_tambah.Size = new System.Drawing.Size(93, 41);
            this.btn_tambah.TabIndex = 7;
            this.btn_tambah.Text = "Tambah";
            this.btn_tambah.UseVisualStyleBackColor = true;
            this.btn_tambah.Click += new System.EventHandler(this.btn_tambah_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(873, 103);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(93, 41);
            this.btn_clear.TabIndex = 8;
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
            this.tableLayoutPanel1.Controls.Add(this.dgvDataInstruktur, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(66, 453);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(887, 117);
            this.tableLayoutPanel1.TabIndex = 9;
            // 
            // dgvDataInstruktur
            // 
            this.dgvDataInstruktur.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDataInstruktur.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDataInstruktur.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDataInstruktur.Location = new System.Drawing.Point(3, 3);
            this.dgvDataInstruktur.Name = "dgvDataInstruktur";
            this.dgvDataInstruktur.RowHeadersWidth = 49;
            this.dgvDataInstruktur.RowTemplate.Height = 24;
            this.dgvDataInstruktur.Size = new System.Drawing.Size(881, 111);
            this.dgvDataInstruktur.TabIndex = 0;
            this.dgvDataInstruktur.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDataInstruktur_CellContentClick);
            // 
            // btn_load
            // 
            this.btn_load.Location = new System.Drawing.Point(66, 406);
            this.btn_load.Name = "btn_load";
            this.btn_load.Size = new System.Drawing.Size(93, 41);
            this.btn_load.TabIndex = 10;
            this.btn_load.Text = "load";
            this.btn_load.UseVisualStyleBackColor = true;
            this.btn_load.Click += new System.EventHandler(this.btn_load_Click);
            // 
            // textBoxPassEdit
            // 
            this.textBoxPassEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxPassEdit.Location = new System.Drawing.Point(127, 173);
            this.textBoxPassEdit.Name = "textBoxPassEdit";
            this.textBoxPassEdit.Size = new System.Drawing.Size(223, 22);
            this.textBoxPassEdit.TabIndex = 29;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 176);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 16);
            this.label7.TabIndex = 28;
            this.label7.Text = "Password";
            // 
            // Edit
            // 
            this.Edit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Edit.Location = new System.Drawing.Point(247, 221);
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(103, 34);
            this.Edit.TabIndex = 27;
            this.Edit.Text = "Edit";
            this.Edit.UseVisualStyleBackColor = true;
            this.Edit.Click += new System.EventHandler(this.Edit_Click);
            // 
            // textBoxUserEdit
            // 
            this.textBoxUserEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxUserEdit.Location = new System.Drawing.Point(127, 121);
            this.textBoxUserEdit.Name = "textBoxUserEdit";
            this.textBoxUserEdit.Size = new System.Drawing.Size(223, 22);
            this.textBoxUserEdit.TabIndex = 26;
            // 
            // textBoxNamaEdit
            // 
            this.textBoxNamaEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxNamaEdit.Location = new System.Drawing.Point(127, 70);
            this.textBoxNamaEdit.Name = "textBoxNamaEdit";
            this.textBoxNamaEdit.Size = new System.Drawing.Size(223, 22);
            this.textBoxNamaEdit.TabIndex = 25;
            // 
            // textBoxIdEdit
            // 
            this.textBoxIdEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxIdEdit.Location = new System.Drawing.Point(127, 20);
            this.textBoxIdEdit.Name = "textBoxIdEdit";
            this.textBoxIdEdit.Size = new System.Drawing.Size(223, 22);
            this.textBoxIdEdit.TabIndex = 24;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 124);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 16);
            this.label6.TabIndex = 23;
            this.label6.Text = "Username";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 16);
            this.label5.TabIndex = 22;
            this.label5.Text = "Nama Lengkap";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 16);
            this.label4.TabIndex = 21;
            this.label4.Text = "ID Instruktur";
            // 
            // txtBxId
            // 
            this.txtBxId.Location = new System.Drawing.Point(850, 415);
            this.txtBxId.Name = "txtBxId";
            this.txtBxId.Size = new System.Drawing.Size(100, 22);
            this.txtBxId.TabIndex = 31;
            this.txtBxId.Visible = false;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.label8, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1030, 100);
            this.tableLayoutPanel2.TabIndex = 32;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(3, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(1024, 100);
            this.label8.TabIndex = 0;
            this.label8.Text = "MENU MANAJEMEN DATA AKUN INSTRUKTUR";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBoxNamaLengkap);
            this.groupBox1.Controls.Add(this.textBoxUsername);
            this.groupBox1.Controls.Add(this.textBoxPassword);
            this.groupBox1.Controls.Add(this.btn_tambah);
            this.groupBox1.Location = new System.Drawing.Point(66, 103);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(343, 258);
            this.groupBox1.TabIndex = 33;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tambah Instruktur";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.textBoxIdEdit);
            this.groupBox2.Controls.Add(this.textBoxNamaEdit);
            this.groupBox2.Controls.Add(this.Edit);
            this.groupBox2.Controls.Add(this.textBoxUserEdit);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.textBoxPassEdit);
            this.groupBox2.Location = new System.Drawing.Point(456, 106);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(382, 276);
            this.groupBox2.TabIndex = 34;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Edit Instruktur";
            // 
            // data_instructor_uc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.txtBxId);
            this.Controls.Add(this.btn_load);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.btn_clear);
            this.Name = "data_instructor_uc";
            this.Size = new System.Drawing.Size(1030, 588);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataInstruktur)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxNamaLengkap;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Button btn_tambah;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView dgvDataInstruktur;
        private System.Windows.Forms.Button btn_load;
        private System.Windows.Forms.TextBox textBoxPassEdit;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button Edit;
        private System.Windows.Forms.TextBox textBoxUserEdit;
        private System.Windows.Forms.TextBox textBoxNamaEdit;
        private System.Windows.Forms.TextBox textBoxIdEdit;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBxId;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}
