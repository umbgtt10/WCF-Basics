using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Claims;
using System.Security.Principal;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using SecureWebApiEg.Models;

namespace SecureWebApiEg
{
    public class ApiKeyHandler : DelegatingHandler
    {
        protected override Task<HttpResponseMessage> SendAsync(
            HttpRequestMessage request,
            CancellationToken cancellationToken)
        {

            // If passed as a url segment:
            // http://localhost:4682/api/Test?ApiKey=55bee49d-bba6-4eb5-b011-d7e56b5d3262
            // var queryString = request.RequestUri.ParseQueryString();
            //var apiKey = queryString["apiKey"];

            // If passed as a header
            var apiKey = request.Headers.GetValues("apiKey").FirstOrDefault();

            var context = new WebApiSecurityDbContext();
            var user = context.APIUsers.SingleOrDefault(u => u.APIUserKey.ToString().Equals(apiKey.ToString()));
            if (user != null)
            {
                var username = user.APIUserName;
                var principal = new ClaimsPrincipal(new GenericIdentity(username, "APIKey"));
                HttpContext.Current.User = principal;

                return base.SendAsync(request, cancellationToken);
            }
            else
            {
                var forbidden = new HttpResponseMessage(HttpStatusCode.Forbidden);
                var task = new TaskCompletionSource<HttpResponseMessage>();
                task.SetResult(forbidden);
                return task.Task;
            }
       }
    }
}