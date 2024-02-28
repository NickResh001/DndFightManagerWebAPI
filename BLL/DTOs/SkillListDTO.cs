using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class SkillListDTO
    {
        public SkillListDTO() { }
        public SkillListDTO(SkillList skillList)
        {
            Id = skillList.Id;
            SkillId = skillList.SkillId;
            BeastNoteId = skillList.BeastNoteId;
            Value = skillList.Value;
            Proficiency = skillList.Proficiency;
        }
        public string Id { get; set; } = null!;
        public string SkillId { get; set; } = null!;
        public string BeastNoteId { get; set; } = null!;
        public int Value { get; set; }
        public bool Proficiency { get; set; }
    }
}
