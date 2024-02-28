using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class AbilityDTO
    {
        public AbilityDTO() { }
        public AbilityDTO(Ability ability)
        {
            Id = ability.Id;
            Title = ability.Title;
        }
        public string Id { get; set; } = null!;
        public string Title { get; set; } = null!;
    }
}
