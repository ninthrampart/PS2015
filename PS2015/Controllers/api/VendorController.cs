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
    public class VendorController : ApiController
    {
        [HttpGet]
        [Route("api/Vendor/Get/{psid}")]
        public List<VendorModel> Get(int psid)
        {

            IVendorModelRepository rep = new VendorModelFakeRepository();

            return rep.Get(psid);
        }
    }
}
