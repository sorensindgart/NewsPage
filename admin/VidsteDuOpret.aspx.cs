using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class admin_VidsteDuOpret : System.Web.UI.Page
{
    VidsteDuFac objVidste = new VidsteDuFac();
    DataTable dt = new DataTable();

    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnSend_Click(object sender, EventArgs e)
    {
        objVidste._overskrift = txtOverskrift.Text;
        objVidste._tekst = txtTekst.Text;

        int addedsubject = objVidste.OpretVidsteDu();

        if (addedsubject > 0)
        {
            txtOverskrift.Text = "";
            txtTekst.Text = "";

            litResult.Text = "<h4>Subject submitted!";
        }
        else
        {
            litResult.Text = "<h4>Error!";
        }

    }
}