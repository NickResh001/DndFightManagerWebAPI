using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class ConditionImmunitiesList
    {
        [Key]
        public string Id { get; set; } = null!;
        public string ConditionId { get; set; } = null!;
        public string BeastNoteId { get; set; } = null!;


        public virtual Condition Condition { get; set; } = null!;
        public virtual BeastNote BeastNote { get; set; } = null!;
    }
}
