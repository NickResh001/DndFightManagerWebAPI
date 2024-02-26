using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class SpellSlotsList
    {
        [Key]
        public string Id { get; set; } = null!;
        public string BeastId { get; set; } = null!;
        public int Level { get; set; }
        public int CountAvailable { get; set; }

        public Beast Beast { get; set; } = null!;
    }
}
