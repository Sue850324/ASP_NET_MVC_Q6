using ASP_NET_MVC_Q6.ActionFilter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASP_NET_MVC_Q6.Area.Controllers
{
    [LogActionFilter]
    public class HomeController : Controller
    {
        // GET: Main
        public ActionResult Welcome()
        {
            return View();
        }
        public ActionResult Contact()
        {
            return View();
        }
    }
}