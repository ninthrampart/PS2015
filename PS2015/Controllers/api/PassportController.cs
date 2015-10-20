using PS2015.Models;
using PS2015.Models.Fake;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PS2015.Controllers.api
{
    public class PassportController : ApiController
    {
        public PS Get(int id)
        {

            IPSRepository rep = new PSFakeRepository();

            return rep.Get(id);
        }
    }
}
