using System;
using System.Collections.Generic;
using System.Configuration.Provider;
using System.Linq;
using System.Web;
using System.Configuration;

namespace AssetTracking_v1.Model
{
    public class DBConnect
    {
        public static string Connects()
        {
            string connection = @"Data Source=issah\sqlexpress;Initial Catalog=NRBAssets;User ID=sa;Password=lengan1";

            //string connection = ConfigurationManager.ConnectionStrings["Inrs.Model"].ToString();

            return connection;
        }
    }
}