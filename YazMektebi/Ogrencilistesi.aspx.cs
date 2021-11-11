using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DatAccessLayer;
using EntityLayer;
using BiznesLogicLayer;

public partial class Default2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        List<EntityOgrenci> OgrList = BLLogrenci.OgrenciListeleBLL();
        Repeater1.DataSource = OgrList;
        Repeater1.DataBind();
    }
}