using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace ASP_NET_MVC_Q6.ActionFilter
{
    public class LogActionFilterAttribute : ActionFilterAttribute, IActionFilter
    {
        private HttpWriter output;
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            output = (HttpWriter)filterContext.RequestContext.HttpContext.Response.Output;
            WriteLog("OnActionExecuting", filterContext.RouteData);           
        }

        private void WriteLog(string methodName, RouteData routeData)
        {
            var controllerName = routeData.Values["Controller"];
            var actionName = routeData.Values["Action"];
            var message = String.Format( methodName, controllerName, actionName);
            Debug.WriteLine(message, "Action Filter Log");
            output.WriteLine(message);
        }
    }
}