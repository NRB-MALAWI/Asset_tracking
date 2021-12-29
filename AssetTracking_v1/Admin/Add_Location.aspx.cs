using AssetTracking_v1.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AssetTracking_v1.Admin
{
    public partial class Add_Location : System.Web.UI.Page
    {
        NRBAssetsEntities assetsEntities = new NRBAssetsEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                GetDistrict();
            }
        }
        void GetDistrict()
        {
            DistrictCtDropDownList.Items.Insert(0, "SELECT DISTRICT");
            var context = from d in assetsEntities.Districts
                          where d.DistrictId > 0
                          orderby d.Name
                          select new
                          {
                              d.DistrictId,
                              d.Name
                          };
            DistrictCtDropDownList.DataSource = context.ToList();
            DistrictCtDropDownList.DataBind();
        }
        protected void btnCreateLocation_Click(object sender, EventArgs e)
        {
            AssetLocation asset = new AssetLocation();
            asset.DistrictID = Int32.Parse(DistrictCtDropDownList.SelectedValue);
            asset.place = txtPlace.Text;

            try
            {
                assetsEntities.AssetLocations.Add(asset);
                assetsEntities.SaveChanges();

                MsgLabel.Text = "Location " + asset.place + "of " + DistrictCtDropDownList.SelectedValue + "Saved Successfully";

                txtPlace.Text = string.Empty;
            }
            catch (Exception)
            {
                MsgLabel.Text = "Failed to save Location. Please contact system administrator";
            }
        }
    }
}