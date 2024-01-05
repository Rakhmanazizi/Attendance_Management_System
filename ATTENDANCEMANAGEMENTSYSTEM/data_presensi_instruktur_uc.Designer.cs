namespace ATTENDANCEMANAGEMENTSYSTEM
{
    partial class data_presensi_instruktur_uc
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBoxIdKehadiran = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_simpan = new System.Windows.Forms.Button();
            this.comboBoxStatusKehadiran = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxNamaAcara = new System.Windows.Forms.TextBox();
            this.textBoxNamaPeserta = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_load = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.dgv_rekap_kehadiran = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btn_export_csv = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_rekap_kehadiran)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1139, 100);
            this.label1.TabIndex = 0;
            this.label1.Text = "DATA PRESENSI";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1145, 100);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_export_csv);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.btn_load);
            this.panel1.Controls.Add(this.tableLayoutPanel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 100);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1145, 602);
            this.panel1.TabIndex = 2;
            // 
            // textBoxIdKehadiran
            // 
            this.textBoxIdKehadiran.Location = new System.Drawing.Point(156, 26);
            this.textBoxIdKehadiran.Name = "textBoxIdKehadiran";
            this.textBoxIdKehadiran.Size = new System.Drawing.Size(223, 22);
            this.textBoxIdKehadiran.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 16);
            this.label5.TabIndex = 20;
            this.label5.Text = "ID Kehadiran";
            // 
            // btn_simpan
            // 
            this.btn_simpan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_simpan.Location = new System.Drawing.Point(237, 224);
            this.btn_simpan.Name = "btn_simpan";
            this.btn_simpan.Size = new System.Drawing.Size(142, 45);
            this.btn_simpan.TabIndex = 19;
            this.btn_simpan.Text = "Simpan";
            this.btn_simpan.UseVisualStyleBackColor = false;
            this.btn_simpan.Click += new System.EventHandler(this.btn_simpan_Click_1);
            // 
            // comboBoxStatusKehadiran
            // 
            this.comboBoxStatusKehadiran.FormattingEnabled = true;
            this.comboBoxStatusKehadiran.Items.AddRange(new object[] {
            "Hadir",
            "Telat",
            "Absen"});
            this.comboBoxStatusKehadiran.Location = new System.Drawing.Point(156, 182);
            this.comboBoxStatusKehadiran.Name = "comboBoxStatusKehadiran";
            this.comboBoxStatusKehadiran.Size = new System.Drawing.Size(223, 24);
            this.comboBoxStatusKehadiran.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 16);
            this.label4.TabIndex = 17;
            this.label4.Text = "Status Kehadiran";
            // 
            // textBoxNamaAcara
            // 
            this.textBoxNamaAcara.Location = new System.Drawing.Point(156, 129);
            this.textBoxNamaAcara.Name = "textBoxNamaAcara";
            this.textBoxNamaAcara.Size = new System.Drawing.Size(223, 22);
            this.textBoxNamaAcara.TabIndex = 16;
            // 
            // textBoxNamaPeserta
            // 
            this.textBoxNamaPeserta.Location = new System.Drawing.Point(156, 77);
            this.textBoxNamaPeserta.Name = "textBoxNamaPeserta";
            this.textBoxNamaPeserta.Size = new System.Drawing.Size(223, 22);
            this.textBoxNamaPeserta.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 16);
            this.label3.TabIndex = 14;
            this.label3.Text = "Nama Acara";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "Nama Peserta";
            // 
            // btn_load
            // 
            this.btn_load.Location = new System.Drawing.Point(48, 311);
            this.btn_load.Name = "btn_load";
            this.btn_load.Size = new System.Drawing.Size(142, 45);
            this.btn_load.TabIndex = 12;
            this.btn_load.Text = "Load";
            this.btn_load.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.dgv_rekap_kehadiran, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(48, 373);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1053, 207);
            this.tableLayoutPanel2.TabIndex = 11;
            // 
            // dgv_rekap_kehadiran
            // 
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_rekap_kehadiran.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_rekap_kehadiran.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_rekap_kehadiran.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_rekap_kehadiran.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_rekap_kehadiran.Location = new System.Drawing.Point(3, 3);
            this.dgv_rekap_kehadiran.Name = "dgv_rekap_kehadiran";
            this.dgv_rekap_kehadiran.RowHeadersWidth = 49;
            this.dgv_rekap_kehadiran.RowTemplate.Height = 24;
            this.dgv_rekap_kehadiran.Size = new System.Drawing.Size(1047, 201);
            this.dgv_rekap_kehadiran.TabIndex = 0;
            this.dgv_rekap_kehadiran.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_rekap_kehadiran_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textBoxIdKehadiran);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btn_simpan);
            this.groupBox1.Controls.Add(this.textBoxNamaPeserta);
            this.groupBox1.Controls.Add(this.comboBoxStatusKehadiran);
            this.groupBox1.Controls.Add(this.textBoxNamaAcara);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(48, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(424, 285);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // btn_export_csv
            // 
            this.btn_export_csv.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_export_csv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_export_csv.Location = new System.Drawing.Point(956, 311);
            this.btn_export_csv.Name = "btn_export_csv";
            this.btn_export_csv.Size = new System.Drawing.Size(142, 45);
            this.btn_export_csv.TabIndex = 23;
            this.btn_export_csv.Text = "Export CSV";
            this.btn_export_csv.UseVisualStyleBackColor = false;
            this.btn_export_csv.Click += new System.EventHandler(this.btn_export_csv_Click);
            // 
            // data_presensi_instruktur_uc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "data_presensi_instruktur_uc";
            this.Size = new System.Drawing.Size(1145, 702);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_rekap_kehadiran)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBoxIdKehadiran;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_simpan;
        private System.Windows.Forms.ComboBox comboBoxStatusKehadiran;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxNamaAcara;
        private System.Windows.Forms.TextBox textBoxNamaPeserta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_load;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.DataGridView dgv_rekap_kehadiran;
        private System.Windows.Forms.Button btn_export_csv;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}
