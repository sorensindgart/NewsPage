using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    VidsteDuFac objVidstedu = new VidsteDuFac();
    NyhederFac objNyhed = new NyhederFac();
    DataTable dt = new DataTable();

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            dt = objNyhed.HentNyesteNyheder();

            foreach (DataRow nyhed in dt.Rows)
            {
                litNyhed.Text += "<div id='forside-nyhed'><img src='Img/Nyheder/" + nyhed["fldImage"] + "'><br /><div id='forside-nyhed-datooverskrift'><p>" + nyhed["fldDato"] + "</p><h2><a href='Nyhedsdetaljer.aspx?ID=" + nyhed["fldID"] + "'>" + nyhed["fldOverskrift"] + "</h2></a></div></div><br />";
            }


            dt = objVidstedu.HentRandomVidsteDu();

            foreach (DataRow vidste in dt.Rows)
            {
                litVidsteDu.Text += "<div id='vidstedu'><h2>" + vidste["fldOverskrift"] + "</h2><br /><p>" + vidste["fldVidsteDuTekst"] + "</p></div><br />";
            }
        }
    }
}