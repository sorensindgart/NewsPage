using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AlleNyheder : System.Web.UI.Page
{
    NyhederFac objNyhed = new NyhederFac();
    DataTable dt = new DataTable();

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            dt = objNyhed.HentAlleNyheder();

            foreach (DataRow nyhed in dt.Rows)
            {
                litNyhed.Text += "<div id='nyhed-box'>";
                litNyhed.Text += "<div id='nyhed-overskrift-teaser'>";
                litNyhed.Text += "<h3>" + nyhed["fldOverskrift"] + "</h3>";
                litNyhed.Text += "<br /><p>" + nyhed["fldTeaser"] + "</p>";
                litNyhed.Text += "<br /><div id='lasmere'>";
                litNyhed.Text += "<a href='Nyhedsdetaljer.aspx?ID=" + nyhed["fldID"] + "'><p>Læs Mere</p></a>";
                litNyhed.Text += "</div>";
                litNyhed.Text += "</div>";
                litNyhed.Text += "<div id='nyhed-imagedate'>";
                litNyhed.Text += "<img style='width: 80%' src='Img/Nyheder/" + nyhed["fldImage"] + "'>";
                litNyhed.Text += "<p>" + nyhed["fldDato"] + "</p>";
                litNyhed.Text += "</div>";
                litNyhed.Text += "</div>";
                litNyhed.Text += "<br />";

            }
        }

    }
}