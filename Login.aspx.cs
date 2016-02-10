using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Login : System.Web.UI.Page
{
    BrugerFac objBruger = new BrugerFac();
    DataTable dt = new DataTable();
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnLogin_Click(object sender, EventArgs e)
    {
        objBruger._user = txtUsername.Text;
        objBruger._password = txtPassword.Text;
        dt = objBruger.BrugerLogin();

        if (dt.Rows.Count > 0)
        {
            Session["login"] = dt.Rows[0]["fldBrugernavn"].ToString();
            Response.Redirect("admin/Default.aspx");
        }
        else
        {
            litResult.Text = "Forkert brugernavn eller password!";
        }
    }
}