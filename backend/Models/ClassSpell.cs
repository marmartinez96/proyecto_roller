using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace rollandplayAPI.Models;

[Table("Class_spells")]
public partial class ClassSpell
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [Column("class_id")]
    public int? ClassId { get; set; }

    [Column("spell_id")]
    public int? SpellId { get; set; }
}
