using System;
using System.Collections.Generic;

namespace WebApplication1;

public partial class Supplier
{
    public int SupplierId { get; set; }

    public int SupplyOrderId { get; set; }

    public string? CompanyName { get; set; }

    public string? ContactPerson { get; set; }

    public string? Phone { get; set; }

    public string? Email { get; set; }

    public string? ProductSpecification { get; set; }
}
