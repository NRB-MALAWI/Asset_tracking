using AssetTracking_v1.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AssetTracking_v1.ARO
{
    public partial class Add_Asset : System.Web.UI.Page
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
        protected void DistrictCtDropDownList_SelectedIndexChanged(object sender, EventArgs e)
        {
            DesignatedOfficeTxtBox.Items.Clear();
            DesignatedOfficeTxtBox.Items.Insert(0, "SELECT LOCATION");
            int district = int.Parse(DistrictCtDropDownList.SelectedValue);

            var context = from l in assetsEntities.AssetLocations
                          where l.DistrictID.Equals(district)
                          orderby l.place ascending
                          select new
                          {
                              l.LocationID,
                              l.place
                          };
            DesignatedOfficeTxtBox.DataSource = context.ToList();
            DesignatedOfficeTxtBox.DataTextField = "place";
            DesignatedOfficeTxtBox.DataValueField = "LocationID";

            DesignatedOfficeTxtBox.DataBind();
        }
    }
}