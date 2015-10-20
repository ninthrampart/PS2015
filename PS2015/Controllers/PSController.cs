using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PS2015.Controllers
{
    public class PSController : Controller
    {
        // GET: PS
        public ActionResult Index(string id)
        {
            ViewBag.PsId = id;

            return View();
        }
    }
}