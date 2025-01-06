using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class לקוחות
{
    public int מזהה { get; set; }

    public string? חברה { get; set; }

    public string? חפעמער { get; set; }

    public string? שםמשפחה { get; set; }

    public string? שםפרטי { get; set; }

    public string? כתובת { get; set; }

    public string? מדינה { get; set; }

    public string? טלפון1 { get; set; }

    public string? טלפון2 { get; set; }

    public string? פקס { get; set; }

    public string? אימייל { get; set; }

    public string? הערה { get; set; }

    public DateTime? תאריךיצירתרשומה { get; set; }

    public virtual ICollection<פרויקטים> פרויקטיםs { get; set; } = new List<פרויקטים>();
}
