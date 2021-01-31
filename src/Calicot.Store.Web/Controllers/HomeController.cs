using Microsoft.AspNetCore.Mvc;

namespace Calicot.Store.Web.Controllers
{
    public class HomeController : StoreControllerBase
    {
        public ActionResult Index()
        {
            return RedirectToAction("Index", "Products");
        }
    }
}