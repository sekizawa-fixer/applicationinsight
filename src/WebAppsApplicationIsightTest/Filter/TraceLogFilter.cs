using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebAppsApplicationIsightTest.Filter
{
    public class TraceLogFilter : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            Trace.TraceInformation($"{filterContext.HttpContext.Request.Url.AbsoluteUri}にアクセスするよ。");
        }

        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            Trace.TraceInformation($"{filterContext.HttpContext.Request.Url.AbsoluteUri}にアクセスしたよ。");
        }
    }
}