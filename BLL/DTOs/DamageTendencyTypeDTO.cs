using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class DamageTendencyTypeDTO
    {
        public DamageTendencyTypeDTO() { }
        public DamageTendencyTypeDTO(DamageTendencyType damageTendency)
        {
            Id = damageTendency.Id;
            Title = damageTendency.Title;
        }
        public string Id { get; set; } = null!;
        public string Title { get; set; } = null!;
    }
}
