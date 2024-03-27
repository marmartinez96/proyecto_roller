using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace rollandplayAPI.Models;

[Table("Racial_languages")]
public partial class RacialLanguage
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [Column("language_id")]
    public int? LanguageId { get; set; }

    [Column("race_id")]
    public int? RaceId { get; set; }

    [ForeignKey("LanguageId")]
    [InverseProperty("RacialLanguages")]
    public virtual Language? Language { get; set; }

    [ForeignKey("RaceId")]
    [InverseProperty("RacialLanguages")]
    public virtual Race? Race { get; set; }
}
