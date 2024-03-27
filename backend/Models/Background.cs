using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace rollandplayAPI.Models;

[Table("Background")]
public partial class Background
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [Column("name")]
    [StringLength(50)]
    public string? Name { get; set; }

    [Column("equipment")]
    [StringLength(50)]
    public string? Equipment { get; set; }

    [Column("languages_qty")]
    public int? LanguagesQty { get; set; }

    [Column("feature")]
    [StringLength(200)]
    public string? Feature { get; set; }

    [InverseProperty("Background")]
    public virtual ICollection<BackgroundProficiency> BackgroundProficiencies { get; set; } = new List<BackgroundProficiency>();
}
