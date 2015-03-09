

using System.Diagnostics;
using System.Web.Mvc;

namespace FIlters.Infrastructure
{
    public class ProfileAllAttribute : ActionFilterAttribute
    {
        private Stopwatch timer;

        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            timer = Stopwatch.StartNew();
        }

        public override void OnResultExecuted(ResultExecutedContext filterContext)
        {
            timer.Stop();

            filterContext.HttpContext.Response.Write(string.Format("<div>Total elapsed time: {0:F6}</div>", timer.Elapsed.TotalSeconds));
        }
    }
}