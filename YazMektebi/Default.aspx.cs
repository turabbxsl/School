using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityLayer;
using DatAccessLayer;
using BiznesLogicLayer;

 



public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        EntityOgrenci ent = new EntityOgrenci();
        ent.Ad = txtad.Text;
        ent.Soyad =txtsoyad.Text;
        ent.Nomre = txtnomre.Text;
        ent.Sifre = txtsifre.Text;
        ent.Sekil = txtsekil.Text;

        BLLogrenci.OgrenciElaveetBLL(ent);



    }
}