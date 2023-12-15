using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

using LIB;

namespace SistemPenjualanPembelian
{
    public partial class FormUtama : Form
    {
        public FormUtama()
        {
            InitializeComponent();
        }

        private void keluarSistemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
        public Pegawai userLogin;
        private void FormUtama_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            this.IsMdiContainer = true;
            this.Visible = false; //agar tdk dpt diakses oleh user

            // munculkan form login sebelum frmutama dpt digunakan oleh user
            FormLogin frm = new FormLogin();
            frm.Owner = this;
            frm.ShowDialog();
            // bagian ini dikerjakan ketika cekLogin berhasil
            labelLogin.Text = "Anda login sebagai " + userLogin.Nama + "(" + userLogin.Posisi.Nama + ")";
            AturMenu(userLogin.Posisi.Id);
        }

        private void AturMenu(string kodejabatan)
        {
            if (kodejabatan == "1") //penjualan
            {
                penjualanToolStripMenuItem.Visible = true;
                pembelianToolStripMenuItem.Visible = false;
                laporanToolStripMenuItem.Visible = false;
            }
            else if (kodejabatan == "2") //pembelian
            {
                penjualanToolStripMenuItem.Visible = false;
                pembelianToolStripMenuItem.Visible = true;
                laporanToolStripMenuItem.Visible = false;
            }
            else if (kodejabatan == "3") //admin
            {
                transaksiToolStripMenuItem.Visible = false;                
                laporanToolStripMenuItem.Visible = true;
            }
        }

        private void kategoriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = Application.OpenForms["frmCategoriesList"];

            if (form == null)
            {
                frmCategoriesList formDaftarKategori = new frmCategoriesList();
                formDaftarKategori.MdiParent = this;
                formDaftarKategori.Show();
            }
            else
            {
                form.Show();
                form.BringToFront();
            }
        }

        private void barangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = Application.OpenForms["FormDaftarBarang"];

            if (form == null)
            {
                frmProductsList formDaftarBarang = new frmProductsList();
                formDaftarBarang.MdiParent = this;
                formDaftarBarang.Show();
            }
            else
            {
                form.Show();
                form.BringToFront();
            }
        }

        private void TutupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LogOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormUtama_Load(this, e);
        }

        private void PenjualanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = Application.OpenForms["FormDaftarNotaJual"];

            if (form == null)
            {
                FormDaftarNotaJual formBaru = new FormDaftarNotaJual();
                formBaru.MdiParent = this;
                formBaru.Show();
            }
            else
            {
                form.Show();
                form.BringToFront();
            }
        }
    }
}
