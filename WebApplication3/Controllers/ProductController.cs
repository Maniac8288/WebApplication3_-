using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Index()
        {
            List<Product> products = new List<Product>();
            products.Add(new Product()
            { ProductId = 1, Name="Ручка",Price=25,Category="Канцтовары" 

            });
            products.Add(new Product()
            { ProductId = 2,
                Category = "Алкоголь",
                Name = "Вино",
                Price = 149.99
            });
            return View(products);
        }
    }
}