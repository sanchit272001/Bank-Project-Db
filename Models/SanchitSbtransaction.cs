using System;
using System.Collections.Generic;

namespace bank.Models;

public partial class SanchitSbtransaction
{
    public int TransactionId { get; set; }

    public DateTime TransactionDate { get; set; }

    public int? AccountNumber { get; set; }

    public int? Amount { get; set; }

    public string? TransactionType { get; set; }
}
