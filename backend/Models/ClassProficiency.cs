using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace rollandplayAPI.Models;

[Table("Class_proficiencies")]
public partial class ClassProficiency
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [Column("class_id")]
    public int? ClassId { get; set; }

    [Column("armor_id")]
    public int? ArmorId { get; set; }

    [Column("weapon_type_id")]
    public int? WeaponTypeId { get; set; }

    [Column("single_weapon")]
    public int? SingleWeapon { get; set; }

    [ForeignKey("ArmorId")]
    [InverseProperty("ClassProficiencies")]
    public virtual ArmorType? Armor { get; set; }

    [ForeignKey("ClassId")]
    [InverseProperty("ClassProficiencies")]
    public virtual Class? Class { get; set; }
}
