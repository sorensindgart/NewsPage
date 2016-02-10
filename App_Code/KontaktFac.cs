using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for KontaktFac
/// </summary>
public class KontaktFac
{
    public string _firmanavn { get; set; }      //    fldFirmanavn
    public string _adresse { get; set; }        //    fldAdresse
    public string _postnummer { get; set; }     //    fldPostnummer
    public string _by { get; set; }             //    fldBy
    public string _telefon { get; set; }        //    fldTelefon
    public string _email { get; set; }          //    fldEmail

    DataAccess DA = new DataAccess();

    public DataTable HentKontaktOplysninger()
    {
        string SQL = @"SELECT * FROM tblKontakt";
        SqlCommand CMD = new SqlCommand(SQL);
        return DA.GetData(CMD);
    }          // Hent Kontakt Oplysninger

    public int RetKontakt()
    {
        string SQL = @"UPDATE tblKontakt
                       SET fldFirmanavn = @firmanavn, fldAdresse = @adresse, fldPostnummer = @postnummer, fldBy = @by, fldTelefon = @telefon, fldEmail = @email";
        SqlCommand CMD = new SqlCommand(SQL);
        CMD.Parameters.AddWithValue("@firmanavn", _firmanavn);
        CMD.Parameters.AddWithValue("@adresse", _adresse);
        CMD.Parameters.AddWithValue("@postnummer", _postnummer);
        CMD.Parameters.AddWithValue("@by", _by);
        CMD.Parameters.AddWithValue("@telefon", _telefon);
        CMD.Parameters.AddWithValue("@email", _email);
        return DA.ModifyData(CMD);
    }                               // Ret Kontakt Oplysninger


}