namespace ATTENDANCEMANAGEMENTSYSTEM
{
    partial class data_events_uc
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
            this.textBoxEvent = new System.Windows.Forms.TextBox();
            this.textBoxTempat = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dgvEvents = new System.Windows.Forms.DataGridView();
            this.btn_tambah = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_load = new System.Windows.Forms.Button();
            this.comboBoxInstruktur = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxDeskripsi = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label8 = new System.Windows.Forms.Label();
            this.dtp_edit = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxIdEditEvent = new System.Windows.Forms.TextBox();
            this.btn_edit = new System.Windows.Forms.Button();
            this.textBoxDeskripsiEdit = new System.Windows.Forms.TextBox();
            this.textBoxTempatEdit = new System.Windows.Forms.TextBox();
            this.textBoxEventEdit = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEvents)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nama Event";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tempat ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tanggal";
            // 
            // textBoxEvent
            // 
            this.textBoxEvent.Location = new System.Drawing.Point(126, 27);
            this.textBoxEvent.Name = "textBoxEvent";
            this.textBoxEvent.Size = new System.Drawing.Size(242, 22);
            this.textBoxEvent.TabIndex = 4;
            // 
            // textBoxTempat
            // 
            this.textBoxTempat.Location = new System.Drawing.Point(126, 75);
            this.textBoxTempat.Name = "textBoxTempat";
            this.textBoxTempat.Size = new System.Drawing.Size(242, 22);
            this.textBoxTempat.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 192);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "Instruktor";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.dgvEvents, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(82, 531);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(958, 180);
            this.tableLayoutPanel1.TabIndex = 12;
            // 
            // dgvEvents
            // 
            this.dgvEvents.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvEvents.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEvents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEvents.Location = new System.Drawing.Point(3, 3);
            this.dgvEvents.Name = "dgvEvents";
            this.dgvEvents.RowHeadersWidth = 49;
            this.dgvEvents.RowTemplate.Height = 24;
            this.dgvEvents.Size = new System.Drawing.Size(952, 174);
            this.dgvEvents.TabIndex = 0;
            this.dgvEvents.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEvents_CellContentClick);
            // 
            // btn_tambah
            // 
            this.btn_tambah.Location = new System.Drawing.Point(261, 305);
            this.btn_tambah.Name = "btn_tambah";
            this.btn_tambah.Size = new System.Drawing.Size(107, 48);
            this.btn_tambah.TabIndex = 13;
            this.btn_tambah.Text = "Tambah";
            this.btn_tambah.UseVisualStyleBackColor = true;
            this.btn_tambah.Click += new System.EventHandler(this.btn_tambah_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(969, 107);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(107, 48);
            this.btn_clear.TabIndex = 14;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_load
            // 
            this.btn_load.Location = new System.Drawing.Point(79, 468);
            this.btn_load.Name = "btn_load";
            this.btn_load.Size = new System.Drawing.Size(107, 48);
            this.btn_load.TabIndex = 15;
            this.btn_load.Text = "Load";
            this.btn_load.UseVisualStyleBackColor = true;
            this.btn_load.Click += new System.EventHandler(this.btn_load_Click);
            // 
            // comboBoxInstruktur
            // 
            this.comboBoxInstruktur.FormattingEnabled = true;
            this.comboBoxInstruktur.Location = new System.Drawing.Point(126, 192);
            this.comboBoxInstruktur.Name = "comboBoxInstruktur";
            this.comboBoxInstruktur.Size = new System.Drawing.Size(242, 24);
            this.comboBoxInstruktur.TabIndex = 18;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(126, 130);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(242, 22);
            this.dateTimePicker1.TabIndex = 19;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.DarkSalmon;
            this.groupBox1.Controls.Add(this.textBoxDeskripsi);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.comboBoxInstruktur);
            this.groupBox1.Controls.Add(this.textBoxEvent);
            this.groupBox1.Controls.Add(this.textBoxTempat);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.btn_tambah);
            this.groupBox1.Location = new System.Drawing.Point(82, 103);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(422, 359);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tambah Event";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // textBoxDeskripsi
            // 
            this.textBoxDeskripsi.Location = new System.Drawing.Point(126, 241);
            this.textBoxDeskripsi.Multiline = true;
            this.textBoxDeskripsi.Name = "textBoxDeskripsi";
            this.textBoxDeskripsi.Size = new System.Drawing.Size(242, 45);
            this.textBoxDeskripsi.TabIndex = 56;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(23, 244);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(64, 16);
            this.label11.TabIndex = 56;
            this.label11.Text = "Deskripsi";
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
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1090, 97);
            this.tableLayoutPanel2.TabIndex = 44;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(3, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(1084, 97);
            this.label8.TabIndex = 0;
            this.label8.Text = "MENU MANAJEMEN DATA EVENT ACARA\r\n";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // dtp_edit
            // 
            this.dtp_edit.Location = new System.Drawing.Point(138, 159);
            this.dtp_edit.Name = "dtp_edit";
            this.dtp_edit.Size = new System.Drawing.Size(218, 22);
            this.dtp_edit.TabIndex = 55;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(34, 165);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 16);
            this.label10.TabIndex = 54;
            this.label10.Text = "Tanggal";
            // 
            // textBoxIdEditEvent
            // 
            this.textBoxIdEditEvent.Location = new System.Drawing.Point(138, 30);
            this.textBoxIdEditEvent.Name = "textBoxIdEditEvent";
            this.textBoxIdEditEvent.Size = new System.Drawing.Size(218, 22);
            this.textBoxIdEditEvent.TabIndex = 53;
            // 
            // btn_edit
            // 
            this.btn_edit.Location = new System.Drawing.Point(258, 308);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(98, 41);
            this.btn_edit.TabIndex = 52;
            this.btn_edit.Text = "Edit";
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // textBoxDeskripsiEdit
            // 
            this.textBoxDeskripsiEdit.Location = new System.Drawing.Point(138, 203);
            this.textBoxDeskripsiEdit.Multiline = true;
            this.textBoxDeskripsiEdit.Name = "textBoxDeskripsiEdit";
            this.textBoxDeskripsiEdit.Size = new System.Drawing.Size(218, 99);
            this.textBoxDeskripsiEdit.TabIndex = 51;
            // 
            // textBoxTempatEdit
            // 
            this.textBoxTempatEdit.Location = new System.Drawing.Point(138, 114);
            this.textBoxTempatEdit.Name = "textBoxTempatEdit";
            this.textBoxTempatEdit.Size = new System.Drawing.Size(218, 22);
            this.textBoxTempatEdit.TabIndex = 50;
            // 
            // textBoxEventEdit
            // 
            this.textBoxEventEdit.Location = new System.Drawing.Point(138, 75);
            this.textBoxEventEdit.Name = "textBoxEventEdit";
            this.textBoxEventEdit.Size = new System.Drawing.Size(218, 22);
            this.textBoxEventEdit.TabIndex = 49;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(34, 206);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 16);
            this.label9.TabIndex = 48;
            this.label9.Text = "Deskripsi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 16);
            this.label4.TabIndex = 47;
            this.label4.Text = "Id";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(34, 120);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 16);
            this.label7.TabIndex = 46;
            this.label7.Text = "Tempat";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 16);
            this.label5.TabIndex = 45;
            this.label5.Text = "Nama Event";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.DarkSalmon;
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.btn_edit);
            this.groupBox2.Controls.Add(this.dtp_edit);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.textBoxIdEditEvent);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.textBoxEventEdit);
            this.groupBox2.Controls.Add(this.textBoxDeskripsiEdit);
            this.groupBox2.Controls.Add(this.textBoxTempatEdit);
            this.groupBox2.Location = new System.Drawing.Point(546, 103);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(398, 359);
            this.groupBox2.TabIndex = 56;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Edit Event Acara";
            // 
            // data_events_uc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_load);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.btn_clear);
            this.Name = "data_events_uc";
            this.Size = new System.Drawing.Size(1090, 742);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEvents)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxEvent;
        private System.Windows.Forms.TextBox textBoxTempat;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView dgvEvents;
        private System.Windows.Forms.Button btn_tambah;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_load;
        private System.Windows.Forms.ComboBox comboBoxInstruktur;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxDeskripsi;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker dtp_edit;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxIdEditEvent;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.TextBox textBoxDeskripsiEdit;
        private System.Windows.Forms.TextBox textBoxTempatEdit;
        private System.Windows.Forms.TextBox textBoxEventEdit;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
    }
}
