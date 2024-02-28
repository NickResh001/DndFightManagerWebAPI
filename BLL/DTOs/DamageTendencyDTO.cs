using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class DamageTendencyDTO
    {
        public DamageTendencyDTO() { }
        public DamageTendencyDTO(DamageTendency damageTendency)
        {
            Id = damageTendency.Id;
            DamageTypeId = damageTendency.DamageTypeId;
            DamageTendencyTypeId = damageTendency.DamageTendencyTypeId;
            BeastNoteId = damageTendency.BeastNoteId;
            Magical = damageTendency.Magical;
            NonMagical = damageTendency.NonMagical;
        }
        public string Id { get; set; } = null!;
        public string DamageTypeId { get; set; } = null!;
        public string DamageTendencyTypeId { get; set; } = null!;
        public string BeastNoteId { get; set; } = null!;
        public bool Magical { get; set; }
        public bool NonMagical { get; set; }
    }
}
