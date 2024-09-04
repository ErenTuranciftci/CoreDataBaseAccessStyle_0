using System;
using System.Collections.Generic;

namespace CoreDataBaseAccessStyle_0.Models.Entities;

public partial class UrunleriGetir
{
    public string UrunIsmi { get; set; } = null!;

    public decimal? Fiyat { get; set; }
}
