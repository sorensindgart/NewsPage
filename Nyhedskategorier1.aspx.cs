using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Nyhedskategorier1 : System.Web.UI.Page
{
    //ProduktFac objProdukt = new ProduktFac();
    KategorierFac objKat = new KategorierFac();
    NyhederFac objNyhed = new NyhederFac();
    DataTable dt = new DataTable();

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            // Getting all kategories from database
            dt = objKat.HentAlleKategorier();

            // Inserting them into DropDownList
            foreach (DataRow kategori in dt.Rows)
            {
                ListItem li = new ListItem(kategori["fldKategori"].ToString(), kategori["fldKatID"].ToString());
                ddlKat.Items.Add(li);
            }
        }

    }
    protected void ddlKat_SelectedIndexChanged(object sender, EventArgs e)
    {
        litResult.Text = "";                                                // Emptying the literal (AutoPostBack)
        int _id = Convert.ToInt32(ddlKat.SelectedValue);                    // Making DropDownList into INT(_id)
        dt = objNyhed.HentNyesteNyhedByKatID(_id);                                // Getting "_id" from Method in Fac

        foreach (DataRow nyhed in dt.Rows)
        {
            litResult.Text += "<div id='vidstedu'><a href='Nyhedsdetaljer.aspx?ID=" + nyhed["fldID"] + "'><p>" + nyhed["fldOverskrift"] + "</p></a></div>";      // Posting selected DropDown item content
        }
    }
}