using System;
using System.Collections.Generic;

namespace WebApplication1;

public partial class CustomerOrder
{
    public int CustomerOrderId { get; set; }

    public int CustomerId { get; set; }

    public int DishId { get; set; }

    public string? CustomersCout { get; set; }

    public string? Tips { get; set; }

    public string? Bill { get; set; }
}
