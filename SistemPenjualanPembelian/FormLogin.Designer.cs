namespace SistemPenjualanPembelian
{
    partial class FormLogin
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
            this.textBoxPwd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textboxUID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonKeluar
            // 
            this.buttonKeluar.BackColor = System.Drawing.Color.MidnightBlue;
            this.buttonKeluar.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonKeluar.ForeColor = System.Drawing.Color.White;
            this.buttonKeluar.Location = new System.Drawing.Point(221, 204);
            this.buttonKeluar.Name = "buttonKeluar";
            this.buttonKeluar.Size = new System.Drawing.Size(118, 40);
            this.buttonKeluar.TabIndex = 60;
            this.buttonKeluar.Text = "&KELUAR";
            this.buttonKeluar.UseVisualStyleBackColor = false;
            this.buttonKeluar.Click += new System.EventHandler(this.ButtonKeluar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Lavender;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.textBoxPwd);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.textboxUID);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(22, 75);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(401, 115);
            this.panel1.TabIndex = 58;
            // 
            // textBoxPwd
            // 
            this.textBoxPwd.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPwd.Location = new System.Drawing.Point(143, 60);
            this.textBoxPwd.Name = "textBoxPwd";
            this.textBoxPwd.PasswordChar = '*';
            this.textBoxPwd.Size = new System.Drawing.Size(229, 26);
            this.textBoxPwd.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(44, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password : ";
            // 
            // textboxUID
            // 
            this.textboxUID.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textboxUID.Location = new System.Drawing.Point(143, 17);
            this.textboxUID.Name = "textboxUID";
            this.textboxUID.Size = new System.Drawing.Size(229, 26);
            this.textboxUID.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(60, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "User ID : ";
            // 
            // buttonLogin
            // 
            this.buttonLogin.BackColor = System.Drawing.Color.MidnightBlue;
            this.buttonLogin.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogin.ForeColor = System.Drawing.Color.White;
            this.buttonLogin.Location = new System.Drawing.Point(95, 204);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(111, 40);
            this.buttonLogin.TabIndex = 59;
            this.buttonLogin.Text = "&LOGIN";
            this.buttonLogin.UseVisualStyleBackColor = false;
            this.buttonLogin.Click += new System.EventHandler(this.ButtonLogin_Click);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Navy;
            this.label3.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(23, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(400, 36);
            this.label3.TabIndex = 61;
            this.label3.Text = "L O G I N";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 264);
            this.Controls.Add(this.buttonKeluar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonKeluar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBoxPwd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textboxUID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Label label3;
    }
}