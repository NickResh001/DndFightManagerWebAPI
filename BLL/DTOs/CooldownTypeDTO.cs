using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class CooldownTypeDTO
    {
        public CooldownTypeDTO() { }
        public CooldownTypeDTO(CooldownType cooldownType)
        {
            Id = cooldownType.Id;
            Title = cooldownType.Title;
        }
        public string Id { get; set; } = null!;
        public string Title { get; set; } = null!;
    }
}
