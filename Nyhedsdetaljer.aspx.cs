using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Nyhedsdetaljer : System.Web.UI.Page
{
    NyhederFac objNyhed = new NyhederFac();
    DataTable dt = new DataTable();

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if (!string.IsNullOrEmpty(Request.QueryString["ID"])) // IF ID EXIST THEN CONTINUE THE CODE - ELSE GO TO DEFAULT WEBPAGE
            {
                objNyhed._id = Convert.ToInt32(Request.QueryString["ID"]);

                dt = objNyhed.HentNyhedFraID();

                foreach (DataRow nyhed in dt.Rows)
                {
                    litNyhed.Text += "<div id='ind-nyhed'>";
                    litNyhed.Text += "<p class='ind-nyhed-img'><img src='Img/Nyheder/" + nyhed["fldImage"] + "'></p>";
                    litNyhed.Text += "<div id='ind-nyhed-style'>";
                    litNyhed.Text += "<p class='ind-nyhed-overskrift'>" + nyhed["fldOverskrift"] + "</p>";
                    litNyhed.Text += "<p class='ind-nyhed-dato'>" + nyhed["fldDato"] + "</p>";
                    litNyhed.Text += "<p class='ind-nyhed-tekst'>" + nyhed["fldTekst"] + "</p>";
                    litNyhed.Text += "</div>";
                    litNyhed.Text += "</div>";
                }
            }
            else
            {
                Response.Redirect("Default.aspx");
            }
        }

    }
}