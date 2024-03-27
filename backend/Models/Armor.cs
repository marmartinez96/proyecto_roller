using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace rollandplayAPI.Models;

[Table("Armor")]
public partial class Armor
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [Column("name")]
    [StringLength(50)]
    public string? Name { get; set; }

    [Column("armor_class")]
    public int? ArmorClass { get; set; }

    [Column("str_req")]
    public int? StrReq { get; set; }

    [Column("has_stealth_dis")]
    public byte? HasStealthDis { get; set; }

    [Column("type")]
    public int? Type { get; set; }

    [ForeignKey("Type")]
    [InverseProperty("Armors")]
    public virtual ArmorType? TypeNavigation { get; set; }
}
