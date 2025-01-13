using System;
using System.Collections.Generic;

namespace BLL.Models;

public partial class מחירון_הטבעהDto
{
    public int מזהה { get; set; }

    public string? צבע { get; set; }

    public string? פורמט { get; set; }

    public decimal? מחירמחירון { get; set; }
}
