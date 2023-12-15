using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LIB;

namespace SistemPenjualanPembelian
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void ButtonKeluar_Click(object sender, EventArgs e)
        {
            this.Owner.Close();
        }

        private void ButtonLogin_Click(object sender, EventArgs e)
        {
            string uid = textboxUID.Text;
            string pwd = textBoxPwd.Text;

            FormUtama frm = (FormUtama)this.Owner;
            frm.userLogin = Pegawai.CekLogin(uid, pwd);

            if (frm.userLogin.Kode==0) //LOGIN GAGAL --> tutup formutama
            {
                MessageBox.Show("Login gagal");
                frm.Close();                
            }
            else //LOGIN BERHASIL --> tampilkan formutama
            {
                MessageBox.Show("Selamat Datang di Aplikasi Saya");
                frm.Visible = true;
                this.Close();
            }
        }
    }
}
