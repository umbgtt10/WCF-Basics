using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MultiplicationServiceReference;

public partial class MultiplicationServiceForm : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        var client = new MultiplicationServiceClient("BasicHttpBinding_MultiplicationService");

        Response.Write(client.Multiply(5, 5));
    }
}