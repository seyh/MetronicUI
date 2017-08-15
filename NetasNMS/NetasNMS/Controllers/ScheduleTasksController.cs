using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NetasNMS.Controllers
{
    public class ScheduleTasksController : Controller
    {
        // GET: ScheduleTasks
        public ActionResult DownloadFile()
        {
            return View();
        }

        public ActionResult Report()
        {
            return View();
        }

        public ActionResult Reboot()
        {
            return View();
        }
    }
}