using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class SenseListDTO
    {
        public SenseListDTO() { }
        public SenseListDTO(SenseList senseList)
        {
            Id = senseList.Id;
            SenseId = senseList.SenseId;
            BeastNoteId = senseList.BeastNoteId;
            DistanceInFeet = senseList.DistanceInFeet;
        }
        public string Id { get; set; } = null!;
        public string SenseId { get; set; } = null!;
        public string BeastNoteId { get; set; } = null!;
        public int DistanceInFeet { get; set; }
    }
}
