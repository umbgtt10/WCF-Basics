using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Security;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WcfSecurityServiceReference;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        try
        {
            var client = new CalculatorClient("BasicHttpBinding_ICalculator");
            client.ClientCredentials.UserName.UserName = "test";
            client.ClientCredentials.UserName.Password = "test";
            Response.Write(client.Add(4, 96));
        }
        catch (MessageSecurityException exception)
        {
            Response.Write(exception.Message);
        }

    }
}