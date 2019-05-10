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
        Random rdm = new Random();
        public ActionResult List(RouteModel routeModel)
        {
            RouteModel route = new RouteModel();
            route.Area = routeModel.Area;
            route.Controller = routeModel.Controller;
            route.Action = routeModel.Action;
            route.Category = "test";
            return View(route);
        }
    }
}