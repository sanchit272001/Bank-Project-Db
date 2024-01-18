using System;
using System.Collections.Generic;

namespace bank.Models;

public partial class AditiSbAccount
{
    public int AccNo { get; set; }

    public string? CustomerName { get; set; }

    public int? CurrentBalance { get; set; }

    public string? CustomerAdd { get; set; }
}
