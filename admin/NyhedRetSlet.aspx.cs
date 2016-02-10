using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class admin_NyhedRetSlet : System.Web.UI.Page
{
    NyhederFac objNyhed = new NyhederFac();
    DataTable dt = new DataTable();
    protected void Page_Load(object sender, EventArgs e)
    {
        dt = objNyhed.HentAlleNyheder();

        foreach (DataRow nyhed in dt.Rows)
        {
            litResult.Text += "<div id='ret-slet'><a target='_blank' href='../Nyhedsdetaljer.aspx?ID=" + nyhed["fldID"] + "'>" + nyhed["fldDato"] + " - " +nyhed["fldOverskrift"] + "<p> </p></a>";
            litResult.Text += "<div id='ret'><a href='NyhedRetRet.aspx?ret=" + nyhed["fldID"] + "'> <i class='fa fa-pencil fa-2x'></i></a></div>";
            litResult.Text += "<div id='slet'><a href='NyhedRetSlet.aspx?sletid=" + nyhed["fldID"] + "' onclick='return confirm (\"Er du sikker på at du vil slette dette produkt?\")'> <i class='fa fa-trash fa-2x'></i></a></br /></div></div><div class='line'></div>";
        }

        if (!string.IsNullOrEmpty(Request.QueryString["sletid"]))
        {
            SletNyhed();
        }

    }
    protected void SletNyhed()
    {
        objNyhed._id = Convert.ToInt32(Request.QueryString["sletid"]);
        objNyhed.SletNyhed(); // from SQL FAC
        Response.Redirect("NyhedRetSlet.aspx");
    }

}