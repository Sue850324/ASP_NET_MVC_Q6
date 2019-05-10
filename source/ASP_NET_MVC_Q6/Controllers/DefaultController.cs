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
    public class DefaultController : Controller
    {
        public object ShowRoute(RouteModel routeModel)
        {
            Random rdm = new Random();
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
            route.Value = rdm.Next(1, 100);
            return route;
        }
        public ActionResult Login(RouteModel routeModel)
        {
            return View( ShowRoute(routeModel));
        }
        public ActionResult List(RouteModel routeModel)
        {
            return View(ShowRoute(routeModel));
        }
    }
}