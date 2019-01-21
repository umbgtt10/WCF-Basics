using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SecureWebApiEg.Controllers
{
    public class TestController : ApiController
    {
        [ApiKeyAuthorizeAttribute(Roles="A")]
        public IHttpActionResult Get()
        {
            return Ok<string>("You are welcome:" + User.Identity.Name);
        }

        [ApiKeyAuthorizeAttribute(Roles = "U")]
        public IHttpActionResult Get(int id)
        {
            return Ok<string>("You are welcome by id:" + id);
        }
    }
}
