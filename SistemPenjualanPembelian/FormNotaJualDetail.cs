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
    public partial class FormNotaJualDetail : Form
    {
        public FormNotaJualDetail()
        {
            InitializeComponent();
        }

        private void ButtonKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public NotaJual notaJualTampil;
        private void FormNotaJualDetail_Load(object sender, EventArgs e)
        {
            labelNoNota.Text = notaJualTampil.NoNota;
            labelTgl.Text = notaJualTampil.Tgl.ToString("dd/MM/yyyy");
            labelKasir.Text = notaJualTampil.Kasir.Nama;
            labelPelanggan.Text = notaJualTampil.Pelanggan.Nama;
            dgvData.DataSource = notaJualTampil.ListBelanja;
        }
    }
}
