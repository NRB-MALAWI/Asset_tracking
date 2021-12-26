using System;
using System.Collections.Generic;
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
        protected void Page_Load(object sender, EventArgs e)
        {
            Display_Data();
            GetAsset();
        }
        void GetAsset()
        {
            //string query = "select Asset_Name from Asset group by Asset_Name";
            //SqlDataAdapter da = new SqlDataAdapter(query, con);
            //DataSet ds = new DataSet();
            //da.Fill(ds);
            //if (ds.Tables[0].Rows.Count > 0)
            //{
            //    txtAssetName.DataSource = ds;
            //    txtAssetName.DataBind();
            //    txtAssetName.Items.Insert(0, new ListItem("Choose Asset"));
            //    txtAssetName.SelectedIndex = 0;
            //}

            //var query = from r in assetsEntities.Assets
            //            group r by r.Asset_Name into g
            //            select new
            //            {
            //                Location = g.Key,
            //                //Buildings = g.Count()
            //            };
            //txtAssetName.DataSource = query.ToList();
            //txtAssetName.DataBind();
            //txtAssetName.Items.Insert(0, "SELECT DISTRICT");
            //var context = from d in assetsEntities.Assets


            //                  //orderby d.Asset_Name
            //              select new
            //              {
            //                  d.Asset_No,
            //                  d.Asset_Name
            //              };

            //txtAssetName.DataSource = context.ToList();
            //txtAssetName.DataBind();
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
    }
}