using System;
using System.Collections.Generic;

namespace Project3.Models;

public partial class Instructor
{
    public int InstructorId { get; set; }

    public string Name { get; set; } = null!;

    public string? Gender { get; set; }

    public string? Bio { get; set; }

    public string? ImageLink { get; set; }

    public string? PhoneNumber { get; set; }

    public string Email { get; set; } = null!;

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual ICollection<Class> Classes { get; set; } = new List<Class>();
}
