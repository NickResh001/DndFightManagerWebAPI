using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class SpellSlotDTO
    {
        public SpellSlotDTO() { }
        public SpellSlotDTO(SpellSlot spellSlot)
        {
            Id = spellSlot.Id;
            BeastNoteId = spellSlot.BeastNoteId;
            Level = spellSlot.Level;
            Count = spellSlot.Count;
        }
        public string Id { get; set; } = null!;
        public string BeastNoteId { get; set; } = null!;
        public int Level { get; set; }
        public int Count { get; set; }
    }
}
