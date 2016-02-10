using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class admin_AdminMasterPage : System.Web.UI.MasterPage
{
    protected void Page_Init(object sender, EventArgs e)
    {
        if (Session["login"] != null)
        {
            litUser.Text = Session["login"].ToString();
        }
        else
        {
            Response.Redirect("../Login.aspx");
        }
    }
    protected void btnLogout_Click(object sender, EventArgs e)
    {
        Session.Remove("login");
        Response.Redirect("../Default.aspx");
    }
}
