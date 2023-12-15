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
    public partial class FormUbahBarang : Form
    {
        public FormUbahBarang()
        {
            InitializeComponent();
        }
        public Barang objUbah;
        private void FormUbahBarang_Load(object sender, EventArgs e)
        {
            List<Kategori> listHasil = Kategori.BacaData();
            comboBoxKategori.DataSource = listHasil;
            comboBoxKategori.DisplayMember = "Nama";

            textboxKode.Text = objUbah.Kode;
            textBoxBarcode.Text = objUbah.Barcode;
            textBoxNama.Text = objUbah.Nama;
            textBoxHJual.Text = objUbah.Hjual.ToString();
            textBoxStok.Text = objUbah.Stok.ToString();
            
            comboBoxKategori.Text = objUbah.Jenis.Nama;
        }

        private void ButtonSimpan_Click(object sender, EventArgs e)
        {            
            objUbah.Barcode=textBoxBarcode.Text;
            objUbah.Nama=textBoxNama.Text;
            objUbah.Hjual=int.Parse(textBoxHJual.Text);
            
            objUbah.Jenis=(Kategori)comboBoxKategori.SelectedItem;

            try
            {
                Barang.UbahData(objUbah);

                MessageBox.Show("Pengubahan data berhasil");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }
        }
    }
}
