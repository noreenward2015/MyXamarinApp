using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
namespace $safeprojectname$.DAL
{
    public class PersonDAL
    {
        public string ConString =
            "Data Source=SOURAV-PC\\SQL_INSTANCE;Initial Catalog=test;Integrated Security=True";
        SqlConnection con = new SqlConnection();
        DataTable dt = new DataTable();
        public DataTable Read()
        {
            con.ConnectionString = ConString;
            if (ConnectionState.Closed == con.State)
                con.Open();
            SqlCommand cmd = new SqlCommand("select * from Person", con);
            try
            {
                SqlDataReader rd = cmd.ExecuteReader();
                dt.Load(rd);
                return dt;
            }
            catch
            {
                throw;
            }
        }
        public DataTable Read(Int16 Id)
        {
            con.ConnectionString = ConString;
            if (ConnectionState.Closed == con.State)
                con.Open();
            SqlCommand cmd = new SqlCommand("select * from Person where ID= " + Id + "", con);
            try
            {
                SqlDataReader rd = cmd.ExecuteReader();
                dt.Load(rd);
                return dt;
            }
            catch
            {
                throw;
            }
        }
    }
}