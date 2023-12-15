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
    public partial class FormTambahNotaJual : Form
    {
        public FormTambahNotaJual()
        {
            InitializeComponent();
        }
        Pegawai kasir;
        List<Barang> listHasil;
        double total;
        private void FormTambahNotaJual_Load(object sender, EventArgs e)
        {
            total = 0;

            labelNoNota.Text = NotaJual.GenerateNoNota();
            labelTgl.Text = DateTime.Now.ToString("dd-MM-yyyy");

            //mengambil data user yang sedang login
            FormDaftarNotaJual frm = (FormDaftarNotaJual)this.Owner;
            FormUtama frmUtama = (FormUtama)frm.MdiParent;
            kasir = frmUtama.userLogin;
            labelKasir.Text = kasir.Kode + "/" + kasir.Nama;

            //mengisi combobox pelanggan
            List<Konsumen> listHasil = Konsumen.BacaData();
            comboBoxPelanggan.DataSource = listHasil;
            comboBoxPelanggan.DisplayMember = "Nama";
        }

        private void ButtonKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void TextBoxKode_TextChanged(object sender, EventArgs e)
        {
            if (textBoxKode.TextLength == 13) //jika panjang text inputan user sdh 13 baru dilakukan pencarian
            {
                //ambil data barang dari database berdasarkan kode barcode nya
                listHasil = Barang.BacaData("b.barcode", textBoxKode.Text);
                //jika barang tersedia, tampilkan nama dan harga satuannya
                if (listHasil.Count > 0)
                {
                    textBoxNama.Text = listHasil[0].Nama;
                    textBoxHarga.Text = listHasil[0].Hjual.ToString();
                    textBoxJumlah.Focus();
                    textBoxSubTotal.Text = "";
                    textBoxJumlah.Text = "";
                }
                else //jika kode barang tidak tersedia, tampilkan pesan kesalahan
                {
                    MessageBox.Show("Kode Barang tidak tersedia");
                    textBoxKode.Text = "";
                    textBoxNama.Text = "";
                    textBoxHarga.Text = "";
                    textBoxJumlah.Text = "";
                    textBoxSubTotal.Text = "";
                }
            }
        }

        private void TextBoxJumlah_TextChanged(object sender, EventArgs e)
        {
            if (listHasil.Count > 0 && textBoxJumlah.Text!="")
            {
                int jum = int.Parse(textBoxJumlah.Text);
                int subtotal = jum * listHasil[0].Hjual;
                textBoxSubTotal.Text = subtotal.ToString();
            }
        }

        private void ButtonTambah_Click(object sender, EventArgs e)
        {
            if (listHasil.Count > 0 && textBoxJumlah.Text != "")
            {   //menambahkan data ke datagridview
                dgvData.Rows.Add(textBoxKode.Text, textBoxNama.Text, textBoxHarga.Text, textBoxJumlah.Text, textBoxSubTotal.Text);

                //tambahkan nilai total
                total += double.Parse(textBoxSubTotal.Text);
                labelTotal.Text = "Total Transaksi = Rp " + total.ToString();

                textBoxKode.Text = "";
                textBoxNama.Text = "";
                textBoxHarga.Text = "";
                textBoxJumlah.Text = "";
                textBoxSubTotal.Text = "";
                listHasil = new List<Barang>();
            }
            else if (listHasil.Count == 0)
            {
                MessageBox.Show("Barang belum diinputkan ");
                textBoxKode.Focus();
            }
            else
            {
                MessageBox.Show("Jumlah barang belum diinputkan ");
                textBoxJumlah.Focus();
            }
        }

        private void ButtonSimpan_Click(object sender, EventArgs e)
        {
            int jumlah = int.Parse(textBoxJumlah.Text);
            string kodeBrang = textBoxKode.Text;

            NotaJual notaBaru = new NotaJual();
            notaBaru.NoNota = labelNoNota.Text;
            notaBaru.Pelanggan = (Konsumen)comboBoxPelanggan.SelectedItem;
            notaBaru.Kasir = kasir;

            
            NotaJualDetil notaJualDetail = new NotaJualDetil();
          
            List<Barang> listHasil = Barang.BacaData("KodeBarang",kodeBrang);


            notaJualDetail.Item.Kode = listHasil[0].Kode;
            notaJualDetail.Jum = jumlah;
            notaJualDetail.Harga = listHasil[0].Hjual;

            try
            {
                NotaJual.TambahNota(notaBaru);
                NotaJual.TambahNotaJualDetail(notaJualDetail);
                MessageBox.Show("Nota berhasil ditambahkan");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }

        }
    }
}
