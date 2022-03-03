using AssetTracking_v1.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

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
            DesignatedOfficeTxtBox.Items.Insert(0, "SELECT LOCATION");
            using (SqlConnection con = new SqlConnection(DBConnect.Connects()))
            {
                string query = "select * from district where districtid>0 order by name";
                con.Open();
                using(SqlCommand cmd = new SqlCommand(query,con))
                {
                    using(SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        DistrictCtDropDownList.DataSource = dt;
                        DistrictCtDropDownList.DataBind();
                    }
                }
                con.Close();
            }
            //DistrictCtDropDownList.Items.Insert(0, "SELECT DISTRICT");
            //var context = from d in assetsEntities.Districts
            //              where d.DistrictId > 0
            //              orderby d.Name
            //              select new
            //              {
            //                  d.DistrictId,
            //                  d.Name
            //              };
            //DistrictCtDropDownList.DataSource = context.ToList();
            //DistrictCtDropDownList.DataBind();
        }
        protected void DistrictCtDropDownList_SelectedIndexChanged(object sender, EventArgs e)
        {
            DesignatedOfficeTxtBox.Items.Clear();
            DesignatedOfficeTxtBox.Items.Insert(0, "SELECT LOCATION");
            if (DistrictCtDropDownList.SelectedIndex == 0)
            {
                DesignatedOfficeTxtBox.Text = "SELECT LOCATION";
                //DesignatedOfficeTxtBox.Items.Insert(0, "SELECT LOCATION");
            }
            else
            {
                int district = int.Parse(DistrictCtDropDownList.SelectedValue);
                string query = "select * from AssetLocations where DistrictID='" + district + "'";

                using (SqlConnection con = new SqlConnection(DBConnect.Connects()))
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                        {
                            using (DataTable dt = new DataTable())
                            {
                                da.Fill(dt);
                                DesignatedOfficeTxtBox.DataSource = dt;
                                DesignatedOfficeTxtBox.DataTextField = "place";
                                DesignatedOfficeTxtBox.DataValueField = "LocationID";
                                DesignatedOfficeTxtBox.DataBind();
                            }
                        }
                    }
                    con.Close();
                }
            }
            //DesignatedOfficeTxtBox.Items.Clear();
            //DesignatedOfficeTxtBox.Items.Insert(0, "SELECT LOCATION");
            //int district = int.Parse(DistrictCtDropDownList.SelectedValue);

            //var context = from l in assetsEntities.AssetLocations
            //              where l.DistrictID.Equals(district)
            //              orderby l.place ascending
            //              select new
            //              {
            //                  l.LocationID,
            //                  l.place
            //              };
            //DesignatedOfficeTxtBox.DataSource = context.ToList();
            //DesignatedOfficeTxtBox.DataTextField = "place";
            //DesignatedOfficeTxtBox.DataValueField = "LocationID";

            //DesignatedOfficeTxtBox.DataBind();
        }

        protected void CreateBtn_Click(object sender, EventArgs e)
        {
            string query = "insert into asset(DateCreated,Asset_Name,Manufacturer,Serial_No,Model,Landing_cost,DistrictID,Designated_Office," +
                "Acquired_Date,Designated_Department,Room_No,custodian,Status,Comments,Source_of_funds,Quantity) " +
                "values('" + DateTime.Now+"','"+ AssetNameTxtBox.Text + "','"+ ManufacturerTxtBox.Text + "','"+ SerialNumberTxtBox.Text + "'," +
                "'"+ ModelNumberTxtBox.Text + "','"+ int.Parse(txtLandingCost.Text) + "','"+ int.Parse(DistrictCtDropDownList.SelectedValue) + "'," +
                "'"+ int.Parse(DesignatedOfficeTxtBox.SelectedValue) + "','"+ DateTime.Parse(AcquiredDateCalendar.Text) + "'," +
                "'"+ DesignatedDepartmentTxtBox.Text + "','"+ RoomNumberTxtBox.Text + "','"+ CustodianTxtBox.Text + "','"+ StatusTxtBox.SelectedValue + "'," +
                "'"+ CommentTxtBox.Text + "','"+ drpSourceoffunds.Text + "','"+ int.Parse(txtQuantity.Text) + "')";

            try
            {
                using (SqlConnection con = new SqlConnection(DBConnect.Connects()))
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.ExecuteNonQuery();
                        MsgLabel.Text = "Successfully Saved";
                    }
                    con.Close();
                }

                //Asset _asset = new Asset();
                //_asset.DateCreated = DateTime.Now;
                //_asset.Asset_Name = AssetNameTxtBox.Text;
                //_asset.Manufacturer = ManufacturerTxtBox.Text;
                //_asset.Serial_No = SerialNumberTxtBox.Text;
                //_asset.Model = ModelNumberTxtBox.Text;
                //_asset.Landing_cost = int.Parse(txtLandingCost.Text);
                //_asset.DistrictID = int.Parse(DistrictCtDropDownList.SelectedValue);
                //_asset.Designated_Office = int.Parse(DesignatedOfficeTxtBox.SelectedValue);
                //_asset.Acquired_Date = DateTime.Parse(AcquiredDateCalendar.Text);
                //_asset.Designated_Department = DesignatedDepartmentTxtBox.Text;
                //_asset.Room_No = RoomNumberTxtBox.Text;
                //_asset.custodian = CustodianTxtBox.Text;
                //_asset.Status = StatusTxtBox.SelectedValue;
                //_asset.Comments = CommentTxtBox.Text;
                //_asset.Source_of_funds = drpSourceoffunds.Text;
                //_asset.Quantity = int.Parse(txtQuantity.Text);
                //MsgLabel.Text = "Successfully Saved";

                //assetsEntities.Assets.Add(_asset);
                //assetsEntities.SaveChanges();

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
            catch (Exception es)
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