using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BethanysPieShop.Models;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace BethanysPieShop.Controllers
{
    public class OrderController : Controller
    {
        private  readonly IOrderRepository _orderRepository;
        private  readonly ShoppingCart _shoppingCart;

        public OrderController(IOrderRepository orderRepository, ShoppingCart shoppingCart)
        {
            _shoppingCart = shoppingCart;
            _orderRepository = orderRepository;
        }


        public IActionResult CheckOut()
        {
            return View();
        }
    }
}
