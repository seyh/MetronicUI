using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NetasNMS.Controllers
{
    public class SystemController : Controller
    {
        // GET: System
        public ActionResult Settings()
        {
            return View();
        }

        public ActionResult Notification()
        {
            return View();
        }

        public ActionResult ImportExport()
        {
            return View();
        }
    }
}