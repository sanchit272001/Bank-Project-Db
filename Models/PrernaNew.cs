using System;
using System.Collections.Generic;

namespace bank.Models;

public partial class PrernaNew
{
    public int Studentid { get; set; }

    public string StudentName { get; set; } = null!;

    public string Subject { get; set; } = null!;

    public int Salary { get; set; }

    public DateTime Dob { get; set; }
}
