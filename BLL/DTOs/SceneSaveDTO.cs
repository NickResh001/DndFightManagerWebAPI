using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class SceneSaveDTO
    {
        public SceneSaveDTO() { }
        public SceneSaveDTO(SceneSave sceneSave)
        {
            Id = sceneSave.Id;
            SceneId = sceneSave.SceneId;
            LastEditingDate = sceneSave.LastEditingDate;
            Title = sceneSave.Title;
            CurrentBeastInitiative = sceneSave.CurrentBeastInitiative;
            RoundNumber = sceneSave.RoundNumber;
        }
        public string Id { get; set; } = null!;
        public string SceneId { get; set; } = null!;
        public DateTime LastEditingDate { get; set; }
        public string Title { get; set; } = null!;
        public string CurrentBeastInitiative { get; set; } = null!; // format 20140615 (as 20 14 06 15)?
        public int RoundNumber { get; set; }
    }
}
