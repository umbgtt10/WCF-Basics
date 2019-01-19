using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SampleClient.SampleServiceReference;

namespace SampleClient
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var client = new ServiceSampleClient();
            DropDownList1.DataSource = client.GetCountries();
            DropDownList1.DataValueField = "Name";
            DropDownList1.DataTextField = "Name";
            DropDownList1.DataBind();
        }
    }
}