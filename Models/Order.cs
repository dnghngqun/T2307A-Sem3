using System;
using System.Collections.Generic;

namespace Project3.Models;

public partial class Order
{
    public int OrderId { get; set; }

    public string CustomerInformationId { get; set; } = null!;

    public decimal TotalPrice { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public DateTime? DeletedAt { get; set; }

    public virtual CustomerInformation CustomerInformation { get; set; } = null!;

    public virtual ICollection<OrderDetail> OrderDetails { get; set; } = new List<OrderDetail>();
}
