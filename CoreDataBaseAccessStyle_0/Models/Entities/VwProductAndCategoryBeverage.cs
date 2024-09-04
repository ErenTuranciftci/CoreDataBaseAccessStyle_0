using System;
using System.Collections.Generic;

namespace CoreDataBaseAccessStyle_0.Models.Entities;

public partial class VwProductAndCategoryBeverage
{
    public string ProductName { get; set; } = null!;

    public string CategoryName { get; set; } = null!;

    public decimal? UnitPrice { get; set; }
}
