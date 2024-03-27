using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace rollandplayAPI.Models;

public partial class Ability
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [Column("name")]
    [StringLength(50)]
    public string? Name { get; set; }

    [InverseProperty("SavingThrow1Navigation")]
    public virtual ICollection<Class> ClassSavingThrow1Navigations { get; set; } = new List<Class>();

    [InverseProperty("SavingThrow2Navigation")]
    public virtual ICollection<Class> ClassSavingThrow2Navigations { get; set; } = new List<Class>();

    [InverseProperty("Ability1Navigation")]
    public virtual ICollection<RacialAbility> RacialAbilityAbility1Navigations { get; set; } = new List<RacialAbility>();

    [InverseProperty("Ability2Navigation")]
    public virtual ICollection<RacialAbility> RacialAbilityAbility2Navigations { get; set; } = new List<RacialAbility>();
}
