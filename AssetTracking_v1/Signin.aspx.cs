using AssetTracking_v1.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data.SqlClient;


namespace AssetTracking_v1
{
    public partial class Signin : System.Web.UI.Page
    {
        //NRBAssetsEntities assetsEntities = new NRBAssetsEntities();
        //string ConnString = ConfigurationManager.ConnectionStrings["NRBAssetsConnectionString"].ToString();

        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        [Obsolete]
        void Authenticate_User()
        {
            string pwd = FormsAuthentication.HashPasswordForStoringInConfigFile(passwdtxtbox.Value, "SHA1");
            using (SqlConnection con = new SqlConnection(DBConnect.Connects()))
            {
                con.Open();
                string query = "select username,Password,UserROle from Users where username='" + usernametxtbox.Value + "' and Password='" + pwd + "'";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    using (SqlDataReader rdr = cmd.ExecuteReader())
                    {
                        if (rdr.HasRows)
                        {
                            while (rdr.Read())
                            {
                                UserLogin.username = rdr[0].ToString();
                                
                                if (rdr["UserROle"].ToString() == "Admin")
                                {
                                    Response.Redirect("~/Admin/Default.aspx");
                                }
                                if(rdr["UserROle"].ToString()== "PRO")
                                {
                                    Response.Redirect("~/PRO/Default.aspx");
                                }
                            }
                        }
                        else
                        {
                            MSGLabel.Text = "Incorrect Username or Password";
                        }
                    }
                }
                con.Close();
            }
            //string password = FormsAuthentication.HashPasswordForStoringInConfigFile(passwdtxtbox.Value, "SHA1");

            //if (usernametxtbox.Value != string.Empty && password != string.Empty)
            //{
            //    var UserExist = assetsEntities.Users.FirstOrDefault(a => a.Username.Equals(usernametxtbox.Value));

            //    if (UserExist != null)
            //    {
            //        //UserLogin.username = assetsEntities.Users.FirstOrDefault(a => a.Username.Equals(UserExist.Username)).ToString();
            //        UserLogin.username = UserExist.Username;

            //        if (UserExist.Password.Equals(password))
            //        {
            //            if (UserExist.UserROle.Equals("Admin"))
            //            {
            //                Response.Redirect("~/Admin/Default.aspx");
            //            }
            //            else if (UserExist.UserROle.Equals("PRO"))
            //            {
            //                Response.Redirect("~/PRO/Default.aspx");
            //            }
            //            else if (UserExist.UserROle.Equals("ARO"))
            //            {
            //                Response.Redirect("~/ARO/Default.aspx");
            //            }
            //            else
            //            {
            //                MSGLabel.Text = "User has no ROles";
            //            }
            //        }
            //        MSGLabel.Text = "Incorrect Username and Password combination";
            //    }
            //    MSGLabel.Text = "User does not exists !!!!";
            //}
        }

        [Obsolete]
        protected void btnLogin_Click(object sender, EventArgs e)
        {
            Authenticate_User();
        }
    }
}