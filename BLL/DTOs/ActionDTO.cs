using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class ActionDTO
    {
        public ActionDTO() { }
        public ActionDTO(DAL.Entities.Action action)
        {
            Id = action.Id;
            CooldownTypeId = action.CooldownTypeId;
            ActionResourceId = action.ActionResourceId;
            BeastNoteId = action.BeastNoteId;
            Cooldown3_TimeMeasureId = action.Cooldown3_TimeMeasureId;
            ParentMultiactionId = action.ParentMultiactionId;

            Title = action.Title;
            Cooldown1_SpellSlotLevel = action.Cooldown1_SpellSlotLevel;
            Cooldown2_LowerRangeLimit = action.Cooldown2_LowerRangeLimit;
            Cooldown2_UpperRangeLimit = action.Cooldown2_UpperRangeLimit;
            Cooldown2_DiceSize = action.Cooldown2_DiceSize;
            Cooldown3_HowManyTimes = action.Cooldown3_HowManyTimes;
            Cooldown3_MeasureMultiply = action.Cooldown3_MeasureMultiply;
            Reaction_Condition = action.Reaction_Condition;
            Lair_InitiativeBonus = action.Lair_InitiativeBonus;
            Description = action.Description;
            IsTemplate = action.IsTemplate;
        }
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
    }
}
