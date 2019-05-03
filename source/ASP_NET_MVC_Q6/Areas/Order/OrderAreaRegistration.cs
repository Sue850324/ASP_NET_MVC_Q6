﻿using System.Web.Mvc;

namespace ASP_NET_MVC_Q6.Areas.Order
{
    public class OrderAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "Order";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "Order_default",
                "{Area}/{action}/{id}",
                new {Area="Order", controller="Default",action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}