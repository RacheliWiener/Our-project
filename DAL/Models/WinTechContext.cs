using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

public partial class WinTechContext : DbContext
{
    public WinTechContext()
    {
    }

    public WinTechContext(DbContextOptions<WinTechContext> options)
        : base(options)
    {
    }

    public virtual DbSet<אריזת_קרטון> אריזת_קרטוןs { get; set; }

    public virtual DbSet<גלופות> גלופותs { get; set; }

    public virtual DbSet<הדבקת_פורזץ> הדבקת_פורזץs { get; set; }

    public virtual DbSet<הדפסה> הדפסהs { get; set; }

    public virtual DbSet<הטבעה> הטבעהs { get; set; }

    public virtual DbSet<הכנת_סטים> הכנת_סטיםs { get; set; }

    public virtual DbSet<הפקה> הפקהs { get; set; }

    public virtual DbSet<הצעת_מחיר_הזמנה> הצעת_מחיר_הזמנהs { get; set; }

    public virtual DbSet<השבחות> השבחותs { get; set; }

    public virtual DbSet<ייצור_כריכה_קשה> ייצור_כריכה_קשהs { get; set; }

    public virtual DbSet<לוחות> לוחותs { get; set; }

    public virtual DbSet<ליין> לייןs { get; set; }

    public virtual DbSet<לקוחות> לקוחותs { get; set; }

    public virtual DbSet<מחירון_הדבקת_פורזץ> מחירון_הדבקת_פורזץs { get; set; }

    public virtual DbSet<מחירון_הדפסה> מחירון_הדפסהs { get; set; }

    public virtual DbSet<מחירון_הטבעה> מחירון_הטבעהs { get; set; }

    public virtual DbSet<מחירוןהשבחות> מחירוןהשבחותs { get; set; }

    public virtual DbSet<מחירון_ייצור_כריכה_קשה> מחירון_ייצור_כריכה_קשהs { get; set; }

    public virtual DbSet<מחירוןליין> מחירוןלייןs { get; set; }

    public virtual DbSet<מחירוןסימניה> מחירוןסימניהs { get; set; }

    public virtual DbSet<מחירוןעטיפה> מחירוןעטיפהs { get; set; }

    public virtual DbSet<מחירוןפורזץ> מחירוןפורזץs { get; set; }

    public virtual DbSet<מחירוןצבע> מחירוןצבעs { get; set; }

    public virtual DbSet<מחירוןציפויכריכהקשה> מחירוןציפויכריכהקשהs { get; set; }

    public virtual DbSet<מחירוןקאת> מחירוןקאתs { get; set; }

    public virtual DbSet<מחירוןקרטוןכריכהקשה> מחירוןקרטוןכריכהקשהs { get; set; }

    public virtual DbSet<נייר> ניירs { get; set; }

    public virtual DbSet<סימניה> סימניהs { get; set; }

    public virtual DbSet<ספקים> ספקיםs { get; set; }

    public virtual DbSet<עטיפה> עטיפהs { get; set; }

    public virtual DbSet<פורזץ> פורזץs { get; set; }

    public virtual DbSet<פרויקטים> פרויקטיםs { get; set; }

    public virtual DbSet<צבע> צבעs { get; set; }

    public virtual DbSet<ציפויכריכהקשה> ציפויכריכהקשהs { get; set; }

    public virtual DbSet<קאת> קאתs { get; set; }

    public virtual DbSet<קופסאסט> קופסאסטs { get; set; }

    public virtual DbSet<קרטוןכריכהקשה> קרטוןכריכהקשהs { get; set; }

    public virtual DbSet<שונות> שונותs { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=wintechserver.database.windows.net;Initial Catalog=WinTech;User ID=RacheliWiener;Password=juhfvi&rjkhuhbr03;Trust Server Certificate=True;Encrypt=True;MultipleActiveResultSets=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<אריזת_קרטון>(entity =>
        {
            entity.HasKey(e => e.מזהה).HasName("PK__אריזת_קר__02473CB34AB85393");

            entity.ToTable("אריזת_קרטון");

            entity.Property(e => e.הערהלפקע).HasColumnName("הערה_לפקע");
            entity.Property(e => e.הצמהזמנה).HasColumnName("הצמ_הזמנה");
            entity.Property(e => e.יישום).HasMaxLength(255);
            entity.Property(e => e.מחיר).HasColumnType("money");
            entity.Property(e => e.משקלנייר).HasColumnName("משקל_נייר");
            entity.Property(e => e.סוגקופסא)
                .HasMaxLength(255)
                .HasColumnName("סוג_קופסא");
            entity.Property(e => e.ערימותבקופסא)
                .HasMaxLength(50)
                .HasColumnName("ערימות_בקופסא");
            entity.Property(e => e.פקע).HasMaxLength(50);
            entity.Property(e => e.תאריךיצירתרשומה)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("תאריך_יצירת_רשומה");

            entity.HasOne(d => d.הצמהזמנהNavigation).WithMany(p => p.אריזתקרטוןs)
                .HasForeignKey(d => d.הצמהזמנה)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_אריזת_קרטון_הצעת_מחיר_הזמנה");

            entity.HasOne(d => d.ספקNavigation).WithMany(p => p.אריזתקרטוןs)
                .HasForeignKey(d => d.ספק)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_אריזת_קרטון_ספקים");
        });

        modelBuilder.Entity<גלופות>(entity =>
        {
            entity.HasKey(e => e.מזהה).HasName("PK__גלופות__02473CB36A9F10A4");

            entity.ToTable("גלופות");

            entity.Property(e => e.אורך).HasDefaultValue(0);
            entity.Property(e => e.הערהלפקע).HasColumnName("הערה_לפקע");
            entity.Property(e => e.הצמהזמנה).HasColumnName("הצמ_הזמנה");
            entity.Property(e => e.יישום).HasMaxLength(255);
            entity.Property(e => e.מחיר)
                .HasDefaultValue(1.45m)
                .HasColumnType("money");
            entity.Property(e => e.פקע).HasMaxLength(50);
            entity.Property(e => e.רוחב).HasDefaultValue(0);
            entity.Property(e => e.תאריךיצירתרשומה)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("תאריך_יצירת_רשומה");

            entity.HasOne(d => d.הצמהזמנהNavigation).WithMany(p => p.גלופותs)
                .HasForeignKey(d => d.הצמהזמנה)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_גלופות_הצעת_מחיר_הזמנה");

            entity.HasOne(d => d.ספקNavigation).WithMany(p => p.גלופותs)
                .HasForeignKey(d => d.ספק)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_גלופות_ספקים");
        });

        modelBuilder.Entity<הדבקת_פורזץ>(entity =>
        {
            entity.HasKey(e => e.מזהה).HasName("PK__הדבקת_פו__02473CB30268C8B7");

            entity.ToTable("הדבקת_פורזץ");

            entity.Property(e => e.הערהלפקע).HasColumnName("הערה_לפקע");
            entity.Property(e => e.הצמהזמנה).HasColumnName("הצמ_הזמנה");
            entity.Property(e => e.יישום).HasMaxLength(255);
            entity.Property(e => e.מחיר).HasColumnType("money");
            entity.Property(e => e.עותקים).HasDefaultValue(0);
            entity.Property(e => e.פקע).HasMaxLength(50);
            entity.Property(e => e.פריט).HasMaxLength(100);
            entity.Property(e => e.תאריךיצירתרשומה)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("תאריך_יצירת_רשומה");

            entity.HasOne(d => d.הצמהזמנהNavigation).WithMany(p => p.הדבקתפורזץs)
                .HasForeignKey(d => d.הצמהזמנה)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_הדבקת_פורזץ_הצעת_מחיר_הזמנה");

            entity.HasOne(d => d.ספקNavigation).WithMany(p => p.הדבקתפורזץs)
                .HasForeignKey(d => d.ספק)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_הדבקת_פורזץ_ספקים");
        });

        modelBuilder.Entity<הדפסה>(entity =>
        {
            entity.HasKey(e => e.מזהה).HasName("PK__הדפסה__02473CB3FBB7E5DE");

            entity.ToTable("הדפסה");

            entity.Property(e => e.הערה).HasMaxLength(255);
            entity.Property(e => e.הערהלפקע)
                .HasMaxLength(255)
                .HasColumnName("הערה_לפקע");
            entity.Property(e => e.הצמהזמנה).HasColumnName("הצמ_הזמנה");
            entity.Property(e => e.יישום).HasMaxLength(50);
            entity.Property(e => e.יצירתרשומה)
                .HasColumnType("datetime")
                .HasColumnName("יצירת_רשומה");
            entity.Property(e => e.מחיראלףראשון)
                .HasColumnType("money")
                .HasColumnName("מחיר_אלף_ראשון");
            entity.Property(e => e.מחירכלאלףנוסף)
                .HasColumnType("money")
                .HasColumnName("מחיר_כל_אלף_נוסף");
            entity.Property(e => e.מקורלוחות)
                .HasMaxLength(50)
                .HasColumnName("מקור_לוחות");
            entity.Property(e => e.עותקיםנטו).HasColumnName("עותקים_נטו");
            entity.Property(e => e.עמודיםבצד).HasColumnName("עמודים_בצד");
            entity.Property(e => e.פקע).HasMaxLength(10);
            entity.Property(e => e.פרפקטור).HasDefaultValue(false);
            entity.Property(e => e.צבע).HasMaxLength(10);

            entity.HasOne(d => d.הצמהזמנהNavigation).WithMany(p => p.הדפסהs)
                .HasForeignKey(d => d.הצמהזמנה)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_הדפסה_הצעת_מחיר_הזמנה");

            entity.HasOne(d => d.ספקNavigation).WithMany(p => p.הדפסהs)
                .HasForeignKey(d => d.ספק)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_הדפסה_ספקים");
        });

        modelBuilder.Entity<הטבעה>(entity =>
        {
            entity.HasKey(e => e.מזהה).HasName("PK__הטבעה__02473CB3A91A9795");

            entity.ToTable("הטבעה");

            entity.Property(e => e.הערה).HasMaxLength(255);
            entity.Property(e => e.הערהלפקע)
                .HasMaxLength(255)
                .HasColumnName("הערה_לפקע");
            entity.Property(e => e.הצמהזמנה).HasColumnName("הצמ_הזמנה");
            entity.Property(e => e.יישום).HasMaxLength(50);
            entity.Property(e => e.מחיר).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.עותקים).HasDefaultValue(0);
            entity.Property(e => e.פקע).HasMaxLength(10);
            entity.Property(e => e.צבע).HasMaxLength(50);
            entity.Property(e => e.תאריךיצירתרשומה)
                .HasColumnType("datetime")
                .HasColumnName("תאריך_יצירת_רשומה");

            entity.HasOne(d => d.הצמהזמנהNavigation).WithMany(p => p.הטבעהs)
                .HasForeignKey(d => d.הצמהזמנה)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_הטבעה_הצעת_מחיר_הזמנה");

            entity.HasOne(d => d.ספקNavigation).WithMany(p => p.הטבעהs)
                .HasForeignKey(d => d.ספק)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_הטבעה_ספקים");
        });

        modelBuilder.Entity<הכנת_סטים>(entity =>
        {
            entity.HasKey(e => e.מזהה).HasName("PK__הכנת_סטי__02473CB37AFFA8F2");

            entity.ToTable("הכנת_סטים");

            entity.Property(e => e.הערהלפקע).HasColumnName("הערה_לפקע");
            entity.Property(e => e.הצמהזמנה).HasColumnName("הצמ_הזמנה");
            entity.Property(e => e.יישום).HasMaxLength(255);
            entity.Property(e => e.מחיר)
                .HasDefaultValue(0.35m)
                .HasColumnType("money");
            entity.Property(e => e.עותקים).HasDefaultValue(0);
            entity.Property(e => e.פקע).HasMaxLength(50);
            entity.Property(e => e.תאריךיצירתרשומה)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("תאריך_יצירת_רשומה");

            entity.HasOne(d => d.הצמהזמנהNavigation).WithMany(p => p.הכנתסטיםs)
                .HasForeignKey(d => d.הצמהזמנה)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_הכנת_סטים_הצעת_מחיר_הזמנה");

            entity.HasOne(d => d.ספקNavigation).WithMany(p => p.הכנתסטיםs)
                .HasForeignKey(d => d.ספק)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_הכנת_סטים_ספקים");
        });

        modelBuilder.Entity<הפקה>(entity =>
        {
            entity.HasKey(e => e.מזהה).HasName("PK__הפקה__02473CB3A99910D0");

            entity.ToTable("הפקה");

            entity.Property(e => e.הערה).HasMaxLength(255);
            entity.Property(e => e.הצמהזמנה).HasColumnName("הצמ_הזמנה");
            entity.Property(e => e.יישום).HasMaxLength(50);
            entity.Property(e => e.יצירתרשומה)
                .HasColumnType("datetime")
                .HasColumnName("יצירת_רשומה");
            entity.Property(e => e.כמות).HasDefaultValue(1);
            entity.Property(e => e.מחיר)
                .HasDefaultValue(0m)
                .HasColumnType("money");
        });

        modelBuilder.Entity<הצעת_מחיר_הזמנה>(entity =>
        {
            entity.HasKey(e => e.מזהה).HasName("PK__הצעת_מחי__02473CB3AD138BDE");

            entity.ToTable("הצעת_מחיר_הזמנה");

            entity.Property(e => e.הנחה).HasDefaultValue(1.0);
            entity.Property(e => e.הצעתמחירהזמנה1)
                .HasMaxLength(50)
                .HasColumnName("הצעת_מחיר_הזמנה");
            entity.Property(e => e.מזההפרויקט).HasColumnName("מזהה_פרויקט");
            entity.Property(e => e.עותקים).HasDefaultValue(0);
            entity.Property(e => e.פריט).HasMaxLength(100);
            entity.Property(e => e.תאריךיצירתרשומה)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("תאריך_יצירת_רשומה");

            entity.HasOne(d => d.מזההפרויקטNavigation).WithMany(p => p.הצעתמחירהזמנהs)
                .HasForeignKey(d => d.מזההפרויקט)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_הצעת_מחיר_הזמנה_פרויקטים");
        });

        modelBuilder.Entity<השבחות>(entity =>
        {
            entity.HasKey(e => e.מזהה).HasName("PK__השבחות__02473CB3C86B5811");

            entity.ToTable("השבחות");

            entity.Property(e => e.הערהלפקע).HasColumnName("הערה_לפקע");
            entity.Property(e => e.הצמהזמנה).HasColumnName("הצמ_הזמנה");
            entity.Property(e => e.יישום).HasMaxLength(255);
            entity.Property(e => e.מחיראלףראשון)
                .HasColumnType("money")
                .HasColumnName("מחיר_אלף_ראשון");
            entity.Property(e => e.מחירכלאלףנוסף)
                .HasColumnType("money")
                .HasColumnName("מחיר_כל_אלף_נוסף");
            entity.Property(e => e.עותקים).HasDefaultValue(1);
            entity.Property(e => e.פקע).HasMaxLength(50);
            entity.Property(e => e.פרטים).HasMaxLength(255);
            entity.Property(e => e.פריט).HasMaxLength(100);
            entity.Property(e => e.תאריךיצירתרשומה)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("תאריך_יצירת_רשומה");

            entity.HasOne(d => d.הצמהזמנהNavigation).WithMany(p => p.השבחותs)
                .HasForeignKey(d => d.הצמהזמנה)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_השבחות_הצעת_מחיר_הזמנה");

            entity.HasOne(d => d.ספקNavigation).WithMany(p => p.השבחותs)
                .HasForeignKey(d => d.ספק)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_השבחות_ספקים");
        });

        modelBuilder.Entity<ייצור_כריכה_קשה>(entity =>
        {
            entity.HasKey(e => e.מזהה).HasName("PK__ייצור_כר__02473CB3B6117314");

            entity.ToTable("ייצור_כריכה_קשה");

            entity.Property(e => e.הערהלפקע).HasColumnName("הערה_לפקע");
            entity.Property(e => e.הצמהזמנה).HasColumnName("הצמ_הזמנה");
            entity.Property(e => e.יישום).HasMaxLength(255);
            entity.Property(e => e.מחיר).HasColumnType("money");
            entity.Property(e => e.פקע).HasMaxLength(50);
            entity.Property(e => e.פריט).HasMaxLength(100);
            entity.Property(e => e.תאריךיצירתרשומה)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("תאריך_יצירת_רשומה");

            entity.HasOne(d => d.הצמהזמנהNavigation).WithMany(p => p.ייצורכריכהקשהs)
                .HasForeignKey(d => d.הצמהזמנה)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ייצור_כריכה_קשה_הצעת_מחיר_הזמנה");

            entity.HasOne(d => d.ספקNavigation).WithMany(p => p.ייצורכריכהקשהs)
                .HasForeignKey(d => d.ספק)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ייצור_כריכה_קשה_ספקים");
        });

        modelBuilder.Entity<לוחות>(entity =>
        {
            entity.HasKey(e => e.מזהה).HasName("PK__לוחות__02473CB3D2EB102B");

            entity.ToTable("לוחות");

            entity.Property(e => e.גודלעמודנטו)
                .HasMaxLength(50)
                .HasColumnName("גודל_עמוד_נטו");
            entity.Property(e => e.הערהלפקע).HasColumnName("הערה_לפקע");
            entity.Property(e => e.הצמהזמנה).HasColumnName("הצמ_הזמנה");
            entity.Property(e => e.חצאים).HasDefaultValue(false);
            entity.Property(e => e.יישום).HasMaxLength(255);
            entity.Property(e => e.מחיר)
                .HasDefaultValue(70m)
                .HasColumnType("money");
            entity.Property(e => e.עמודיםבצד).HasColumnName("עמודים_בצד");
            entity.Property(e => e.פורמטנייר).HasColumnName("פורמט_נייר");
            entity.Property(e => e.פקע).HasMaxLength(50);
            entity.Property(e => e.פרפקטור).HasDefaultValue(false);
            entity.Property(e => e.צבע)
                .HasMaxLength(50)
                .HasDefaultValue("שחור");
            entity.Property(e => e.תאריךיצירתרשומה)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("תאריך_יצירת_רשומה");

            entity.HasOne(d => d.הצמהזמנהNavigation).WithMany(p => p.לוחותs)
                .HasForeignKey(d => d.הצמהזמנה)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_לוחות_הצעת_מחיר_הזמנה");

            entity.HasOne(d => d.ספקNavigation).WithMany(p => p.לוחותs)
                .HasForeignKey(d => d.ספק)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_לוחות_ספקים");
        });

        modelBuilder.Entity<ליין>(entity =>
        {
            entity.HasKey(e => e.מזהה).HasName("PK__ליין__02473CB34B28057D");

            entity.ToTable("ליין");

            entity.Property(e => e.הערה).HasMaxLength(255);
            entity.Property(e => e.הערהלפקע)
                .HasMaxLength(255)
                .HasColumnName("הערה_לפקע");
            entity.Property(e => e.הצמהזמנה).HasColumnName("הצמ_הזמנה");
            entity.Property(e => e.יישום).HasMaxLength(50);
            entity.Property(e => e.מחיר).HasColumnType("money");
            entity.Property(e => e.עותקים).HasDefaultValue(0);
            entity.Property(e => e.פקע).HasMaxLength(10);
            entity.Property(e => e.רוחבשידרה50ומעלה)
                .HasDefaultValue(false)
                .HasColumnName("רוחב_שידרה_50_ומעלה");
            entity.Property(e => e.תאריךיצירתרשומה)
                .HasColumnType("datetime")
                .HasColumnName("תאריך_יצירת_רשומה");

            entity.HasOne(d => d.הצמהזמנהNavigation).WithMany(p => p.לייןs)
                .HasForeignKey(d => d.הצמהזמנה)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ליין_הצעת_מחיר_הזמנה");

            entity.HasOne(d => d.ספקNavigation).WithMany(p => p.לייןs)
                .HasForeignKey(d => d.ספק)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ליין_ספקים");
        });

        modelBuilder.Entity<לקוחות>(entity =>
        {
            entity.HasKey(e => e.מזהה).HasName("PK__לקוחות__02473CB310647A79");

            entity.ToTable("לקוחות");

            entity.Property(e => e.אימייל).HasMaxLength(100);
            entity.Property(e => e.חברה).HasMaxLength(100);
            entity.Property(e => e.חפעמער)
                .HasMaxLength(50)
                .HasColumnName("חפ_עמ_ער");
            entity.Property(e => e.טלפון1)
                .HasMaxLength(20)
                .HasColumnName("טלפון_1");
            entity.Property(e => e.טלפון2)
                .HasMaxLength(20)
                .HasColumnName("טלפון_2");
            entity.Property(e => e.כתובת).HasMaxLength(255);
            entity.Property(e => e.מדינה).HasMaxLength(50);
            entity.Property(e => e.פקס).HasMaxLength(20);
            entity.Property(e => e.שםמשפחה)
                .HasMaxLength(50)
                .HasColumnName("שם_משפחה");
            entity.Property(e => e.שםפרטי)
                .HasMaxLength(50)
                .HasColumnName("שם_פרטי");
            entity.Property(e => e.תאריךיצירתרשומה)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("תאריך_יצירת_רשומה");
        });

        modelBuilder.Entity<מחירון_הדבקת_פורזץ>(entity =>
        {
            entity.HasKey(e => e.מזהה).HasName("PK__מחירון_ה__02473CB3910F496D");

            entity.ToTable("מחירון_הדבקת_פורזץ");

            entity.Property(e => e.מחירמחירון)
                .HasColumnType("money")
                .HasColumnName("מחיר_מחירון");
            entity.Property(e => e.סוגפורזץ)
                .HasMaxLength(255)
                .HasColumnName("סוג_פורזץ");
            entity.Property(e => e.פורמט).HasMaxLength(255);
        });

        modelBuilder.Entity<מחירון_הדפסה>(entity =>
        {
            entity.HasKey(e => e.מזהה).HasName("PK__מחירון_ה__02473CB3C7FF8736");

            entity.ToTable("מחירון_הדפסה");

            entity.Property(e => e.מחירמחירון)
                .HasDefaultValue(0m)
                .HasColumnType("money")
                .HasColumnName("מחיר_מחירון");
            entity.Property(e => e.מחירמחירוןאלףנוסף)
                .HasDefaultValue(0m)
                .HasColumnType("money")
                .HasColumnName("מחיר_מחירון_אלף_נוסף");
            entity.Property(e => e.צבע).HasMaxLength(50);
        });

        modelBuilder.Entity<מחירון_הטבעה>(entity =>
        {
            entity.HasKey(e => e.מזהה).HasName("PK__מחירון_ה__02473CB32685A558");

            entity.ToTable("מחירון_הטבעה");

            entity.Property(e => e.מחירמחירון)
                .HasDefaultValue(0m)
                .HasColumnType("money")
                .HasColumnName("מחיר_מחירון");
            entity.Property(e => e.פורמט).HasMaxLength(100);
            entity.Property(e => e.צבע).HasMaxLength(50);
        });

        modelBuilder.Entity<מחירוןהשבחות>(entity =>
        {
            entity.HasKey(e => e.מזהה).HasName("PK__מחירון_ה__02473CB35A4E59D7");

            entity.ToTable("מחירון_השבחות");

            entity.Property(e => e.השבחה)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.מחירמחירון)
                .HasColumnType("money")
                .HasColumnName("מחיר_מחירון");
            entity.Property(e => e.מחירמחירוןאלףנוסף)
                .HasColumnType("money")
                .HasColumnName("מחיר_מחירון_אלף_נוסף");
            entity.Property(e => e.פורמט).HasMaxLength(50);
        });

        modelBuilder.Entity<מחירון_ייצור_כריכה_קשה>(entity =>
        {
            entity.HasKey(e => e.מזהה).HasName("PK__מחירון_י__02473CB372E499A2");

            entity.ToTable("מחירון_ייצור_כריכה_קשה");

            entity.Property(e => e.מחירמחירון)
                .HasColumnType("money")
                .HasColumnName("מחיר_מחירון");
            entity.Property(e => e.פורמט).HasMaxLength(255);
        });

        modelBuilder.Entity<מחירוןליין>(entity =>
        {
            entity.HasKey(e => e.מזהה).HasName("PK__מחירון_ל__02473CB3EA5BE167");

            entity.ToTable("מחירון_ליין");

            entity.Property(e => e.מחירמחירון)
                .HasDefaultValue(0m)
                .HasColumnType("money")
                .HasColumnName("מחיר_מחירון");
            entity.Property(e => e.פורמט).HasMaxLength(100);
        });

        modelBuilder.Entity<מחירוןסימניה>(entity =>
        {
            entity.HasKey(e => e.מזהה).HasName("PK__מחירון_ס__02473CB3C9A1CF54");

            entity.ToTable("מחירון_סימניה");

            entity.Property(e => e.מחירמחירון)
                .HasDefaultValue(0m)
                .HasColumnType("money")
                .HasColumnName("מחיר_מחירון");
            entity.Property(e => e.פורמט).HasMaxLength(100);
        });

        modelBuilder.Entity<מחירוןעטיפה>(entity =>
        {
            entity.HasKey(e => e.מזהה).HasName("PK__מחירון_ע__02473CB3FC74299C");

            entity.ToTable("מחירון_עטיפה");

            entity.Property(e => e.מחירמחירון)
                .HasColumnType("money")
                .HasColumnName("מחיר_מחירון");
            entity.Property(e => e.פורמט).HasMaxLength(50);
        });

        modelBuilder.Entity<מחירוןפורזץ>(entity =>
        {
            entity.HasKey(e => e.מזהה).HasName("PK__מחירון_פ__02473CB3D841EDAF");

            entity.ToTable("מחירון_פורזץ");

            entity.Property(e => e.מחירמחירון)
                .HasColumnType("money")
                .HasColumnName("מחיר_מחירון");
            entity.Property(e => e.פורמט).HasMaxLength(50);
        });

        modelBuilder.Entity<מחירוןצבע>(entity =>
        {
            entity.HasKey(e => e.מזהה).HasName("PK__מחירון_צ__02473CB32754F5FE");

            entity.ToTable("מחירון_צבע");

            entity.Property(e => e.מחירמחירון)
                .HasDefaultValue(0m)
                .HasColumnType("money")
                .HasColumnName("מחיר_מחירון");
            entity.Property(e => e.סוגצבע)
                .HasMaxLength(50)
                .HasColumnName("סוג_צבע");
            entity.Property(e => e.פורמט).HasMaxLength(100);
        });

        modelBuilder.Entity<מחירוןציפויכריכהקשה>(entity =>
        {
            entity.HasKey(e => e.מזהה).HasName("PK__מחירון_צ__02473CB300007EE4");

            entity.ToTable("מחירון_ציפוי_כריכה_קשה");

            entity.Property(e => e.מחירמחירון)
                .HasColumnType("money")
                .HasColumnName("מחיר_מחירון");
            entity.Property(e => e.פורמט).HasMaxLength(255);
            entity.Property(e => e.ציפוי).HasMaxLength(50);
        });

        modelBuilder.Entity<מחירוןקאת>(entity =>
        {
            entity.HasKey(e => e.מזהה).HasName("PK__מחירון_ק__02473CB3B514F3DE");

            entity.ToTable("מחירון_קאת");

            entity.Property(e => e.מחירמחירון)
                .HasColumnType("money")
                .HasColumnName("מחיר_מחירון");
            entity.Property(e => e.סוגנייר)
                .HasMaxLength(255)
                .HasColumnName("סוג_נייר");
            entity.Property(e => e.פורמט).HasMaxLength(255);
        });

        modelBuilder.Entity<מחירוןקרטוןכריכהקשה>(entity =>
        {
            entity.HasKey(e => e.מזהה).HasName("PK__מחירון_ק__02473CB39C7C425F");

            entity.ToTable("מחירון_קרטון_כריכה_קשה");

            entity.Property(e => e.מחירמחירון)
                .HasColumnType("money")
                .HasColumnName("מחיר_מחירון");
            entity.Property(e => e.עוביקרטון)
                .HasMaxLength(50)
                .HasColumnName("עובי_קרטון");
            entity.Property(e => e.פורמט).HasMaxLength(50);
        });

        modelBuilder.Entity<נייר>(entity =>
        {
            entity.HasKey(e => e.מזהה).HasName("PK__נייר__02473CB38E10A549");

            entity.ToTable("נייר");

            entity.Property(e => e.הערה).HasMaxLength(255);
            entity.Property(e => e.הערהלפקע)
                .HasMaxLength(255)
                .HasColumnName("הערה_לפקע");
            entity.Property(e => e.הצמהזמנה).HasColumnName("הצמ_הזמנה");
            entity.Property(e => e.יישום).HasMaxLength(50);
            entity.Property(e => e.יצירתרשומה)
                .HasColumnType("datetime")
                .HasColumnName("יצירת_רשומה");
            entity.Property(e => e.כיוון).HasMaxLength(10);
            entity.Property(e => e.מחירלטון)
                .HasColumnType("money")
                .HasColumnName("מחיר_לטון");
            entity.Property(e => e.סוגנייר)
                .HasMaxLength(50)
                .HasColumnName("סוג_נייר");
            entity.Property(e => e.עודעודף).HasColumnName("עוד_עודף");
            entity.Property(e => e.עמודיםבצד).HasColumnName("עמודים_בצד");
            entity.Property(e => e.פקע).HasMaxLength(10);

            entity.HasOne(d => d.הצמהזמנהNavigation).WithMany(p => p.ניירs)
                .HasForeignKey(d => d.הצמהזמנה)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_נייר_הצעת_מחיר_הזמנה");

            entity.HasOne(d => d.ספקNavigation).WithMany(p => p.ניירs)
                .HasForeignKey(d => d.ספק)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_נייר_ספקים");
        });

        modelBuilder.Entity<סימניה>(entity =>
        {
            entity.HasKey(e => e.מזהה).HasName("PK__סימניה__02473CB31BE0B374");

            entity.ToTable("סימניה");

            entity.Property(e => e.הערה).HasMaxLength(255);
            entity.Property(e => e.הערהלפקע)
                .HasMaxLength(255)
                .HasColumnName("הערה_לפקע");
            entity.Property(e => e.הצמהזמנה).HasColumnName("הצמ_הזמנה");
            entity.Property(e => e.יישום).HasMaxLength(50);
            entity.Property(e => e.יצירתרשומה)
                .HasColumnType("datetime")
                .HasColumnName("יצירת_רשומה");
            entity.Property(e => e.מחיר).HasColumnType("money");
            entity.Property(e => e.סוגוצבע)
                .HasMaxLength(50)
                .HasColumnName("סוג_וצבע");
            entity.Property(e => e.פקע).HasMaxLength(10);
            entity.Property(e => e.פריט).HasMaxLength(50);

            entity.HasOne(d => d.הצמהזמנהNavigation).WithMany(p => p.סימניהs)
                .HasForeignKey(d => d.הצמהזמנה)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_סימניה_הצעת_מחיר_הזמנה");

            entity.HasOne(d => d.ספקNavigation).WithMany(p => p.סימניהs)
                .HasForeignKey(d => d.ספק)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_סימניה_ספקיםם");
        });

        modelBuilder.Entity<ספקים>(entity =>
        {
            entity.HasKey(e => e.מזהה);

            entity.ToTable("ספקים");

            entity.Property(e => e.ספק).HasMaxLength(50);
        });

        modelBuilder.Entity<עטיפה>(entity =>
        {
            entity.HasKey(e => e.מזהה).HasName("PK__עטיפה__02473CB3631D1E73");

            entity.ToTable("עטיפה");

            entity.Property(e => e.הערהלפקע).HasColumnName("הערה_לפקע");
            entity.Property(e => e.הצמהזמנה).HasColumnName("הצמ_הזמנה");
            entity.Property(e => e.יישום).HasMaxLength(255);
            entity.Property(e => e.למינציה).HasMaxLength(50);
            entity.Property(e => e.מחיר)
                .HasDefaultValue(0m)
                .HasColumnType("money");
            entity.Property(e => e.סוגנייר)
                .HasMaxLength(50)
                .HasColumnName("סוג_נייר");
            entity.Property(e => e.עותקים).HasDefaultValue(1);
            entity.Property(e => e.פקע).HasMaxLength(50);
            entity.Property(e => e.פריט).HasMaxLength(100);
            entity.Property(e => e.צבע).HasMaxLength(50);
            entity.Property(e => e.תאריךיצירתרשומה)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("תאריך_יצירת_רשומה");

            entity.HasOne(d => d.הצמהזמנהNavigation).WithMany(p => p.עטיפהs)
                .HasForeignKey(d => d.הצמהזמנה)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_עטיפה_הצעת_מחיר_הזמנה");

            entity.HasOne(d => d.ספקNavigation).WithMany(p => p.עטיפהs)
                .HasForeignKey(d => d.ספק)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_עטיפה_ספקים");
        });

        modelBuilder.Entity<פורזץ>(entity =>
        {
            entity.HasKey(e => e.מזהה).HasName("PK__פורזץ__02473CB3AD2316D6");

            entity.ToTable("פורזץ");

            entity.Property(e => e.אחורי).HasDefaultValue(true);
            entity.Property(e => e.גודלנייר)
                .HasMaxLength(50)
                .HasColumnName("גודל_נייר");
            entity.Property(e => e.הערהלפקע).HasColumnName("הערה_לפקע");
            entity.Property(e => e.הצמהזמנה).HasColumnName("הצמ_הזמנה");
            entity.Property(e => e.יישום).HasMaxLength(255);
            entity.Property(e => e.מחיר)
                .HasDefaultValue(0m)
                .HasColumnType("money");
            entity.Property(e => e.סוגנייר)
                .HasMaxLength(50)
                .HasColumnName("סוג_נייר");
            entity.Property(e => e.עותקים).HasDefaultValue(1);
            entity.Property(e => e.פקע).HasMaxLength(50);
            entity.Property(e => e.פריט).HasMaxLength(100);
            entity.Property(e => e.צבע).HasMaxLength(50);
            entity.Property(e => e.קדמי).HasDefaultValue(true);
            entity.Property(e => e.תאריךיצירתרשומה)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("תאריך_יצירת_רשומה");

            entity.HasOne(d => d.הצמהזמנהNavigation).WithMany(p => p.פורזץs)
                .HasForeignKey(d => d.הצמהזמנה)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_פורזץ_הצעת_מחיר_הזמנה");

            entity.HasOne(d => d.ספקNavigation).WithMany(p => p.פורזץs)
                .HasForeignKey(d => d.ספק)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_פורזץ_ספקים");
        });

        modelBuilder.Entity<פרויקטים>(entity =>
        {
            entity.HasKey(e => e.מזהה).HasName("PK__פרויקטים__02473CB3D7699379");

            entity.ToTable("פרויקטים");

            entity.Property(e => e.כרך).HasMaxLength(50);
            entity.Property(e => e.מהדורה).HasMaxLength(50);
            entity.Property(e => e.מזההלקוח).HasColumnName("מזהה_לקוח");
            entity.Property(e => e.סטטוספרויקט)
                .HasMaxLength(50)
                .HasColumnName("סטטוס_פרויקט");
            entity.Property(e => e.שםפרויקט)
                .HasMaxLength(100)
                .HasColumnName("שם_פרויקט");
            entity.Property(e => e.תאריךיצירתרשומה)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("תאריך_יצירת_רשומה");

            entity.HasOne(d => d.מזההלקוחNavigation).WithMany(p => p.פרויקטיםs)
                .HasForeignKey(d => d.מזההלקוח)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__פרויקטים__מזהה_ל__7E37BEF6");
        });

        modelBuilder.Entity<צבע>(entity =>
        {
            entity.HasKey(e => e.מזהה).HasName("PK__צבע__02473CB35E311C37");

            entity.ToTable("צבע");

            entity.Property(e => e.הערה).HasMaxLength(255);
            entity.Property(e => e.הערהלפקע)
                .HasMaxLength(255)
                .HasColumnName("הערה_לפקע");
            entity.Property(e => e.הצמהזמנה).HasColumnName("הצמ_הזמנה");
            entity.Property(e => e.יישום).HasMaxLength(50);
            entity.Property(e => e.מחיר).HasDefaultValue(0);
            entity.Property(e => e.עותקים).HasDefaultValue(0);
            entity.Property(e => e.פקע).HasMaxLength(10);
            entity.Property(e => e.פריט).HasDefaultValueSql("((0))");
            entity.Property(e => e.צבע1)
                .HasMaxLength(50)
                .HasColumnName("צבע");
            entity.Property(e => e.תאריךיצירתרשומה)
                .HasColumnType("datetime")
                .HasColumnName("תאריך_יצירת_רשומה");

            entity.HasOne(d => d.הצמהזמנהNavigation).WithMany(p => p.צבעs)
                .HasForeignKey(d => d.הצמהזמנה)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_צבע_הצעת_מחיר_הזמנה");

            entity.HasOne(d => d.ספקNavigation).WithMany(p => p.צבעs)
                .HasForeignKey(d => d.ספק)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_צבע_ספקים");
        });

        modelBuilder.Entity<ציפויכריכהקשה>(entity =>
        {
            entity.HasKey(e => e.מזהה).HasName("PK__ציפוי_כר__02473CB352E1B2EF");

            entity.ToTable("ציפוי_כריכה_קשה");

            entity.Property(e => e.הערהלפקע).HasColumnName("הערה_לפקע");
            entity.Property(e => e.הצמהזמנה).HasColumnName("הצמ_הזמנה");
            entity.Property(e => e.יישום).HasMaxLength(255);
            entity.Property(e => e.מחיר).HasColumnType("money");
            entity.Property(e => e.מקטסקאי)
                .HasMaxLength(255)
                .HasColumnName("מקט_סקאי");
            entity.Property(e => e.עותקים).HasDefaultValue(0);
            entity.Property(e => e.פקע).HasMaxLength(50);
            entity.Property(e => e.פריט).HasMaxLength(100);
            entity.Property(e => e.תאריךיצירתרשומה)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("תאריך_יצירת_רשומה");

            entity.HasOne(d => d.הצמהזמנהNavigation).WithMany(p => p.ציפויכריכהקשהs)
                .HasForeignKey(d => d.הצמהזמנה)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ציפוי_כריכה_קשה_הצעת_מחיר_הזמנה");

            entity.HasOne(d => d.ספקNavigation).WithMany(p => p.ציפויכריכהקשהs)
                .HasForeignKey(d => d.ספק)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ציפוי_כריכה_קשה_ספקים");
        });

        modelBuilder.Entity<קאת>(entity =>
        {
            entity.HasKey(e => e.מזהה).HasName("PK__קאת__02473CB3E2608F33");

            entity.ToTable("קאת");

            entity.Property(e => e.הערהלפקע).HasColumnName("הערה_לפקע");
            entity.Property(e => e.הצמהזמנה).HasColumnName("הצמ_הזמנה");
            entity.Property(e => e.חצאים).HasDefaultValue(false);
            entity.Property(e => e.יישום).HasMaxLength(255);
            entity.Property(e => e.מחיר).HasColumnType("money");
            entity.Property(e => e.עותקים).HasDefaultValue(0);
            entity.Property(e => e.עמודים).HasDefaultValue(0);
            entity.Property(e => e.עמודיםבצד).HasColumnName("עמודים_בצד");
            entity.Property(e => e.פקע).HasMaxLength(50);
            entity.Property(e => e.פריט).HasMaxLength(100);
            entity.Property(e => e.תאריךיצירתרשומה)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("תאריך_יצירת_רשומה");

            entity.HasOne(d => d.הצמהזמנהNavigation).WithMany(p => p.קאתs)
                .HasForeignKey(d => d.הצמהזמנה)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_קאת_הצעת_מחיר_הזמנה");

            entity.HasOne(d => d.ספקNavigation).WithMany(p => p.קאתs)
                .HasForeignKey(d => d.ספק)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_קאת_ספקים");
        });

        modelBuilder.Entity<קופסאסט>(entity =>
        {
            entity.HasKey(e => e.מזהה).HasName("PK__קופסא_סט__02473CB34E6BE321");

            entity.ToTable("קופסא_סט");

            entity.Property(e => e.הערה).HasMaxLength(255);
            entity.Property(e => e.הערהלפקע)
                .HasMaxLength(255)
                .HasColumnName("הערה_לפקע");
            entity.Property(e => e.הצמהזמנה).HasColumnName("הצמ_הזמנה");
            entity.Property(e => e.יישום).HasMaxLength(50);
            entity.Property(e => e.יצירתרשומה)
                .HasColumnType("datetime")
                .HasColumnName("יצירת_רשומה");
            entity.Property(e => e.מחיר)
                .HasDefaultValue(0m)
                .HasColumnType("money");
            entity.Property(e => e.מחירפתיחתקופסא)
                .HasDefaultValue(0.5m)
                .HasColumnType("money")
                .HasColumnName("מחיר_פתיחת_קופסא");
            entity.Property(e => e.סוג).HasMaxLength(50);
            entity.Property(e => e.פקע).HasMaxLength(10);

            entity.HasOne(d => d.הצמהזמנהNavigation).WithMany(p => p.קופסאסטs)
                .HasForeignKey(d => d.הצמהזמנה)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_קופסא_סט_הצעת_מחיר_הזמנה");

            entity.HasOne(d => d.ספקNavigation).WithMany(p => p.קופסאסטs)
                .HasForeignKey(d => d.ספק)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_קופסא_סט_ספקים");
        });

        modelBuilder.Entity<קרטוןכריכהקשה>(entity =>
        {
            entity.HasKey(e => e.מזהה).HasName("PK__קרטון_כר__02473CB3046BB704");

            entity.ToTable("קרטון_כריכה_קשה");

            entity.Property(e => e.גודל).HasMaxLength(100);
            entity.Property(e => e.הערהלפקע).HasColumnName("הערה_לפקע");
            entity.Property(e => e.הצמהזמנה).HasColumnName("הצמ_הזמנה");
            entity.Property(e => e.יישום).HasMaxLength(255);
            entity.Property(e => e.מחיר).HasColumnType("money");
            entity.Property(e => e.עותקים).HasDefaultValue(0);
            entity.Property(e => e.פקע).HasMaxLength(50);
            entity.Property(e => e.פריט).HasMaxLength(100);
            entity.Property(e => e.תאריךיצירתרשומה)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("תאריך_יצירת_רשומה");

            entity.HasOne(d => d.הצמהזמנהNavigation).WithMany(p => p.קרטוןכריכהקשהs)
                .HasForeignKey(d => d.הצמהזמנה)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_קרטון_כריכה_קשה_הצעת_מחיר_הזמנה");

            entity.HasOne(d => d.ספקNavigation).WithMany(p => p.קרטוןכריכהקשהs)
                .HasForeignKey(d => d.ספק)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_קרטון_כריכה_קשה_ספקים");
        });

        modelBuilder.Entity<שונות>(entity =>
        {
            entity.HasKey(e => e.מזהה).HasName("PK__שונות__02473CB3124D2344");

            entity.ToTable("שונות");

            entity.Property(e => e.הערהלפקע).HasColumnName("הערה_לפקע");
            entity.Property(e => e.הצמהזמנה).HasColumnName("הצמ_הזמנה");
            entity.Property(e => e.יישום).HasMaxLength(255);
            entity.Property(e => e.כמות).HasDefaultValue(1);
            entity.Property(e => e.מחיר).HasColumnType("money");
            entity.Property(e => e.פקע).HasMaxLength(50);
            entity.Property(e => e.פריט).HasMaxLength(100);
            entity.Property(e => e.תאריךיצירתרשומה)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("תאריך_יצירת_רשומה");

            entity.HasOne(d => d.הצמהזמנהNavigation).WithMany(p => p.שונותs)
                .HasForeignKey(d => d.הצמהזמנה)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_שונות_הצעת_מחיר_הזמנה");

            entity.HasOne(d => d.ספקNavigation).WithMany(p => p.שונותs)
                .HasForeignKey(d => d.ספק)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_שונות_ספקים");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
