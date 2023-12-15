namespace SistemPenjualanPembelian
{
    partial class FormDaftarNotaJual
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.buttonKeluar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textboxCari = new System.Windows.Forms.TextBox();
            this.comboboxCari = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.buttonTambah = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonKeluar
            // 
            this.buttonKeluar.BackColor = System.Drawing.Color.MidnightBlue;
            this.buttonKeluar.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonKeluar.ForeColor = System.Drawing.Color.White;
            this.buttonKeluar.Location = new System.Drawing.Point(518, 419);
            this.buttonKeluar.Name = "buttonKeluar";
            this.buttonKeluar.Size = new System.Drawing.Size(118, 40);
            this.buttonKeluar.TabIndex = 58;
            this.buttonKeluar.Text = "&KELUAR";
            this.buttonKeluar.UseVisualStyleBackColor = false;
            this.buttonKeluar.Click += new System.EventHandler(this.ButtonKeluar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Lavender;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.textboxCari);
            this.panel1.Controls.Add(this.comboboxCari);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(11, 58);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(625, 53);
            this.panel1.TabIndex = 56;
            // 
            // textboxCari
            // 
            this.textboxCari.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textboxCari.Location = new System.Drawing.Point(313, 13);
            this.textboxCari.Name = "textboxCari";
            this.textboxCari.Size = new System.Drawing.Size(280, 26);
            this.textboxCari.TabIndex = 2;
            this.textboxCari.TextChanged += new System.EventHandler(this.TextboxCari_TextChanged);
            // 
            // comboboxCari
            // 
            this.comboboxCari.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboboxCari.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboboxCari.FormattingEnabled = true;
            this.comboboxCari.Items.AddRange(new object[] {
            "Nomor Nota",
            "Tgl Nota",
            "Konsumen",
            "Kasir"});
            this.comboboxCari.Location = new System.Drawing.Point(141, 13);
            this.comboboxCari.Name = "comboboxCari";
            this.comboboxCari.Size = new System.Drawing.Size(166, 26);
            this.comboboxCari.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cari Berdasarkan:";
            // 
            // dgvData
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.Location = new System.Drawing.Point(12, 121);
            this.dgvData.Name = "dgvData";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvData.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvData.Size = new System.Drawing.Size(624, 291);
            this.dgvData.TabIndex = 60;
            this.dgvData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvData_CellContentClick);
            // 
            // buttonTambah
            // 
            this.buttonTambah.BackColor = System.Drawing.Color.MidnightBlue;
            this.buttonTambah.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTambah.ForeColor = System.Drawing.Color.White;
            this.buttonTambah.Location = new System.Drawing.Point(11, 419);
            this.buttonTambah.Name = "buttonTambah";
            this.buttonTambah.Size = new System.Drawing.Size(111, 40);
            this.buttonTambah.TabIndex = 57;
            this.buttonTambah.Text = "&TAMBAH";
            this.buttonTambah.UseVisualStyleBackColor = false;
            this.buttonTambah.Click += new System.EventHandler(this.ButtonTambah_Click);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Navy;
            this.label3.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(624, 36);
            this.label3.TabIndex = 59;
            this.label3.Text = "DAFTAR NOTA JUAL";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormDaftarNotaJual
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 467);
            this.Controls.Add(this.buttonKeluar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvData);
            this.Controls.Add(this.buttonTambah);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormDaftarNotaJual";
            this.Load += new System.EventHandler(this.FormDaftarNotaJual_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonKeluar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textboxCari;
        private System.Windows.Forms.ComboBox comboboxCari;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.Button buttonTambah;
        private System.Windows.Forms.Label label3;
    }
}