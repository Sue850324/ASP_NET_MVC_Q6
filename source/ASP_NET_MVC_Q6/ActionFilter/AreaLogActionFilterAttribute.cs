using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace ASP_NET_MVC_Q6.ActionFilter
{
    public class AreaLogActionFilterAttribute : ActionFilterAttribute, IActionFilter
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            WriteLog("OnActionExecuting", filterContext.RouteData);
        }

        private void WriteLog(string methodName, RouteData routeData)
        {
            var Area= routeData.Values["Area"];
            var controllerName = routeData.Values["controller"];
            var actionName = routeData.Values["action"];
            var message = String.Format("{0} area :{1} controller : {2} action:{3}", methodName, Area, controllerName, actionName);
            Debug.WriteLine(message, "Action Filter Log");
        }
    }
}