using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace MyFirstWebApi.Controllers
{
    [EnableCors("*","*","*")]
    public class MttController : ApiController
    {
        private readonly string[] _content = new[] { "Umberto Gotti", "Francesca Ceccaroli" };

        //../api/Mtt
        public string[] Get()
        {
            return _content;
        }

        //../api/Mtt//id
        public string Get(int id)
        {
            return _content[id];
        }
    }
}
