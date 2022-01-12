using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using AssetTracking_v1.Model;

namespace AssetTracking_v1.Admin
{
    public partial class View_Asset_Issuance : System.Web.UI.Page
    {
        string ConneString = ConfigurationManager.ConnectionStrings["NRBAssetsConnectionString"].ToString();
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                Get_Issuances();
                GetAsset();
            }
        }
        void Get_Issuances()
        {
            using(NRBAssetsEntities assetsEntities = new NRBAssetsEntities())
            {
                var context = (from i in assetsEntities.Issuances
                               join a in assetsEntities.Assets
                               on i.Asset_No equals a.Asset_No
                               select new
                               {
                                   i.Date_of_Issue,
                                   a.Asset_Name,
                                   i.Issued_to,
                                   i.Quantity
                               }
                           ).ToList();
                GridView1.DataSource = context;
                GridView1.DataBind();
            }
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

        protected void txtAssetName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txtAssetName.SelectedIndex == 0)
            {
                using (NRBAssetsEntities assetsEntities = new NRBAssetsEntities())
                {
                    var context = (from a in assetsEntities.Assets
                                   join d in assetsEntities.Districts
                                   on a.DistrictID equals d.DistrictId
                                   join l in assetsEntities.AssetLocations
                                   on a.Designated_Office equals l.LocationID
                                   //where a.Asset_Name.Equals("" + txtAssetName.SelectedValue.ToString() + "")
                                   select new
                                   {
                                       a.Asset_No,
                                       a.Asset_Name,
                                       District = d.Name,
                                       l.place,
                                       a.Designated_Department,
                                       a.Quantity
                                   }
                               ).ToList();
                    GridView1.DataSource = context;
                    GridView1.DataBind();
                }
            }
            else
            {
                using (NRBAssetsEntities assetsEntities = new NRBAssetsEntities())
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
                                       District = d.Name,
                                       l.place,
                                       a.Designated_Department,
                                       a.Quantity
                                   }
                               ).ToList();
                    GridView1.DataSource = context;
                    GridView1.DataBind();
                }
            }
        }
    }
}