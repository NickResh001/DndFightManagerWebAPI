using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class ConditionList
    {
        [Key]
        public string Id { get; set; } = null!;
        public string BeastId { get; set; } = null!;
        public string ConditionId { get; set; } = null!;
        public int? RoundCount { get; set; }

        public Beast Beast { get; set; } = null!;
        public Condition Condition { get; set; } = null!;
    }
}
