using System;
using System.Collections.Generic;

namespace Project3.Models;

public partial class Token
{
    public int TokenId { get; set; }

    public int UserId { get; set; }

    public string Token1 { get; set; } = null!;

    public string TokenType { get; set; } = null!;

    public DateTime? CreatedAt { get; set; }

    public DateTime? ExpiresAt { get; set; }

    public bool? IsRevoked { get; set; }

    public virtual Account User { get; set; } = null!;
}
