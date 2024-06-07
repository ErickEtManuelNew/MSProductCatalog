using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]
public class OrdersController : ControllerBase
{
    private static readonly List<Order> Orders = new List<Order>
    {
        new Order { Id = 1, ProductName = "Product1", Quantity = 2 },
        new Order { Id = 2, ProductName = "Product2", Quantity = 1 }
    };

    [HttpGet]
    public IEnumerable<Order> Get()
    {
        return Orders;
    }
}

public class Order
{
    public int Id { get; set; }
    public string ProductName { get; set; }
    public int Quantity { get; set; }
}
