using ASP_NET_MVC_Q6.ActionFilter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASP_NET_MVC_Q6.Controllers
{
    [LogActionFilter]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            string controller = RouteData.Values["Controller"] as string;
            string action = RouteData.Values["Action"] as string;
            string area = RouteData.Values["Area"] as string;
            ViewBag.Controller = controller;
            ViewBag.Action = action;
            return View();
        }
        public ActionResult Welcome()
        {
            string controller = RouteData.Values["Controller"] as string;
            string action = RouteData.Values["Action"] as string;
            string area = RouteData.Values["Area"] as string;
            ViewBag.Controller = controller;
            ViewBag.Action = action;
            return View();
        }
        public ActionResult ContactMe()
        {
            string controller = RouteData.Values["Controller"] as string;
            string action = RouteData.Values["Action"] as string;
            string area = RouteData.Values["Area"] as string;
            ViewBag.Controller = controller;
            ViewBag.Action = action;
            return View();
        }
    }
}