using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class FightTeam
    {
        [Key]
        public string Id { get; set; } = null!;
        public string SceneSaveId { get; set; } = null!;
        public string Title { get; set; } = null!;

        public SceneSave SceneSave { get; set; } = null!;
        public virtual ICollection<Beast> Beasts { get; } = new List<Beast>();

    }
}
