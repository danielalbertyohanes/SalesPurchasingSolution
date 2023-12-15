namespace SistemPenjualanPembelian
{
    partial class FormTambahKategori
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
            this.buttonKeluar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBoxNama = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textboxID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonTambah = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonKeluar
            // 
            this.buttonKeluar.BackColor = System.Drawing.Color.MidnightBlue;
            this.buttonKeluar.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonKeluar.ForeColor = System.Drawing.Color.White;
            this.buttonKeluar.Location = new System.Drawing.Point(201, 188);
            this.buttonKeluar.Name = "buttonKeluar";
            this.buttonKeluar.Size = new System.Drawing.Size(118, 40);
            this.buttonKeluar.TabIndex = 56;
            this.buttonKeluar.Text = "&KELUAR";
            this.buttonKeluar.UseVisualStyleBackColor = false;
            this.buttonKeluar.Click += new System.EventHandler(this.ButtonKeluar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Lavender;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.textBoxNama);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.textboxID);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(11, 58);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(401, 115);
            this.panel1.TabIndex = 54;
            // 
            // textBoxNama
            // 
            this.textBoxNama.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNama.Location = new System.Drawing.Point(78, 55);
            this.textBoxNama.Name = "textBoxNama";
            this.textBoxNama.Size = new System.Drawing.Size(280, 26);
            this.textBoxNama.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nama : ";
            // 
            // textboxID
            // 
            this.textboxID.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textboxID.Location = new System.Drawing.Point(78, 12);
            this.textboxID.Name = "textboxID";
            this.textboxID.Size = new System.Drawing.Size(143, 26);
            this.textboxID.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID : ";
            // 
            // buttonTambah
            // 
            this.buttonTambah.BackColor = System.Drawing.Color.MidnightBlue;
            this.buttonTambah.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTambah.ForeColor = System.Drawing.Color.White;
            this.buttonTambah.Location = new System.Drawing.Point(75, 188);
            this.buttonTambah.Name = "buttonTambah";
            this.buttonTambah.Size = new System.Drawing.Size(111, 40);
            this.buttonTambah.TabIndex = 55;
            this.buttonTambah.Text = "&SIMPAN";
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
            this.label3.Size = new System.Drawing.Size(400, 36);
            this.label3.TabIndex = 57;
            this.label3.Text = "TAMBAH KATEGORI";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormTambahKategori
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 245);
            this.Controls.Add(this.buttonKeluar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonTambah);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormTambahKategori";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FormTambahKategori_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonKeluar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textboxID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonTambah;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxNama;
        private System.Windows.Forms.Label label2;
    }
}