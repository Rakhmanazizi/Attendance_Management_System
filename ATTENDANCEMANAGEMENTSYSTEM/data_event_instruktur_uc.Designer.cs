namespace ATTENDANCEMANAGEMENTSYSTEM
{
    partial class data_event_instruktur_uc
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dtp_edit = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxIdEditEvent = new System.Windows.Forms.TextBox();
            this.textBoxEventEdit = new System.Windows.Forms.TextBox();
            this.textBoxTempatEdit = new System.Windows.Forms.TextBox();
            this.btn_edit = new System.Windows.Forms.Button();
            this.textBoxDeskripsiEdit = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxEvent = new System.Windows.Forms.TextBox();
            this.textBoxTempat = new System.Windows.Forms.TextBox();
            this.btn_tambah = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxDeksripsi = new System.Windows.Forms.TextBox();
            this.dtp_tanggal = new System.Windows.Forms.DateTimePicker();
            this.btn_load = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.dgvEventInst = new System.Windows.Forms.DataGridView();
            this.btn_clear = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEventInst)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1200, 115);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1194, 115);
            this.label1.TabIndex = 0;
            this.label1.Text = "DATA EVENT YANG DITANGANI OLEH ANDA";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.btn_load);
            this.panel1.Controls.Add(this.tableLayoutPanel2);
            this.panel1.Controls.Add(this.btn_clear);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 115);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1200, 686);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.dtp_edit);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.textBoxIdEditEvent);
            this.groupBox2.Controls.Add(this.textBoxEventEdit);
            this.groupBox2.Controls.Add(this.textBoxTempatEdit);
            this.groupBox2.Controls.Add(this.btn_edit);
            this.groupBox2.Controls.Add(this.textBoxDeskripsiEdit);
            this.groupBox2.Location = new System.Drawing.Point(550, 0);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(426, 458);
            this.groupBox2.TabIndex = 26;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Edit Event";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(29, 38);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(23, 20);
            this.label8.TabIndex = 14;
            this.label8.Text = "Id";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Nama Event";
            // 
            // dtp_edit
            // 
            this.dtp_edit.Location = new System.Drawing.Point(146, 199);
            this.dtp_edit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtp_edit.Name = "dtp_edit";
            this.dtp_edit.Size = new System.Drawing.Size(245, 26);
            this.dtp_edit.TabIndex = 24;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(29, 150);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "Tempat";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(29, 206);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(66, 20);
            this.label10.TabIndex = 23;
            this.label10.Text = "Tanggal";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(29, 258);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 20);
            this.label9.TabIndex = 15;
            this.label9.Text = "Deskripsi";
            // 
            // textBoxIdEditEvent
            // 
            this.textBoxIdEditEvent.Location = new System.Drawing.Point(146, 38);
            this.textBoxIdEditEvent.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxIdEditEvent.Name = "textBoxIdEditEvent";
            this.textBoxIdEditEvent.Size = new System.Drawing.Size(245, 26);
            this.textBoxIdEditEvent.TabIndex = 22;
            // 
            // textBoxEventEdit
            // 
            this.textBoxEventEdit.Location = new System.Drawing.Point(146, 94);
            this.textBoxEventEdit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxEventEdit.Name = "textBoxEventEdit";
            this.textBoxEventEdit.Size = new System.Drawing.Size(245, 26);
            this.textBoxEventEdit.TabIndex = 16;
            // 
            // textBoxTempatEdit
            // 
            this.textBoxTempatEdit.Location = new System.Drawing.Point(146, 142);
            this.textBoxTempatEdit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxTempatEdit.Name = "textBoxTempatEdit";
            this.textBoxTempatEdit.Size = new System.Drawing.Size(245, 26);
            this.textBoxTempatEdit.TabIndex = 17;
            // 
            // btn_edit
            // 
            this.btn_edit.Location = new System.Drawing.Point(281, 385);
            this.btn_edit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(110, 51);
            this.btn_edit.TabIndex = 20;
            this.btn_edit.Text = "Edit";
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // textBoxDeskripsiEdit
            // 
            this.textBoxDeskripsiEdit.Location = new System.Drawing.Point(146, 254);
            this.textBoxDeskripsiEdit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxDeskripsiEdit.Multiline = true;
            this.textBoxDeskripsiEdit.Name = "textBoxDeskripsiEdit";
            this.textBoxDeskripsiEdit.Size = new System.Drawing.Size(245, 123);
            this.textBoxDeskripsiEdit.TabIndex = 18;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBoxEvent);
            this.groupBox1.Controls.Add(this.textBoxTempat);
            this.groupBox1.Controls.Add(this.btn_tambah);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textBoxDeksripsi);
            this.groupBox1.Controls.Add(this.dtp_tanggal);
            this.groupBox1.Location = new System.Drawing.Point(88, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(430, 320);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tambah Event";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nama Event";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tempat";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Tanggal";
            // 
            // textBoxEvent
            // 
            this.textBoxEvent.Location = new System.Drawing.Point(155, 35);
            this.textBoxEvent.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxEvent.Name = "textBoxEvent";
            this.textBoxEvent.Size = new System.Drawing.Size(245, 26);
            this.textBoxEvent.TabIndex = 3;
            // 
            // textBoxTempat
            // 
            this.textBoxTempat.Location = new System.Drawing.Point(155, 88);
            this.textBoxTempat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxTempat.Name = "textBoxTempat";
            this.textBoxTempat.Size = new System.Drawing.Size(245, 26);
            this.textBoxTempat.TabIndex = 4;
            // 
            // btn_tambah
            // 
            this.btn_tambah.Location = new System.Drawing.Point(290, 241);
            this.btn_tambah.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_tambah.Name = "btn_tambah";
            this.btn_tambah.Size = new System.Drawing.Size(110, 51);
            this.btn_tambah.TabIndex = 6;
            this.btn_tambah.Text = "Tambah";
            this.btn_tambah.UseVisualStyleBackColor = true;
            this.btn_tambah.Click += new System.EventHandler(this.btn_tambah_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 202);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Deksripsi";
            // 
            // textBoxDeksripsi
            // 
            this.textBoxDeksripsi.Location = new System.Drawing.Point(156, 195);
            this.textBoxDeksripsi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxDeksripsi.Multiline = true;
            this.textBoxDeksripsi.Name = "textBoxDeksripsi";
            this.textBoxDeksripsi.Size = new System.Drawing.Size(244, 26);
            this.textBoxDeksripsi.TabIndex = 10;
            // 
            // dtp_tanggal
            // 
            this.dtp_tanggal.Location = new System.Drawing.Point(155, 140);
            this.dtp_tanggal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtp_tanggal.Name = "dtp_tanggal";
            this.dtp_tanggal.Size = new System.Drawing.Size(245, 26);
            this.dtp_tanggal.TabIndex = 11;
            // 
            // btn_load
            // 
            this.btn_load.Location = new System.Drawing.Point(88, 411);
            this.btn_load.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_load.Name = "btn_load";
            this.btn_load.Size = new System.Drawing.Size(108, 51);
            this.btn_load.TabIndex = 21;
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
            this.tableLayoutPanel2.Controls.Add(this.dgvEventInst, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(88, 466);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1062, 185);
            this.tableLayoutPanel2.TabIndex = 8;
            // 
            // dgvEventInst
            // 
            this.dgvEventInst.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvEventInst.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEventInst.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvEventInst.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEventInst.Location = new System.Drawing.Point(3, 4);
            this.dgvEventInst.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvEventInst.Name = "dgvEventInst";
            this.dgvEventInst.RowHeadersWidth = 49;
            this.dgvEventInst.RowTemplate.Height = 24;
            this.dgvEventInst.Size = new System.Drawing.Size(1056, 177);
            this.dgvEventInst.TabIndex = 0;
            this.dgvEventInst.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEventInst_CellContentClick);
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(997, 0);
            this.btn_clear.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(114, 51);
            this.btn_clear.TabIndex = 7;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // data_event_instruktur_uc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "data_event_instruktur_uc";
            this.Size = new System.Drawing.Size(1200, 801);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEventInst)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBoxEvent;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_tambah;
        private System.Windows.Forms.TextBox textBoxTempat;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.DataGridView dgvEventInst;
        private System.Windows.Forms.TextBox textBoxDeksripsi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.TextBox textBoxDeskripsiEdit;
        private System.Windows.Forms.TextBox textBoxTempatEdit;
        private System.Windows.Forms.TextBox textBoxEventEdit;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtp_tanggal;
        private System.Windows.Forms.Button btn_load;
        private System.Windows.Forms.TextBox textBoxIdEditEvent;
        private System.Windows.Forms.DateTimePicker dtp_edit;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
    }
}
