using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using BLL.Entities;
using BLL.Entities_Lists;
using DAL;
using Microsoft.VisualBasic;
using static Azure.Core.HttpHeader;

namespace BLL.Entities_Manager
{
    public class TitleManager
    {
        static DBmanager manager = new();
        static DataTable titles = new();
        public static TitlesList selectAllTitles()
        {
            try
            {
                titles = manager.ExecuteDataTable("selectAllTitles");
                return datatableToList(titles);
            }
            catch 
            {
                return new TitlesList();
            }
        }
        public static TitlesList datatableToList(DataTable DT)
        {
            TitlesList list = new();
            foreach(DataRow row in DT.Rows)
            {
                list.Add(datarowToTitle(row));
            }   
            return list;
        }
        public static Title datarowToTitle(DataRow DR)
        {
            Title title = new Title();

            title.Title_id = DR["title_id"]?.ToString() ?? "-1";
            if (int.TryParse(DR["royalty"]?.ToString() ?? "-1", out int royalty))
                title.Royalty = royalty;
            if (int.TryParse(DR["ytd_sales"]?.ToString() ?? "-1", out int ytd_sales))
                title.Ytd_sales = ytd_sales;
            title.TitleName = DR["title"]?.ToString()??"Na";
            title.Type = DR["type"]?.ToString()??"Na";
            title.Pub_id = DR["pub_id"]?.ToString()??"Na";
            title.Notes = DR["notes"]?.ToString()?? "Na";
            if (decimal.TryParse(DR["price"]?.ToString() ?? "-1", out decimal price))
                title.Price = price;
            if (decimal.TryParse(DR["advance"]?.ToString() ?? "-1", out decimal advance))
                title.Advance = advance;
            if (DateTime.TryParse(DR["pubdate"]?.ToString() ?? "-1", out DateTime pubdate))
                title.Pubdate = pubdate;
            title.State = EntityState.Unchanged;
            return title;
        }
        public static void UpdateTitles()
        {
            try
            {
                manager.UpdateDB(titles);
            }
            catch (Exception)
            {

                throw;
            }
        }
        
        public static bool updateTitlesByID(string titleID, string titleName, decimal price, string notes, DateTime publishDate, string publisher)
        {
            try
            {
                Dictionary<string, object> parameters = new() { ["@title"] = titleName, ["@pub_id"] = publisher, ["@notes"] = notes, ["@pubdate"] = publishDate, ["@title_id"] = titleID, ["@price"] = price};
                return manager.ExecuteNonQuery("updateTitles", parameters) >0;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static bool updateTitleByID(string titleID, string titleName = "",string type = "", decimal price = 0, decimal advance = 0, int royalty = 0, int ytd_sales = 0, string notes = "", DateTime publishDate = default, string publisher = "")
        {
            try
            {
                Dictionary<string, object> parameters = new() { ["@title"] = titleName, ["@pub_id"] = publisher,["@ytd_sales"] = ytd_sales, ["@royalty"] = royalty, ["type"]= type, ["@advance"] = advance, ["@notes"] = notes, ["@pubdate"] = publishDate, ["@title_id"] = titleID, ["@price"] = price };
                return manager.ExecuteNonQuery("updateAllTitleData", parameters) > 0;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public static bool insertTitle(string titleID = "", string titleName = "", string type = "", decimal price = 0, decimal advance = 0, int royalty = 0, int ytd_sales = 0, string notes = "", DateTime publishDate = default, string publisher = "")
        {
            try
            {
                Dictionary<string, object> parameters = new() { ["@title"] = titleName, ["@pub_id"] = publisher, ["@ytd_sales"] = ytd_sales, ["@royalty"] = royalty, ["type"] = type, ["@advance"] = advance, ["@notes"] = notes, ["@pubdate"] = publishDate, ["@title_id"] = titleID, ["@price"] = price };
                return manager.ExecuteNonQuery("insertTitle", parameters) > 0;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public static bool deleteTitle(string titleID )
        {
            try
            {
                return manager.ExecuteNonQuery("deleteTitle", new Dictionary<string, object> {["@title_id"] = titleID}) > 0;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
