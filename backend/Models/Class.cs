using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace rollandplayAPI.Models;

[Table("Class")]
public partial class Class
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [Column("name")]
    [StringLength(50)]
    public string? Name { get; set; }

    [Column("level")]
    public int? Level { get; set; }

    [Column("hitdie")]
    public int? Hitdie { get; set; }

    [Column("saving_throw_1")]
    public int? SavingThrow1 { get; set; }

    [Column("saving_throw_2")]
    public int? SavingThrow2 { get; set; }

    [Column("skill_qty")]
    public int? SkillQty { get; set; }

    [Column("is_spellcaster")]
    public byte? IsSpellcaster { get; set; }

    [InverseProperty("Class")]
    public virtual ICollection<ClassProficiency> ClassProficiencies { get; set; } = new List<ClassProficiency>();

    [InverseProperty("Class")]
    public virtual ICollection<ClassSkillPool> ClassSkillPools { get; set; } = new List<ClassSkillPool>();

    [ForeignKey("SavingThrow1")]
    [InverseProperty("ClassSavingThrow1Navigations")]
    public virtual Ability? SavingThrow1Navigation { get; set; }

    [ForeignKey("SavingThrow2")]
    [InverseProperty("ClassSavingThrow2Navigations")]
    public virtual Ability? SavingThrow2Navigation { get; set; }
}
