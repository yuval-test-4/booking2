namespace Booking2.APIs.Dtos;

public class OrderCreateInput
{
    public string? Amount { get; set; }

    public DateTime CreatedAt { get; set; }

    public Customer? Customer { get; set; }

    public string? Id { get; set; }

    public DateTime UpdatedAt { get; set; }
}
