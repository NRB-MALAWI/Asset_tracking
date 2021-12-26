using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AssetTracking_v1.Admin
{
    public partial class Administrator : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Usernamelbl.Text!="username")
            {
                Usernamelbl.Text = UserLogin.username;
            }
            else
            {
                Response.Redirect(@"~/Default.aspx");
            }
        }
    }
}