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
        Random rdm = new Random();
        RouteModel route = new RouteModel();
        public void  ShowRoute()
        {
            string controller = RouteData.Values["Controller"] as string;
            string action = RouteData.Values["Action"] as string;
            string area= RouteData.Values["Area"] as string;
            ViewBag.Controller = controller;
            ViewBag.Action = action;
            ViewBag.Area = area;
        }
        // GET: Order/Main
        public ActionResult List()
        {         
            ShowRoute();
            route.Page = rdm.Next(1, 100);
            return View(route);            
        }
        public ActionResult Detail()
        {           
            ShowRoute();
            route.ID = rdm.Next(1,100);
            return View(route);
        }
    }
}