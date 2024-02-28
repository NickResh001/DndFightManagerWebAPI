using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class SpellSlotListDTO
    {
        public SpellSlotListDTO() { }
        public SpellSlotListDTO(SpellSlotsList spellSlotList)
        {
            Id = spellSlotList.Id;
            BeastId = spellSlotList.BeastId;
            Level = spellSlotList.Level;
            CountAvailable = spellSlotList.CountAvailable;
        }
        public string Id { get; set; } = null!;
        public string BeastId { get; set; } = null!;
        public int Level { get; set; }
        public int CountAvailable { get; set; }
    }
}
