using System;
using System.Collections.Generic;

namespace CoreDataBaseAccessStyle_0.Models.Entities;

public partial class EmployeeSpecificSale
{
    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string ProductName { get; set; } = null!;

    public double? ToplamSatis { get; set; }
}
