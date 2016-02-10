using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for NyhederFac
/// </summary>
public class NyhederFac
{

    // Properties

    public int _id { get; set; }                           //    fldID
    public string _overskrift { get; set; }                //    fldOverskrift
    public string _teaser { get; set; }                    //    fldTeaser
    public string _tekst { get; set; }                     //    fldTekst
    public DateTime _date { get; set; }                    //    fldDato
    public string _image { get; set; }                     //    fldImage
    public int _katid { get; set; }                        //    fldKatID_fk

    DataAccess DA = new DataAccess();

    public DataTable HentAlleNyheder()
    {
        string SQL = @"SELECT * FROM tblNyheder ORDER BY fldID DESC";
        SqlCommand CMD = new SqlCommand(SQL);
        return DA.GetData(CMD);
    }                  // Hent Alle Nyheder

    public DataTable HentNyhedFraID()
    {
        string SQL = @"SELECT * 
                       FROM tblNyheder 
                       WHERE fldID = @id";
        SqlCommand CMD = new SqlCommand(SQL);
        CMD.Parameters.AddWithValue("@id", _id);
        return DA.GetData(CMD);
    }                   // Få Nyhed Ud Fra ID

    public DataTable HentNyesteNyheder()
    {
        string SQL = @"SELECT TOP 3 *
                     FROM tblNyheder
                     ORDER BY fldID DESC";
        SqlCommand CMD = new SqlCommand(SQL);
        return DA.GetData(CMD);
    }                // Få 3 Nyeste Nyheder

    public DataTable Hent2NyesteNyheder()
    {
        string SQL = @"SELECT TOP 2 *
                     FROM tblNyheder
                     ORDER BY fldID DESC";
        SqlCommand CMD = new SqlCommand(SQL);
        return DA.GetData(CMD);
    }                // Få 2 Nyeste Nyheder


    public DataTable HentNyesteNyhedByKatID(int ID)
    {
        string SQL = @"SELECT *
                       FROM tblNyheder
                       WHERE fldKatID_fk = @ID
                       ORDER BY fldID DESC";
        SqlCommand CMD = new SqlCommand(SQL);
        CMD.Parameters.AddWithValue("@ID", ID);
        return DA.GetData(CMD);
    }     // Få Nyeste Nyheder Ud Fra Kategori (int "ID" <- IS A PARAMETER)

    public DataTable HentNyhedByKatID(int ID)
    {
        string SQL = @"SELECT *
                       FROM tblNyheder
                       WHERE fldKatID_fk = @ID";
        SqlCommand CMD = new SqlCommand(SQL);
        CMD.Parameters.AddWithValue("@ID", ID);
        return DA.GetData(CMD);
    }           // Få Nyheder Ud Fra Kategori (int "ID" <- IS A PARAMETER)

    public int OpretNyhed()
    {
        string SQL = @"INSERT INTO tblNyheder (fldOverskrift, fldTeaser, fldTekst, fldDato, fldImage, fldKatID_fk)
                       VALUES (@overskrift, @teaser, @tekst, @date, @img, @katid)";
        SqlCommand CMD = new SqlCommand(SQL);
        CMD.Parameters.AddWithValue("@overskrift", _overskrift);
        CMD.Parameters.AddWithValue("@teaser", _teaser);
        CMD.Parameters.AddWithValue("@tekst", _tekst);
        CMD.Parameters.AddWithValue("@date", _date);
        CMD.Parameters.AddWithValue("@img", _image);
        CMD.Parameters.AddWithValue("@katid", _katid);
        return DA.ModifyData(CMD);
    }                             // Opret Nyhed

    public int SletNyhed()
    {
        string SQL = @"DELETE FROM tblNyheder WHERE fldID = @id";
        SqlCommand CMD = new SqlCommand(SQL);
        CMD.Parameters.AddWithValue("@id", _id);
        return DA.ModifyData(CMD);
    }                              // Slet Nyhed

    public int RetNyhed()
    {
        string SQL = @"UPDATE tblNyheder 
                       SET fldOverskrift = @overskrift, fldTekst = @tekst, fldTeaser = @teaser, fldImage = @img, fldKatID_fk = @katid 
                       WHERE fldID = @id";
        SqlCommand CMD = new SqlCommand(SQL);
        CMD.Parameters.AddWithValue("@id", _id);
        CMD.Parameters.AddWithValue("@overskrift", _overskrift);
        CMD.Parameters.AddWithValue("@tekst", _tekst);
        CMD.Parameters.AddWithValue("@teaser", _teaser);
        CMD.Parameters.AddWithValue("@img", _image);
        CMD.Parameters.AddWithValue("@katid", _katid);
        return DA.ModifyData(CMD);
    }                               // Ret Nyhed


}