using ASP_NET_MVC_Q6.ActionFilter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASP_NET_MVC_Q6.Controllers
{
    [AreaLogActionFilter]
    public class HomeController : Controller
    {
        public void ShowRoute()
        {
            string controller = RouteData.Values["Controller"] as string;
            string action = RouteData.Values["Action"] as string;
            string area = RouteData.Values["Area"] as string;
            if (area is null)
            {
                area = "-";
            }
            ViewBag.Area = area;
            ViewBag.Controller = controller;
            ViewBag.Action = action;
        }
        public ActionResult Index()
        {
            ShowRoute();
            return View();
        }
        public ActionResult Welcome()
        {
            ShowRoute();
            return View();
        }
        public ActionResult ContactMe()
        {
            ShowRoute();
            return View();
        }
    }
}