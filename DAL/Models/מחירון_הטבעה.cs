using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class מחירון_הטבעה
{
    public int מזהה { get; set; }

    public string? צבע { get; set; }

    public string? פורמט { get; set; }

    public decimal? מחירמחירון { get; set; }
}
