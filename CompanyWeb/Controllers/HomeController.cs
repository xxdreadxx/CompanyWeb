using CompanyWeb.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;

namespace CompanyWeb.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public ActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public JsonResult SendEmail(string str)
        {
            //Email.Address = "mailnhcsatech@gmail.com";
            Email.Address = "cskh.huongvietlib@gmail.com";
            //Email.Password = "satech@123";
            Email.Password = "vjdhzxvwtsrqdccx";

            Email email = new Email();
            string noidung = str;
            email.Send("NHC.SATech@gmail.com", "Thông tin khách hàng yêu cầu tư vấn", noidung);

            var data = new { status = true, mess = "" };
            var result = new JsonResult(data);
            result.StatusCode = 200;
            result.ContentType = "application/json";
            return result;
        }
    }
}