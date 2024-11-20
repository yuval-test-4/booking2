using Booking2.APIs.Common;
using Booking2.Infrastructure.Models;
using Microsoft.AspNetCore.Mvc;

namespace Booking2.APIs.Dtos;

[BindProperties(SupportsGet = true)]
public class CustomerFindManyArgs : FindManyInput<Customer, CustomerWhereInput> { }
