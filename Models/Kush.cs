﻿using System;
using System.Collections.Generic;

namespace bank.Models;

public partial class Kush
{
    public int Sid { get; set; }

    public string? Sname { get; set; }

    public double? Marks { get; set; }

    public DateOnly? Dob { get; set; }
}
