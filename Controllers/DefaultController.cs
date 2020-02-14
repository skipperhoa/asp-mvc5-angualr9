using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Routing;
namespace WebAngular9mvc5.Controllers
{
    [Route("api/[controller]")]
    public class DefaultController : ApiController
    {
        [HttpGet]
        public string  Get()
        {
            return "hoa";
        }
    }
}
