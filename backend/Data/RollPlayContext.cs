using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using rollandplayAPI.Models;

namespace rollandplayAPI.Data;

public partial class RollPlayContext : DbContext
{
    public RollPlayContext()
    {
    }

    public RollPlayContext(DbContextOptions<RollPlayContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Ability> Abilities { get; set; }

    public virtual DbSet<Armor> Armors { get; set; }

    public virtual DbSet<ArmorType> ArmorTypes { get; set; }

    public virtual DbSet<Background> Backgrounds { get; set; }

    public virtual DbSet<BackgroundProficiency> BackgroundProficiencies { get; set; }

    public virtual DbSet<Class> Classes { get; set; }

    public virtual DbSet<ClassFeature> ClassFeatures { get; set; }

    public virtual DbSet<ClassProficiency> ClassProficiencies { get; set; }

    public virtual DbSet<ClassSkillPool> ClassSkillPools { get; set; }

    public virtual DbSet<ClassSpell> ClassSpells { get; set; }

    public virtual DbSet<Language> Languages { get; set; }

    public virtual DbSet<OptionalFeature> OptionalFeatures { get; set; }

    public virtual DbSet<Race> Races { get; set; }

    public virtual DbSet<RacialAbility> RacialAbilities { get; set; }

    public virtual DbSet<RacialFeat> RacialFeats { get; set; }

    public virtual DbSet<RacialLanguage> RacialLanguages { get; set; }

    public virtual DbSet<Skill> Skills { get; set; }

    public virtual DbSet<Spell> Spells { get; set; }

    public virtual DbSet<Tool> Tools { get; set; }

    public virtual DbSet<Weapon> Weapons { get; set; }

    public virtual DbSet<WeaponRange> WeaponRanges { get; set; }

    public virtual DbSet<WeaponType> WeaponTypes { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=localhost,1433;Initial Catalog=Roll_play;User ID=sa;Password=65823_jm;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Ability>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Abilitie__3213E83FF594F056");

            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<Armor>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Armor__3213E83FA610FB08");

            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.HasOne(d => d.TypeNavigation).WithMany(p => p.Armors).HasConstraintName("FK__Armor__type__70DDC3D8");
        });

        modelBuilder.Entity<ArmorType>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Armor_ty__3213E83F5F6E85CE");

            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<Background>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Backgrou__3213E83F9CC12F2D");

            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<BackgroundProficiency>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Backgrou__3213E83F97E0D315");

            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.HasOne(d => d.Background).WithMany(p => p.BackgroundProficiencies).HasConstraintName("FK__Backgroun__backg__693CA210");

            entity.HasOne(d => d.Skill).WithMany(p => p.BackgroundProficiencies).HasConstraintName("FK__Backgroun__skill__68487DD7");

            entity.HasOne(d => d.Tool).WithMany(p => p.BackgroundProficiencies).HasConstraintName("FK__Backgroun__tool___6754599E");
        });

        modelBuilder.Entity<Class>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Class__3213E83F6F0C97CF");

            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.HasOne(d => d.SavingThrow1Navigation).WithMany(p => p.ClassSavingThrow1Navigations).HasConstraintName("FK__Class__saving_th__5FB337D6");

            entity.HasOne(d => d.SavingThrow2Navigation).WithMany(p => p.ClassSavingThrow2Navigations).HasConstraintName("FK__Class__saving_th__60A75C0F");
        });

        modelBuilder.Entity<ClassFeature>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Class_fe__3213E83FC40F58CD");

            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<ClassProficiency>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Class_pr__3213E83F76232A47");

            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.HasOne(d => d.Armor).WithMany(p => p.ClassProficiencies).HasConstraintName("FK__Class_pro__armor__72C60C4A");

            entity.HasOne(d => d.Class).WithMany(p => p.ClassProficiencies).HasConstraintName("FK__Class_pro__class__71D1E811");
        });

        modelBuilder.Entity<ClassSkillPool>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Class_sk__3213E83F8DD5EEFA");

            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.HasOne(d => d.Class).WithMany(p => p.ClassSkillPools).HasConstraintName("FK__Class_ski__class__6A30C649");

            entity.HasOne(d => d.Skill).WithMany(p => p.ClassSkillPools).HasConstraintName("FK__Class_ski__skill__76969D2E");
        });

        modelBuilder.Entity<ClassSpell>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Class_sp__3213E83F4ED6E91C");

            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<Language>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Language__3213E83F49B6BDC6");

            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<OptionalFeature>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Optional__3213E83F62F43221");

            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<Race>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Race__3213E83F89391E1F");

            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<RacialAbility>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Racial_a__3213E83F4604980D");

            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.HasOne(d => d.Ability1Navigation).WithMany(p => p.RacialAbilityAbility1Navigations).HasConstraintName("FK__Racial_ab__abili__628FA481");

            entity.HasOne(d => d.Ability2Navigation).WithMany(p => p.RacialAbilityAbility2Navigations).HasConstraintName("FK__Racial_ab__abili__6383C8BA");

            entity.HasOne(d => d.Race).WithMany(p => p.RacialAbilities).HasConstraintName("FK__Racial_ab__race___619B8048");
        });

        modelBuilder.Entity<RacialFeat>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Racial_f__3213E83FFFDBFC39");

            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.HasOne(d => d.Race).WithMany(p => p.RacialFeats).HasConstraintName("FK__Racial_fe__race___66603565");
        });

        modelBuilder.Entity<RacialLanguage>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Racial_l__3213E83FE07DC4DA");

            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.HasOne(d => d.Language).WithMany(p => p.RacialLanguages).HasConstraintName("FK__Racial_la__langu__6477ECF3");

            entity.HasOne(d => d.Race).WithMany(p => p.RacialLanguages).HasConstraintName("FK__Racial_la__race___656C112C");
        });

        modelBuilder.Entity<Skill>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Skills__3213E83F26467F54");

            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<Spell>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Spells__3213E83FEE7562AD");

            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<Tool>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Tools__3213E83F8AC5BFE5");

            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<Weapon>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Weapon__3213E83F081B5AAE");

            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.HasOne(d => d.RangeNavigation).WithMany(p => p.Weapons).HasConstraintName("FK__Weapon__range__6FE99F9F");

            entity.HasOne(d => d.TypeNavigation).WithMany(p => p.Weapons).HasConstraintName("FK__Weapon__type__6EF57B66");
        });

        modelBuilder.Entity<WeaponRange>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Weapon_r__3213E83F1115863B");

            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<WeaponType>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Weapon_t__3213E83F4151A716");

            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
