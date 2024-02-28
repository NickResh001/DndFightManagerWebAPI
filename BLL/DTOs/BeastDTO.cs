using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class BeastDTO
    {
        public BeastDTO() { }
        public BeastDTO(Beast beast)
        {
            Id = beast.Id;
            SceneSaveId = beast.SceneSaveId;
            FightTeamId = beast.FightTeamId;
            Title = beast.Title;
            CurrentInitiative = beast.CurrentInitiative;
            CurrentArmorClass = beast.CurrentArmorClass;
            MaxHitPoints = beast.MaxHitPoints;
            CurrentHitPoints = beast.CurrentHitPoints;
            TemporaryHitPoints = beast.TemporaryHitPoints;
            IsSuprised = beast.IsSuprised;
        }
        public string Id { get; set; } = null!;
        public string SceneSaveId { get; set; } = null!;
        public string FightTeamId { get; set; } = null!;
        public string Title { get; set; } = null!;
        public string CurrentInitiative { get; set; } = null!;
        public int CurrentArmorClass { get; set; }
        public int MaxHitPoints { get; set; }
        public int CurrentHitPoints { get; set; }
        public int TemporaryHitPoints { get; set; }
        public bool IsSuprised { get; set; }
    }
}
