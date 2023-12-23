using Microsoft.AspNetCore.Mvc;

namespace CompanyWeb.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class LoginController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}
