using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for VidsteDuFac
/// </summary>
public class VidsteDuFac
{
    public int _id { get; set; }                //    fldID
    public string _overskrift { get; set; }     //    fldOverskrift
    public string _tekst { get; set; }          //    fldVidsteDuTekst

    DataAccess DA = new DataAccess();

    public DataTable HentAlleVidsteDu()
    {
        string SQL = @"SELECT * FROM tblVidsteDu";
        SqlCommand CMD = new SqlCommand(SQL);
        return DA.GetData(CMD);
    }          // Hent Kontakt Oplysninger

    public DataTable Hent2NyesteVidsteDu()
    {
        string SQL = @"SELECT TOP 2 *
                     FROM tblVidsteDu
                     ORDER BY fldID DESC";
        SqlCommand CMD = new SqlCommand(SQL);
        return DA.GetData(CMD);
    }                // Få 2 Nyeste VidsteDu


    public DataTable HentRandomVidsteDu()
    {
        string SQL = @"SELECT TOP 4 *
                     FROM tblVidsteDu
                     ORDER BY NEWID() DESC";
        SqlCommand CMD = new SqlCommand(SQL);
        return DA.GetData(CMD);
    }        // Få Random VidsteDu

    public DataTable HentVidsteDuFraID()
    {
        string SQL = @"SELECT * 
                       FROM tblVidsteDu 
                       WHERE fldID = @id";
        SqlCommand CMD = new SqlCommand(SQL);
        CMD.Parameters.AddWithValue("@id", _id);
        return DA.GetData(CMD);
    }                   // Få Nyhed Ud Fra ID

    public int OpretVidsteDu()
    {
        string SQL = @"INSERT INTO tblVidsteDu (fldOverskrift, fldVidsteDuTekst)
                       VALUES (@overskrift, @tekst)";
        SqlCommand CMD = new SqlCommand(SQL);
        CMD.Parameters.AddWithValue("@overskrift", _overskrift);
        CMD.Parameters.AddWithValue("@tekst", _tekst);
        return DA.ModifyData(CMD);
    }                   // Opret VidsteDu

    public int SletVidsteDu()
    {
        string SQL = @"DELETE FROM tblVidsteDu WHERE fldID = @id";
        SqlCommand CMD = new SqlCommand(SQL);
        CMD.Parameters.AddWithValue("@id", _id);
        return DA.ModifyData(CMD);
    }                    // Slet VidsteDu

    public int RetVidsteDu()
    {
        string SQL = @"UPDATE tblVidsteDu 
                       SET fldOverskrift = @overskrift, fldVidsteDuTekst = @tekst
                       WHERE fldID = @id";
        SqlCommand CMD = new SqlCommand(SQL);
        CMD.Parameters.AddWithValue("@id", _id);
        CMD.Parameters.AddWithValue("@overskrift", _overskrift);
        CMD.Parameters.AddWithValue("@tekst", _tekst);
        return DA.ModifyData(CMD);
    }                     // Ret VidsteDu

}