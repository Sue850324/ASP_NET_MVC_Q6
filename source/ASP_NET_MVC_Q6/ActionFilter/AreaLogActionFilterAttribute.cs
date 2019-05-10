using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using ASP_NET_MVC_Q6.Models;

namespace ASP_NET_MVC_Q6.ActionFilter
{
    public class AreaLogActionFilterAttribute : ActionFilterAttribute, IActionFilter
    {
        private HttpWriter output;
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            output = (HttpWriter)filterContext.RequestContext.HttpContext.Response.Output;
            WriteLog(" ", filterContext.RouteData);
        }

        private void WriteLog(string methodName, RouteData routeData)
        {
            RouteModel route = new RouteModel();
            var Area = routeData.Values["Area"];
            if (Area != null)
            {
                route.Area = Area.ToString();
            }
            var controllerName = routeData.Values["Controller"];
            route.Controller = controllerName.ToString();
            var actionName = routeData.Values["Action"];
            route.Action = actionName.ToString();
            var message = String.Format(methodName, route.Area, route.Controller, route.Action);
            output.WriteLine(message);
            Debug.WriteLine(message, "Action Filter Log");

        }
    }
}