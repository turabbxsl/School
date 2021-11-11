using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatAccessLayer;
using EntityLayer;

namespace BiznesLogicLayer
{
   public class BLLdersler
    {
        public static List<EntityDersler> BLLDerslistle()
        {
            return DALdersler.Derslistesi();
        }
        public static int BLLDersTelebEkle(EntityBasvuruform parametr)
        {
            if (parametr.Basogrid != null && parametr.Basdersid != null)
            {
                return DALdersler.TelebEkle(parametr);
            }
            return -1;
        }
    }
}
