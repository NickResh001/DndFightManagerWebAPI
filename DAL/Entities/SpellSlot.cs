using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class SpellSlot
    {
        [Key]
        public string Id { get; set; } = null!;
        public string BeastNoteId { get; set; } = null!;
        public int Level { get; set; }
        public int Count { get; set; }


        public virtual BeastNote BeastNote { get; set; } = null!;
    }
}
