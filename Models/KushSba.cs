using System;
using System.Collections.Generic;

namespace bank.Models;

public partial class KushSba
{
    public int AccNo { get; set; }

    public string? CustName { get; set; }

    public string? CustAddress { get; set; }

    public int? CurrBal { get; set; }
}
