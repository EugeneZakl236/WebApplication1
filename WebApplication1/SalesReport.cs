using System;
using System.Collections.Generic;

namespace WebApplication1;

public partial class SalesReport
{
    public string? SalesReportId { get; set; }

    public DateTime? ReportDate { get; set; }

    public string? TotalRevenue { get; set; }

    public string? TotalOrders { get; set; }
}
