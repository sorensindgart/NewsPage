using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class MasterPage : System.Web.UI.MasterPage
{
    KontaktFac objKontakt = new KontaktFac();
    DataTable dt = new DataTable();

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            dt = objKontakt.HentKontaktOplysninger();

            foreach (DataRow kontakt in dt.Rows)
            {
                litKontakt.Text += "<p class='plaintext'>" + kontakt["fldFirmanavn"] +"</p>";
                litKontakt.Text += "<p class='plaintext'>" + kontakt["fldAdresse"] +"</p>";
                litKontakt.Text += "<p class='plaintext'>" + kontakt["fldPostnummer"] + "</p>";
                litKontakt.Text += "<p class='plaintext'>" + kontakt["fldBy"] + "</p>";
                litKontakt.Text += "<p class='plaintext'>" + kontakt["fldTelefon"] + "</p>";
                litKontakt.Text += "<p class='plaintext'><a href='mailto:newssite@newssite.dk'>" + kontakt["fldEmail"] + "</p></a>";

            }
        }
    }
}
