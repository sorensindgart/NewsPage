using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class admin_VidsteDuRetRet : System.Web.UI.Page
{
    VidsteDuFac objVidsteDu = new VidsteDuFac();
    DataTable dt = new DataTable();
    protected void Page_Load(object sender, EventArgs e)
    {

        if (!IsPostBack)
        {
            if (!string.IsNullOrEmpty(Request.QueryString["ret"]))
            {
                objVidsteDu._id = Convert.ToInt32(Request.QueryString["ret"]);

                dt = objVidsteDu.HentVidsteDuFraID();

                txtOverskrift.Text = dt.Rows[0]["fldOverskrift"].ToString();
                txtTekst.Text = dt.Rows[0]["fldVidsteDuTekst"].ToString();

            }
            else
            {
                Response.Redirect("VidsteDuRetSlet.aspx");
            }
        }

    }
    protected void btnSend_Click(object sender, EventArgs e)
    {
        objVidsteDu._id = Convert.ToInt32(Request.QueryString["ret"]);
        dt = objVidsteDu.HentVidsteDuFraID();

        objVidsteDu._overskrift = txtOverskrift.Text;
        objVidsteDu._tekst = txtTekst.Text;

        int antalnewsopdateret = objVidsteDu.RetVidsteDu();

        if (antalnewsopdateret > 0)
        {
            litResult.Text = "<h4>Så er VidsteDu opdateret!</h4>";
        }
        else
        {
            litResult.Text = "<h4>Fejl i rettelsen!</h4>";
        }
    }
}