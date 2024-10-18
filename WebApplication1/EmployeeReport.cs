using System;
using System.Collections.Generic;

namespace WebApplication1;

public partial class EmployeeReport
{
    public int EmployeeReportId { get; set; }

    public int? EmployeeId { get; set; }

    public string? HoursWorked { get; set; }

    public string? OrdersHandled { get; set; }
}
