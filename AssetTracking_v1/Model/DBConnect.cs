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
            string connection = @"Data Source=issah\ti;Initial Catalog=NRBAssets;Integrated Security=True";

            //string connection = ConfigurationManager.ConnectionStrings["Inrs.Model"].ToString();

            return connection;
        }
    }
}