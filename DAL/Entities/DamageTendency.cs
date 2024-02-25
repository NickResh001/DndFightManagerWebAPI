using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class DamageTendency
    {
        [Key]
        public string Id { get; set; } = null!;
        public string DamageTypeId { get; set; } = null!;
        public string DamageTendencyTypeId { get; set; } = null!;
        public string BeastNoteId { get; set; } = null!;
        public bool Magical { get; set; }
        public bool NonMagical { get; set; }

        public virtual DamageType DamageType { get; set; } = null!;
        public virtual DamageTendencyType DamageTendencyType { get; set; } = null!;
        public virtual BeastNote BeastNote { get; set; } = null!;
    }
}
