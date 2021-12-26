using AssetTracking_v1.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AssetTracking_v1.Admin
{
    public partial class View_Assets : System.Web.UI.Page
    {
        NRBAssetsEntities assetsEntities = new NRBAssetsEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                Display_Data();
            }
        }
        void Display_Data()
        {
            var context = (from a in assetsEntities.Assets
                           join d in assetsEntities.Districts
                           on a.DistrictID equals d.DistrictId
                           join l in assetsEntities.AssetLocations
                           on a.Designated_Office equals l.LocationID
                           select new
                           {
                               a.Asset_No,
                               a.Asset_Name,
                               d.Name,
                               l.place,
                               a.Designated_Department,
                               a.DateCreated,
                               a.Acquired_Date,
                               a.Status
                           }
                           ).ToList();
            GridView1.DataSource = context;
            GridView1.DataBind();
        }
    }
}