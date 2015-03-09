using System.Web.Mvc;
using FIlters.Infrastructure;

namespace FIlters.Controllers
{
    [SimpleMessage(Message = "A")]
    public class CustomerController : Controller
    {
        [SimpleMessage(Message = "A", Order = 2)]
        [SimpleMessage(Message = "B", Order = 1)]
        public string Index()
        {
            return "This is the customer controller";
        }

        [CustomOverrideFilters]
        [SimpleMessage(Message = "B")]
        public string OtherAction()
        {
            return "This is the other action in the customer controller";
        }
    }
}