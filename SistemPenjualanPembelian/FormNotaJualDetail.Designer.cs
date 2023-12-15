namespace SistemPenjualanPembelian
{
    partial class FormNotaJualDetail
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.buttonKeluar = new System.Windows.Forms.Button();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelNoNota = new System.Windows.Forms.Label();
            this.labelTgl = new System.Windows.Forms.Label();
            this.labelKasir = new System.Windows.Forms.Label();
            this.labelPelanggan = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonKeluar
            // 
            this.buttonKeluar.BackColor = System.Drawing.Color.MidnightBlue;
            this.buttonKeluar.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonKeluar.ForeColor = System.Drawing.Color.White;
            this.buttonKeluar.Location = new System.Drawing.Point(518, 340);
            this.buttonKeluar.Name = "buttonKeluar";
            this.buttonKeluar.Size = new System.Drawing.Size(118, 40);
            this.buttonKeluar.TabIndex = 61;
            this.buttonKeluar.Text = "&KELUAR";
            this.buttonKeluar.UseVisualStyleBackColor = false;
            this.buttonKeluar.Click += new System.EventHandler(this.ButtonKeluar_Click);
            // 
            // dgvData
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.Location = new System.Drawing.Point(12, 116);
            this.dgvData.Name = "dgvData";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvData.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvData.Size = new System.Drawing.Size(624, 206);
            this.dgvData.TabIndex = 62;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(60, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 16);
            this.label1.TabIndex = 63;
            this.label1.Text = "No Nota : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 16);
            this.label2.TabIndex = 64;
            this.label2.Text = "Tgl Transaksi : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(347, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 16);
            this.label3.TabIndex = 66;
            this.label3.Text = "Pelanggan : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(382, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 16);
            this.label4.TabIndex = 65;
            this.label4.Text = "Kasir : ";
            // 
            // labelNoNota
            // 
            this.labelNoNota.AutoSize = true;
            this.labelNoNota.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNoNota.Location = new System.Drawing.Point(137, 18);
            this.labelNoNota.Name = "labelNoNota";
            this.labelNoNota.Size = new System.Drawing.Size(66, 16);
            this.labelNoNota.TabIndex = 67;
            this.labelNoNota.Text = "No Nota  ";
            // 
            // labelTgl
            // 
            this.labelTgl.AutoSize = true;
            this.labelTgl.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTgl.Location = new System.Drawing.Point(137, 66);
            this.labelTgl.Name = "labelTgl";
            this.labelTgl.Size = new System.Drawing.Size(25, 16);
            this.labelTgl.TabIndex = 68;
            this.labelTgl.Text = "tgl";
            // 
            // labelKasir
            // 
            this.labelKasir.AutoSize = true;
            this.labelKasir.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelKasir.Location = new System.Drawing.Point(441, 18);
            this.labelKasir.Name = "labelKasir";
            this.labelKasir.Size = new System.Drawing.Size(39, 16);
            this.labelKasir.TabIndex = 69;
            this.labelKasir.Text = "kasir";
            // 
            // labelPelanggan
            // 
            this.labelPelanggan.AutoSize = true;
            this.labelPelanggan.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPelanggan.Location = new System.Drawing.Point(441, 66);
            this.labelPelanggan.Name = "labelPelanggan";
            this.labelPelanggan.Size = new System.Drawing.Size(75, 16);
            this.labelPelanggan.TabIndex = 70;
            this.labelPelanggan.Text = "pelanggan";
            // 
            // FormNotaJualDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 394);
            this.Controls.Add(this.labelPelanggan);
            this.Controls.Add(this.labelKasir);
            this.Controls.Add(this.labelTgl);
            this.Controls.Add(this.labelNoNota);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonKeluar);
            this.Controls.Add(this.dgvData);
            this.Name = "FormNotaJualDetail";
            this.Text = "Nota Jual Detail";
            this.Load += new System.EventHandler(this.FormNotaJualDetail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonKeluar;
        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelNoNota;
        private System.Windows.Forms.Label labelTgl;
        private System.Windows.Forms.Label labelKasir;
        private System.Windows.Forms.Label labelPelanggan;
    }
}