using System;
using System.Collections.Generic;

namespace Project3.Models;

public partial class Discount
{
    public int DiscountId { get; set; }

    public decimal Amount { get; set; }

    public DateOnly? Expires { get; set; }

    public int? Quantity { get; set; }

    public string? Description { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public DateTime? DeletedAt { get; set; }

    public virtual ICollection<OrderDetail> OrderDetails { get; set; } = new List<OrderDetail>();
}
