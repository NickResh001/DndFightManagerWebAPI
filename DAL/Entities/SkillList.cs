using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class SkillList
    {
        [Key]
        public string Id { get; set; } = null!;
        public string SkillId { get; set; } = null!;
        public string BeastNoteId { get; set; } = null!;
        public int Value { get; set; }
        public bool Proficiency { get; set; }


        public virtual Skill Skill { get; set; } = null!;
        public virtual BeastNote BeastNote { get; set; } = null!;
    }
}
