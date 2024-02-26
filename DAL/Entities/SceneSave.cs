using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class SceneSave
    {
        [Key]
        public string Id { get; set; } = null!;
        public string SceneId { get; set; } = null!;
        public DateTime LastEditingDate { get; set; }
        public string Title { get; set; } = null!;
        public string CurrentBeastInitiative { get; set; } = null!; // format 20140615 (as 20 14 06 15)?
        public int RoundNumber { get; set; }

        public Scene Scene { get; set; } = null!;
        public virtual ICollection<FightTeam> FightTeams { get; } = new List<FightTeam>();
        public virtual ICollection<Beast> Beasts { get; } = new List<Beast>();


    }
}
