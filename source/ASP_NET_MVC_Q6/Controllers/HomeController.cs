using ASP_NET_MVC_Q6.ActionFilter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ASP_NET_MVC_Q6.Models;

namespace ASP_NET_MVC_Q6.Controllers
{
    [AreaLogActionFilter]
    public class HomeController : Controller
    {
        public RouteModel ShowRoute(RouteModel routeModel)
        {
            RouteModel route = new RouteModel();
            route.Controller = routeModel.Controller;
            if (routeModel.Area == null)
            {
                route.Area = "-";
            }
            else
            {
                route.Area = routeModel.Area;
            }
            route.Action = routeModel.Action;
            return route;
        }
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Welcome(RouteModel routeModel)
        {
            return View(ShowRoute(routeModel));
        }
        public ActionResult ContactMe(RouteModel routeModel)
        {
            return View(ShowRoute(routeModel));
        }
    }
}