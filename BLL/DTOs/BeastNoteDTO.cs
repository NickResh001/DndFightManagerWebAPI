using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class BeastNoteDTO
    {
        public BeastNoteDTO() { }
        public BeastNoteDTO(BeastNote beastNote)
        {
            Id = beastNote.Id;
            AlignmentId = beastNote.AlignmentId;
            SizeId = beastNote.SizeId;
            BeastTypeId = beastNote.BeastTypeId;
            AuthorId = beastNote.AuthorId;
            ModeratorId = beastNote.ModeratorId;
            SpellAbilityId = beastNote.SpellAbilityId;

            HitPointsDice = beastNote.HitPointsDice;
            InitiativeBonus = beastNote.InitiativeBonus;
            ArmorClass = beastNote.ArmorClass;
            SpecialBonus = beastNote.SpecialBonus;
            Image = beastNote.Image;
            Title = beastNote.Title;
            SpellSaveThrowDifficulty = beastNote.SpellSaveThrowDifficulty;
            SpellAttackBonus = beastNote.SpellAttackBonus;
            ChallengeRating = beastNote.ChallengeRating;
            Description = beastNote.Description;

            CreationDate = beastNote.CreationDate;
            LastEditingDate = beastNote.LastEditingDate;
            AllUses = beastNote.AllUses;
            UniqueUses = beastNote.UniqueUses;
            UserRating = beastNote.UserRating;
            IsBeingModerated = beastNote.IsBeingModerated;
            IsPublished = beastNote.IsPublished;
        }
        public string Id { get; set; } = null!;
        public string AlignmentId { get; set; } = null!;
        public string SizeId { get; set; } = null!;
        public string BeastTypeId { get; set; } = null!;
        public string AuthorId { get; set; } = null!;
        public string? ModeratorId { get; set; }
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
    }
}
