using ASP_NET_MVC_Q6.ActionFilter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASP_NET_MVC_Q6.Controllers
{
    [AreaLogActionFilter]
    public class DefaultController : Controller
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
        public ActionResult Login()
        {
            ShowRoute();
            return View();
        }
        public ActionResult List()
        {
            ShowRoute();
            return View();
        }
    }
}