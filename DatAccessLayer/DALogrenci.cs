using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using EntityLayer;

namespace DatAccessLayer
{
    public class DALogrenci
    {
        public static int Ogrencielaveet(EntityOgrenci parametr)
        {
            SqlCommand cmd1 = new SqlCommand("insert into tbl_ogrenci (OGRAD,OGRSOYAD,OGRNOMRE,OGRFOTO,OGRSIFRE) values(@p1,@p2,@p3,@p4,@p5)", Baglanti.bg);
            if (cmd1.Connection.State != ConnectionState.Open)
            {
                cmd1.Connection.Open();
            }
            cmd1.Parameters.AddWithValue("@p1", parametr.Ad);
            cmd1.Parameters.AddWithValue("@p2", parametr.Soyad);
            cmd1.Parameters.AddWithValue("@p3", parametr.Nomre);
            cmd1.Parameters.AddWithValue("@p4", parametr.Sekil);
            cmd1.Parameters.AddWithValue("@p5", parametr.Sifre);

            return cmd1.ExecuteNonQuery();
        }
        public static List<EntityOgrenci> OgrenciListesi()
        {
            List<EntityOgrenci> deyerler = new List<EntityOgrenci>();
            SqlCommand cmd2 = new SqlCommand("select * from tbl_ogrenci", Baglanti.bg);

            if (cmd2.Connection.State != ConnectionState.Open)
            {
                cmd2.Connection.Open();
            }
            SqlDataReader dr = cmd2.ExecuteReader();
            while (dr.Read())
            {
                EntityOgrenci ent = new EntityOgrenci();
                ent.Id = Convert.ToInt32(dr["OGRID"]);
                ent.Ad = dr["OGRAD"].ToString();
                ent.Soyad = dr["OGRSOYAD"].ToString();
                ent.Nomre = dr["OGRNOMRE"].ToString();
                ent.Sifre = dr["OGRSIFRE"].ToString();
                ent.Sekil = dr["OGRFOTO"].ToString();
                ent.Bakiye = Convert.ToDouble(dr["OGRBAKIYE"].ToString());

                deyerler.Add(ent);
            }
            dr.Close();
            return deyerler;
        }
        public static bool OgrenciSil(int parametr2)
        {
            SqlCommand cmd3 = new SqlCommand("delete from tbl_ogrenci where OGRID = @p1", Baglanti.bg);
            if (cmd3.Connection.State != ConnectionState.Open)
            {
                cmd3.Connection.Open();
            }

            cmd3.Parameters.AddWithValue("@p1", parametr2);
            return cmd3.ExecuteNonQuery() > 0;
        }
        public static List<EntityOgrenci> OgrenciDetay(int id)
        {
            List<EntityOgrenci> deyerler = new List<EntityOgrenci>();
            SqlCommand cmd4 = new SqlCommand("select * from tbl_ogrenci where OGRID = @p1", Baglanti.bg);
            cmd4.Parameters.AddWithValue("@p1", id);
            if (cmd4.Connection.State != ConnectionState.Open)
            {
                cmd4.Connection.Open();
            }
            SqlDataReader dr = cmd4.ExecuteReader();
            while (dr.Read())
            {
                EntityOgrenci ent = new EntityOgrenci();

                ent.Ad = dr["OGRAD"].ToString();
                ent.Soyad = dr["OGRSOYAD"].ToString();
                ent.Nomre = dr["OGRNOMRE"].ToString();
                ent.Sifre = dr["OGRSIFRE"].ToString();
                ent.Sekil = dr["OGRFOTO"].ToString();
                ent.Bakiye = Convert.ToDouble(dr["OGRBAKIYE"].ToString());

                deyerler.Add(ent);
            }
            dr.Close();
            return deyerler;
        }
        public static bool OgrenciGuncelle(EntityOgrenci deyer)
        {
            SqlCommand cmd5 = new SqlCommand("update tbl_ogrenci set OGRAD = @p1,OGRSOYAD = @p2,OGRNOMRE = @p3,OGRFOTO = @p4,OGRSIFRE = @p5 where OGRID = @p6", Baglanti.bg);

            if (cmd5.Connection.State != ConnectionState.Open)
            {
                cmd5.Connection.Open();
            }

            cmd5.Parameters.AddWithValue("@p1", deyer.Ad);
            cmd5.Parameters.AddWithValue("@p2", deyer.Soyad);
            cmd5.Parameters.AddWithValue("@p3", deyer.Nomre);
            cmd5.Parameters.AddWithValue("@p4", deyer.Sekil);
            cmd5.Parameters.AddWithValue("@p5", deyer.Sifre);
            cmd5.Parameters.AddWithValue("@p6", deyer.Id);

            return cmd5.ExecuteNonQuery() > 0;
        }
    }
}
