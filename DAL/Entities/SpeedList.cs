using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class SpeedList
    {
        [Key]
        public string Id { get; set; } = null!;
        public string SpeedId { get; set; } = null!;
        public string BeastNoteId { get; set; } = null!;
        public int DistanceInFeet { get; set; }


        public virtual Speed Speed { get; set; } = null!;
        public virtual BeastNote BeastNote { get; set; } = null!;
    }
}
