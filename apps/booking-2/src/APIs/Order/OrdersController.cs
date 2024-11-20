using Microsoft.AspNetCore.Mvc;

namespace Booking2.APIs;

[ApiController()]
public class OrdersController : OrdersControllerBase
{
    public OrdersController(IOrdersService service)
        : base(service) { }
}
