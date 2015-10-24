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
    public class WorkController : ApiController
    {
        [HttpGet]
        [Route("api/Work/GetForPassport/{psid}")]
        public List<WorkModel> GetForPassport(int psid)
        {

            IWorkModelRepository rep = new WorkModelFakeRepository();

            return rep.GetForPassport(psid);
        }
    }
}
