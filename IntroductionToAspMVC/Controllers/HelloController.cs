using Microsoft.AspNetCore.Mvc;

namespace IntroductionToAspMVC.Controllers
{
    public class HelloController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}