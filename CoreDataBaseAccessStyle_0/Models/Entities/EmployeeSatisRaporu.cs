using System;
using System.Collections.Generic;

namespace CoreDataBaseAccessStyle_0.Models.Entities;

public partial class EmployeeSatisRaporu
{
    public string IsimSoyIsim { get; set; } = null!;

    public string UrunIsmi { get; set; } = null!;

    public double? ToplamSatıs { get; set; }
}
