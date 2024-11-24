using System;
using System.Collections.Generic;

namespace minibidlo.Models;

public partial class ProductSupply
{
    public int SupplyId { get; set; }

    public int? SupplierId { get; set; }

    public int? ProductId { get; set; }

    public DateOnly? SupplyDate { get; set; }

    public int? Quantity { get; set; }

    public virtual Catalog? Product { get; set; }

    public virtual Supplier? Supplier { get; set; }
}
