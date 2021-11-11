using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityLayer;
using DatAccessLayer;
using BiznesLogicLayer;

public partial class Dersler : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Page.IsPostBack == false)
        {
            List<EntityDersler> ent = BLLdersler.BLLDerslistle();
            DropDownList1.DataSource = BLLdersler.BLLDerslistle();
            DropDownList1.DataTextField = "DERSAD";
            DropDownList1.DataValueField = "Id";
            DropDownList1.DataBind();

            List<EntityOgrenci> ent2 = BLLogrenci.OgrenciListeleBLL();
            DropDownList2.DataSource = BLLogrenci.OgrenciListeleBLL();
           
            DropDownList2.DataTextField = "Ad";
            
            
            DropDownList2.DataValueField = "Id";
            DropDownList2.DataBind();
        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        
        EntityBasvuruform ent = new EntityBasvuruform();
        EntityOgrenci ent2 = new EntityOgrenci();
        ent.Basdersid = Convert.ToInt32(DropDownList1.SelectedValue.ToString());
        ent.Basogrid =Convert.ToInt32(DropDownList2.SelectedValue.ToString());



        BLLdersler.BLLDersTelebEkle(ent);
    }
}