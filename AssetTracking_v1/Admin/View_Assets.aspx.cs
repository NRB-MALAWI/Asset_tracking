using AssetTracking_v1.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AssetTracking_v1.Admin
{
    public partial class View_Assets : System.Web.UI.Page
    {
        //NRBAssetsEntities assetsEntities = new NRBAssetsEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                Display_Data();
            }
        }
        void Display_Data()
        {
            string query = "select a.Asset_No, a.Asset_Name, d.name,l.place,a.Designated_Department,a.DateCreated,Acquired_Date,a.Status,a.Quantity" +
                " from Asset a join District d on d.DistrictID=a.districtID join AssetLocations l on l.locationid=a.Designated_Office " +
                " group by a.Asset_No, a.Asset_Name, d.name,l.place,a.Designated_Department,a.DateCreated,Acquired_Date,a.Status,a.Quantity";
            using (SqlConnection con = new SqlConnection(DBConnect.Connects()))
            {
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        GridView1.DataSource = dt;
                        GridView1.DataBind();
                    }
                }
            }
            //var context = (from a in assetsEntities.Assets
            //               join d in assetsEntities.Districts
            //               on a.DistrictID equals d.DistrictId
            //               join l in assetsEntities.AssetLocations
            //               on a.Designated_Office equals l.LocationID
            //               select new
            //               {
            //                   a.Asset_No,
            //                   a.Asset_Name,
            //                   d.Name,
            //                   l.place,
            //                   a.Designated_Department,
            //                   a.DateCreated,
            //                   Date_Acquired=a.Acquired_Date.Year,
            //                   a.Status,
            //                   a.Quantity
            //               }
            //               ).ToList();
            //GridView1.DataSource = context;
            //GridView1.DataBind();
        }
    }
}