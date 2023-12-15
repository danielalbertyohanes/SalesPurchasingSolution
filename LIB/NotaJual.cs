using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace LIB
{
    public class NotaJual
    {
        private string noNota;
        private DateTime tgl;
        private Konsumen pelanggan;
        private Pegawai kasir;
        private List<NotaJualDetil> listBelanja;

        public string NoNota { get => noNota; set => noNota = value; }
        public DateTime Tgl { get => tgl; set => tgl = value; }
        public Pegawai Kasir { get => kasir; set => kasir = value; }
        public Konsumen Pelanggan { get => pelanggan; set => pelanggan = value; }
        public List<NotaJualDetil> ListBelanja { get => listBelanja; private set => listBelanja = value; }

        public NotaJual()
        {
            NoNota = "";
            Tgl = DateTime.Now;
            Kasir = new Pegawai();
            Pelanggan = new Konsumen();
            ListBelanja = new List<NotaJualDetil>();
        }

        public static List<NotaJual> BacaData(string filter = "", string nilai = "")
        {
            List<NotaJual> listHasil = new List<NotaJual>();
            string perintah;
            if (filter == "")
                perintah = "select nj.*, p.nama, pl.nama from notajual nj inner join pegawai p on p.kodepegawai=nj.kodepegawai inner join pelanggan pl on pl.kodepelanggan=nj.kodepelanggan";
            else
                perintah = "select nj.*, p.nama, pl.nama from notajual nj inner join pegawai p on p.kodepegawai=nj.kodepegawai inner join pelanggan pl on pl.kodepelanggan=nj.kodepelanggan where " + filter + " like '%" + nilai + "%';";
            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(perintah);

            while (hasil.Read() == true)
            {   // BACA DATA NOTA INI HANYA UNTUK MEMBACA DAFTAR NOTA
                // BELUM MEMBACA ISI DARI NOTA
                // ** isi nota akan dilakukan di function lain agar lebih menghemat proses
                NotaJual nota = new NotaJual();
                nota.NoNota = hasil.GetValue(0).ToString();
                nota.Tgl = DateTime.Parse(hasil.GetValue(1).ToString());
                // pelanggan 
                nota.Pelanggan.Kode= int.Parse(hasil.GetValue(2).ToString());
                nota.Pelanggan.Nama= hasil.GetValue(5).ToString();
                // kasir                 
                nota.Kasir.Kode= int.Parse(hasil.GetValue(3).ToString());
                nota.Kasir.Nama = hasil.GetValue(4).ToString();

                listHasil.Add(nota);
            }
            return listHasil;
        }

        public void BacaDataDetail()
        {   // mengambil detail dari nota tertentu
            //tidak static, karena pembacaan detail ini tergantung pada nota tertentu
            string perintah = "select njd.*, b.nama from notajualdetil njd inner join barang b on njd.kodebarang=b.kodebarang where nonota='" + NoNota+"'";
            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(perintah);
            while (hasil.Read() == true)
            {
                NotaJualDetil njd = new NotaJualDetil();
                njd.Item.Kode= hasil.GetValue(1).ToString();
                njd.Item.Nama= hasil.GetValue(4).ToString();
                njd.Jum = int.Parse(hasil.GetValue(3).ToString());
                njd.Harga= double.Parse(hasil.GetValue(2).ToString());
                
                listBelanja.Add(njd);
            }            

        }

        public static string GenerateNoNota()
        {
            string noNota="";
            // ambil no nota terakhir unt hari ini
            string perintah = "select max(nonota) from notajual where date(tanggal)=curdate();";
            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(perintah);

            if (hasil.Read() == true)
            {   // ambil 3 digit terakhir
                noNota = hasil.GetValue(0).ToString();
                noNota = noNota.Substring(8, 3);
                // 3 digit terakhir ditambah 1
                noNota = (int.Parse(noNota) + 1).ToString();
                // susun no nota yang baru
                // noNota.PadLeft(3,'0'); --> memaksa nonota menjadi 3 karakter
                // jika isi nonota kurang dr 3 karakter, maka di sebelah kirinya akan diisi dengan karakter 0
                noNota = DateTime.Now.ToString("yyyyMMdd") + noNota.PadLeft(3,'0');
            }
            else
                // belum ada nota untuk hari ini, maka no urutnya 1:
                noNota = DateTime.Now.ToString("yyyyMMdd") + "001";
            return noNota;
        }

        public static void TambahNota(NotaJual nj)
        {
            Koneksi k = new Koneksi();

            // CARA 1:
            MySqlCommand c = new MySqlCommand();
            c.CommandType = System.Data.CommandType.StoredProcedure;
            c.CommandText = "uspTambahNotaJual";
            c.Parameters.AddWithValue("pNoNota", nj.NoNota);
            c.Parameters.AddWithValue("pKodeKasir", nj.Kasir.Kode);
            c.Parameters.AddWithValue("pKodePelanggan", nj.Pelanggan.Kode);
            c.Connection = k.KoneksiDB;
            c.ExecuteNonQuery();

            // atau CARA2:
            /*string perintah = "call uspTambahNotaJual('" + nj.NoNota + "','" + nj.Kasir.Kode + "','" + nj.Pelanggan.Kode + "');";
            Koneksi.JalankanPerintahNonQuery(perintah);*/
        }

        public static void TambahNotaJualDetail(NotaJualDetil njd)
        {
            string perintah = "call uspTambahNotaJualDetail('" + njd.Item.Kode + "','" + njd.Jum + "','" + njd.Harga + "');";
            Koneksi.JalankanPerintahNonQuery(perintah);
        }
    }
}
