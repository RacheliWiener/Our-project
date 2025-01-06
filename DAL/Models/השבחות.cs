﻿using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class השבחות
{
    public int מזהה { get; set; }

    public int הצמהזמנה { get; set; }

    public int ספק { get; set; }

    public string? פקע { get; set; }

    public string? יישום { get; set; }

    public string? פריט { get; set; }

    public string? פרטים { get; set; }

    public int? עותקים { get; set; }

    public decimal? מחיראלףראשון { get; set; }

    public decimal? מחירכלאלףנוסף { get; set; }

    public string? הערהלפקע { get; set; }

    public string? הערה { get; set; }

    public DateTime? תאריךיצירתרשומה { get; set; }

    public virtual הצעתמחירהזמנה הצמהזמנהNavigation { get; set; } = null!;

    public virtual ספקים ספקNavigation { get; set; } = null!;
}
