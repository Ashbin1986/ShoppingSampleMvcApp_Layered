using Microsoft.AspNetCore.Mvc;
using ShoppingSampleMvcApp_Layered.Services;
using ShoppingSampleMvcApp_Layered.Models;

namespace ShoppingSampleMvcApp_Layered.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ProductsApiController : ControllerBase
{
    private readonly ProductService _service;

    public ProductsApiController(ProductService service)
    {
        _service = service;
    }

    // GET: api/products
    [HttpGet]
    public ActionResult<IEnumerable<Product>> GetProducts()
    {
        return Ok(_service.GetProducts());
    }

    // GET: api/products/2
    [HttpGet("{id}")]
    public ActionResult<Product> GetProduct(int id)
    {
        var product = _service.GetProductById(id);
        if (product == null) return NotFound();
        return Ok(product);
    }
}
