using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NetasNMS.Controllers
{
    public class UserManagementController : Controller
    {
        // GET: UserManagement
        public ActionResult UserManagement()
        {
            return View();
        }

        public ActionResult UserAudit()
        {
            return View();
        }

        public ActionResult ChangePassword()
        {
            return View();
        }

        public ActionResult SessionSetting()
        {
            return View();
        }

        public ActionResult AccountSetting()
        {
            return View();
        }
    }
}