using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace rollandplayAPI.Models;

[Table("Optional_features")]
public partial class OptionalFeature
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [Column("name")]
    [StringLength(50)]
    public string? Name { get; set; }

    [Column("prerequisite")]
    [StringLength(50)]
    public string? Prerequisite { get; set; }

    [Column("type")]
    [StringLength(50)]
    public string? Type { get; set; }

    [Column("level")]
    public int? Level { get; set; }

    [Column("feature_id")]
    public int? FeatureId { get; set; }
}
