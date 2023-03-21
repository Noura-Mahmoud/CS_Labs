using BLL.Entities;
using BLL.Entities_Lists;
using DAL;
using Microsoft.Data.SqlClient;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Entities_Manager
{
    public class PublisherManager
    {
        SqlConnection sqlCN;
        SqlCommand sqlCmd;
        SqlDataAdapter sqlAdapter;
        DataTable dtPublishers;
        public PublisherManager()
        {
            try
            {
                sqlCN = new SqlConnection(ConfigurationManager.ConnectionStrings["pubsCN"].ConnectionString);
                sqlCmd = new SqlCommand();
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Connection = sqlCN;
                sqlAdapter = new SqlDataAdapter(sqlCmd);
                dtPublishers = new();
            }
            catch (Exception)
            {
                throw;
            }
        }
        static DBmanager manager;
        public static PublisherList selectAllPublishers()
        {
            try
            {
                manager = new DBmanager();
                var publishers = manager.ExecuteDataTable("selectAllPublishers");
                return datatableToList(publishers);
            }
            catch (Exception)
            {

                throw;
            }
            
        }
        public static PublisherList datatableToList(DataTable DT)
        {
            PublisherList list = new();
            foreach(DataRow row in DT.Rows)
            {
                list.Add(datarowToPublisher(row));
            }
            return list;
        }
        public static Publisher datarowToPublisher(DataRow DR)
        {
            Publisher publisher = new();
            publisher.pub_id = DR["pub_id"]?.ToString() ?? "NA";
            publisher.pub_name = DR["pub_name"]?.ToString() ?? "NA";
            publisher.city = DR["city"]?.ToString() ?? "NA";
            publisher.state = DR["state"]?.ToString() ?? "NA";
            publisher.country = DR["country"]?.ToString() ?? "NA";
            return publisher;
        }
        
        
    }
}
