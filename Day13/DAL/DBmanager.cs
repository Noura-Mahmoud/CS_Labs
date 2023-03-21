using Microsoft.Data.SqlClient;
using Microsoft.IdentityModel.Protocols;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DBmanager
    {
        SqlConnection sqlCN;
        SqlCommand sqlCmd;
        SqlDataAdapter sqlAdapter;
        DataTable dtTitles;
        public DBmanager()
        {
            try
            {
                sqlCN = new SqlConnection(ConfigurationManager.ConnectionStrings["pubsCN"].ConnectionString );
                sqlCmd = new SqlCommand();
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Connection = sqlCN;
                sqlAdapter = new SqlDataAdapter(sqlCmd);
                dtTitles = new();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public int ExecuteNonQuery(string stordProcName)
        {
            try
            {
                dtTitles.Clear();
                sqlCmd.CommandText = stordProcName;
                if(sqlCN.State == ConnectionState.Closed)
                {
                    sqlCN.Open();
                }
                return sqlCmd.ExecuteNonQuery();
            }
            catch (Exception)
            {

                return -1;
            }
            finally
            {
                sqlCN.Close();
            }
        }
        public object ExecuteScalar(string stordProcName)
        {
            try
            {
                dtTitles.Clear();
                sqlCmd.CommandText = stordProcName;
                if (sqlCN.State == ConnectionState.Closed)
                {
                    sqlCN.Open();
                }
                return sqlCmd.ExecuteScalar();
            }
            catch (Exception)
            {

                return -1;
            }
            finally
            {
                sqlCN.Close();
            }
        }
        public DataTable ExecuteDataTable(string stordProcName)
        {
            try
            {
                dtTitles.Clear();
                sqlCmd.Parameters.Clear();
                sqlCmd.CommandText = stordProcName;
                sqlAdapter.Fill(dtTitles);
                return dtTitles;
            }
            catch (Exception)
            {
                return new();
            }

        }
        public int ExecuteNonQuery(string stordProcName, Dictionary<string, object> paramList)
        {
            try
            {
                dtTitles.Clear();
                sqlCmd.Parameters.Clear();
                foreach (var param in paramList)
                {
                    sqlCmd.Parameters.Add(new SqlParameter(param.Key, param.Value));
                }
                sqlCmd.CommandText = stordProcName;
                if (sqlCN.State == ConnectionState.Closed)
                {
                    sqlCN.Open();
                }
                return sqlCmd.ExecuteNonQuery();
            }
            catch (Exception)
            {

                return -1;
            }
            finally
            {
                sqlCN.Close();
            }
        }

        public object ExecuteScalar(string stordProcName, Dictionary<string, object> paramList)
        { throw new NotImplementedException(); }
        public DataTable ExecuteDataTable(string stordProcName, Dictionary<string, object> paramList)
        { throw new NotImplementedException(); }
        public void UpdateDB(DataTable TD)
        {
            sqlAdapter.Update(TD);
        }
    }
}
