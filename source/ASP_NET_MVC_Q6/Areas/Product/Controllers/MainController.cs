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
            RouteModel route = new RouteModel();
            string controller = RouteData.Values["Controller"] as string;
            string action = RouteData.Values["Action"] as string;
            string area = RouteData.Values["Area"] as string;
            ViewBag.Controller = controller;
            ViewBag.Action = action;
            ViewBag.Area = area;
            route.Category= category;

            return View(route);
        }
    }
}