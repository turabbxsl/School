using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DatAccessLayer;
using BiznesLogicLayer;
using EntityLayer;

public partial class OgrenciGuncelle : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        int x = Convert.ToInt32(Request.QueryString["TELEBEID"].ToString());

        txtID.Text = x.ToString();
        txtID.Enabled = false;

        if (Page.IsPostBack == false)
        {
            List<EntityOgrenci> ogrlist = BLLogrenci.OgrenciDetayBLL(x);

            txtad.Text = ogrlist[0].Ad.ToString();
            txtsoyad.Text = ogrlist[0].Soyad.ToString();
            txtsifre.Text = ogrlist[0].Sifre.ToString();
            txtnomre.Text = ogrlist[0].Nomre.ToString();
            txtsekil.Text = ogrlist[0].Sekil.ToString();

        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        EntityOgrenci ent = new EntityOgrenci();
        ent.Ad = txtad.Text;
        ent.Soyad = txtsoyad.Text;
        ent.Sifre = txtsifre.Text;
        ent.Nomre = txtnomre.Text;
        ent.Sekil = txtsekil.Text;
        ent.Id = Convert.ToInt32(txtID.Text);
        BLLogrenci.OgrenciGuncelleBLL(ent);

        Response.Redirect("Ogrencilistesi.aspx");
    }
}