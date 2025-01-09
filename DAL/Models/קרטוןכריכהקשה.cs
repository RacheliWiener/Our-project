using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class קרטוןכריכהקשה
{
    public int מזהה { get; set; }

    public int הצמהזמנה { get; set; }

    public int ספק { get; set; }

    public string? פקע { get; set; }

    public string? יישום { get; set; }

    public string? פריט { get; set; }

    public string? גודל { get; set; }

    public decimal? מחיר { get; set; }

    public int? עותקים { get; set; }

    public string? הערהלפקע { get; set; }

    public string? הערה { get; set; }

    public DateTime? תאריךיצירתרשומה { get; set; }

    public virtual הצעת_מחיר_הזמנה הצמהזמנהNavigation { get; set; } = null!;

    public virtual ספקים ספקNavigation { get; set; } = null!;
}
