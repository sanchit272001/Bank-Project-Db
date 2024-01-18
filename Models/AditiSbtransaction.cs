using System;
using System.Collections.Generic;

namespace bank.Models;

public partial class AditiSbtransaction
{
    public int? AccountNumber { get; set; }

    public int? Amount { get; set; }

    public int? TransactionId { get; set; }

    public string? TransactionType { get; set; }

    public DateTime? TrasactionDate { get; set; }
}
