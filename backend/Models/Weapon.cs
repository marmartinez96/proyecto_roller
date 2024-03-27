using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace rollandplayAPI.Models;

[Table("Weapon")]
public partial class Weapon
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [Column("name")]
    [StringLength(50)]
    public string? Name { get; set; }

    [Column("type")]
    public int? Type { get; set; }

    [Column("range")]
    public int? Range { get; set; }

    [Column("damage")]
    public int? Damage { get; set; }

    [Column("reach")]
    public int? Reach { get; set; }

    [Column("min_range")]
    public int? MinRange { get; set; }

    [Column("max_range")]
    public int? MaxRange { get; set; }

    [ForeignKey("Range")]
    [InverseProperty("Weapons")]
    public virtual WeaponRange? RangeNavigation { get; set; }

    [ForeignKey("Type")]
    [InverseProperty("Weapons")]
    public virtual WeaponType? TypeNavigation { get; set; }
}
