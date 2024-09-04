using System;
using System.Collections.Generic;

namespace CoreDataBaseAccessStyle_0.Models.Entities;

public partial class KategorilerineGoreUrunSayilari
{
    public string CategoryName { get; set; } = null!;

    public int? UrunSayısı { get; set; }
}
