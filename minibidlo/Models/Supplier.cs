using System;
using System.Collections.Generic;

namespace minibidlo.Models;

public partial class Supplier
{
    public int SupplierId { get; set; }

    public string? Name { get; set; }

    public string? ContactPerson { get; set; }

    public string? PhoneNumber { get; set; }

    public string? Address { get; set; }

    public virtual ICollection<ProductSupply> ProductSupplies { get; set; } = new List<ProductSupply>();
}
