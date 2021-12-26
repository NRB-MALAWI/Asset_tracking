using AssetTracking_v1.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AssetTracking_v1.Admin
{
    public partial class View_Users : System.Web.UI.Page
    {
        NRBAssetsEntities assetsEntities = new NRBAssetsEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                var context = (from u in assetsEntities.Users
                               select new
                               {
                                   u.UserId,
                                   u.FirstName,
                                   u.OtherNames,
                                   u.Surname,
                                   u.Username,
                                   u.UserROle
                               }
                           ).ToList();
                GridView1.DataSource = context;
                GridView1.DataBind();
            }
        }
    }
}