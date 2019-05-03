using ASP_NET_MVC_Q6.ActionFilter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ASP_NET_MVC_Q6.Models;
namespace ASP_NET_MVC_Q6.Areas.Product.Controllers
{
    [AreaLogActionFilter]
    public class MainController : Controller
    {
       
        public ActionResult List()
        {
            string category = "List";
            Route route = new Route();
            string controller = RouteData.Values["controller"] as string;
            string action = RouteData.Values["action"] as string;
            string area = RouteData.Values["Area"] as string;
            ViewBag.controller = controller;
            ViewBag.action = action;
            ViewBag.area = area;
            route.category= category;

            return View(route);
        }
    }
}