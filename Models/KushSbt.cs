using System;
using System.Collections.Generic;

namespace bank.Models;

public partial class KushSbt
{
    public int TransId { get; set; }

    public DateOnly? TransDate { get; set; }

    public int? Accno { get; set; }

    public int? Amount { get; set; }

    public string? TransType { get; set; }
}
