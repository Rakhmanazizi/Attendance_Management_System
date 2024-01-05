namespace ATTENDANCEMANAGEMENTSYSTEM
{
    partial class data_presensi_uc
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxIdKehadiran = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_simpan = new System.Windows.Forms.Button();
            this.textBoxNamaPeserta = new System.Windows.Forms.TextBox();
            this.comboBoxStatusKehadiran = new System.Windows.Forms.ComboBox();
            this.textBoxNamaAcara = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_load = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.dgv_rekap_kehadiran = new System.Windows.Forms.DataGridView();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btn_export_csv = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_rekap_kehadiran)).BeginInit();
            this.SuspendLayout();
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1378, 110);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1372, 110);
            this.label1.TabIndex = 0;
            this.label1.Text = "MENU DATA REKAP KEHADIRAN PESERTA";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_export_csv);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.btn_load);
            this.panel1.Controls.Add(this.tableLayoutPanel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 110);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1378, 603);
            this.panel1.TabIndex = 1;
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
            this.groupBox1.Location = new System.Drawing.Point(94, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(419, 274);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Rekap Kehadiran";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "ID Kehadiran";
            // 
            // textBoxIdKehadiran
            // 
            this.textBoxIdKehadiran.Location = new System.Drawing.Point(153, 22);
            this.textBoxIdKehadiran.Name = "textBoxIdKehadiran";
            this.textBoxIdKehadiran.Size = new System.Drawing.Size(223, 22);
            this.textBoxIdKehadiran.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nama Peserta";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nama Acara";
            // 
            // btn_simpan
            // 
            this.btn_simpan.Location = new System.Drawing.Point(234, 220);
            this.btn_simpan.Name = "btn_simpan";
            this.btn_simpan.Size = new System.Drawing.Size(142, 45);
            this.btn_simpan.TabIndex = 8;
            this.btn_simpan.Text = "Simpan";
            this.btn_simpan.UseVisualStyleBackColor = true;
            this.btn_simpan.Click += new System.EventHandler(this.btn_simpan_Click);
            // 
            // textBoxNamaPeserta
            // 
            this.textBoxNamaPeserta.Location = new System.Drawing.Point(153, 73);
            this.textBoxNamaPeserta.Name = "textBoxNamaPeserta";
            this.textBoxNamaPeserta.Size = new System.Drawing.Size(223, 22);
            this.textBoxNamaPeserta.TabIndex = 4;
            // 
            // comboBoxStatusKehadiran
            // 
            this.comboBoxStatusKehadiran.FormattingEnabled = true;
            this.comboBoxStatusKehadiran.Items.AddRange(new object[] {
            "Hadir",
            "Telat",
            "Absen"});
            this.comboBoxStatusKehadiran.Location = new System.Drawing.Point(153, 178);
            this.comboBoxStatusKehadiran.Name = "comboBoxStatusKehadiran";
            this.comboBoxStatusKehadiran.Size = new System.Drawing.Size(223, 24);
            this.comboBoxStatusKehadiran.TabIndex = 7;
            // 
            // textBoxNamaAcara
            // 
            this.textBoxNamaAcara.Location = new System.Drawing.Point(153, 125);
            this.textBoxNamaAcara.Name = "textBoxNamaAcara";
            this.textBoxNamaAcara.Size = new System.Drawing.Size(223, 22);
            this.textBoxNamaAcara.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Status Kehadiran";
            // 
            // btn_load
            // 
            this.btn_load.Location = new System.Drawing.Point(91, 302);
            this.btn_load.Name = "btn_load";
            this.btn_load.Size = new System.Drawing.Size(142, 45);
            this.btn_load.TabIndex = 1;
            this.btn_load.Text = "Load";
            this.btn_load.UseVisualStyleBackColor = true;
            this.btn_load.Click += new System.EventHandler(this.btn_load_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.dgv_rekap_kehadiran, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(91, 353);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1232, 232);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // dgv_rekap_kehadiran
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_rekap_kehadiran.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_rekap_kehadiran.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_rekap_kehadiran.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_rekap_kehadiran.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_rekap_kehadiran.Location = new System.Drawing.Point(3, 3);
            this.dgv_rekap_kehadiran.Name = "dgv_rekap_kehadiran";
            this.dgv_rekap_kehadiran.RowHeadersWidth = 49;
            this.dgv_rekap_kehadiran.RowTemplate.Height = 24;
            this.dgv_rekap_kehadiran.Size = new System.Drawing.Size(1226, 226);
            this.dgv_rekap_kehadiran.TabIndex = 0;
            this.dgv_rekap_kehadiran.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_rekap_kehadiran_CellContentClick);
            // 
            // btn_export_csv
            // 
            this.btn_export_csv.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_export_csv.Location = new System.Drawing.Point(1209, 302);
            this.btn_export_csv.Name = "btn_export_csv";
            this.btn_export_csv.Size = new System.Drawing.Size(111, 37);
            this.btn_export_csv.TabIndex = 12;
            this.btn_export_csv.Text = "Export CSV";
            this.btn_export_csv.UseVisualStyleBackColor = true;
            this.btn_export_csv.Click += new System.EventHandler(this.btn_export_csv_Click);
            // 
            // data_presensi_uc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "data_presensi_uc";
            this.Size = new System.Drawing.Size(1378, 713);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_rekap_kehadiran)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.DataGridView dgv_rekap_kehadiran;
        private System.Windows.Forms.Button btn_load;
        private System.Windows.Forms.ComboBox comboBoxStatusKehadiran;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxNamaAcara;
        private System.Windows.Forms.TextBox textBoxNamaPeserta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_simpan;
        private System.Windows.Forms.TextBox textBoxIdKehadiran;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btn_export_csv;
    }
}
