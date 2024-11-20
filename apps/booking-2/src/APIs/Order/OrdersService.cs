using Booking2.Infrastructure;

namespace Booking2.APIs;

public class OrdersService : OrdersServiceBase
{
    public OrdersService(Booking2DbContext context)
        : base(context) { }
}
