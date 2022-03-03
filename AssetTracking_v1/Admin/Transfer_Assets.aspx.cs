using AssetTracking_v1.Model;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AssetTracking_v1.Admin
{
    public partial class Transfer_Assets : System.Web.UI.Page
    {
        NRBAssetsEntities assetsEntities = new NRBAssetsEntities();
        string ConneString = ConfigurationManager.ConnectionStrings["NRBAssetsConnectionString"].ToString();
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                GetAsset();
            }
        }

        protected void txtAssetName_SelectedIndexChanged(object sender, EventArgs e)
        {
                var context = (from a in assetsEntities.Assets
                               join d in assetsEntities.Districts
                               on a.DistrictID equals d.DistrictId
                               join l in assetsEntities.AssetLocations
                               on a.Designated_Office equals l.LocationID
                               where a.Asset_Name.Equals("" + txtAssetName.SelectedValue.ToString() + "")
                               select new
                               {
                                   a.Asset_No,
                                   a.Asset_Name,
                                   d.Name,
                                   l.place,
                                   a.Designated_Department,
                                   a.Quantity
                               }
                               ).ToList();
            AssetGridview.DataSource = context;
            AssetGridview.DataBind();
            
        }

        protected void btnSearchAssetName_Click(object sender, EventArgs e)
        {

        }
        void GetAsset()
        {
            using (SqlConnection con = new SqlConnection(ConneString))
            {
                string query = "select Asset_Name from Asset group by Asset_Name";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        txtAssetName.DataSource = dt;
                        txtAssetName.DataBind();
                        txtAssetName.Items.Insert(0, "SELECT ASSET");
                    }
                }
            }

        }
    }
}