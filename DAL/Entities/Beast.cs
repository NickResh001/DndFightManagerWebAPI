using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class Beast
    {
        [Key]
        public string Id { get; set; } = null!;
        public string SceneSaveId { get; set; } = null!;
        public string FightTeamId { get; set; } = null!;
        public string BeastNoteId { get; set; } = null!;
        public string Title { get; set; } = null!;
        public string CurrentInitiative { get; set; } = null!;
        public int CurrentArmorClass { get; set; }
        public int MaxHitPoints { get; set; }
        public int CurrentHitPoints { get; set; }
        public int TemporaryHitPoints { get; set; }
        public bool IsSuprised { get; set; }

        public SceneSave SceneSave { get; set; } = null!;
        public FightTeam FightTeam { get; set; } = null!;
        public BeastNote BeastNote { get; set; } = null!;

        public virtual ICollection<TemporaryAbilityList> TemporaryAbilityLists { get; } = new List<TemporaryAbilityList>();
        public virtual ICollection<ConditionList> ConditionLists { get; } = new List<ConditionList>();
        public virtual ICollection<ActionResourceList> ActionResourceLists { get; } = new List<ActionResourceList>();
        public virtual ICollection<SpellSlotsList> SpellSlotsLists { get; } = new List<SpellSlotsList>();
        public virtual ICollection<Thing> Things { get; } = new List<Thing>();

    }
}
