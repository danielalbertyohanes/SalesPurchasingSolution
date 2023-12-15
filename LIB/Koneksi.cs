using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

using System.Configuration;

namespace LIB
{
    public class Koneksi
    {

        private MySqlConnection koneksiDB;

        public MySqlConnection KoneksiDB { get => koneksiDB; private set => koneksiDB = value; }

        public void Connect()
        {   // jika koneksi sdg terbuka, tutup dulu koneksinya
            if (KoneksiDB.State == System.Data.ConnectionState.Open)
            {
                KoneksiDB.Close();
            }
            KoneksiDB.Open();
        }

         public Koneksi()
         {  // mengatur section yang akan diambil dari app config
            Configuration myC = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None); // buka app config
            ConfigurationSectionGroup userSettings = myC.SectionGroups["userSettings"]; // masuk ke bagian usersetting
            var sectionSetting = userSettings.Sections["SistemPenjualanPembelian.db"] as ClientSettingsSection; // masuk ke file settings
            
            // ambil data dari app config
            string vServer = sectionSetting.Settings.Get("DbServer").Value.ValueXml.InnerText;
            string vDb = sectionSetting.Settings.Get("DbName").Value.ValueXml.InnerText;
            string vUID = sectionSetting.Settings.Get("DbUsername").Value.ValueXml.InnerText;
            string vPWD = sectionSetting.Settings.Get("DbPassword").Value.ValueXml.InnerText;

            string conStr = "Server=" + vServer + ";Database=" + vDb + ";Uid=" + vUID + ";Pwd=" + vPWD + ";";

            KoneksiDB = new MySqlConnection();
            KoneksiDB.ConnectionString = conStr;

            Connect();
         }

        public Koneksi(string pServer, string pDb, string pUID, string pPWD)
        {
            string conStr = "Server=" + pServer + ";Database=" + pDb + ";Uid=" + pUID + ";Pwd=" + pPWD + ";";

            KoneksiDB = new MySqlConnection();
            KoneksiDB.ConnectionString = conStr;

            Connect();
        }

        public static MySqlDataReader JalankanPerintahQuery(string perintah)
        {   // untuk menjalankan perintah select saja            
            Koneksi k = new Koneksi();
            MySqlCommand c = new MySqlCommand(perintah, k.KoneksiDB);
            MySqlDataReader hasil = c.ExecuteReader();
            return hasil;
        }

        public static MySqlDataReader JalankanSPNonParam(string perintah)
        {   // untuk menjalankan stored procedure tanpa parameter          
            Koneksi k = new Koneksi();

            MySqlCommand c = new MySqlCommand();
            c.CommandType = System.Data.CommandType.StoredProcedure;
            c.CommandText = perintah; // isi perintah adalah nama SP yang akan dijalankan          
            c.Connection = k.KoneksiDB;           

            MySqlDataReader hasil = c.ExecuteReader();
            return hasil;
        }

        public static void JalankanPerintahNonQuery(string perintah)
        {   // untuk menjalankan perintah insert/update/delete
            Koneksi k = new Koneksi();
            MySqlCommand c = new MySqlCommand(perintah, k.KoneksiDB);
            c.ExecuteNonQuery();           
        }

    }
}
