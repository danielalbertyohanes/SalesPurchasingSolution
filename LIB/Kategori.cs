using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace LIB
{
    public class Kategori
    {
        private int id;
        private string nama;

        public int Id { get => id; set => id = value; }
        public string Nama { get => nama; set => nama = value; }

        public Kategori()
        {
            Id = 0;
            Nama = "";
        }
        public Kategori(int pID, string pNama)
        {
            Id = pID;
            Nama = pNama;
        }
        // string filter="" --> memberikan default value ke parameter
        // jika user tdk mengisi parameter filter, otomatis diisi ""


        public static List<Kategori> BacaData(string filter = "", string nilai = "")
        {
            List<Kategori> listHasil = new List<Kategori>();
            string perintah;

            if (filter == "") // jika tdk ada filtering
                perintah = "select * from kategori";
            else // jika user melakukan filtering
                perintah = "SELECT * FROM kategori where " + filter + " like '%" + nilai + "%'";

            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(perintah);

            // pindahkan isi reader ke list
            while (hasil.Read() == true) // selama ada yang bisa dibaca di datareader
            {   // buat objek penampung
                Kategori kat = new Kategori();
                kat.Id = int.Parse(hasil.GetValue(0).ToString());
                kat.Nama = hasil.GetValue(1).ToString();
                // masukkan ke list
                listHasil.Add(kat);

                // ATAU dapat ditulis spt ini:
                // listHasil.Add(new Kategori(int.Parse(hasil.GetValue(0).ToString()), hasil.GetValue(1).ToString()));
            }
            return listHasil;
        }

        public static void TambahData(Kategori objTambah)
        {
            string perintah = "INSERT INTO kategori (KodeKategori, Nama) VALUES ('" + objTambah.Id + "', '" + objTambah.Nama + "');";
            Koneksi.JalankanPerintahNonQuery(perintah);
        }

        public void TambahDataNonStatic()
        {
            string perintah = "INSERT INTO kategori (KodeKategori, Nama) VALUES ('" + Id + "', '" + Nama + "');";
            Koneksi.JalankanPerintahNonQuery(perintah);
        }

        public static void UbahData(Kategori objUbah)
        {
            string perintah = "UPDATE kategori SET Nama='"+ objUbah.Nama + "' WHERE KodeKategori='" + objUbah.Id + "';";
            Koneksi.JalankanPerintahNonQuery(perintah);
        }

        public static void HapusData(Kategori objHapus)
        {
            string perintah = "DELETE FROM kategori WHERE KodeKategori='" + objHapus.Id + "';";
            Koneksi.JalankanPerintahNonQuery(perintah);
        }

        public override string ToString()
        {
            return Nama;
        }
    }
}
