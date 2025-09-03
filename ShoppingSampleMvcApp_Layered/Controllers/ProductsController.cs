using Microsoft.AspNetCore.Mvc;
using ShoppingSampleMvcApp_Layered.Services;

namespace ShoppingSampleMvcApp_Layered.Controllers
{
    public class ProductsController : Controller
    {
        private readonly ProductService _service;

        public ProductsController(ProductService service)
        {
            _service = service;
        }

        public IActionResult Index()
        {
            var products = _service.GetProducts();
            return View(products);
        }

        public IActionResult Details(int id)
        {
            var product = _service.GetProductById(id);
            if (product == null) return NotFound();

            return View(product);
        }
    }
}
