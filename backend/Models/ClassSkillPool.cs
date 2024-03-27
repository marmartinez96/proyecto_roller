using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace rollandplayAPI.Models;

[Table("Class_skill_pool")]
public partial class ClassSkillPool
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [Column("class_id")]
    public int? ClassId { get; set; }

    [Column("skill_id")]
    public int? SkillId { get; set; }

    [ForeignKey("ClassId")]
    [InverseProperty("ClassSkillPools")]
    public virtual Class? Class { get; set; }

    [ForeignKey("SkillId")]
    [InverseProperty("ClassSkillPools")]
    public virtual Skill? Skill { get; set; }
}
