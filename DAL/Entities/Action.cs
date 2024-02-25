using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class Action
    {
        [Key]
        public string Id { get; set; } = null!;
        public string CooldownTypeId { get; set; } = null!;
        public string ActionResourceId { get; set; } = null!;
        public string BeastNoteId { get; set; } = null!;
        public string? Cooldown3_TimeMeasureId { get; set; }
        public string? ParentMultiactionId { get; set; }

        public string Title { get; set; } = null!;
        public int? Cooldown1_SpellSlotLevel { get; set; }
        public int? Cooldown2_LowerRangeLimit { get; set; }
        public int? Cooldown2_UpperRangeLimit { get; set; }
        public int? Cooldown2_DiceSize { get; set; }
        public int? Cooldown3_HowManyTimes { get; set; }
        public int? Cooldown3_MeasureMultiply { get; set; }
        public string? Reaction_Condition { get; set; }
        public int? Lair_InitiativeBonus { get; set; }
        public string Description { get; set; } = null!;
        public bool IsTemplate { get; set; }

        public virtual CooldownType CooldownType { get; set; } = null!;
        public virtual ActionResource ActionResource { get; set; } = null!;
        public virtual BeastNote BeastNote { get; set; } = null!; 
        public virtual TimeMeasure? Cooldown3_TimeMeasure { get; set; }
        public virtual Action? ParentMultiaction { get; set; }

        public virtual ICollection<Action> ChildActions { get; } = new List<Action>();
        public virtual ICollection<ActionThrow> ActionThrows { get; } = new List<ActionThrow>();

    }
}
