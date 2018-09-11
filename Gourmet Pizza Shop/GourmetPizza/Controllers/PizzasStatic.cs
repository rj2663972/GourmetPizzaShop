using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace GourmetPizza.Controllers
{
    public class PizzasStatic : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Purchase(int PizzaType,int PizzaCount)
        {
            double price = 0;
            switch (PizzaType)
            {
                case 1:
                    ViewData["Pizza Type"] = "BBQ Beef";
                    price = PizzaCount * 10.50;
                    ViewData["Price"] = "$"+price;
                    ViewData["url"] = "bbq_beef_pizza.jpeg";
                    break;
                case 2:
                    ViewData["Pizza Type"] = "Chicken and Pineapple";
                    price = PizzaCount * 8.50;
                    ViewData["Price"] = "$" + price;
                    ViewData["url"] = "bbq_chicken_and_pineapple_pizza.jpg";
                    break;
                case 3:
                    ViewData["Pizza Type"] = "Pepperoni Feast";
                     price = PizzaCount * 9.00;
                    ViewData["Price"] = "$" + price;
                    ViewData["url"] = "bbq_pepperoni_pizza.jpg";
                    break;
                case 4:
                    ViewData["Pizza Type"] = "Vegetarian";
                    price = PizzaCount * 7.00;
                    ViewData["Price"] = "$" + price;
                    ViewData["url"] = "bbq_veggie_pizza.jpg";
                    break;
            }
            return View();
        }
    }
}
