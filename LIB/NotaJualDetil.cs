using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace LIB
{
    public class NotaJualDetil
    {
        private Barang item;
        private int jum;
        private double harga;

        public Barang Item { get => item; set => item = value; }
        public int Jum { get => jum; set => jum = value; }
        public double Harga { get => harga; set => harga = value; }

        public NotaJualDetil()
        {
            Item = new Barang();
            Jum = 0;
            Harga = 0;
        }
    }
}
