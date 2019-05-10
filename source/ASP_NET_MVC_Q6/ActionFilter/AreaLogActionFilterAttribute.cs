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
            var Area= routeData.Values["Area"];
            var controllerName = routeData.Values["Controller"];
            var actionName = routeData.Values["Action"];
            var message = String.Format( methodName, Area, controllerName, actionName);
            output.WriteLine(message);
            Debug.WriteLine(message, "Action Filter Log");
            
        }
    }
}