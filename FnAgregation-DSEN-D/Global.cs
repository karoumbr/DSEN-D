using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FnAgregation_DSEN_D
{
    class Global
    {
        //cs: connection string
        static public String cs = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|MaBaseDSEN_D.accdb";
    //    static public String cs = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=10.25.236.14\RepPartage\MaBaseDSEN_D.accdb";

        static public SqlConnection seConnecterSQLServer(String strCN)
        {
            SqlConnection ocn = new SqlConnection();
            ocn.ConnectionString = strCN;
            try
            {
                if (ocn.State == System.Data.ConnectionState.Closed)
                {
                    ocn.Open();
                }
            }
            catch (Exception)
            {

                throw;
            }
            return ocn;
        }

        static public OleDbConnection seConnecter(String strCN)
        {
            
            OleDbConnection ocn = new OleDbConnection();
            ocn.ConnectionString = strCN;
            try
            {
                if (ocn.State == System.Data.ConnectionState.Closed)
                {
                    ocn.Open();
                }
            }
            catch (Exception)
            {

                throw;
            }
            return ocn;
        }

        static public void seDeconnecter(OleDbConnection ocx)
        {
            try
            {
                if (ocx.State == System.Data.ConnectionState.Open)
                {
                    ocx.Close();
                }
            }
            catch (Exception)
            {

                throw;
            }

        }

        static public Object ExecuterOleDbScalaire(String req, OleDbConnection ocn)
        {
            Object o = new Object();
            OleDbCommand com = new OleDbCommand(req, ocn);
            try
            {
                o = com.ExecuteScalar();
            }
            catch (Exception)
            {

                throw;
            }
            return o;

        }



        static public OleDbDataReader ExecuterOleDBSelect(String strSQL, OleDbConnection objCN)
        {
            OleDbDataReader objDR = null;
            OleDbCommand objCOM = new OleDbCommand(strSQL, objCN);
            try
            {
                objDR = objCOM.ExecuteReader();
            }
            catch (Exception)
            {

                throw;
            }
            return objDR;
        }


        static public int ExecuterOleDBAction(String strSQL, OleDbConnection objCN)
        {
            int nb = 0;
            OleDbCommand objCOM = new OleDbCommand(strSQL, objCN);
            try
            {
                nb = objCOM.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }
            return nb;
        }


        static public int ExecuterOleDBAction(String strSQL, OleDbConnection objCN, params Object[] objPM)
        {
            int nb = -1;
            OleDbCommand objCOM = new OleDbCommand(strSQL, objCN);
            try
            {

                foreach (Object obj in objPM)
                {
                    OleDbParameter param = new OleDbParameter();
                    param.Value = obj;
                    objCOM.Parameters.Add(param);
                }


                nb = objCOM.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }
            return nb;
        }



        static public bool ExecuterTransaction(String strCN, params string[] tabSQL)
        {
            bool ok;

            OleDbCommand objCOM = new OleDbCommand();
            OleDbTransaction transact;
            try
            {
                OleDbConnection objCN = seConnecter(strCN);
                objCOM.Connection = objCN;
                transact = objCN.BeginTransaction();
                objCOM.Transaction = transact;
                try
                {
                    foreach (string strSQL in tabSQL)
                    {
                        objCOM.CommandText = strSQL;
                        int i = objCOM.ExecuteNonQuery();
                    }
                    transact.Commit();
                    ok = true;
                }
                catch (Exception)
                {
                    transact.Rollback();
                    ok = false;
                    //    throw;
                }
                finally
                {
                    seDeconnecter(objCN);
                }

            }
            catch (Exception)
            {
                ok = false;
                //  throw;
            }

            return ok;

               



        }

    }
}
