namespace ShoppingSampleMvcApp_Layered.Data;

using ShoppingSampleMvcApp_Layered.Models;

public class ProductRepository
{
    private readonly List<Product> _products = new()
    {
        new Product { Id = 1, Name = "Wireless Mouse", Description = "Ergonomic wireless mouse", Price = 799.00m, Category = "Accessories" },
        new Product { Id = 2, Name = "Mechanical Keyboard", Description = "RGB mechanical keyboard", Price = 2499.00m, Category = "Accessories" },
        new Product { Id = 3, Name = "27\" Monitor", Description = "27 inch 4K monitor", Price = 21999.00m, Category = "Displays" },
        new Product { Id = 4, Name = "USB-C Hub", Description = "5-in-1 USB-C hub", Price = 1299.00m, Category = "Accessories" }
    };

    public IEnumerable<Product> GetAll() => _products;

    public Product? GetById(int id) => _products.FirstOrDefault(p => p.Id == id);
}
