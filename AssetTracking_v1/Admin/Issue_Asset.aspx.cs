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
    public partial class Issue_Asset : System.Web.UI.Page
    {
        NRBAssetsEntities assetsEntities = new NRBAssetsEntities();
        SqlConnection con = new SqlConnection(@"Data Source=issah;Initial Catalog=NRBAssets;Integrated Security=True");
        string ConneString = ConfigurationManager.ConnectionStrings["NRBAssetsConnectionString"].ToString();
        protected void Page_Load(object sender, EventArgs e)
        {
            //Display_Data();
            GetAsset();
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
        void Display_Data()
        {
            var context = (from a in assetsEntities.Assets
                           join d in assetsEntities.Districts
                           on a.DistrictID equals d.DistrictId
                           join l in assetsEntities.AssetLocations
                           on a.Designated_Office equals l.LocationID
                           where a.Asset_Name.Contains("BRK")
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
            GridView1.DataSource = context;
            GridView1.DataBind();
        }
        void AddAsset()
        {
            using(NRBAssetsEntities _entity = new NRBAssetsEntities())
            {
                Issuance _issue = new Issuance();
                Asset asset = new Asset();
                _issue.Asset_No.Value.Equals(txtAssetNo.Value);
                _issue.Date_of_Issue.Equals(DateTime.Now);
                _issue.Quantity.Equals(txtQuanityIssue.Value);
                _issue.Issued_to.Equals(txtIssued_to.Value);
                asset.Quantity.Equals(asset.Quantity - int.Parse(txtQuanityIssue.Value));

                _entity.Issuances.Add(_issue);
                _entity.Assets.Add(asset);
                _entity.SaveChanges();
            }
        }

        protected void txtAssetName_SelectedIndexChanged(object sender, EventArgs e)
        {
            var context = (from a in assetsEntities.Assets
                           join d in assetsEntities.Districts
                           on a.DistrictID equals d.DistrictId
                           join l in assetsEntities.AssetLocations
                           on a.Designated_Office equals l.LocationID
                           where a.Asset_Name.Contains(txtAssetName.SelectedValue.ToString())
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
            GridView1.DataSource = context;
            GridView1.DataBind();
        }

        protected void btnSearchAssetName_Click(object sender, EventArgs e)
        {
            Display_Data();
        }
    }
}