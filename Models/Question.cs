using System;
using System.Collections.Generic;

namespace Project3.Models;

public partial class Question
{
    public int QuestionId { get; set; }

    public string Question1 { get; set; } = null!;

    public string? Answer { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }
}
