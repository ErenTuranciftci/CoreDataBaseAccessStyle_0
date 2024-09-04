using System;
using System.Collections.Generic;

namespace CoreDataBaseAccessStyle_0.Models.Entities;

public partial class EmployeeSaleReport
{
    public string PersonelBilgisi { get; set; } = null!;

    public string Urunİsmi { get; set; } = null!;

    public double? Satis { get; set; }
}
