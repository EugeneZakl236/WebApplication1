using System;
using System.Collections.Generic;

namespace WebApplication1;

public partial class SupplyOrder
{
    public string SupplyOrderId { get; set; } = null!;

    public int OrderFillingId { get; set; }

    public string RestorauntId { get; set; } = null!;

    public string? OrderName { get; set; }

    public string? DeliveryAddress { get; set; }

    public string? Bill { get; set; }
}
