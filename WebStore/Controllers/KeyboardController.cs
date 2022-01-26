using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebStore.Models;
using WebStore.ViewModels;

namespace WebStore.Controllers
{
    public class KeyboardController : Controller
    {
        private readonly IKeyboardRepository _keyboardRepository;
        private readonly ICategoryRepository _categoryRepository;

        public KeyboardController(IKeyboardRepository keyboardRepository, ICategoryRepository categoryRepository)
        {
            _keyboardRepository = keyboardRepository;
            _categoryRepository = categoryRepository;
        }

        public IActionResult List()
        {
            //ViewBag.CurrentCategory = "Bestsellers";
            //return View(_keyboardRepository.GetAllKeyboard);

            var keyboardListViewModel = new KeyboardListViewModel();
            keyboardListViewModel.Keyboards = _keyboardRepository.GetAllKeyboard;
            keyboardListViewModel.CurrentCategory = "Bestsellers";
            return View(keyboardListViewModel);
        }
    }
}
