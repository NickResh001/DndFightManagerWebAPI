using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class BeastNote
    {
        [Key]
        public string Id { get; set; } = null!;
        public string AlignmentId { get; set; } = null!;
        public string SizeId { get; set; } = null!;
        public string BeastTypeId { get; set; } = null!;
        public string AuthorId { get; set; } = null!;
        public string? ModeratorId { get; set; }
        public string? ModeratorComment {  get; set; }
        public string? SpellAbilityId { get; set; }

        public string HitPointsDice { get; set; } = null!;
        public int InitiativeBonus { get; set; }
        public int ArmorClass { get; set; }
        public int SpecialBonus { get; set; }
        public byte[]? Image { get; set; }
        public string Title { get; set; } = null!;
        public int? SpellSaveThrowDifficulty { get; set; }
        public int? SpellAttackBonus { get; set; }
        public int ChallengeRating { get; set; }
        public string Description { get; set; } = null!;

        public DateTime CreationDate { get; set; }
        public DateTime LastEditingDate { get; set; }
        public int AllUses { get; set; }
        public int UniqueUses { get; set; }
        public double UserRating { get; set; }
        public bool IsBeingModerated { get; set; }
        public bool IsPublished { get; set; }

        public virtual Alignment Alignment { get; set; } = null!;
        public virtual Size Size { get; set; } = null!;
        public virtual BeastType BeastType { get; set; } = null!;
        public virtual User Author { get; set; } = null!;
        public virtual User? Moderator { get; set; }
        public virtual Ability? SpellAbility { get; set; }

        public virtual ICollection<SpeedList> SpeedLists { get; } = new List<SpeedList>();
        public virtual ICollection<DamageTendency> DamageTendencies { get; } = new List<DamageTendency>();
        public virtual ICollection<SkillList> SkillLists { get; } = new List<SkillList>();
        public virtual ICollection<AbilityList> AbilityLists { get; } = new List<AbilityList>();
        public virtual ICollection<SpellSlot> SpellSlots { get; } = new List<SpellSlot>();
        public virtual ICollection<HabitatList> HabitatLists { get; } = new List<HabitatList>();
        public virtual ICollection<LanguageList> LanguageLists { get; } = new List<LanguageList>();
        public virtual ICollection<SenseList> SenseLists { get; } = new List<SenseList>();
        public virtual ICollection<ConditionImmunitiesList> ConditionImmunitiesLists { get; } = new List<ConditionImmunitiesList>();
        public virtual ICollection<Action> Actions { get; } = new List<Action>();
        public virtual ICollection<Thing> Things { get; } = new List<Thing>();
        public virtual ICollection<Beast> Beasts { get; } = new List<Beast>();

    }
}
