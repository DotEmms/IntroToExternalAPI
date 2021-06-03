using AutoMapper;
using IntroductionToAspMVC.Models;
using IntroductionToAspMVC.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace IntroductionToAspMVC.Controllers
{
    public class CursistController : Controller
    {
        private IMapper _mapper;

        public CursistController(IMapper mapper)
        {
            _mapper = mapper;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(CursistViewModel vm)
        {
            // Verify if all data annotations check in ViewModel are valid
            bool isValid = TryValidateModel(vm);

            if (isValid)
            {
                Cursist cursist = _mapper.Map<Cursist>(vm);

                // TODO: Data to be sent to service

                return RedirectToAction(nameof(Index));
            }

            // Show view again with errors if model is not valid
            return View(vm);
        }
    }
}