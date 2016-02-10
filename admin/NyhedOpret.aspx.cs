using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class admin_NyhedOpret : System.Web.UI.Page
{
    NyhederFac objNyhed = new NyhederFac();
    KategorierFac objKat = new KategorierFac();
    DataTable dt = new DataTable();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            dt = objKat.HentAlleKategorier();

            foreach (DataRow kategori in dt.Rows)
            {
                ListItem li = new ListItem(kategori["fldKategori"].ToString(), kategori["fldKatID"].ToString());
                ddlKat.Items.Add(li);
            }
        }
    }
    protected void btnSend_Click(object sender, EventArgs e)
    {
        string imagename = "foto-paa-vej.jpg";

        if (fuImage.HasFile)
        {
            imagename = PictureSave.SavePicture(fuImage.PostedFile, "Img/Nyheder/", 580);
        }

        objNyhed._image = imagename;
        objNyhed._overskrift = txtOverskrift.Text;
        objNyhed._teaser = txtTeaser.Text;
        objNyhed._tekst = txtTekst.Text;
        objNyhed._date = DateTime.Now;
        objNyhed._katid = Convert.ToInt32(ddlKat.SelectedValue);

        int addedsubject = objNyhed.OpretNyhed();

        if (addedsubject > 0)
        {
            txtOverskrift.Text = "";
            txtTeaser.Text = "";
            txtTekst.Text = "";

            litResult.Text = "<h4>Subject submitted!";
        }
        else
        {
            litResult.Text = "<h4>Error!";
        }
    }
}