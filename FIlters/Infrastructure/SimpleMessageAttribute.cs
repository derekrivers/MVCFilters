﻿using System;
using System.Web.Mvc;

namespace FIlters.Infrastructure
{

    [AttributeUsage(AttributeTargets.Method | AttributeTargets.Class, AllowMultiple = true)]
    public class SimpleMessageAttribute : FilterAttribute, IActionFilter
    {
        public string Message { get; set; }

        public void OnActionExecuting(ActionExecutingContext filterContext)
        {
            filterContext.HttpContext.Response.Write(string.Format("<div>[Before Action: {0}]</div>", Message));
        }

        public void OnActionExecuted(ActionExecutedContext filterContext)
        {
             filterContext.HttpContext.Response.Write(string.Format("<div>[After Action: {0}]</div>", Message));
        }
        
    }
}