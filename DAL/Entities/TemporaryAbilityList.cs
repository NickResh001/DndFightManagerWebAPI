using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class TemporaryAbilityList
    {
        [Key]
        public string Id { get; set; } = null!;
        public string BeastId { get; set; } = null!;
        public string AbilityId { get; set; } = null!;
        public int Value { get; set; }
        public bool SavingThrowProficiency { get; set; }

        public Beast Beast { get; set; } = null!;
        public Ability Ability { get; set; } = null!;
    }
}
