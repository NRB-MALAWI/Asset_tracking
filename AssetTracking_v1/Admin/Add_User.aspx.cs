using AssetTracking_v1.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace AssetTracking_v1.Admin
{
    public partial class Add_User : System.Web.UI.Page
    {
       //NRBAssetsEntities _entity = new NRBAssetsEntities();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        [Obsolete]
        protected void CreateBtn_Click(object sender, EventArgs e)
        {
            Add_Users();
        }

        [Obsolete]
        void Add_Users()
        {
            string query = "";
            //Asset_User user = new Asset_User();
            string password = FormsAuthentication.HashPasswordForStoringInConfigFile(txtPassword.Text, "SHA1");

            try
            {
                using(SqlConnection con = new SqlConnection(DBConnect.Connects()))
                {
                    con.Open();
                    using(SqlCommand cmd = new SqlCommand(query,con))
                    {
                        cmd.ExecuteNonQuery();
                        MsgLabel.Text = "User Added Successfully";
                    }
                    con.Close();
                }
            }
            catch(Exception)
            {
                MsgLabel.Text = "Failed to Add User, Please contact system Administrator !!";
            }
            //User _user = new User();
            //UserRole role = new UserRole();
            //_user.FirstName = txtfirstname.Text;
            //_user.OtherNames = txtOthernames.Text;
            //_user.Surname = txtSurname.Text;
            //_user.Password = password;
            //_user.Username = txtusername.Text;
            //if (ActivateUserchk.Checked == true)
            //{
            //    _user.IsUserActive = 1;
            //}
            //else
            //{
            //    _user.IsUserActive = 0;
            //}
            //if (rdAdmin.Checked == true) { _user.UserROle = rdAdmin.Text; }
            //if (rdPRO.Checked == true) { _user.UserROle = rdPRO.Text; }
            //if (rdARO.Checked == true) { _user.UserROle = rdARO.Text; }


            //_entity.Users.Add(_user);
            //_entity.SaveChanges();


            
        }
    }
}