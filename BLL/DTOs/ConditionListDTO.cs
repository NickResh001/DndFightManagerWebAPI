using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class ConditionListDTO
    {
        public ConditionListDTO() { }
        public ConditionListDTO(ConditionList conditionList)
        {
            Id = conditionList.Id;
            BeastId = conditionList.BeastId;
            ConditionId = conditionList.ConditionId;
            RoundCount = conditionList.RoundCount;
        }
        public string Id { get; set; } = null!;
        public string BeastId { get; set; } = null!;
        public string ConditionId { get; set; } = null!;
        public int? RoundCount { get; set; }
    }
}
