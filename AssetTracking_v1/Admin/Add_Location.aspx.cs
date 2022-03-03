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
            using (SqlConnection con = new SqlConnection(DBConnect.Connects()))
            {
                string query = "select * from district where districtid>0 order by name";
                con.Open();
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
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
        protected void btnCreateLocation_Click(object sender, EventArgs e)
        {
            string query = "insert into AssetLocation(DistrictID,place) values('"+ DistrictCtDropDownList.SelectedValue + "','"+ txtPlace.Text + "')";
            using(SqlConnection con = new SqlConnection(DBConnect.Connects()))
            {
                con.Open();
                try
                {
                    using(SqlCommand cmd = new SqlCommand(query,con))
                    {
                        cmd.ExecuteNonQuery();
                        MsgLabel.Text = "Location " + txtPlace.Text + "of " + DistrictCtDropDownList.SelectedValue + "Saved Successfully";
                        txtPlace.Text = string.Empty;
                    }
                }
                catch(Exception)
                {
                    MsgLabel.Text = "Failed to save Location. Please contact system administrator";
                }
                con.Close();
            }
            //AssetLocation asset = new AssetLocation();
            //asset.DistrictID = Int32.Parse(DistrictCtDropDownList.SelectedValue);
            //asset.place = txtPlace.Text;

            //try
            //{
            //    assetsEntities.AssetLocations.Add(asset);
            //    assetsEntities.SaveChanges();

            //    MsgLabel.Text = "Location " + asset.place + "of " + DistrictCtDropDownList.SelectedValue + "Saved Successfully";

            //    txtPlace.Text = string.Empty;
            //}
            //catch (Exception)
            //{
            //    MsgLabel.Text = "Failed to save Location. Please contact system administrator";
            //}
        }
    }
}