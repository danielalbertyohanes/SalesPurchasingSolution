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
    public partial class FormTambahBarang : Form
    {
        public FormTambahBarang()
        {
            InitializeComponent();
        }

        private void ButtonKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormTambahBarang_Load(object sender, EventArgs e)
        {
            List<Kategori> listHasil = Kategori.BacaData();
            comboBoxKategori.DataSource = listHasil;
            comboBoxKategori.DisplayMember = "Nama"; //yg muncul di combobox adalah bagian nama

            textBoxStok.Text = "0";
            textBoxHJual.Text = "0";
        }

        private void ButtonSimpan_Click(object sender, EventArgs e)
        {            
            Barang objTambah = new Barang();
            objTambah.Kode = textboxKode.Text;
            objTambah.Barcode = textBoxBarcode.Text;
            objTambah.Nama = textBoxNama.Text;
            objTambah.Hjual = int.Parse(textBoxHJual.Text);
            objTambah.Stok = int.Parse(textBoxStok.Text);
            objTambah.Jenis = (Kategori)comboBoxKategori.SelectedItem; //jangan lupa dicast ke kategori dulu, agar objek dari combobox berubah jadi objek kategori

            try
            {                
                Barang.TambahData(objTambah); 

                MessageBox.Show("Penambahan data berhasil");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }
        }
    }
}
