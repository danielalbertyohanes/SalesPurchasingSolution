using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace LIB
{
    public class Barang
    {
        private string kode;
        private string barcode;
        private string nama;
        private int hjual;
        private int stok;
        private Kategori jenis;

        public string Kode { get => kode; set => kode = value; }
        public string Barcode { get => barcode; set => barcode = value; }
        public string Nama { get => nama; set => nama = value; }
        public int Hjual { get => hjual; set => hjual = value; }
        public int Stok { get => stok; set => stok = value; }
        public Kategori Jenis { get => jenis; set => jenis = value; }

        public Barang()
        {
            Kode = "";
            Barcode = "";
            Nama = "";
            Hjual = 0;
            Stok = 0;
            jenis = new Kategori();
        }

        public static List<Barang> BacaData(string filter = "", string nilai = "")
        {
            List<Barang> listHasil = new List<Barang>();
            //CARA 1:
            string perintah;
            if (filter == "")                
                perintah = "call uspTampilBarangID('%')";
            else
                perintah = "call uspTampilBarangID('" + nilai + "')"; // filter hanya dapat dilakukan terhadap ID
            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(perintah);
            

            //CARA 2:
            //JIKA MEMANGGIL SP MENGGUNAKAN COMMANDTYPE SP --> TIDAK BISA MENGGUNAKAN STATIC METHOD DI KONEKSI. HAL INI DIKARENAKAN JUMLAH DAN NAMA PARAMETER BERGANTUNG PADA MASING2 SP
            //MAKA, SETTING KONEKSI DAN LAINNYA HARUS DILAKUKAN SETIAP KALI DIBUTUHKAN, SPT DI BAWAH INI:
            /*Koneksi k = new Koneksi();
            MySqlCommand c = new MySqlCommand();
            c.CommandType = System.Data.CommandType.StoredProcedure;
            c.CommandText = "uspTampilBarangID";
            c.Parameters.AddWithValue("ID", nilai); //mengisi parameter
            c.Connection = k.KoneksiDB;
            MySqlDataReader hasil = c.ExecuteReader();*/

            //agar lebih singkat, maka lebih baik tetap menggunakan jalankanperintahquery, di mana perintah diisi dengan "call namasp(param2,param2,...)"

            while (hasil.Read() == true) 
            {
                Barang brg = new Barang();
                brg.Kode = hasil.GetValue(0).ToString();
                brg.Barcode = hasil.GetValue(1).ToString();
                brg.Nama = hasil.GetValue(2).ToString();
                brg.Hjual= int.Parse(hasil.GetValue(3).ToString());
                brg.Stok= int.Parse(hasil.GetValue(4).ToString());

                //UNTUK AGGREGATION KATEGORI PADA OBJEK BARANG
                Kategori kat = new Kategori(); 
                kat.Id = int.Parse(hasil.GetValue(5).ToString());
                kat.Nama = hasil.GetValue(6).ToString();

                brg.Jenis = kat;

                listHasil.Add(brg);
            }
            return listHasil;
        }

        public static void TambahData(Barang objTambah)
        {
            //objTambah.Jenis.Id --> mengambil kode kategori pada objek jenis
            string perintah = "INSERT INTO barang (KodeBarang, Barcode, Nama, HargaJual, Stok, KodeKategori) VALUES ('" + objTambah.Kode + "', '" + objTambah.Barcode + "', '" + objTambah.Nama + "', '" + objTambah.Hjual.ToString() + "', '" + objTambah.Stok.ToString() + "', '" + objTambah.Jenis.Id + "');";
            Koneksi.JalankanPerintahNonQuery(perintah);
        }

        public static void UbahData(Barang objUbah)
        {
            string perintah = "UPDATE barang SET Barcode='" + objUbah.Barcode + "', Nama='" + objUbah.Nama + "', HargaJual='" + objUbah.Hjual.ToString() + "', KodeKategori='" + objUbah.Jenis.Id + "' WHERE KodeBarang='" + objUbah.Kode + "';";
            Koneksi.JalankanPerintahNonQuery(perintah);
        }

        public override string ToString()
        {
            return Nama;
        }
    }
}
