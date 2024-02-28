using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class SkillDTO
    {
        public SkillDTO() { }
        public SkillDTO(Skill skill)
        {
            Id = skill.Id;
            AbilityId = skill.AbilityId;
            Title = skill.Title;
        }
        public string Id { get; set; } = null!;
        public string AbilityId { get; set; } = null!;
        public string Title { get; set; } = null!;
    }
}
