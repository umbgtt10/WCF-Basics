﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
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

        try
        {
            Response.Write(client.DivideInt(5, 0));
        }
        catch (FaultException<DivisionFault> exception)
        {
            Response.Write(exception.Message);
        }
    }
}