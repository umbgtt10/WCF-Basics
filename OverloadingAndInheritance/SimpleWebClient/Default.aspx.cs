using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Threading;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MultiplicationServiceReference;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        var student = new Student()
        {
            Sid = 1,
            Name = "Gianni",
            Contact = "Whoever"
        };

        var client = new MultiplicationServiceClient("BasicHttpBinding_MultiplicationService1");
        try
        {
            Response.Write(client.DivideInt(12, 0));
        }
        catch (FaultException<DivisionFault> ex)
        {
            Response.Write(ex.Detail.Message + "<br/>");
            Response.Write(ex.Detail.OperationMessage);
        }
        catch (Exception exc)
        {
            Response.Write(exc.Message);
        }
    }
}