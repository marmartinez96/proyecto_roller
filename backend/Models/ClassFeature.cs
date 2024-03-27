using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace rollandplayAPI.Models;

[Table("Class_features")]
public partial class ClassFeature
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [Column("class_id")]
    public int? ClassId { get; set; }

    [Column("name")]
    [StringLength(50)]
    public string? Name { get; set; }

    [Column("description")]
    [StringLength(50)]
    public string? Description { get; set; }

    [Column("level")]
    public int? Level { get; set; }
}
