using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class ConditionDTO
    {
        public ConditionDTO() { }
        public ConditionDTO(Condition condition)
        {
            Id = condition.Id;
            Title = condition.Title;
        }
        public string Id { get; set; } = null!;
        public string Title { get; set; } = null!;
    }
}
