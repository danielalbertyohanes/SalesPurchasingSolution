namespace SistemPenjualanPembelian
{
    partial class FormTambahNotaJual
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonKeluar = new System.Windows.Forms.Button();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.Barcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NamaBarang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HargaSatuan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Jumlah = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.labelKasir = new System.Windows.Forms.Label();
            this.labelTgl = new System.Windows.Forms.Label();
            this.labelNoNota = new System.Windows.Forms.Label();
            this.comboBoxPelanggan = new System.Windows.Forms.ComboBox();
            this.buttonSimpan = new System.Windows.Forms.Button();
            this.textBoxKode = new System.Windows.Forms.TextBox();
            this.textBoxNama = new System.Windows.Forms.TextBox();
            this.textBoxHarga = new System.Windows.Forms.TextBox();
            this.textBoxJumlah = new System.Windows.Forms.TextBox();
            this.textBoxSubTotal = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.buttonTambah = new System.Windows.Forms.Button();
            this.labelTotal = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(463, 140);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 21);
            this.label3.TabIndex = 76;
            this.label3.Text = "Pelanggan : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(509, 98);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 21);
            this.label4.TabIndex = 75;
            this.label4.Text = "Kasir : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 140);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 21);
            this.label2.TabIndex = 74;
            this.label2.Text = "Tgl Transaksi : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(80, 98);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 21);
            this.label1.TabIndex = 73;
            this.label1.Text = "No Nota : ";
            // 
            // buttonKeluar
            // 
            this.buttonKeluar.BackColor = System.Drawing.Color.MidnightBlue;
            this.buttonKeluar.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonKeluar.ForeColor = System.Drawing.Color.White;
            this.buttonKeluar.Location = new System.Drawing.Point(700, 494);
            this.buttonKeluar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonKeluar.Name = "buttonKeluar";
            this.buttonKeluar.Size = new System.Drawing.Size(157, 49);
            this.buttonKeluar.TabIndex = 71;
            this.buttonKeluar.Text = "&KELUAR";
            this.buttonKeluar.UseVisualStyleBackColor = false;
            this.buttonKeluar.Click += new System.EventHandler(this.ButtonKeluar_Click);
            // 
            // dgvData
            // 
            this.dgvData.AllowUserToAddRows = false;
            this.dgvData.AllowUserToDeleteRows = false;
            this.dgvData.AllowUserToOrderColumns = true;
            this.dgvData.AllowUserToResizeRows = false;
            this.dgvData.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Barcode,
            this.NamaBarang,
            this.HargaSatuan,
            this.Jumlah,
            this.SubTotal});
            this.dgvData.Location = new System.Drawing.Point(16, 267);
            this.dgvData.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvData.Name = "dgvData";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvData.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvData.RowHeadersWidth = 51;
            this.dgvData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvData.Size = new System.Drawing.Size(841, 208);
            this.dgvData.TabIndex = 72;
            // 
            // Barcode
            // 
            this.Barcode.HeaderText = "Barcode";
            this.Barcode.MinimumWidth = 6;
            this.Barcode.Name = "Barcode";
            this.Barcode.ReadOnly = true;
            this.Barcode.Width = 125;
            // 
            // NamaBarang
            // 
            this.NamaBarang.HeaderText = "Nama Barang";
            this.NamaBarang.MinimumWidth = 6;
            this.NamaBarang.Name = "NamaBarang";
            this.NamaBarang.ReadOnly = true;
            this.NamaBarang.Width = 125;
            // 
            // HargaSatuan
            // 
            this.HargaSatuan.HeaderText = "Harga Satuan";
            this.HargaSatuan.MinimumWidth = 6;
            this.HargaSatuan.Name = "HargaSatuan";
            this.HargaSatuan.ReadOnly = true;
            this.HargaSatuan.Width = 125;
            // 
            // Jumlah
            // 
            this.Jumlah.HeaderText = "Jumlah";
            this.Jumlah.MinimumWidth = 6;
            this.Jumlah.Name = "Jumlah";
            this.Jumlah.ReadOnly = true;
            this.Jumlah.Width = 125;
            // 
            // SubTotal
            // 
            this.SubTotal.HeaderText = "Sub Total";
            this.SubTotal.MinimumWidth = 6;
            this.SubTotal.Name = "SubTotal";
            this.SubTotal.ReadOnly = true;
            this.SubTotal.Width = 125;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Navy;
            this.label5.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(16, 22);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(841, 44);
            this.label5.TabIndex = 81;
            this.label5.Text = "TAMBAH NOTA JUAL";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelKasir
            // 
            this.labelKasir.AutoSize = true;
            this.labelKasir.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelKasir.Location = new System.Drawing.Point(588, 98);
            this.labelKasir.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelKasir.Name = "labelKasir";
            this.labelKasir.Size = new System.Drawing.Size(177, 21);
            this.labelKasir.TabIndex = 79;
            this.labelKasir.Text = "pegawai yang login";
            // 
            // labelTgl
            // 
            this.labelTgl.AutoSize = true;
            this.labelTgl.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTgl.Location = new System.Drawing.Point(183, 140);
            this.labelTgl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTgl.Name = "labelTgl";
            this.labelTgl.Size = new System.Drawing.Size(97, 21);
            this.labelTgl.TabIndex = 78;
            this.labelTgl.Text = "tgl hari ini";
            // 
            // labelNoNota
            // 
            this.labelNoNota.AutoSize = true;
            this.labelNoNota.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNoNota.Location = new System.Drawing.Point(183, 98);
            this.labelNoNota.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNoNota.Name = "labelNoNota";
            this.labelNoNota.Size = new System.Drawing.Size(201, 21);
            this.labelNoNota.TabIndex = 77;
            this.labelNoNota.Text = "generate no nota baru";
            // 
            // comboBoxPelanggan
            // 
            this.comboBoxPelanggan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPelanggan.FormattingEnabled = true;
            this.comboBoxPelanggan.Location = new System.Drawing.Point(592, 140);
            this.comboBoxPelanggan.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxPelanggan.Name = "comboBoxPelanggan";
            this.comboBoxPelanggan.Size = new System.Drawing.Size(204, 24);
            this.comboBoxPelanggan.TabIndex = 82;
            // 
            // buttonSimpan
            // 
            this.buttonSimpan.BackColor = System.Drawing.Color.MidnightBlue;
            this.buttonSimpan.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSimpan.ForeColor = System.Drawing.Color.White;
            this.buttonSimpan.Location = new System.Drawing.Point(529, 494);
            this.buttonSimpan.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonSimpan.Name = "buttonSimpan";
            this.buttonSimpan.Size = new System.Drawing.Size(157, 49);
            this.buttonSimpan.TabIndex = 83;
            this.buttonSimpan.Text = "&SIMPAN";
            this.buttonSimpan.UseVisualStyleBackColor = false;
            this.buttonSimpan.Click += new System.EventHandler(this.ButtonSimpan_Click);
            // 
            // textBoxKode
            // 
            this.textBoxKode.Location = new System.Drawing.Point(16, 235);
            this.textBoxKode.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxKode.Name = "textBoxKode";
            this.textBoxKode.Size = new System.Drawing.Size(132, 22);
            this.textBoxKode.TabIndex = 85;
            this.textBoxKode.TextChanged += new System.EventHandler(this.TextBoxKode_TextChanged);
            // 
            // textBoxNama
            // 
            this.textBoxNama.BackColor = System.Drawing.SystemColors.Menu;
            this.textBoxNama.Enabled = false;
            this.textBoxNama.Location = new System.Drawing.Point(157, 235);
            this.textBoxNama.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxNama.Name = "textBoxNama";
            this.textBoxNama.Size = new System.Drawing.Size(215, 22);
            this.textBoxNama.TabIndex = 86;
            // 
            // textBoxHarga
            // 
            this.textBoxHarga.BackColor = System.Drawing.SystemColors.Menu;
            this.textBoxHarga.Enabled = false;
            this.textBoxHarga.Location = new System.Drawing.Point(381, 235);
            this.textBoxHarga.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxHarga.Name = "textBoxHarga";
            this.textBoxHarga.Size = new System.Drawing.Size(132, 22);
            this.textBoxHarga.TabIndex = 87;
            // 
            // textBoxJumlah
            // 
            this.textBoxJumlah.Location = new System.Drawing.Point(523, 235);
            this.textBoxJumlah.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxJumlah.Name = "textBoxJumlah";
            this.textBoxJumlah.Size = new System.Drawing.Size(132, 22);
            this.textBoxJumlah.TabIndex = 88;
            this.textBoxJumlah.TextChanged += new System.EventHandler(this.TextBoxJumlah_TextChanged);
            // 
            // textBoxSubTotal
            // 
            this.textBoxSubTotal.BackColor = System.Drawing.SystemColors.Menu;
            this.textBoxSubTotal.Enabled = false;
            this.textBoxSubTotal.Location = new System.Drawing.Point(664, 235);
            this.textBoxSubTotal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxSubTotal.Name = "textBoxSubTotal";
            this.textBoxSubTotal.Size = new System.Drawing.Size(132, 22);
            this.textBoxSubTotal.TabIndex = 89;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 212);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 21);
            this.label6.TabIndex = 90;
            this.label6.Text = "Barcode";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(153, 212);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(125, 21);
            this.label7.TabIndex = 91;
            this.label7.Text = "Nama Barang";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(377, 212);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(126, 21);
            this.label8.TabIndex = 92;
            this.label8.Text = "Harga Satuan";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(519, 212);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 21);
            this.label9.TabIndex = 93;
            this.label9.Text = "Jumlah";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(664, 212);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(91, 21);
            this.label10.TabIndex = 94;
            this.label10.Text = "Sub Total";
            // 
            // buttonTambah
            // 
            this.buttonTambah.BackColor = System.Drawing.Color.MidnightBlue;
            this.buttonTambah.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTambah.ForeColor = System.Drawing.Color.White;
            this.buttonTambah.Location = new System.Drawing.Point(805, 218);
            this.buttonTambah.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonTambah.Name = "buttonTambah";
            this.buttonTambah.Size = new System.Drawing.Size(52, 49);
            this.buttonTambah.TabIndex = 95;
            this.buttonTambah.Text = "+";
            this.buttonTambah.UseVisualStyleBackColor = false;
            this.buttonTambah.Click += new System.EventHandler(this.ButtonTambah_Click);
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotal.Location = new System.Drawing.Point(12, 479);
            this.labelTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(202, 21);
            this.labelTotal.TabIndex = 96;
            this.labelTotal.Text = "Total Transaksi = Rp 0";
            // 
            // FormTambahNotaJual
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 555);
            this.Controls.Add(this.labelTotal);
            this.Controls.Add(this.buttonTambah);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxSubTotal);
            this.Controls.Add(this.textBoxJumlah);
            this.Controls.Add(this.textBoxHarga);
            this.Controls.Add(this.textBoxNama);
            this.Controls.Add(this.textBoxKode);
            this.Controls.Add(this.buttonSimpan);
            this.Controls.Add(this.comboBoxPelanggan);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.labelKasir);
            this.Controls.Add(this.labelTgl);
            this.Controls.Add(this.labelNoNota);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonKeluar);
            this.Controls.Add(this.dgvData);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormTambahNotaJual";
            this.Load += new System.EventHandler(this.FormTambahNotaJual_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonKeluar;
        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelKasir;
        private System.Windows.Forms.Label labelTgl;
        private System.Windows.Forms.Label labelNoNota;
        private System.Windows.Forms.ComboBox comboBoxPelanggan;
        private System.Windows.Forms.Button buttonSimpan;
        private System.Windows.Forms.TextBox textBoxKode;
        private System.Windows.Forms.TextBox textBoxNama;
        private System.Windows.Forms.TextBox textBoxHarga;
        private System.Windows.Forms.TextBox textBoxJumlah;
        private System.Windows.Forms.TextBox textBoxSubTotal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button buttonTambah;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Barcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn NamaBarang;
        private System.Windows.Forms.DataGridViewTextBoxColumn HargaSatuan;
        private System.Windows.Forms.DataGridViewTextBoxColumn Jumlah;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubTotal;
    }
}