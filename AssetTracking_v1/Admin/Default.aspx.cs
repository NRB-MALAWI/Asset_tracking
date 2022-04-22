using AssetTracking_v1.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;

namespace AssetTracking_v1.Admin
{
    public partial class Default : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                //GetRecordsGroupByAssetName();
            }
        }
        void GetRecordsGroupByAssetName()
        {
            string query = "select Asset_Name, count(*) Total from Asset group by Asset_Name";
            using(SqlConnection con = new SqlConnection(DBConnect.Connects()))
            {
                using(SqlCommand cmd = new SqlCommand(query,con))
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
        }
    }
}