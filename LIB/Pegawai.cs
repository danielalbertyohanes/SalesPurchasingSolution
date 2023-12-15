using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace LIB
{
    public class Pegawai
    {
        private int kode;
        private string nama;
        private DateTime tglLahir;
        private string alamat;
        private int gaji;
        private string username;
        private Jabatan posisi;

        public int Kode { get => kode; set => kode = value; }
        public string Nama { get => nama; set => nama = value; }
        public DateTime TglLahir { get => tglLahir; set => tglLahir = value; }
        public string Alamat { get => alamat; set => alamat = value; }
        public int Gaji { get => gaji; set => gaji = value; }
        public string Username { get => username; set => username = value; }
        public Jabatan Posisi { get => posisi; set => posisi = value; }

        public Pegawai()
        {
            Kode = 0;
            Nama = "";
            TglLahir = DateTime.Now;
            Alamat = "";
            Gaji = 0;
            Username = "";
            Posisi = new Jabatan();
        }
        public Pegawai(int pKode, string pNama, DateTime pTgl, string pAlamat, int pGaji, string pUID, Jabatan pPosisi)
        {
            Kode = pKode;
            Nama = pNama;
            TglLahir = pTgl;
            Alamat = pAlamat;
            Gaji = pGaji;
            Username = pUID;
            Posisi = pPosisi;
        }

        public static Pegawai CekLogin(string UID, string pwd)
        {
            string perintah;
            Pegawai hasil = new Pegawai();
            perintah = "SELECT p.*, j.nama FROM pegawai p inner join jabatan j on j.idjabatan = p.idjabatan where p.username = '" + UID + "' and p.password = SHA2('" + pwd + "',512); ";
            MySqlDataReader drHasil = Koneksi.JalankanPerintahQuery(perintah);
            if (drHasil.Read() == true) //jika ada data yang dapat dibaca dari datareader --> login sukses
            {
                hasil.Kode = int.Parse(drHasil.GetValue(0).ToString());
                hasil.Nama = drHasil.GetValue(1).ToString();
                hasil.TglLahir = DateTime.Parse(drHasil.GetValue(2).ToString());
                hasil.Alamat = drHasil.GetValue(3).ToString();
                hasil.Gaji= int.Parse(drHasil.GetValue(4).ToString());
                hasil.Username= drHasil.GetValue(5).ToString();                

                //UNTUK AGGREGATION OBJEK JABATAN
                Jabatan j= new Jabatan();
                j.Id = drHasil.GetValue(7).ToString();
                j.Nama = drHasil.GetValue(8).ToString();
                hasil.Posisi = j;
            }    
            
            return hasil;
        }

        public override string ToString()
        {
            return Nama;
        }

        // bacadata, tambah, ubah, hapus ikuti alur seperti di class Barang
    }
}
