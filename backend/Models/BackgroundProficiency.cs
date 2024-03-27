using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace rollandplayAPI.Models;

[Table("Background_proficiencies")]
public partial class BackgroundProficiency
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [Column("tool_id")]
    public int? ToolId { get; set; }

    [Column("skill_id")]
    public int? SkillId { get; set; }

    [Column("background_id")]
    public int? BackgroundId { get; set; }

    [ForeignKey("BackgroundId")]
    [InverseProperty("BackgroundProficiencies")]
    public virtual Background? Background { get; set; }

    [ForeignKey("SkillId")]
    [InverseProperty("BackgroundProficiencies")]
    public virtual Skill? Skill { get; set; }

    [ForeignKey("ToolId")]
    [InverseProperty("BackgroundProficiencies")]
    public virtual Tool? Tool { get; set; }
}
