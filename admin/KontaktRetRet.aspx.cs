using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class admin_KontaktRetRet : System.Web.UI.Page
{
    KontaktFac objKontakt = new KontaktFac();
    DataTable dt = new DataTable();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            dt = objKontakt.HentKontaktOplysninger();

            txtFirmanavn.Text = dt.Rows[0]["fldFirmanavn"].ToString();
            txtAdresse.Text = dt.Rows[0]["fldAdresse"].ToString();
            txtPostnummer.Text = dt.Rows[0]["fldPostnummer"].ToString();
            txtBy.Text = dt.Rows[0]["fldBy"].ToString();
            txtTelefon.Text = dt.Rows[0]["fldTelefon"].ToString();
            txtEmail.Text = dt.Rows[0]["fldEmail"].ToString();
        }

    }
    protected void btnSend_Click(object sender, EventArgs e)
    {
                dt = objKontakt.HentKontaktOplysninger();

        objKontakt._firmanavn = txtFirmanavn.Text;
        objKontakt._adresse = txtAdresse.Text;
        objKontakt._postnummer = txtPostnummer.Text;
        objKontakt._by = txtBy.Text;
        objKontakt._telefon = txtTelefon.Text;
        objKontakt._email = txtEmail.Text;

        int antalnewsopdateret = objKontakt.RetKontakt();

        if (antalnewsopdateret > 0)
        {
            litResult.Text = "<h4>Så er Kontakt Oplysningerne opdateret!</h4>";
        }
        else
        {
            litResult.Text = "<h4>Fejl i rettelsen!</h4>";
        }
    }
}