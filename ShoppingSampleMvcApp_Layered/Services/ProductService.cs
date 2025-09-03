namespace ShoppingSampleMvcApp_Layered.Services;

using ShoppingSampleMvcApp_Layered.Data;
using ShoppingSampleMvcApp_Layered.Models;

public class ProductService
{
    private readonly ProductRepository _repository;

    public ProductService(ProductRepository repository)
    {
        _repository = repository;
    }

    public IEnumerable<Product> GetProducts() => _repository.GetAll();
    public Product? GetProductById(int id) => _repository.GetById(id);

    public string AddToCart(int id)
    {
        var product = _repository.GetById(id);
        return product == null ? "Product not found" : $"Added {product.Name} to cart (demo only).";
    }
}
