using Microsoft.AspNetCore.Mvc;
using System.Linq;
using WebStore.Models;
using WebStore.ViewModels;

namespace WebStore.Controllers
{
    public class ShoppingCartController : Controller
    {
        private readonly IKeyboardRepository _keyboardRepository;
        private readonly ShoppingCart _shoppingCart;

        public ShoppingCartController(IKeyboardRepository keyboardRepository, ShoppingCart shoppingCart)
        {
            _keyboardRepository = keyboardRepository;
            _shoppingCart = shoppingCart;
        }

        public ViewResult Index()
        {
            _shoppingCart.ShoppingCartItems = _shoppingCart.GetShoppingCartItems();
            var shoppingCartViewModel = new ShoppingCartViewModel
            {
                ShoppingCart = _shoppingCart,
                ShoppingCartTotal = _shoppingCart.GetShoppingCartTotal()
            };
            return View(shoppingCartViewModel); 
        }
        public RedirectToActionResult AddToShoppingCart(int keyboardId)
        {
            var selectedKeyboard = _keyboardRepository.GetAllKeyboard.FirstOrDefault(c => c.KeyboardId == keyboardId);
            if(selectedKeyboard != null)
            {
                _shoppingCart.AddToCart(selectedKeyboard, 1);
            }
            return RedirectToAction("Index");
        }

        public RedirectToActionResult RemoveFromShoppingCart(int keyboardId)
        {
            var selectedKeyboard = _keyboardRepository.GetAllKeyboard.FirstOrDefault(c => c.KeyboardId == keyboardId);
            if (selectedKeyboard != null)
            {
                _shoppingCart.RemoveFromCart(selectedKeyboard);
            }
            return RedirectToAction("Index");
        }

    }
}
