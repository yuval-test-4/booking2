namespace Booking2.APIs.Dtos;

public class CustomerCreateInput
{
    public DateTime CreatedAt { get; set; }

    public string? Id { get; set; }

    public List<Order>? Orders { get; set; }

    public DateTime UpdatedAt { get; set; }
}
