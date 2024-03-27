using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace rollandplayAPI.Models;

public partial class Skill
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [Column("name")]
    [StringLength(50)]
    public string? Name { get; set; }

    [InverseProperty("Skill")]
    public virtual ICollection<BackgroundProficiency> BackgroundProficiencies { get; set; } = new List<BackgroundProficiency>();

    [InverseProperty("Skill")]
    public virtual ICollection<ClassSkillPool> ClassSkillPools { get; set; } = new List<ClassSkillPool>();
}
