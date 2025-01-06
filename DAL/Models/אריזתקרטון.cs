﻿using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class אריזתקרטון
{
    public int מזהה { get; set; }

    public int הצמהזמנה { get; set; }

    public int ספק { get; set; }

    public string? פקע { get; set; }

    public string? יישום { get; set; }

    public int? עמודים { get; set; }

    public double? משקלנייר { get; set; }

    public string? ערימותבקופסא { get; set; }

    public int? עותקים { get; set; }

    public string? סוגקופסא { get; set; }

    public decimal? מחיר { get; set; }

    public string? הערהלפקע { get; set; }

    public string? הערה { get; set; }

    public DateTime? תאריךיצירתרשומה { get; set; }

    public virtual הצעתמחירהזמנה הצמהזמנהNavigation { get; set; } = null!;

    public virtual ספקים ספקNavigation { get; set; } = null!;
}
