using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ASPMVC2.Models;

namespace ASPMVC2.Controllers
{
    public class LoginLogController : Controller
    {
        // GET: LoginLog
        public ActionResult Index()
        {
            Person person = new Models.Person();
            return View();
        }
    }
}