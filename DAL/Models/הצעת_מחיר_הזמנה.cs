using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class הצעת_מחיר_הזמנה
{
    public int מזהה { get; set; }

    public int מזההפרויקט { get; set; }

    public string הצעתמחירהזמנה1 { get; set; } = null!;

    public string? פריט { get; set; }

    public int? עותקים { get; set; }

    public double? הנחה { get; set; }

    public string? הערות { get; set; }

    public DateTime? תאריךיצירתרשומה { get; set; }

    public virtual ICollection<אריזת_קרטון> אריזתקרטוןs { get; set; } = new List<אריזת_קרטון>();

    public virtual ICollection<גלופות> גלופותs { get; set; } = new List<גלופות>();

    public virtual ICollection<הדבקת_פורזץ> הדבקתפורזץs { get; set; } = new List<הדבקת_פורזץ>();

    public virtual ICollection<הדפסה> הדפסהs { get; set; } = new List<הדפסה>();

    public virtual ICollection<הטבעה> הטבעהs { get; set; } = new List<הטבעה>();

    public virtual ICollection<הכנת_סטים> הכנתסטיםs { get; set; } = new List<הכנת_סטים>();

    public virtual ICollection<השבחות> השבחותs { get; set; } = new List<השבחות>();

    public virtual ICollection<ייצור_כריכה_קשה> ייצורכריכהקשהs { get; set; } = new List<ייצור_כריכה_קשה>();

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
