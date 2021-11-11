using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class EntityOgrenci
    {
        private string ad;
        private string soyad;
        private int id;
        private string nomre;
        private string sekil;
        private double bakiye;
        private string sifre;
        ////////////////////////////////////////////////////
        public string Ad { get => ad; set => ad = value; }
        public string Soyad { get => soyad; set => soyad = value; }
        public int Id { get => id; set => id = value; }
        public string Nomre { get => nomre; set => nomre = value; }
        public string Sekil { get => sekil; set => sekil = value; }
        public double Bakiye { get => bakiye; set => bakiye = value; }
        public string Sifre { get => sifre; set => sifre = value; }
    }
}
