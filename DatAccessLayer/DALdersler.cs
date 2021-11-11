using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using EntityLayer;

namespace DatAccessLayer
{
    public class DALdersler
    {
        public static List<EntityDersler> Derslistesi()
        {
            List<EntityDersler> deyerler = new List<EntityDersler>();
            SqlCommand cmd1 = new SqlCommand("select * from tbl_dersler", Baglanti.bg);

            if (cmd1.Connection.State != ConnectionState.Open)
            {
                cmd1.Connection.Open();
            }

            SqlDataReader dr = cmd1.ExecuteReader();
            while (dr.Read())
            {
                EntityDersler ent = new EntityDersler();
                ent.Id = Convert.ToInt32(dr["DERSID"].ToString());
                ent.Dersad = dr["DERSAD"].ToString();
                ent.Min = Convert.ToInt32(dr["DERSMINKON"].ToString());
                ent.Max = Convert.ToInt32(dr["DERSMAXKON"].ToString());
                deyerler.Add(ent);
            }
            dr.Close();
            return deyerler;
        }
        public static int TelebEkle(EntityBasvuruform parametr)
        {
            SqlCommand cmd2 = new SqlCommand("insert into tbl_basvuruform (OGRENCIID,DERSID) values (@p1,@p2)", Baglanti.bg);
            cmd2.Parameters.AddWithValue("@p1", parametr.Basogrid);
            cmd2.Parameters.AddWithValue("@p2", parametr.Basdersid);

            if (cmd2.Connection.State != ConnectionState.Open)
            {
                cmd2.Connection.Open();
            }

            return cmd2.ExecuteNonQuery();
        }
    }
}
