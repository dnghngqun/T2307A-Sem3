using System;
using System.Collections.Generic;

namespace Project3.Models;

public partial class CustomerInformation
{
    public string CustomerInformationId { get; set; } = null!;

    public string FullName { get; set; } = null!;

    public string Email { get; set; } = null!;

    public decimal? Mark { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public DateTime? DeletedAt { get; set; }

    public virtual ICollection<Enrollment> Enrollments { get; set; } = new List<Enrollment>();

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
}
