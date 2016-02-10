using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class admin_VidsteDuRetSlet : System.Web.UI.Page
{
    VidsteDuFac objVidsteDu = new VidsteDuFac();
    DataTable dt = new DataTable();

    protected void Page_Load(object sender, EventArgs e)
    {
                dt = objVidsteDu.HentAlleVidsteDu();

        foreach (DataRow nyhed in dt.Rows)
        {
            litResult.Text += "<div id='ret-slet'><a target='_blank' href='#'>" +nyhed["fldOverskrift"] + "<p> </p></a>";
            litResult.Text += "<div id='ret'><a href='VidsteDuRetRet.aspx?ret=" + nyhed["fldID"] + "'> <i class='fa fa-pencil fa-2x'></i></a></div>";
            litResult.Text += "<div id='slet'><a href='VidsteDuRetSlet.aspx?sletid=" + nyhed["fldID"] + "' onclick='return confirm (\"Er du sikker på at du vil slette dette produkt?\")'> <i class='fa fa-trash fa-2x'></i></a></br /></div></div><div class='line'></div>";
        }

        if (!string.IsNullOrEmpty(Request.QueryString["sletid"]))
        {
            SletNyhed();
        }

    }
    protected void SletNyhed()
    {
        objVidsteDu._id = Convert.ToInt32(Request.QueryString["sletid"]);
        objVidsteDu.SletVidsteDu(); // from SQL FAC
        Response.Redirect("NyhedRetSlet.aspx");
    }
}