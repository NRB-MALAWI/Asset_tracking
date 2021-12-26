using AssetTracking_v1.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AssetTracking_v1.Admin
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

        protected void CreateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Asset _asset = new Asset();
                _asset.DateCreated = DateTime.Now;
                _asset.Asset_Name = AssetNameTxtBox.Text;
                _asset.Manufacturer = ManufacturerTxtBox.Text;
                _asset.Serial_No = SerialNumberTxtBox.Text;
                _asset.Model = ModelNumberTxtBox.Text;
                _asset.Landing_cost = int.Parse(txtLandingCost.Text);
                _asset.DistrictID = int.Parse(DistrictCtDropDownList.SelectedValue);
                _asset.Designated_Office = int.Parse(DesignatedOfficeTxtBox.SelectedValue);
                _asset.Acquired_Date = DateTime.Parse(AcquiredDateCalendar.Text);
                _asset.Designated_Department = DesignatedDepartmentTxtBox.Text;
                _asset.Room_No = RoomNumberTxtBox.Text;
                _asset.custodian = CustodianTxtBox.Text;
                _asset.Status = StatusTxtBox.SelectedValue;
                _asset.Comments = CommentTxtBox.Text;
                _asset.Source_of_funds = drpSourceoffunds.Text;
                _asset.Quantity = int.Parse(txtQuantity.Text);
                MsgLabel.Text = "Successfully Saved";

                assetsEntities.Assets.Add(_asset);
                assetsEntities.SaveChanges();

                AssetNameTxtBox.Text = string.Empty;
                ManufacturerTxtBox.Text = string.Empty;
                SerialNumberTxtBox.Text = string.Empty;
                ModelNumberTxtBox.Text = string.Empty;
                txtLandingCost.Text = string.Empty;
                DesignatedDepartmentTxtBox.Text = string.Empty;
                RoomNumberTxtBox.Text = string.Empty;
                CustodianTxtBox.Text = string.Empty;
                StatusTxtBox.Text = string.Empty;
                CommentTxtBox.Text = string.Empty;
                drpSourceoffunds.SelectedIndex = 0;
                txtQuantity.Text = string.Empty;
            }
            catch(Exception es)
            {
                throw es;
                
            }
            
        }

        protected void drpSourceoffunds_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (drpSourceoffunds.SelectedIndex == 3)
            {
                txtOthersource.Visible = true;
            }
            else
            {
                txtOthersource.Visible = false;
            }
        }

    }
}