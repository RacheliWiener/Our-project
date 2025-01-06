using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class פרויקטים
{
    public int מזהה { get; set; }

    public int מזההלקוח { get; set; }

    public string סטטוספרויקט { get; set; } = null!;

    public DateOnly תאריך { get; set; }

    public string שםפרויקט { get; set; } = null!;

    public string? כרך { get; set; }

    public string? מהדורה { get; set; }

    public string? הערות { get; set; }

    public DateTime? תאריךיצירתרשומה { get; set; }

    public virtual ICollection<הצעתמחירהזמנה> הצעתמחירהזמנהs { get; set; } = new List<הצעתמחירהזמנה>();

    public virtual לקוחות מזההלקוחNavigation { get; set; } = null!;
}
