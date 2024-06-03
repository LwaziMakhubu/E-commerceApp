using ECommerceApp.Services;
using Microsoft.AspNetCore.Mvc;

namespace ECommerceApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ProductService _productService;

        public HomeController()
        {
            _productService = new ProductService();
        }

        public IActionResult Index(string category)
        {
            var products = _productService.GetProducts(category);
            return View(products);
        }
    }
}
