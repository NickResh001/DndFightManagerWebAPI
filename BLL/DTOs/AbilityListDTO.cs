using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class AbilityListDTO
    {
        public AbilityListDTO() { }
        public AbilityListDTO(AbilityList abilityList)
        {
            Id = abilityList.Id;
            AbilityId = abilityList.AbilityId;
            BeastNoteId = abilityList.BeastNoteId;
            Value = abilityList.Value;
            SavingThrowProficiency = abilityList.SavingThrowProficiency;
        }
        public string Id { get; set; } = null!;
        public string AbilityId { get; set; } = null!;
        public string BeastNoteId { get; set; } = null!;
        public int Value { get; set; }
        public bool SavingThrowProficiency { get; set; }
    }
}
