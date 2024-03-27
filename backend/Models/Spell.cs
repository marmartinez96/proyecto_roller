using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace rollandplayAPI.Models;

public partial class Spell
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [Column("name")]
    [StringLength(50)]
    public string? Name { get; set; }

    [Column("casting_time")]
    [StringLength(50)]
    public string? CastingTime { get; set; }

    [Column("range")]
    public int? Range { get; set; }

    [Column("components")]
    [StringLength(50)]
    public string? Components { get; set; }

    [Column("duration")]
    [StringLength(50)]
    public string? Duration { get; set; }

    [Column("school")]
    [StringLength(50)]
    public string? School { get; set; }

    [Column("is_concentration")]
    public byte? IsConcentration { get; set; }
}
