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
    public partial class frmProductsList : Form
    {
        public frmProductsList()
        {
            InitializeComponent();
        }

        private void FormProductList_Load(object sender, EventArgs e)
        {
            List<Barang> listHasil = Barang.BacaData();
            dgvData.DataSource = listHasil;
        }

        private void TextboxCari_TextChanged(object sender, EventArgs e)
        {
            string filter;
            string nilai = textboxCari.Text;

            if (comboboxCari.SelectedIndex == 0)
                filter = "b.Barcode"; //harus sesuai dg nama field di database
            else if (comboboxCari.SelectedIndex == 1)
                filter = "b.Nama";
            else 
                filter = "k.Nama";

            List<Barang> listHasil = Barang.BacaData(filter, nilai);
            dgvData.DataSource = listHasil;
        }

        private void ButtonTambah_Click(object sender, EventArgs e)
        {
            FormTambahBarang frm = new FormTambahBarang();
            frm.Owner = this;
            frm.ShowDialog();
            FormProductList_Load(this, e);
        }

        private void ButtonUbah_Click(object sender, EventArgs e)
        {
            if (dgvData.SelectedRows.Count > 0)
            {
                FormUbahBarang frm = new FormUbahBarang();
                frm.Owner = this;                
                frm.objUbah = new Barang();
                frm.objUbah.Kode = dgvData.CurrentRow.Cells["Kode"].Value.ToString();
                frm.objUbah.Barcode= dgvData.CurrentRow.Cells["Barcode"].Value.ToString();
                frm.objUbah.Nama = dgvData.CurrentRow.Cells["Nama"].Value.ToString();
                frm.objUbah.Hjual= int.Parse(dgvData.CurrentRow.Cells["Hjual"].Value.ToString());
                frm.objUbah.Stok = int.Parse(dgvData.CurrentRow.Cells["Stok"].Value.ToString());

                //yang ada pada grid hanya NAMA KATEGORI. 
                //oleh karena itu, ambil objek kategori dari db dulu, menggunakan method bacadata-nya kategori
                string namaKategori = dgvData.CurrentRow.Cells["Jenis"].Value.ToString();
                List<Kategori> listHasil = Kategori.BacaData("Nama",namaKategori);
                frm.objUbah.Jenis = listHasil[0];

                frm.ShowDialog();
                //refresh formdaftarkategori
                FormProductList_Load(this, e);
            }
        }
    }
}
