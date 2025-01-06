using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class צבע
{
    public int מזהה { get; set; }

    public int הצמהזמנה { get; set; }

    public string? פקע { get; set; }

    public int ספק { get; set; }

    public string? יישום { get; set; }

    public string? צבע1 { get; set; }

    public int? מחיר { get; set; }

    public string? פריט { get; set; }

    public int? עותקים { get; set; }

    public string? הערהלפקע { get; set; }

    public string? הערה { get; set; }

    public DateTime? תאריךיצירתרשומה { get; set; }

    public virtual הצעתמחירהזמנה הצמהזמנהNavigation { get; set; } = null!;

    public virtual ספקים ספקNavigation { get; set; } = null!;
}
