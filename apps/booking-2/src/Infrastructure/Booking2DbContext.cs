using Booking2.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;

namespace Booking2.Infrastructure;

public class Booking2DbContext : DbContext
{
    public Booking2DbContext(DbContextOptions<Booking2DbContext> options)
        : base(options) { }

    public DbSet<CustomerDbModel> Customers { get; set; }

    public DbSet<OrderDbModel> Orders { get; set; }
}
