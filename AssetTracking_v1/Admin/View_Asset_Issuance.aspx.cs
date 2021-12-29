using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using AssetTracking_v1.Model;

namespace AssetTracking_v1.Admin
{
    public partial class View_Asset_Issuance : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                Get_Issuances();
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
    }
}