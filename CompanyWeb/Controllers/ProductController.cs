using Microsoft.AspNetCore.Mvc;

namespace CompanyWeb.Controllers
{
    public class ProductController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Details(int id)
        {
            return View();
        }
    }
}
