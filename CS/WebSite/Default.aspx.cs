using System;

using DevExpress.XtraReports.Web;
using DevExpress.XtraReports.UI;

public partial class _Default : System.Web.UI.Page 
{
    protected void Page_Load(object sender, EventArgs e)
    {
            if(Session["Report"] == null) {
                XtraReport1 r = new XtraReport1();
                Session["Report"] = r;
            }
            ReportViewer1.Report = Session["Report"] as XtraReport;
    }
    protected void ReportViewer1_Unload(object sender,EventArgs e) {
        ((ReportViewer)sender).Report = null;
    }
}
