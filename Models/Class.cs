using System;
using System.Collections.Generic;

namespace Project3.Models;

public partial class Class
{
    public int ClassesId { get; set; }

    public int CourseId { get; set; }

    public int InstructorId { get; set; }

    public string? Description { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public DateTime? DeletedAt { get; set; }

    public virtual Course Course { get; set; } = null!;

    public virtual ICollection<Enrollment> Enrollments { get; set; } = new List<Enrollment>();

    public virtual Instructor Instructor { get; set; } = null!;
}
