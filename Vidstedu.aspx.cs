using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Vidstedu : System.Web.UI.Page
{
    VidsteDuFac objVidstedu = new VidsteDuFac();
    DataTable dt = new DataTable();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            dt = objVidstedu.HentAlleVidsteDu();

            foreach (DataRow vidste in dt.Rows)
            {
            litVidsteDu.Text += "<div id='vidstedu'><h2>" + vidste["fldOverskrift"] + "</h2><br /><p>" + vidste["fldVidsteDuTekst"] + "</p><br /><br /></div>";
            }
        }
    }
}