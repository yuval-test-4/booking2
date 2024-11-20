using Microsoft.AspNetCore.Mvc;

namespace Booking2.APIs;

[ApiController()]
public class CustomersController : CustomersControllerBase
{
    public CustomersController(ICustomersService service)
        : base(service) { }
}
