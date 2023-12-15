using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace LIB
{
    public class Jabatan
    {
        private string id;
        private string nama;

        public string Id { get => id; set => id = value; }
        public string Nama { get => nama; set => nama = value; }

        public Jabatan()
        {
            Id = "";
            Nama = "";
        }
        public Jabatan(string pID, string pNama)
        {
            Id = pID;
            Nama = pNama;
        }

        public static List<Jabatan> BacaData(string filter = "", string nilai = "")
        {
            List<Jabatan> listHasil = new List<Jabatan>();
            string perintah;

            if (filter == "") 
                perintah = "select * from jabatan";
            else 
                perintah = "SELECT * FROM jabatan where " + filter + " like '%" + nilai + "%'";

            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(perintah);
            
            while (hasil.Read() == true) 
            {   
                Jabatan j= new Jabatan();
                j.Id = hasil.GetValue(0).ToString();
                j.Nama = hasil.GetValue(1).ToString();                
                listHasil.Add(j);                
            }
            return listHasil;
        }

        // tambah, ubah, hapus ikuti alur seperti di class Kategori
    }
}
