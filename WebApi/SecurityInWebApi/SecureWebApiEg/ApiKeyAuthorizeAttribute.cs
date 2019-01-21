using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using System.Web.Http.Controllers;
using SecureWebApiEg.Models;

namespace SecureWebApiEg
{
    public class ApiKeyAuthorizeAttribute : AuthorizeAttribute
    {
        public override void OnAuthorization(HttpActionContext actionContext)
        {
            var actionRole = Roles[0].ToString();
            var userName = HttpContext.Current.User.Identity.Name;

            var context = new WebApiSecurityDbContext();
            var user = context.APIUsers.SingleOrDefault(u => u.APIUserName.ToString().Equals(userName));
            if (user == null || !user.APIUserRole.Equals(actionRole))
            {
                actionContext.Response = new HttpResponseMessage(HttpStatusCode.Unauthorized);
            }
        }
    }
}