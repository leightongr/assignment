using license.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebTitle
{
    public partial class GetLicenseControl : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCheck_Click(object sender, EventArgs e)
        {
            LicenseConnection connection = new LicenseConnection();

            var firstName = txtFirstName.Text;
            var lastName = txtLastName.Text;
            var trn = txtTRN.Text;

            var existingLicense = connection.Licenses.FirstOrDefault(x =>
                 x.FirstName == firstName && x.LastName == lastName
                 && x.Trn == trn);

            if(existingLicense == null)
            {
                Session.Add("CurrentLicense", null);
                this.alertInvalidInfo.Attributes["class"]= this.alertInvalidInfo.Attributes["class"].Replace("hidden", "");
            }
            else
            {
                Session.Add("CurrentLicense", existingLicense);
                this.alertInvalidInfo.Attributes["class"] += " hidden";

            }

        }
    }
}