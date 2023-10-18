using Microsoft.AspNetCore.Mvc;

namespace CompanyWeb.Controllers
{
    public class AboutController : Controller
    {
        public ActionResult Index(int id = 0)
        {
            ViewBag.AbountId = id;
            return View();
        }
    }
}
