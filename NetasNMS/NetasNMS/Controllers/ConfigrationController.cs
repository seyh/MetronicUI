using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NetasNMS.Controllers
{
    public class ConfigrationController : Controller
    {
        // GET: Configration
        public ActionResult SubnetManagement()
        {
            return View();
        }

        public ActionResult Configration()
        {
            return View();
        }

        public ActionResult Topology()
        {
            return View();
        }

        public ActionResult FileManagement()
        {
            return View();
        }

        public ActionResult Template()
        {
            return View();
        }
    }
}