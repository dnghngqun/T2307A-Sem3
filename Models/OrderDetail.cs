using System;
using System.Collections.Generic;

namespace Project3.Models;

public partial class OrderDetail
{
    public int OrderDetailId { get; set; }

    public int OrderId { get; set; }

    public int CourseId { get; set; }

    public decimal Price { get; set; }

    public int? DiscountId { get; set; }

    public string? Status { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public DateTime? DeletedAt { get; set; }

    public virtual Course Course { get; set; } = null!;

    public virtual Discount? Discount { get; set; }

    public virtual Order Order { get; set; } = null!;
}
