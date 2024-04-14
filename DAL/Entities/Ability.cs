using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class Ability : HardcodeDirectory
    {
        public virtual ICollection<Skill> Skills { get; } = new List<Skill>();
        public virtual ICollection<AbilityList> AbilityLists { get; } = new List<AbilityList>();
        public virtual ICollection<BeastNote> BeastNotes { get; } = new List<BeastNote>();
        public virtual ICollection<TemporaryAbilityList> TemporaryAbilityLists { get; } = new List<TemporaryAbilityList>();
    }
}
