using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class נייר
{
    public int מזהה { get; set; }

    public int הצמהזמנה { get; set; }

    public string? פקע { get; set; }

    public int ספק { get; set; }

    public string? יישום { get; set; }

    public int? עמודים { get; set; }

    public int? עמודיםבצד { get; set; }

    public int? עותקים { get; set; }

    public int? עודעודף { get; set; }

    public bool? חבילה { get; set; }

    public string? סוגנייר { get; set; }

    public int? רוחב { get; set; }

    public int? אורך { get; set; }

    public string? כיוון { get; set; }

    public int? גרמז { get; set; }

    public decimal? מחירלטון { get; set; }

    public string? הערהלפקע { get; set; }

    public string? הערה { get; set; }

    public DateTime? יצירתרשומה { get; set; }

    public virtual הצעתמחירהזמנה הצמהזמנהNavigation { get; set; } = null!;

    public virtual ספקים ספקNavigation { get; set; } = null!;
}
