using ASP_NET_MVC_Q6.ActionFilter;
using System.Web;
using System.Web.Mvc;

namespace ASP_NET_MVC_Q6
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
            filters.Add(new LogActionFilterAttribute());
            filters.Add(new AreaLogActionFilterAttribute());
        }
    }
}
