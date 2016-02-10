using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for BrugerFac
/// </summary>
public class BrugerFac
{
    public int _id { get; set; }            //    fldID
    public string _user { get; set; }       //    fldBrugernavn
    public string _password { get; set; }   //    fldPassword
    public string _email { get; set; }      //    fldEmail

    DataAccess DA = new DataAccess();

    public DataTable BrugerLogin()
    {
        string SQL = "SELECT fldBrugernavn FROM tblBruger WHERE fldBrugernavn = @user AND fldPassword = @password";
        SqlCommand CMD = new SqlCommand(SQL);
        CMD.Parameters.AddWithValue("@user", _user);
        CMD.Parameters.AddWithValue("@password", _password);
        return DA.GetData(CMD);
    }

}