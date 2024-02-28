using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class ConditionImmunitiesListDTO
    {
        public ConditionImmunitiesListDTO() { }
        public ConditionImmunitiesListDTO(ConditionImmunitiesList conditionImmunitiesList)
        {
            Id = conditionImmunitiesList.Id;
            ConditionId = conditionImmunitiesList.ConditionId;
            BeastNoteId = conditionImmunitiesList.BeastNoteId;
        }
        public string Id { get; set; } = null!;
        public string ConditionId { get; set; } = null!;
        public string BeastNoteId { get; set; } = null!;
    }
}
