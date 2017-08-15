using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NetasNMS.Controllers
{
    public class ReportingController : Controller
    {
        // GET: Reporting
        public ActionResult NetworkReport()
        {
            return View();
        }

        public ActionResult AlarmReport()
        {
            return View();
        }

        public ActionResult InventoryReport()
        {
            return View();
        }

        public ActionResult WLANReport()
        {
            return View();
        }
    }
}