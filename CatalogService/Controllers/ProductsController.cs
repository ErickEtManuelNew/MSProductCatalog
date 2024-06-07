using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]
public class ProductsController : ControllerBase
{
    private static readonly List<Product> Products = new List<Product>
    {
        new Product { Id = 1, Name = "Product1", Price = 10 },
        new Product { Id = 2, Name = "Product2", Price = 20 }
    };

    [HttpGet]
    public IEnumerable<Product> Get()
    {
        return Products;
    }
}

public class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    public decimal Price { get; set; }
}
