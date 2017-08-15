using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NetasNMS.Controllers
{
    public class MonitorController : Controller
    {
        // GET: Monitor
        public ActionResult CurrentAlarms()
        {
            return View();
        }

        public ActionResult HistoricalAlarms()
        {
            return View();
        }

        public ActionResult ACNetworkMonitor()
        {
            return View();
        }

        public ActionResult APNetworkMonitor()
        {
            return View();
        }

        public ActionResult ClientNetworkMonitor()
        {
            return View();
        }
    }
}