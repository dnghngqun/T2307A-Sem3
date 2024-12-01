using System;
using System.Collections.Generic;

namespace Project3.Models;

public partial class CourseInformation
{
    public int CourseInformationId { get; set; }

    public int CourseId { get; set; }

    public DateOnly StartDate { get; set; }

    public string Duration { get; set; } = null!;

    public string? StudyLevel { get; set; }

    public string? TopicsIncluded { get; set; }

    public string? Description { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual Course Course { get; set; } = null!;
}
