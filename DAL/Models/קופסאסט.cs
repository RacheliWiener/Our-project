using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class קופסאסט
{
    public int מזהה { get; set; }

    public int הצמהזמנה { get; set; }

    public string? פקע { get; set; }

    public int ספק { get; set; }

    public string? יישום { get; set; }

    public string? סוג { get; set; }

    public decimal? מחיר { get; set; }

    public decimal? מחירפתיחתקופסא { get; set; }

    public int? עותקים { get; set; }

    public string? הערהלפקע { get; set; }

    public string? הערה { get; set; }

    public DateTime? יצירתרשומה { get; set; }

    public virtual הצעתמחירהזמנה הצמהזמנהNavigation { get; set; } = null!;

    public virtual ספקים ספקNavigation { get; set; } = null!;
}
