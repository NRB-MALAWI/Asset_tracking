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
            Usernamelbl.Text = UserLogin.username;

            if (Usernamelbl.Text == "")
            {
                Response.Redirect(@"~/Signin.aspx");
            }

        }
    }
}