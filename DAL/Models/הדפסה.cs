using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class הדפסה
{
    public int מזהה { get; set; }

    public int הצמהזמנה { get; set; }

    public string? פקע { get; set; }

    public int ספק { get; set; }

    public string? יישום { get; set; }

    public string? צבע { get; set; }

    public int? עמודים { get; set; }

    public int? עמודיםבצד { get; set; }

    public bool? פרפקטור { get; set; }

    public bool? חצאים { get; set; }

    public int? עותקיםנטו { get; set; }

    public string? מקורלוחות { get; set; }

    public decimal? מחיראלףראשון { get; set; }

    public decimal? מחירכלאלףנוסף { get; set; }

    public string? הערהלפקע { get; set; }

    public string? הערה { get; set; }

    public DateTime? יצירתרשומה { get; set; }

    public virtual הצעתמחירהזמנה הצמהזמנהNavigation { get; set; } = null!;

    public virtual ספקים ספקNavigation { get; set; } = null!;
}
