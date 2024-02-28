using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class HabitatListDTO
    {
        public HabitatListDTO() { }
        public HabitatListDTO(HabitatList habitat)
        {
            Id = habitat.Id;
            HabitatId = habitat.HabitatId;
            BeastNoteId = habitat.BeastNoteId;
        }
        public string Id { get; set; } = null!;
        public string HabitatId { get; set; } = null!;
        public string BeastNoteId { get; set; } = null!;
    }
}
