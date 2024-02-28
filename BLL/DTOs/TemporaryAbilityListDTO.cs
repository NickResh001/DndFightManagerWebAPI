using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class TemporaryAbilityListDTO
    {
        public TemporaryAbilityListDTO() { }
        public TemporaryAbilityListDTO(TemporaryAbilityList temporaryAbilityList)
        {
            Id = temporaryAbilityList.Id;
            BeastId = temporaryAbilityList.BeastId;
            AbilityId = temporaryAbilityList.AbilityId;
            Value = temporaryAbilityList.Value;
            SavingThrowProficiency = temporaryAbilityList.SavingThrowProficiency;
        }
        public string Id { get; set; } = null!;
        public string BeastId { get; set; } = null!;
        public string AbilityId { get; set; } = null!;
        public int Value { get; set; }
        public bool SavingThrowProficiency { get; set; }
    }
}
