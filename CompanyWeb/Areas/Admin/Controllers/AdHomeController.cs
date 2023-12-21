using Microsoft.AspNetCore.Mvc;

namespace CompanyWeb.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AdHomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}
