using Microsoft.AspNetCore.Mvc;

namespace TempData.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            TempData["myKey"] = "Data form Index";
            return View();
        }
        public IActionResult Index2()
        {
            ViewBag.mykey = TempData["myKey"];
            return View();
        }
        public IActionResult Index3()
        {
            ViewBag.mykey = TempData["myKey"]; // we can access data for one request
            return View();
        }
    }
}
