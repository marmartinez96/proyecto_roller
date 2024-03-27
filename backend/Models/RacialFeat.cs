using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace rollandplayAPI.Models;

[Table("Racial_feats")]
public partial class RacialFeat
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [Column("name")]
    [StringLength(50)]
    public string? Name { get; set; }

    [Column("description")]
    [StringLength(50)]
    public string? Description { get; set; }

    [Column("race_id")]
    public int? RaceId { get; set; }

    [ForeignKey("RaceId")]
    [InverseProperty("RacialFeats")]
    public virtual Race? Race { get; set; }
}
