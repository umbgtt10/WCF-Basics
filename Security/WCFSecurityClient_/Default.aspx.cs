using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WCFSecurityServiceReference;
using System.ServiceModel;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnAdd_Click(object sender, EventArgs e)
    {
        try
        {
            CalculatorClient cc = new CalculatorClient("NetTcpBinding_ICalculator");
            cc.ClientCredentials.Windows.ClientCredential.UserName = "Thinkpad-PC\\Thinkpad";
            cc.ClientCredentials.Windows.ClientCredential.Password = "thinkpad.6";
            int c = cc.Add(int.Parse(txta.Text), int.Parse(txtb.Text));
            Response.Write(c.ToString());
        }
        catch (Exception E1)
        {
            Response.Write(E1.Message);
        }
    }
}