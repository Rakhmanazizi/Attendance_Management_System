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
            this.btn_export_pdf = new System.Windows.Forms.Button();
            this.btn_export_csv = new System.Windows.Forms.Button();
            this.comboBoxInstruktur = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEvents)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nama Event";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(76, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tempat ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(76, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tanggal";
            // 
            // textBoxEvent
            // 
            this.textBoxEvent.Location = new System.Drawing.Point(179, 46);
            this.textBoxEvent.Name = "textBoxEvent";
            this.textBoxEvent.Size = new System.Drawing.Size(242, 22);
            this.textBoxEvent.TabIndex = 4;
            // 
            // textBoxTempat
            // 
            this.textBoxTempat.Location = new System.Drawing.Point(179, 94);
            this.textBoxTempat.Name = "textBoxTempat";
            this.textBoxTempat.Size = new System.Drawing.Size(242, 22);
            this.textBoxTempat.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(76, 211);
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
            this.tableLayoutPanel1.Location = new System.Drawing.Point(79, 522);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(958, 311);
            this.tableLayoutPanel1.TabIndex = 12;
            // 
            // dgvEvents
            // 
            this.dgvEvents.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEvents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEvents.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvEvents.Location = new System.Drawing.Point(3, 3);
            this.dgvEvents.Name = "dgvEvents";
            this.dgvEvents.RowHeadersWidth = 49;
            this.dgvEvents.RowTemplate.Height = 24;
            this.dgvEvents.Size = new System.Drawing.Size(952, 305);
            this.dgvEvents.TabIndex = 0;
            // 
            // btn_tambah
            // 
            this.btn_tambah.Location = new System.Drawing.Point(314, 293);
            this.btn_tambah.Name = "btn_tambah";
            this.btn_tambah.Size = new System.Drawing.Size(107, 48);
            this.btn_tambah.TabIndex = 13;
            this.btn_tambah.Text = "Tambah";
            this.btn_tambah.UseVisualStyleBackColor = true;
            this.btn_tambah.Click += new System.EventHandler(this.btn_tambah_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(179, 293);
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
            // btn_export_pdf
            // 
            this.btn_export_pdf.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_export_pdf.Location = new System.Drawing.Point(930, 468);
            this.btn_export_pdf.Name = "btn_export_pdf";
            this.btn_export_pdf.Size = new System.Drawing.Size(107, 48);
            this.btn_export_pdf.TabIndex = 16;
            this.btn_export_pdf.Text = "EXPORT PDF";
            this.btn_export_pdf.UseVisualStyleBackColor = true;
            // 
            // btn_export_csv
            // 
            this.btn_export_csv.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_export_csv.Location = new System.Drawing.Point(817, 468);
            this.btn_export_csv.Name = "btn_export_csv";
            this.btn_export_csv.Size = new System.Drawing.Size(107, 48);
            this.btn_export_csv.TabIndex = 17;
            this.btn_export_csv.Text = "EXPORT CSV";
            this.btn_export_csv.UseVisualStyleBackColor = true;
            // 
            // comboBoxInstruktur
            // 
            this.comboBoxInstruktur.FormattingEnabled = true;
            this.comboBoxInstruktur.Location = new System.Drawing.Point(179, 211);
            this.comboBoxInstruktur.Name = "comboBoxInstruktur";
            this.comboBoxInstruktur.Size = new System.Drawing.Size(242, 24);
            this.comboBoxInstruktur.TabIndex = 18;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(179, 149);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(242, 22);
            this.dateTimePicker1.TabIndex = 19;
            // 
            // data_events_uc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.comboBoxInstruktur);
            this.Controls.Add(this.btn_export_csv);
            this.Controls.Add(this.btn_export_pdf);
            this.Controls.Add(this.btn_load);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_tambah);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxTempat);
            this.Controls.Add(this.textBoxEvent);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "data_events_uc";
            this.Size = new System.Drawing.Size(1090, 742);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEvents)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.Button btn_export_pdf;
        private System.Windows.Forms.Button btn_export_csv;
        private System.Windows.Forms.ComboBox comboBoxInstruktur;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}
