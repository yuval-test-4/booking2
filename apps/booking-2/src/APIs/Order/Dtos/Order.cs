namespace Booking2.APIs.Dtos;

public class Order
{
    public string? Amount { get; set; }

    public DateTime CreatedAt { get; set; }

    public string? Customer { get; set; }

    public string Id { get; set; }

    public DateTime UpdatedAt { get; set; }
}
