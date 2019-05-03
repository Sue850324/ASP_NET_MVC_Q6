using ASP_NET_MVC_Q6.ActionFilter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASP_NET_MVC_Q6.Controllers
{
    [LogActionFilter]
    public class MainController : Controller
    {
        // GET: Main
        public ActionResult Login()
        {
            return View();
        }
        public ActionResult List()
        {
            return View();
        }
    }
}