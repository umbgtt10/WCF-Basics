using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http.Filters;

namespace CrudWebApi.Controllers
{
    public class MyExceptionAttribute : ExceptionFilterAttribute
    {
        public override void OnException(HttpActionExecutedContext actionExecutedContext)
        {
            HttpResponseMessage msg = new HttpResponseMessage(HttpStatusCode.NotImplemented);
            msg.ReasonPhrase = actionExecutedContext.Exception.Message;
            actionExecutedContext.Response = msg;
            base.OnException(actionExecutedContext);
        }
    }
}