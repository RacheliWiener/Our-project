using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class הפקה
{
    public int מזהה { get; set; }

    public int הצמהזמנה { get; set; }

    public string? יישום { get; set; }

    public decimal? מחיר { get; set; }

    public int? כמות { get; set; }

    public string? הערה { get; set; }

    public DateTime? יצירתרשומה { get; set; }
}
