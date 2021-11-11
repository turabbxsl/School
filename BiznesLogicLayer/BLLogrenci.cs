using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatAccessLayer;
using EntityLayer;

namespace BiznesLogicLayer
{
   public class BLLogrenci
    {
        public static int OgrenciElaveetBLL(EntityOgrenci parametr)
        {
            if (parametr.Ad != null && parametr.Soyad != null && parametr.Nomre != null && parametr.Sifre != null && parametr.Sekil != null)
            {
                return DALogrenci.Ogrencielaveet(parametr);
            }
            else
            {
                return -1;
            }
        }
        public static List<EntityOgrenci> OgrenciListeleBLL()
        {
            return DALogrenci.OgrenciListesi();
        }
        public static bool OgrenciSilBLL(int p)
        {
            if (p>= 0)
            {
                return DALogrenci.OgrenciSil(p);
            }
            return false;
        }
        public static List<EntityOgrenci> OgrenciDetayBLL(int p)
        {
            return DALogrenci.OgrenciDetay(p);
        }
        public static bool OgrenciGuncelleBLL(EntityOgrenci parametr)
        {
            if (parametr.Ad != null && parametr.Soyad != null && parametr.Nomre != null && parametr.Sifre != null && parametr.Sekil != null && parametr.Id > 0)
            {
                return DALogrenci.OgrenciGuncelle(parametr);
            }
            return false;
        }
    }
}
