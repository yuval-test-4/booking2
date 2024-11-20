using Booking2.Infrastructure;

namespace Booking2.APIs;

public class CustomersService : CustomersServiceBase
{
    public CustomersService(Booking2DbContext context)
        : base(context) { }
}
