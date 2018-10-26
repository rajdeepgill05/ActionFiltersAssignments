using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ActionFiltersAssignment.Models.ActionFilters
{
    public class DummyActionFilter : ActionFilterAttribute
    {
        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
           
        }

        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            bool checkReq = filterContext.HttpContext.Request.Browser.Crawler;
            if (checkReq)
            {
                filterContext.Controller.TempData["FlashMessage"] = "Request Denied.";
            }
        }

    }
}