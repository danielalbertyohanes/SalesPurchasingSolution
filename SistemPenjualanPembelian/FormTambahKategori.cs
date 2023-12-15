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
    public partial class FormTambahKategori : Form
    {
        public FormTambahKategori()
        {
            InitializeComponent();
        }

        private void ButtonTambah_Click(object sender, EventArgs e)
        {   //buat objek untuk dikirimkan ke method tambahdata
            Kategori objTambah=new Kategori();
            objTambah.Id = int.Parse(textboxID.Text);
            objTambah.Nama = textBoxNama.Text;

            try
            {
                //panggil method tambahdata
                Kategori.TambahData(objTambah); // menggunakan static method --ATAU--
                //objTambah.TambahDataNonStatic(); // menggunakan non static method

                MessageBox.Show("Penambahan data berhasil");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }
        }

        private void ButtonKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormTambahKategori_Load(object sender, EventArgs e)
        {

        }
    }
}
