using Microsoft.Reporting.WebForms;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AssetTracking_v1.Admin
{
    public partial class Asset_Sheet : System.Web.UI.Page
    {
        string ConneString = ConfigurationManager.ConnectionStrings["NRBAssetsConnectionString"].ToString();
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        void GetAssetSheetByRoomNumber()
        {
            string query = "select Asset_Name,custodian,Room_No, count(*) as Quantity from Asset where Room_No=" + txtAssetNumber.Value + " group by Asset_Name,custodian,Room_No";
            using (SqlDataAdapter da = new SqlDataAdapter(query, ConneString))
            {
                using (DataTable dt = new DataTable("DataTable1"))
                {
                    da.Fill(dt);
                    ReportViewer1.ProcessingMode = ProcessingMode.Local;
                    ReportViewer1.LocalReport.ReportPath = Server.MapPath("..\\AssetSheet.rdlc");
                    ReportViewer1.LocalReport.DataSources.Clear();
                    ReportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", dt));
                }
            }
        }
        void GetAssetSheetByCustodian()
        {

        }

        protected void btnSearchAssetNumber_Click(object sender, EventArgs e)
        {
            GetAssetSheetByRoomNumber();
        }
    }
}