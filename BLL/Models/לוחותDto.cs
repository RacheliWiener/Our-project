using System;
using System.Collections.Generic;

namespace BLL.Models;

public partial class לוחותDto
{
    public int מזהה { get; set; }

    public int הצמהזמנה { get; set; }

    public int ספק { get; set; }

    public string? פקע { get; set; }

    public string? יישום { get; set; }

    public int? פורמטנייר { get; set; }

    public string? גודלעמודנטו { get; set; }

    public bool? חצאים { get; set; }

    public int? עמודים { get; set; }

    public int? עמודיםבצד { get; set; }

    public bool? פרפקטור { get; set; }

    public string? צבע { get; set; }

    public decimal? מחיר { get; set; }

    public string? הערהלפקע { get; set; }

    public string? הערה { get; set; }

    public DateTime? תאריךיצירתרשומה { get; set; }

    public virtual הצעת_מחיר_הזמנה הצמהזמנהNavigation { get; set; } = null!;

    public virtual ספקים ספקNavigation { get; set; } = null!;
}
