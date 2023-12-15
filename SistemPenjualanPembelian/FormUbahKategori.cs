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
    public partial class FormUbahKategori : Form
    {
        public FormUbahKategori()
        {
            InitializeComponent();
        }
        public Kategori objUbah;
        private void FormUbahKategori_Load(object sender, EventArgs e)
        {
            textboxID.Text = objUbah.Id.ToString();
            textBoxNama.Text = objUbah.Nama;
        }

        private void ButtonTambah_Click(object sender, EventArgs e)
        {
            objUbah.Nama = textBoxNama.Text; //ambil kembali data dari textbox
            Kategori.UbahData(objUbah); //panggil method ubah di class
            MessageBox.Show("Perubahan data berhasil disimpan");
            this.Close();
        }
    }
}
