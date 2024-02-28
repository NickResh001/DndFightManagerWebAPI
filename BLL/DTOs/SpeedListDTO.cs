using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class SpeedListDTO
    {
        public SpeedListDTO() { }
        public SpeedListDTO(SpeedList speedList)
        {
            Id = speedList.Id;
            SpeedId = speedList.SpeedId;
            BeastNoteId = speedList.BeastNoteId;
            DistanceInFeet = speedList.DistanceInFeet;
        }
        public string Id { get; set; } = null!;
        public string SpeedId { get; set; } = null!;
        public string BeastNoteId { get; set; } = null!;
        public int DistanceInFeet { get; set; }
    }
}
