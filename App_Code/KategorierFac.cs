using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for KategorierFac
/// </summary> dragostea
public class KategorierFac
{
    public int _id { get; set; }            //    fldKatID
    public string _kategori { get; set; }   //    fldKategori
    public string _image { get; set; }      //    fldKatImage

    DataAccess DA = new DataAccess();

    public DataTable HentAlleKategorier()
    {
        string SQL = @"SELECT * FROM tblKategorier";
        SqlCommand CMD = new SqlCommand(SQL);
        return DA.GetData(CMD);
    }

    public DataTable HentUdvalgtKategori()
    {
        string SQL = @"SELECT * 
                       FROM tblNyheder 
                       INNER JOIN tblKategorier 
                       ON fldKatID = fldKatID_fk";
        SqlCommand CMD = new SqlCommand(SQL);
        return DA.GetData(CMD);
    }
}