using IntroductionToAspMVC.Services;
using IntroductionToAspMVC.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace IntroductionToAspMVC.Controllers
{
    public class AuthorController : Controller
    {
        private readonly IUserService _service;

        public AuthorController(IUserService service)
        {
            _service = service;
        }

        public IActionResult About()
        {
            // One page == One viewmodel.
            // This contains ALL the data that the page needs
            // VM fetches all data, preferably through an injected service
            var model = new UserViewModel
            {
                Users = _service.GetUsers()
            };

            // ViewBag / Viewdata are outdated processes and bad practices.
            // Prefer (View)Model whenever possible
            //ViewBag.Name = "Michiel in the bag";
            //ViewBag.Skills = skills;

            // VM then passes ViewModel into View
            return View(model);
        }
    }
}