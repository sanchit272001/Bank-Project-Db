﻿using System;
using System.Collections.Generic;

namespace bank.Models;

public partial class HetalSbtransaction
{
    public int TransactionId { get; set; }

    public DateTime TransactionDate { get; set; }

    public int AccountNo { get; set; }

    public double Amount { get; set; }

    public string TransactionType { get; set; } = null!;
}
