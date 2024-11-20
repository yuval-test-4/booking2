using Booking2.APIs.Common;
using Booking2.APIs.Dtos;

namespace Booking2.APIs;

public interface ICustomersService
{
    /// <summary>
    /// Create one customer
    /// </summary>
    public Task<Customer> CreateCustomer(CustomerCreateInput customer);

    /// <summary>
    /// Delete one customer
    /// </summary>
    public Task DeleteCustomer(CustomerWhereUniqueInput uniqueId);

    /// <summary>
    /// Find many customers
    /// </summary>
    public Task<List<Customer>> Customers(CustomerFindManyArgs findManyArgs);

    /// <summary>
    /// Meta data about customer records
    /// </summary>
    public Task<MetadataDto> CustomersMeta(CustomerFindManyArgs findManyArgs);

    /// <summary>
    /// Get one customer
    /// </summary>
    public Task<Customer> Customer(CustomerWhereUniqueInput uniqueId);

    /// <summary>
    /// Update one customer
    /// </summary>
    public Task UpdateCustomer(CustomerWhereUniqueInput uniqueId, CustomerUpdateInput updateDto);

    /// <summary>
    /// Connect multiple orders records to customer
    /// </summary>
    public Task ConnectOrders(CustomerWhereUniqueInput uniqueId, OrderWhereUniqueInput[] ordersId);

    /// <summary>
    /// Disconnect multiple orders records from customer
    /// </summary>
    public Task DisconnectOrders(
        CustomerWhereUniqueInput uniqueId,
        OrderWhereUniqueInput[] ordersId
    );

    /// <summary>
    /// Find multiple orders records for customer
    /// </summary>
    public Task<List<Order>> FindOrders(
        CustomerWhereUniqueInput uniqueId,
        OrderFindManyArgs OrderFindManyArgs
    );

    /// <summary>
    /// Update multiple orders records for customer
    /// </summary>
    public Task UpdateOrders(CustomerWhereUniqueInput uniqueId, OrderWhereUniqueInput[] ordersId);
}
