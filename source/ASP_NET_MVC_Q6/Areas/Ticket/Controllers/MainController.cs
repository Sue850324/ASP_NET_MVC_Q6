using ASP_NET_MVC_Q6.ActionFilter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ASP_NET_MVC_Q6.Models;

namespace ASP_NET_MVC_Q6.Areas.Ticket.Controllers
{
    [AreaLogActionFilter]
    public class MainController : Controller
    {
        // GET: Ticket/Main
        public ActionResult List()
        {
            Route route = new Route();
            string controller = RouteData.Values["Controller"] as string;
            string action = RouteData.Values["Action"] as string;
            string area = RouteData.Values["Area"] as string;
            ViewBag.controller = controller;
            ViewBag.action = action;
            ViewBag.area = area;
            return View();
        }
        public ActionResult Detail()
        {
            int id = 9;
            Route route = new Route();
            string controller = RouteData.Values["Controller"] as string;
            string action = RouteData.Values["Action"] as string;
            string area = RouteData.Values["Area"] as string;
            ViewBag.controller = controller;
            ViewBag.action = action;
            ViewBag.area = area;
            route.ID = id;

            return View(route);
        }
    }
}