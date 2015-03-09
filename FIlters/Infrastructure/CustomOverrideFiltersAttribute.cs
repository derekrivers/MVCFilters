using System;
using System.Web.Mvc;
using System.Web.Mvc.Filters;

namespace FIlters.Infrastructure
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, Inherited = true, AllowMultiple = false)]
    public class CustomOverrideFiltersAttribute : FilterAttribute , IOverrideFilter
    {
        public Type FiltersToOverride
        {
            get { return typeof (IActionFilter); }
        }
    }
}