using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace rollandplayAPI.Models;

[Table("Race")]
public partial class Race
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [Column("speed")]
    public int? Speed { get; set; }

    [Column("size")]
    [StringLength(50)]
    public string? Size { get; set; }

    [InverseProperty("Race")]
    public virtual ICollection<RacialAbility> RacialAbilities { get; set; } = new List<RacialAbility>();

    [InverseProperty("Race")]
    public virtual ICollection<RacialFeat> RacialFeats { get; set; } = new List<RacialFeat>();

    [InverseProperty("Race")]
    public virtual ICollection<RacialLanguage> RacialLanguages { get; set; } = new List<RacialLanguage>();
}
