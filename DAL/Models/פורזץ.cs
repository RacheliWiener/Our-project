﻿using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class פורזץ
{
    public int מזהה { get; set; }

    public int הצמהזמנה { get; set; }

    public int ספק { get; set; }

    public string? פקע { get; set; }

    public string? יישום { get; set; }

    public string? פריט { get; set; }

    public string? גודלנייר { get; set; }

    public string? סוגנייר { get; set; }

    public string? צבע { get; set; }

    public bool? קדמי { get; set; }

    public bool? אחורי { get; set; }

    public decimal? מחיר { get; set; }

    public int? עותקים { get; set; }

    public string? הערהלפקע { get; set; }

    public string? הערה { get; set; }

    public DateTime? תאריךיצירתרשומה { get; set; }

    public virtual הצעתמחירהזמנה הצמהזמנהNavigation { get; set; } = null!;

    public virtual ספקים ספקNavigation { get; set; } = null!;
}
