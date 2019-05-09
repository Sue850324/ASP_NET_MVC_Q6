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
            int page = 1;
            Route route = new Route();
            string controller = RouteData.Values["Controller"] as string;
            string action = RouteData.Values["Action"] as string;
            string area= RouteData.Values["Area"] as string;
            ViewBag.Controller = controller;
            ViewBag.Action = action;
            ViewBag.Area = area;
            route.Page=page;

            return View(route);            
        }
        public ActionResult Detail()
        {
            int id = 1;
            Route route = new Route();
            string controller = RouteData.Values["Controller"] as string;
            string action = RouteData.Values["Action"] as string;
            string area = RouteData.Values["Area"] as string;
            ViewBag.Controller = controller;
            ViewBag.Action = action;
            ViewBag.Area = area;
            route.ID = id;
            return View(route);
        }
    }
}