using ASP_NET_MVC_Q6.ActionFilter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ASP_NET_MVC_Q6.Models;

namespace ASP_NET_MVC_Q6.Areas.Order.Controllers
{
    [AreaLogActionFilter]
    public class DefaultController : Controller
    {
        // GET: Order/Main
        public ActionResult List()
        {
            int Page = 1;
            Route route = new Route();
            string controller = RouteData.Values["controller"] as string;
            string action = RouteData.Values["action"] as string;
            string area= RouteData.Values["Area"] as string;
            ViewBag.controller = controller;
            ViewBag.action = action;
            ViewBag.area = area;
            route.page=Page;

            return View(route);            
        }
        public ActionResult Detail()
        {
            int id = 1;
            Route route = new Route();
            string controller = RouteData.Values["controller"] as string;
            string action = RouteData.Values["action"] as string;
            string area = RouteData.Values["Area"] as string;
            ViewBag.controller = controller;
            ViewBag.action = action;
            ViewBag.area = area;
            route.id = id;
            return View(route);
        }
    }
}