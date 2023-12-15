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
    public partial class FormDaftarNotaJual : Form
    {
        public FormDaftarNotaJual()
        {
            InitializeComponent();
        }

        private void FormDaftarNotaJual_Load(object sender, EventArgs e)
        {
            List<NotaJual> listHasil = NotaJual.BacaData();
            dgvData.DataSource = listHasil;

            if (dgvData.ColumnCount == 4)
            {   
                DataGridViewButtonColumn btnDetail = new DataGridViewButtonColumn();
                btnDetail.HeaderText = "Aksi"; 
                btnDetail.Text = "Lihat Detail"; 
                btnDetail.Name = "buttonDetail"; 
                btnDetail.UseColumnTextForButtonValue = true;
                dgvData.Columns.Add(btnDetail);
            }
        }

        private void TextboxCari_TextChanged(object sender, EventArgs e)
        {
            string filter;
            string nilai = textboxCari.Text;

            if (comboboxCari.SelectedIndex == 1)
                filter = "nj.Tanggal";
            else if (comboboxCari.SelectedIndex == 2)
                filter = "pl.Nama"; // nama konsumen
            else if (comboboxCari.SelectedIndex == 3)
                filter = "p.Nama"; // nama kasir
            else //jika user tdk memilih jenis filter, maka filter berdasar no nota
                filter = "nj.NoNota";

            List<NotaJual> listHasil = NotaJual.BacaData(filter, nilai);
            dgvData.DataSource = listHasil;
        }

        private void DgvData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int indexDetail = dgvData.Columns["buttonDetail"].Index;
            if (e.ColumnIndex == indexDetail)
            {
                FormNotaJualDetail frm = new FormNotaJualDetail();
                frm.Owner = this;
                //CARA 1:
                string nonota = dgvData.CurrentRow.Cells["NoNota"].Value.ToString();
                List<NotaJual> listHasil = NotaJual.BacaData("nj.NoNota", nonota);
                frm.notaJualTampil = listHasil[0];
                //CARA 2:
                /*frm.notaJualTampil = new NotaJual();
                frm.notaJualTampil.NoNota = dgvData.CurrentRow.Cells["NoNota"].Value.ToString();
                frm.notaJualTampil.Tgl = DateTime.Parse(dgvData.CurrentRow.Cells["Tgl"].Value.ToString());
                frm.notaJualTampil.Kasir.Nama = dgvData.CurrentRow.Cells["Kasir"].Value.ToString();
                frm.notaJualTampil.Pelanggan.Nama = dgvData.CurrentRow.Cells["Pelanggan"].Value.ToString();*/

                frm.notaJualTampil.BacaDataDetail();
                frm.ShowDialog();
            }
        }

        private void ButtonTambah_Click(object sender, EventArgs e)
        {
            FormTambahNotaJual frm = new FormTambahNotaJual();
            frm.Owner = this;
            frm.ShowDialog();
        }

        private void ButtonKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
