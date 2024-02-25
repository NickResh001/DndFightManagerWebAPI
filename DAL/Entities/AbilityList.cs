using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class AbilityList
    {
        [Key]
        public string Id { get; set; } = null!;
        public string AbilityId { get; set; } = null!;
        public string BeastNoteId { get; set; } = null!;
        public int Value { get; set; }
        public bool SavingThrowProficiency { get; set; }


        public virtual Ability Ability { get; set; } = null!;
        public virtual BeastNote BeastNote { get; set; } = null!;
    }
}
