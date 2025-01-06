using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class הצעתמחירהזמנה
{
    public int מזהה { get; set; }

    public int מזההפרויקט { get; set; }

    public string הצעתמחירהזמנה1 { get; set; } = null!;

    public string? פריט { get; set; }

    public int? עותקים { get; set; }

    public double? הנחה { get; set; }

    public string? הערות { get; set; }

    public DateTime? תאריךיצירתרשומה { get; set; }

    public virtual ICollection<אריזתקרטון> אריזתקרטוןs { get; set; } = new List<אריזתקרטון>();

    public virtual ICollection<גלופות> גלופותs { get; set; } = new List<גלופות>();

    public virtual ICollection<הדבקתפורזץ> הדבקתפורזץs { get; set; } = new List<הדבקתפורזץ>();

    public virtual ICollection<הדפסה> הדפסהs { get; set; } = new List<הדפסה>();

    public virtual ICollection<הטבעה> הטבעהs { get; set; } = new List<הטבעה>();

    public virtual ICollection<הכנתסטים> הכנתסטיםs { get; set; } = new List<הכנתסטים>();

    public virtual ICollection<השבחות> השבחותs { get; set; } = new List<השבחות>();

    public virtual ICollection<ייצורכריכהקשה> ייצורכריכהקשהs { get; set; } = new List<ייצורכריכהקשה>();

    public virtual ICollection<לוחות> לוחותs { get; set; } = new List<לוחות>();

    public virtual ICollection<ליין> לייןs { get; set; } = new List<ליין>();

    public virtual פרויקטים מזההפרויקטNavigation { get; set; } = null!;

    public virtual ICollection<נייר> ניירs { get; set; } = new List<נייר>();

    public virtual ICollection<סימניה> סימניהs { get; set; } = new List<סימניה>();

    public virtual ICollection<עטיפה> עטיפהs { get; set; } = new List<עטיפה>();

    public virtual ICollection<פורזץ> פורזץs { get; set; } = new List<פורזץ>();

    public virtual ICollection<צבע> צבעs { get; set; } = new List<צבע>();

    public virtual ICollection<ציפויכריכהקשה> ציפויכריכהקשהs { get; set; } = new List<ציפויכריכהקשה>();

    public virtual ICollection<קאת> קאתs { get; set; } = new List<קאת>();

    public virtual ICollection<קופסאסט> קופסאסטs { get; set; } = new List<קופסאסט>();

    public virtual ICollection<קרטוןכריכהקשה> קרטוןכריכהקשהs { get; set; } = new List<קרטוןכריכהקשה>();

    public virtual ICollection<שונות> שונותs { get; set; } = new List<שונות>();
}
