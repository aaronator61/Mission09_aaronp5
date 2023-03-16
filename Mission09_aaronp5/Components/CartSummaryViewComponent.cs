using Microsoft.AspNetCore.Mvc;
using Mission09_aaronp5.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// This is for the shopping cart icon and how to allow it to show the items
namespace Mission09_aaronp5.Components
{
    public class CartSummaryViewComponent : ViewComponent
    {
        private Basket basket;
        public CartSummaryViewComponent(Basket cartService)
        {
            basket = cartService;
        }
        public IViewComponentResult Invoke()
        {
            return View(basket);
        }
    }
    
}
