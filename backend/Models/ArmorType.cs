using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace rollandplayAPI.Models;

[Table("Armor_type")]
public partial class ArmorType
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [Column("name")]
    [StringLength(50)]
    public string? Name { get; set; }

    [InverseProperty("TypeNavigation")]
    public virtual ICollection<Armor> Armors { get; set; } = new List<Armor>();

    [InverseProperty("Armor")]
    public virtual ICollection<ClassProficiency> ClassProficiencies { get; set; } = new List<ClassProficiency>();
}
