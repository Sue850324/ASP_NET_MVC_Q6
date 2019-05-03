using ASP_NET_MVC_Q6.ActionFilter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASP_NET_MVC_Q6.Areas.Ticket.Controllers
{
    [AreaLogActionFilter]
    public class MainController : Controller
    {
        // GET: Ticket/Main
        public ActionResult List()
        {
            return View();
        }
        public ActionResult Detail(int id=9)
        {
            return View(id);
        }
    }
}