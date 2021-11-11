using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityLayer;
using DatAccessLayer;
using BiznesLogicLayer;

public partial class OgrenciSil : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        int x = Convert.ToInt32(Request.QueryString["TELEBEID"]);
        Response.Write(x);

        EntityOgrenci ent = new EntityOgrenci();
        ent.Id = x;
        BLLogrenci.OgrenciSilBLL(ent.Id);
        Response.Redirect("Ogrencilistesi.aspx");


    }
}