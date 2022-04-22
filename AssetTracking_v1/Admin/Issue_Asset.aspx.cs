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
using System.Drawing;

namespace AssetTracking_v1.Admin
{
    public partial class Issue_Asset : System.Web.UI.Page
    {
        //NRBAssetsEntities assetsEntities = new NRBAssetsEntities();
        //string ConneString = ConfigurationManager.ConnectionStrings["NRBAssetsConnectionString"].ToString();
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                GetAsset();
                GetDistrict();
            }
            
        }
        // Listing all districts
        void GetDistrict()
        {
            string query = "select * from district where districtid>0 order by name";
            using(SqlConnection con = new SqlConnection(DBConnect.Connects()))
            {
                con.Open();
                using(SqlCommand cmd = new SqlCommand(query,con))
                {
                    using(SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        using(DataTable dt = new DataTable())
                        {
                            da.Fill(dt);
                            drpSearchAssetbyDistrict.DataSource = dt;
                            drpSearchAssetbyDistrict.DataBind();
                        }
                    }
                }
                con.Close();
            }
        }
        // Listing all Assets 
        void GetAsset()
        {
            
            using (SqlConnection con = new SqlConnection(DBConnect.Connects()))
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

        // DIsplaying Data in GridView
        void Display_Data()
        {
            string query = "select a.Asset_No, a.Asset_Name, d.Name as District, l.place, a.Designated_Department, a.Quantity from Assets a " +
                "join districts d on d.districtid=a.districtid join AssetLocations l on l.locationid=a.Designated_Office " +
                "where a.saaet_name='"+ txtAssetName.SelectedValue.ToString() + "'";
            using(SqlConnection con = new SqlConnection())
            {
                con.Open();
                using(SqlCommand cmd = new SqlCommand(query,con))
                {
                    using(SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        using(DataTable dt = new DataTable())
                        {
                            da.Fill(dt);
                            GridView1.DataSource = dt;
                            GridView1.DataBind();
                        }
                    }
                }
                con.Close();
            }
        }

        // Listing Assets by name
        protected void txtAssetName_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(DBConnect.Connects()))
            {
                con.Open();
                string query = "select a.Asset_No,a.Asset_Name,d.Name as District,l.place as Office,a.Designated_Department,a.Quantity from Asset a " +
                    "join District d on d.DistrictId=a.DistrictID join AssetLocations l on l.LocationID = a.Designated_Office " +
                    "where a.Asset_Name='" + txtAssetName.SelectedValue + "'";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        GridView1.DataSource = dt;
                        GridView1.DataBind();
                    }
                }
                con.Close();
            }
            
        }

        protected void btnSearchAssetName_Click(object sender, EventArgs e)
        {
            string query = "select a.Asset_No,a.Asset_Name,d.Name as District,l.place as Office,a.Designated_Department,a.Quantity from Asset a " +
                    "join District d on d.DistrictId=a.DistrictID join AssetLocations l on l.LocationID = a.Designated_Office " +
                    "where a.Asset_Name='" + txtAssetName.SelectedValue + "'";

            using (SqlConnection con = new SqlConnection(DBConnect.Connects()))
            {
                using(SqlCommand cmd = new SqlCommand())
                {
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        GridView1.DataSource = dt;
                        GridView1.DataBind();
                    }
                }
            }
            //var context = (from a in assetsEntities.Assets
            //               join d in assetsEntities.Districts
            //               on a.DistrictID equals d.DistrictId
            //               join l in assetsEntities.AssetLocations
            //               on a.Designated_Office equals l.LocationID
            //               where a.Asset_Name.Equals("" + txtAssetName.SelectedValue.ToString() + "")
            //               select new
            //               {
            //                   a.Asset_No,
            //                   a.Asset_Name,
            //                   District=d.Name,
            //                   l.place,
            //                   a.Designated_Department,
            //                   a.Quantity
            //               }
            //               ).ToList();
            //GridView1.DataSource = context;
            //GridView1.DataBind();

        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            GridViewRow row = GridView1.SelectedRow;
            txtAssetNo.Value = row.Cells[1].Text;
            txtAsset_name.Value = row.Cells[2].Text;
            txtAsset_Location.Value = row.Cells[3].Text;
            txtQuantity.Value = row.Cells[6].Text;
        }
        // Inserting Items in Issuance table
        void UpdateAsset()
        {
            //string test = @"Data Source=issah\ti;Initial Catalog=NRBAssets;Integrated Security=True";
            string query = "insert into Issuance(Asset_No,Date_of_Issue,Issued_to,Quantity,Issued_by) " +
                "values(" + txtAssetNo.Value + ",'" + DateTime.Now + "','" + txtIssued_to.Value + "','" + txtQuanityIssue.Value + "','" + UserLogin.username + "') ";
                
            using(SqlConnection con = new SqlConnection(DBConnect.Connects()))
            {
                con.Open();
                using(SqlCommand cmd = new SqlCommand(query,con))
                {
                    cmd.ExecuteNonQuery();

                }
                con.Close();
            }
            //Issuance _issue = new Issuance();
            //_issue.Asset_No = int.Parse(txtAssetNo.Value);
            //_issue.Date_of_Issue = DateTime.Now;
            //_issue.Issued_by = UserLogin.username;
            //_issue.Issued_to = txtIssued_to.Value;
            //_issue.Quantity = int.Parse(txtQuanityIssue.Value);
            //assetsEntities.Issuances.Add(_issue);
            //assetsEntities.SaveChanges();

            //using (NRBAssetsEntities db = new NRBAssetsEntities())
            //{
            //    Asset asset = db.Assets.Where(a => a.Asset_No == Convert.ToInt32(txtAssetNo.Value)).First();
            //    Issuance _issue = db.Issuances.Where(i => i.Asset_No == int.Parse(txtAssetNo.Value)).FirstOrDefault();
            //    if (asset.Asset_No == 0) throw new Exception("");
            //    //asset.Quantity = int.Parse(txtQuanityIssue.Value);
            //    _issue.Issued_to = txtIssued_to.Value;
            //    _issue.Date_of_Issue = DateTime.Now;
            //    db.SaveChanges();
            //}
        }
        // Cleaning fields in Issue Asset UI Page
        void ClearFields()
        {
            txtAsset_name.Value = string.Empty;
            txtAssetNo.Value = string.Empty;
            txtAsset_Location.Value = string.Empty;
            txtAsset_name.Value = string.Empty;
            txtQuantity.Value = string.Empty;
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            if (txtAssetNo.Value == string.Empty)
            {
                MSGLabel.ForeColor = Color.Red;
                MSGLabel.Text = "Please Select Asset First !!!!!";
            }
            else
            {
                if (int.Parse(txtQuantity.Value) <= int.Parse(txtQuanityIssue.Value)) // Validating if Assets in database is sufficient
                {
                    MSGLabel.ForeColor = Color.Red;
                    MSGLabel.Text = "ITEMS REQUESTED ARE MORE THAN ITEMS IN STOCK";

                    ClearFields();
                }
                else
                {
                    try
                    {
                            string query = "insert into Issuance(Asset_No,Date_of_Issue,Issued_to,Quantity,Issued_by) " +
                            "values(" + txtAssetNo.Value + ",'" + DateTime.Now + "','" + txtIssued_to.Value + "','" + txtQuanityIssue.Value + "'," +
                            "'" + UserLogin.username + "') ";

                            using (SqlConnection con = new SqlConnection(DBConnect.Connects()))
                            {
                                con.Open();
                                using (SqlCommand cmd = new SqlCommand(query, con))
                                {
                                    cmd.ExecuteNonQuery();
                                    MSGLabel.ForeColor = Color.Green;
                                    MSGLabel.Text = "ITEM " + txtAsset_name.Value + " HAS BEEN ISSUED to " + txtIssued_to.Value + " SUCCESSFULLY";
                                }
                                con.Close();
                            }

                            Display_Data();
                       
                    }
                    catch (Exception es)
                    {
                        MSGLabel.Text = "Error !!!! Unable to Issue Asset ";
                    }

                    ClearFields();
                }
            }
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            ClearFields();
            Display_Data();
        }

        protected void btnSearchbyDistrict_Click(object sender, EventArgs e)
        {
            if(txtAssetName.SelectedIndex==0)
            {
                try
                {
                    ClearFields();
                    //var context = (from a in assetsEntities.Assets
                    //               join d in assetsEntities.Districts
                    //               on a.DistrictID equals d.DistrictId
                    //               join l in assetsEntities.AssetLocations
                    //               on a.Designated_Office equals l.LocationID
                    //               where d.Name.Equals(""+drpSearchAssetbyDistrict.SelectedValue.ToString()+"")
                    //               //where a.Asset_Name.Equals("" + txtAssetName.SelectedValue.ToString() + "")
                    //               select new
                    //               {
                    //                   a.Asset_No,
                    //                   a.Asset_Name,
                    //                   District = d.Name,
                    //                   l.place,
                    //                   a.Designated_Department,
                    //                   a.Quantity
                    //               }
                    //       ).ToList();
                    //GridView1.DataSource = context;
                    //GridView1.DataBind();
                }
                catch(Exception es)
                {
                    throw new Exception("" + es);
                }
            }
            else
            {
                try
                {
                    ClearFields();
                    //var context = (from a in assetsEntities.Assets
                    //               join d in assetsEntities.Districts
                    //               on a.DistrictID equals d.DistrictId
                    //               join l in assetsEntities.AssetLocations
                    //               on a.Designated_Office equals l.LocationID
                    //               where d.Name.Equals("" + drpSearchAssetbyDistrict.SelectedValue.ToString() + "") &&
                    //               a.Asset_Name.Equals("" + txtAssetName.SelectedValue.ToString() + "")
                    //               select new
                    //               {
                    //                   a.Asset_No,
                    //                   a.Asset_Name,
                    //                   District = d.Name,
                    //                   l.place,
                    //                   a.Designated_Department,
                    //                   a.Quantity
                    //               }
                    //       ).ToList();
                    //GridView1.DataSource = context;
                    //GridView1.DataBind();
                }
                catch(Exception es)
                {
                    throw new Exception("" + es);
                }
            }
        }

        protected void drpSearchAssetbyDistrict_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txtAssetName.SelectedIndex == 0)
            {
                try
                {
                    ClearFields();
                   // var context = (from a in assetsEntities.Assets
                   //        join d in assetsEntities.Districts
                   //        on a.DistrictID equals d.DistrictId
                   //        join l in assetsEntities.AssetLocations
                   //        on a.Designated_Office equals l.LocationID
                   //        where d.Name == drpSearchAssetbyDistrict.SelectedValue
                   //        //where a.Asset_Name.Equals("" + txtAssetName.SelectedValue.ToString() + "")
                   //        select new
                   //        {
                   //            a.Asset_No,
                   //            a.Asset_Name,
                   //            District = d.Name,
                   //            l.place,
                   //            a.Designated_Department,
                   //            a.Quantity
                   //        }
                   //).ToList();
                   //GridView1.DataSource = context;
                   //GridView1.DataBind();
                }
                catch (Exception es)
                {
                    throw new Exception("" + es);
                }
            }
            else
            {
                try
                {
                    ClearFields();
                    //var context = (from a in assetsEntities.Assets
                    //               join d in assetsEntities.Districts
                    //               on a.DistrictID equals d.DistrictId
                    //               join l in assetsEntities.AssetLocations
                    //               on a.Designated_Office equals l.LocationID
                    //               where d.Name.Equals("" + drpSearchAssetbyDistrict.SelectedValue + "") &&
                    //               a.Asset_Name.Equals("" + txtAssetName.SelectedValue.ToString() + "")
                    //               select new
                    //               {
                    //                   a.Asset_No,
                    //                   a.Asset_Name,
                    //                   District = d.Name,
                    //                   l.place,
                    //                   a.Designated_Department,
                    //                   a.Quantity
                    //               }
                    //       ).ToList();
                    //GridView1.DataSource = context;
                    //GridView1.DataBind();
                }
                catch (Exception es)
                {
                    throw new Exception("" + es);
                }
            }
        }
    }
}