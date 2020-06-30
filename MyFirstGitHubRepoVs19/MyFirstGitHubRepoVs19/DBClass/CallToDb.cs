using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace MyFirstGitHubRepoVs19.DBClass
{
    public class CallToDb
    {
        //Access Connection String using classNameRepository
        ClassNameRepository config = new ClassNameRepository();
        public DataSet GetTransInfo(string comCode, string SQLprocName, string CallType, string mDesc1 = "", string mDesc2 = "",
        string mDesc3 = "", string mDesc4 = "", string mDesc5 = "", string mDesc6 = "", string mDesc7 = "", string mDesc8 = "", string mDesc9 = "", string mDesc10 = "")
        {
            try
            {
                SqlConnection con = config.StringName();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = SQLprocName;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@Comp1", comCode));
                cmd.Parameters.Add(new SqlParameter("@CallType", CallType));
                cmd.Parameters.Add(new SqlParameter("@Desc1", mDesc1));
                cmd.Parameters.Add(new SqlParameter("@Desc2", mDesc2));
                cmd.Parameters.Add(new SqlParameter("@Desc3", mDesc3));
                cmd.Parameters.Add(new SqlParameter("@Desc4", mDesc4));
                cmd.Parameters.Add(new SqlParameter("@Desc5", mDesc5));
                cmd.Parameters.Add(new SqlParameter("@Desc6", mDesc6));
                cmd.Parameters.Add(new SqlParameter("@Desc7", mDesc7));
                cmd.Parameters.Add(new SqlParameter("@Desc8", mDesc8));
                cmd.Parameters.Add(new SqlParameter("@Desc9", mDesc9));
                cmd.Parameters.Add(new SqlParameter("@Desc10", mDesc10));


                SqlDataAdapter adp = new SqlDataAdapter();
                adp.SelectCommand = cmd;
                cmd.CommandTimeout = 0;
                cmd.Connection = con;
                con.Open();
                DataSet ds = new DataSet();
                adp.Fill(ds);
                return ds;

            }
            catch (Exception exp)
            {
                return null;
            }// try
        }



        public DataSet GetTransResult(ClassProAccessParams parm)
        {
            try
            {
                SqlConnection con = config.StringName();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = parm.StoredProcedure;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@Comp1", parm.Comp1));
                cmd.Parameters.Add(new SqlParameter("@CallType", parm.Calltype));
                cmd.Parameters.Add("@Dxml01", SqlDbType.Xml).Value = (parm.Dxml01 == null ? null : parm.Dxml01.GetXml());
                cmd.Parameters.Add("@Dxml02", SqlDbType.Xml).Value = (parm.Dxml02 == null ? null : parm.Dxml02.GetXml());
                cmd.Parameters.Add(new SqlParameter("@Dbin01", parm.Dbin01));
                cmd.Parameters.Add(new SqlParameter("@Desc1", parm.Desc01));
                cmd.Parameters.Add(new SqlParameter("@Desc2", parm.Desc02));
                cmd.Parameters.Add(new SqlParameter("@Desc3", parm.Desc03));
                cmd.Parameters.Add(new SqlParameter("@Desc4", parm.Desc04));
                cmd.Parameters.Add(new SqlParameter("@Desc5", parm.Desc05));
                cmd.Parameters.Add(new SqlParameter("@Desc6", parm.Desc06));
                cmd.Parameters.Add(new SqlParameter("@Desc7", parm.Desc07));
                cmd.Parameters.Add(new SqlParameter("@Desc8", parm.Desc08));
                cmd.Parameters.Add(new SqlParameter("@Desc9", parm.Desc09));
                cmd.Parameters.Add(new SqlParameter("@Desc10", parm.Desc10));
                cmd.Parameters.Add(new SqlParameter("@Desc11", parm.Desc11));
                cmd.Parameters.Add(new SqlParameter("@Desc12", parm.Desc12));
                cmd.Parameters.Add(new SqlParameter("@Desc13", parm.Desc13));
                cmd.Parameters.Add(new SqlParameter("@Desc14", parm.Desc14));
                cmd.Parameters.Add(new SqlParameter("@Desc15", parm.Desc15));
                cmd.Parameters.Add(new SqlParameter("@Desc16", parm.Desc16));
                cmd.Parameters.Add(new SqlParameter("@Desc17", parm.Desc17));
                cmd.Parameters.Add(new SqlParameter("@Desc18", parm.Desc18));
                cmd.Parameters.Add(new SqlParameter("@Desc19", parm.Desc19));
                cmd.Parameters.Add(new SqlParameter("@Desc20", parm.Desc20));
                cmd.Parameters.Add(new SqlParameter("@Desc21", parm.Desc21));
                cmd.Parameters.Add(new SqlParameter("@Desc22", parm.Desc22));

                cmd.Parameters.Add(new SqlParameter("@UserID", parm.UserID));
                SqlDataAdapter adp = new SqlDataAdapter();
                adp.SelectCommand = cmd;
                cmd.CommandTimeout = 0;
                cmd.Connection = con;
                con.Open();
                DataSet ds = new DataSet();
                adp.Fill(ds);
                return ds;
            }
            catch (Exception exp)
            {
                return null;
            }// try
        }


    }
}
