using System;
using System.Collections.Generic;

namespace minibidlo.Models;

public partial class Catalog
{
    public int ProductId { get; set; }

    public string Name { get; set; } = null!;

    public string? Description { get; set; }

    public decimal Price { get; set; }

    public string? Size { get; set; }

    public string? Material { get; set; }

    public int? Stock { get; set; }

    public virtual ICollection<PosOrder> PosOrders { get; set; } = new List<PosOrder>();

    public virtual ICollection<ProductSupply> ProductSupplies { get; set; } = new List<ProductSupply>();

    public virtual ICollection<Review> Reviews { get; set; } = new List<Review>();
}
