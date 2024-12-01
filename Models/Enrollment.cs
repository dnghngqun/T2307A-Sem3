using System;
using System.Collections.Generic;

namespace Project3.Models;

public partial class Enrollment
{
    public int EnrollmentId { get; set; }

    public int ClassesId { get; set; }

    public string CustomerInformationId { get; set; } = null!;

    public DateOnly EnrollmentDate { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual Class Classes { get; set; } = null!;

    public virtual CustomerInformation CustomerInformation { get; set; } = null!;
}
