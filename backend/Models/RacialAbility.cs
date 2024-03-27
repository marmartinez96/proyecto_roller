using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace rollandplayAPI.Models;

[Table("Racial_abilities")]
public partial class RacialAbility
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [Column("race_id")]
    public int? RaceId { get; set; }

    [Column("ability_1")]
    public int? Ability1 { get; set; }

    [Column("ability_2")]
    public int? Ability2 { get; set; }

    [ForeignKey("Ability1")]
    [InverseProperty("RacialAbilityAbility1Navigations")]
    public virtual Ability? Ability1Navigation { get; set; }

    [ForeignKey("Ability2")]
    [InverseProperty("RacialAbilityAbility2Navigations")]
    public virtual Ability? Ability2Navigation { get; set; }

    [ForeignKey("RaceId")]
    [InverseProperty("RacialAbilities")]
    public virtual Race? Race { get; set; }
}
