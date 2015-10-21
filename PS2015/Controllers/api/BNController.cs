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
    public class BNController : ApiController
    {
        [HttpGet]
        [Route("api/BN/Get/{psid}")]
        public List<BNSumModel> Get(int psid)
        {

            IBNSumModelRepository rep = new BNSumModelFakeRepository();

            return rep.Get(psid);
        }
    }
}
