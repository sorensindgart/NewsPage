using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class admin_NyhedRetRet : System.Web.UI.Page
{
    NyhederFac objNyhed = new NyhederFac();
    KategorierFac objKat = new KategorierFac();
    DataTable dt = new DataTable();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if (!string.IsNullOrEmpty(Request.QueryString["ret"]))
            {
                dt = objKat.HentAlleKategorier();

                foreach (DataRow kategori in dt.Rows)
                {
                    ListItem li = new ListItem(kategori["fldKategori"].ToString(), kategori["fldKatID"].ToString());
                    ddlKat.Items.Add(li);
                }
                objNyhed._id = Convert.ToInt32(Request.QueryString["ret"]);

                dt = objNyhed.HentNyhedFraID();

                if (!IsPostBack)
                {
                    ShowSubject();

                }

                txtOverskrift.Text = dt.Rows[0]["fldOverskrift"].ToString();
                txtTeaser.Text = dt.Rows[0]["fldTeaser"].ToString();
                txtTekst.Text = dt.Rows[0]["fldTekst"].ToString();
                ddlKat.SelectedValue = dt.Rows[0]["fldKatID_fk"].ToString();

            }
            else
            {
                Response.Redirect("NyhedRetSlet.aspx");
            }
        }
    }
    protected void btnSend_Click(object sender, EventArgs e)
    {
        objNyhed._id = Convert.ToInt32(Request.QueryString["ret"]);
        dt = objNyhed.HentNyhedFraID();

        string imagename;


        if ((chbImg.Checked || fuImage.HasFile) && !string.IsNullOrEmpty(dt.Rows[0]["fldImage"].ToString()))
        {
            IOFunctions.DeleteFile(Server.MapPath("../Img/Nyheder/") + dt.Rows[0]["fldImage"]);
            imagename = ""; // Så img-navn bliver slettet i DB ved slet
        }

        else
        {
            imagename = dt.Rows[0]["fldImage"].ToString();
        }

        if (fuImage.HasFile)
        {
            imagename = PictureSave.SavePicture(fuImage.PostedFile, "Img/Nyheder/", 580);
        }
        objNyhed._image = imagename;
        objNyhed._overskrift = txtOverskrift.Text;
        objNyhed._tekst = txtTekst.Text;
        objNyhed._teaser = txtTeaser.Text;
        objNyhed._katid = Convert.ToInt32(ddlKat.SelectedValue);

        int antalnewsopdateret = objNyhed.RetNyhed();

        if (antalnewsopdateret > 0)
        {
            litResult.Text = "<h4>Så er nyheden opdateret!</h4>";
        }
        else
        {
            litResult.Text = "<h4>Fejl i rettelsen!</h4>";
        }
    }

    protected void ShowSubject()
    {
        if (!string.IsNullOrEmpty(dt.Rows[0]["fldImage"].ToString()))
        {
            imgImage.ImageUrl = "../Img/Nyheder/" + dt.Rows[0]["fldImage"].ToString();
            imgImage.Visible = true; // Gør img synligt
            chbImg.Visible = true; // Gør slet-img-checkbox synlig
        }
        else
        {
            // Hvis der ikke er et billede i db...
            imgImage.Visible = false; // Skjul img-container/tomt image
            chbImg.Visible = false; // Skjul slet-img-checkbox
        }
    }

}