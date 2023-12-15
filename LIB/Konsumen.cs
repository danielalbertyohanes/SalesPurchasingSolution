using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace LIB
{
    public class Konsumen
    {
        private int kode;
        private string nama;
        private string telp;
        private string alamat;

        public int Kode { get => kode; set => kode = value; }
        public string Nama { get => nama; set => nama = value; }
        public string Telp { get => telp; set => telp = value; }
        public string Alamat { get => alamat; set => alamat = value; }

        public Konsumen()
        {
            Kode = 0;
            Nama = "";
            Telp = "";
            Alamat = "";
        }
        public override string ToString()
        {
            return Nama;
        }

        public static List<Konsumen> BacaData(string filter = "", string nilai = "")
        {
            List<Konsumen> listHasil = new List<Konsumen>();
            string perintah;

            if (filter == "") // jika tdk ada filtering
                perintah = "select * from pelanggan";
            else // jika user melakukan filtering
                perintah = "SELECT * FROM pelanggan where " + filter + " like '%" + nilai + "%'";

            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(perintah);
            
            while (hasil.Read() == true) 
            {   
                Konsumen kons = new Konsumen();
                kons.Kode= int.Parse(hasil.GetValue(0).ToString());
                kons.Nama = hasil.GetValue(1).ToString();
                kons.Alamat = hasil.GetValue(2).ToString();
                kons.Telp = hasil.GetValue(3).ToString();
                listHasil.Add(kons);
            }
            return listHasil;
        }
    }
}
