using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Web;
using System.Web.Http;

namespace GlaveStar.Controllers
{
    [Authorize]
    [RoutePrefix("api/userAccount")]
    public class UserAccountController : ApiController
    {
        [Route("")]
        public IEnumerable<object> GetShipments()
        {
            var identity = User.Identity as ClaimsIdentity;

            return identity.Claims.Select(c => new
            {
                Type = c.Type,
                Value = c.Value
            });
        }
    }
}