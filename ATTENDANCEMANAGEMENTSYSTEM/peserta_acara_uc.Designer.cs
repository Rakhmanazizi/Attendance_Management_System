namespace ATTENDANCEMANAGEMENTSYSTEM
{
    partial class peserta_acara_uc
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxUser = new System.Windows.Forms.ComboBox();
            this.btn_tambah = new System.Windows.Forms.Button();
            this.comboBoxEvent = new System.Windows.Forms.ComboBox();
            this.btn_load = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.dgv_peserta_acara = new System.Windows.Forms.DataGridView();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.txtBoxIdPeserta = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_peserta_acara)).BeginInit();
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1121, 100);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1115, 100);
            this.label1.TabIndex = 0;
            this.label1.Text = "TAMBAH DATA PESERTA ACARA";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtBoxIdPeserta);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.btn_load);
            this.panel1.Controls.Add(this.tableLayoutPanel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 100);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1121, 660);
            this.panel1.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.comboBoxUser);
            this.groupBox1.Controls.Add(this.btn_tambah);
            this.groupBox1.Controls.Add(this.comboBoxEvent);
            this.groupBox1.Location = new System.Drawing.Point(79, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(400, 171);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tambah Data";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nama Lengkap";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Nama Acara";
            // 
            // comboBoxUser
            // 
            this.comboBoxUser.FormattingEnabled = true;
            this.comboBoxUser.Location = new System.Drawing.Point(137, 18);
            this.comboBoxUser.Name = "comboBoxUser";
            this.comboBoxUser.Size = new System.Drawing.Size(240, 24);
            this.comboBoxUser.TabIndex = 3;
            // 
            // btn_tambah
            // 
            this.btn_tambah.Location = new System.Drawing.Point(246, 111);
            this.btn_tambah.Name = "btn_tambah";
            this.btn_tambah.Size = new System.Drawing.Size(130, 47);
            this.btn_tambah.TabIndex = 5;
            this.btn_tambah.Text = "Tambah";
            this.btn_tambah.UseVisualStyleBackColor = true;
            this.btn_tambah.Click += new System.EventHandler(this.btn_tambah_Click);
            // 
            // comboBoxEvent
            // 
            this.comboBoxEvent.FormattingEnabled = true;
            this.comboBoxEvent.Location = new System.Drawing.Point(137, 59);
            this.comboBoxEvent.Name = "comboBoxEvent";
            this.comboBoxEvent.Size = new System.Drawing.Size(240, 24);
            this.comboBoxEvent.TabIndex = 4;
            // 
            // btn_load
            // 
            this.btn_load.Location = new System.Drawing.Point(82, 208);
            this.btn_load.Name = "btn_load";
            this.btn_load.Size = new System.Drawing.Size(130, 47);
            this.btn_load.TabIndex = 7;
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
            this.tableLayoutPanel2.Controls.Add(this.dgv_peserta_acara, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(79, 274);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(981, 355);
            this.tableLayoutPanel2.TabIndex = 6;
            // 
            // dgv_peserta_acara
            // 
            this.dgv_peserta_acara.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_peserta_acara.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_peserta_acara.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_peserta_acara.Location = new System.Drawing.Point(3, 3);
            this.dgv_peserta_acara.Name = "dgv_peserta_acara";
            this.dgv_peserta_acara.RowHeadersWidth = 49;
            this.dgv_peserta_acara.RowTemplate.Height = 24;
            this.dgv_peserta_acara.Size = new System.Drawing.Size(975, 349);
            this.dgv_peserta_acara.TabIndex = 0;
            this.dgv_peserta_acara.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_peserta_acara_CellContentClick);
            // 
            // txtBoxIdPeserta
            // 
            this.txtBoxIdPeserta.Location = new System.Drawing.Point(559, 152);
            this.txtBoxIdPeserta.Name = "txtBoxIdPeserta";
            this.txtBoxIdPeserta.Size = new System.Drawing.Size(150, 22);
            this.txtBoxIdPeserta.TabIndex = 9;
            this.txtBoxIdPeserta.Visible = false;
            // 
            // peserta_acara_uc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "peserta_acara_uc";
            this.Size = new System.Drawing.Size(1121, 760);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_peserta_acara)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_tambah;
        private System.Windows.Forms.ComboBox comboBoxEvent;
        private System.Windows.Forms.ComboBox comboBoxUser;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.DataGridView dgv_peserta_acara;
        private System.Windows.Forms.Button btn_load;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox txtBoxIdPeserta;
    }
}
