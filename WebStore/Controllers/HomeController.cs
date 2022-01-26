using Microsoft.AspNetCore.Mvc;
using WebStore.Models;
using WebStore.ViewModels;

namespace WebStore.Controllers
{
    public class HomeController : Controller
    {
        private readonly IKeyboardRepository _keyboardRepository;

        public HomeController(IKeyboardRepository keyboardRepository)
        {
            _keyboardRepository = keyboardRepository;
        }
        public IActionResult Index()
        {
            var homeViewModel = new HomeViewModel
            {
                KeyboardOnSale = _keyboardRepository.GetKeyboardsOnSale
            };
            return View(homeViewModel);
        }
    }
}
