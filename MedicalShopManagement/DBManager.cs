using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Data;

/// <summary>
/// Summary description for DBManager
/// </summary>
public class DBManager
{
    public DBManager()
    {
        //
        // TODO: Add constructor logic here
        //
    }
    DBConnection conn = new DBConnection();
    public void EXESQL(string str)
    {
        string msg = string.Empty;
        SqlConnection con = conn.GetConnection();
        SqlCommand cmd = new SqlCommand(str, con);
        con.Open();
        int IsTrue = cmd.ExecuteNonQuery();
        con.Close();
        if (IsTrue == 1)
        {
            msg = "Successfull inserted";
        }
        else
        {
            msg = "Error occured!Please Try Again.";
        }

    }
    public DataTable GetData(string str)
    {
        string msg = string.Empty;
        SqlConnection con = conn.GetConnection();
        SqlDataAdapter adp = new SqlDataAdapter(str, con);
        DataTable dt = new DataTable();
        int IsTrue = adp.Fill(dt);
        if (IsTrue == 1)
        {
            msg = "Successfully Retrive Data";
        }
        else
        {
            msg = "Error occured! please Try Again.";
        }
        return dt;
    }
}
        
  