using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class FightTeamDTO
    {
        public FightTeamDTO() { }
        public FightTeamDTO(FightTeam fightTeam)
        {
            Id = fightTeam.Id;
            SceneSaveId = fightTeam.SceneSaveId;
            Title = fightTeam.Title;
        }
        public string Id { get; set; } = null!;
        public string SceneSaveId { get; set; } = null!;
        public string Title { get; set; } = null!;
    }
}
