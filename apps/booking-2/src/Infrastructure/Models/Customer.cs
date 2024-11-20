using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Booking2.Infrastructure.Models;

[Table("Customers")]
public class CustomerDbModel
{
    [Required()]
    public DateTime CreatedAt { get; set; }

    [Key()]
    [Required()]
    public string Id { get; set; }

    public List<OrderDbModel>? Orders { get; set; } = new List<OrderDbModel>();

    [Required()]
    public DateTime UpdatedAt { get; set; }
}
