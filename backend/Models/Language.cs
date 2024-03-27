using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace rollandplayAPI.Models;

public partial class Language
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [Column("name")]
    [StringLength(50)]
    public string? Name { get; set; }

    [InverseProperty("Language")]
    public virtual ICollection<RacialLanguage> RacialLanguages { get; set; } = new List<RacialLanguage>();
}
