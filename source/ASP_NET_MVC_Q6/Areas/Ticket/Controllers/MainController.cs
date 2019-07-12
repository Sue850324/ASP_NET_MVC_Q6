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
        Random rdm = new Random();
        public RouteModel ShowRoute(RouteModel routeModel)
        {      
            RouteModel route = new RouteModel();
            route.Area = routeModel.Area;
            route.Controller = routeModel.Controller;
            route.Action = routeModel.Action;
            route.Value = rdm.Next(1, 100);
            return route;
        }
        // GET: Ticket/Main
        public ActionResult List(RouteModel routeModel)
        {           
            return View( ShowRoute(routeModel));
        }
        public ActionResult Detail(RouteModel routeModel)
        {
            return View(ShowRoute(routeModel));

        }
    }
}