using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
/// <summary>
/// Summary description for DBConnection
/// </summary>
public class DBConnection
{
    public DBConnection()
    {
        //
        // TODO: Add constructor logic here
        //
    }
    public SqlConnection GetConnection()
    {
        SqlConnection con = new SqlConnection(@"Data Source=.; initial catalog=MedicalShopDB; Integrated Security=True");
        return con;
    }

}