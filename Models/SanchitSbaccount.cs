using System;
using System.Collections.Generic;

namespace bank.Models;

public partial class SanchitSbaccount
{
    public int AccountNumber { get; set; }

    public string? CustomerName { get; set; }

    public string? CustomerAddress { get; set; }

    public int? CurrentBalance { get; set; }
}
