using System.Web;
using System.Web.Mvc;

namespace FIlters.Infrastructure
{
    public class CustomAuthAttribute : AuthorizeAttribute
    {
        private bool LocalAllowed;

        public CustomAuthAttribute(bool localAllowed)
        {
            LocalAllowed = localAllowed;
        }

        protected override bool AuthorizeCore(HttpContextBase httpContext)
        {
            if (httpContext.Request.IsLocal)
            {
                return LocalAllowed;
            }

            return true;

        }
    }
}