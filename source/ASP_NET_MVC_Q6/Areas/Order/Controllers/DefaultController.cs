using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASP_NET_MVC_Q6.Areas.Order.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Order/Main
        public ActionResult List(int page=1)
        {
      
            return View(page);
        }
        public ActionResult Detail(int id = 8)
        {

            return View(id);
        }
    }
}