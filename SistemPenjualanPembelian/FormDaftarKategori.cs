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
    public partial class frmCategoriesList : Form
    {
        public frmCategoriesList()
        {
            InitializeComponent();
        }

        private void frmCategoriesList_Load(object sender, EventArgs e)
        {
            List<Kategori> listHasil = Kategori.BacaData();
            dgvData.DataSource = listHasil;

            if (dgvData.ColumnCount == 2)
            {   // menambah objek button hapus di datagridview
                DataGridViewButtonColumn btnHapus = new DataGridViewButtonColumn();
                btnHapus.HeaderText = "Aksi"; //judul kolom
                btnHapus.Text = "Hapus Data"; //tulisan di button
                btnHapus.Name = "buttonHapus"; //nama objek
                btnHapus.UseColumnTextForButtonValue = true;
                dgvData.Columns.Add(btnHapus);
            }
        }

        private void TextboxCari_TextChanged(object sender, EventArgs e)
        {   // method ini dijalankan setiap kali user ketik di textboxCari

            string filter;
            string nilai=textboxCari.Text;

            if (comboboxCari.SelectedIndex == 0)
                filter = "KodeKategori"; //harus sesuai dg nama field di database
            else
                filter = "Nama";

            List<Kategori> listHasil = Kategori.BacaData(filter,nilai);
            dgvData.DataSource = listHasil;
        }

        private void ButtonTambah_Click(object sender, EventArgs e)
        {
            FormTambahKategori frm = new FormTambahKategori();
            frm.Owner = this;
            frm.ShowDialog();
            // refresh form 
            frmCategoriesList_Load(this, e);
        }

        private void ButtonKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DgvData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int indexHapus = dgvData.Columns["buttonHapus"].Index;
            if (e.ColumnIndex == indexHapus)
            //if (e.ColumnIndex == 2) --> jika sudah tahu posisi button di kolom ke berapa
            {
                //konfirmasi ke user apakah benar mau menghapus data atau tidak
                DialogResult hasil = MessageBox.Show("Yakin mau menghapus data?","Hapus Data",MessageBoxButtons.YesNo);
                if (hasil == DialogResult.Yes)
                {
                    //jika user menjawab YA: lakukan penghapusan data
                    Kategori objHapus = new Kategori();
                    objHapus.Id = int.Parse(dgvData.CurrentRow.Cells["Id"].Value.ToString());
                    try
                    {
                        Kategori.HapusData(objHapus);
                        MessageBox.Show("Penghapusan data berhasil");
                        frmCategoriesList_Load(this, e);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("error: " + ex.Message);
                    }
                }
            }
        }

        private void ButtonUbah_Click(object sender, EventArgs e)
        {
            //dgvData.SelectedRows.Count=0 --> tidak ada data yg dipilih oleh user di grid
            if (dgvData.SelectedRows.Count > 0)
            {
                FormUbahKategori frm = new FormUbahKategori();
                frm.Owner = this;            
                // mengisi objek di formubah, isi sesuai data yang dipilih oleh user di grid
                // currentrow menunjukkan baris yang dipilih oleh user
                frm.objUbah = new Kategori();
                frm.objUbah.Id = int.Parse(dgvData.CurrentRow.Cells["Id"].Value.ToString());
                frm.objUbah.Nama = dgvData.CurrentRow.Cells["Nama"].Value.ToString();

                frm.ShowDialog();
                //refresh formdaftarkategori
                frmCategoriesList_Load(this, e);
            }
        }

        private void DgvData_Click(object sender, EventArgs e)
        {
            buttonUbah.Enabled = true;
        }
    }
}
